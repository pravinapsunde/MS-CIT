using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using System.Globalization;

namespace MS_CIT
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SecurityForm security = new SecurityForm();
            while (!File.Exists("C:\\MS-CIT\\FirstRun\\DoNotDelete.txt"))
            {
                if (!security.IsDisposed)
                {
                    if (!SecurityForm.SECURITY_CHECK)
                    {
                        try
                        {
                            Application.Run(security);
                        }
                        catch (Exception ee)
                        {
                            MessageBox.Show(ee.Message);
                        }
                    }
                }
                else
                {
                    break;
                }
            }
            if (File.Exists("C:\\MS-CIT\\FirstRun\\DoNotDelete.txt"))
            {
                try
                {
                    FileStream ff = new FileStream("C:\\MS-CIT\\FirstRun\\DoNotDelete.txt", FileMode.Open, FileAccess.Read);
                    StreamReader reader = new StreamReader(ff);
                    DateTime date = Convert.ToDateTime(CryptorEngine.Decrypt(reader.ReadLine(), true));
                    date = date.AddYears(1);
                    DateTime Sysdate = DateTime.UtcNow.Date;
                    ff.Close();
                    if (date < Sysdate)
                    {
                        MessageBox.Show("Your Licence was Expired");
                        File.Delete("C:\\MS-CIT\\FirstRun\\DoNotDelete.txt");
                    }
                    else
                    {
                        while (!LogIn.loginsuccess)
                        {
                            try
                            {
                                Application.Run(new LogIn());
                            }
                            catch (Exception)
                            { }
                        }

                        if (!LogIn.cancelbuuton)
                        {
                            Application.Run(new Home());
                        }
                    }
                }
                catch (System.FormatException rr)
                {
                    MessageBox.Show("Application can't run because system date was changed \n Please set it as automatic(or internet time )");
                }
                catch (Exception tt)
                {
                    MessageBox.Show(tt.Message);
                }


            }
            else
            {
                Application.Exit();
            }
        }
    }
}
