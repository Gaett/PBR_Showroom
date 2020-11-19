using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBR_Showroom
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.UseWaitCursor = true;

            Form1 f = new Form1();
            f.Width = Screen.PrimaryScreen.Bounds.Width;
            f.Height = (int)(Screen.PrimaryScreen.Bounds.Height * 0.90);
            f.find_thumbnails(System.IO.Directory.GetCurrentDirectory());
            string[] names = f.img_url_list.ToArray();
            f.flowLayoutPanel1.Show();
            Thread t1 = new Thread(() => {
                for (int i = 0; i < names.Length; i++)
                {
                    f.useless(names, i);
                }
                Application.UseWaitCursor = false;
            });
            t1.Start();
            f.test();
            Application.Run(f);

        }
    }
}
