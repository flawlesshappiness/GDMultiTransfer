using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDMultiTransfer
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

            var transfer = GetGameTransfer();
            if (string.IsNullOrWhiteSpace(transfer))
            {
                Application.Exit();
            }
            else if(!transfer.Contains(".gst"))
            {
                MessageBox.Show("File did not have .gst extension", "Wrong file!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            else
            {

                var pathSaves = AddOrGetDirectory("Saves");
                var pathEmpty = AddOrGetDirectory("Empty");
                var fileEmpty = pathEmpty + "\\" + "empty.gst";

                var result = MessageBox.Show("Open editor in mode?", "Editor mode", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Application.Run(new FormMenu(transfer, pathSaves, fileEmpty));
                }
                else if (result == DialogResult.No)
                {
                    Application.Run(new FormUser(transfer, pathSaves, fileEmpty));
                }
            }
        }

        static string GetGameTransfer()
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Title = "Find game transfer.gst";
                var result = ofd.ShowDialog();
                return ofd.FileName;
            }
        }

        static string AddOrGetDirectory(string name)
        {
            string dir = Directory.GetCurrentDirectory() + "\\" + name;
            if (!Directory.Exists(name)) Directory.CreateDirectory(dir);
            return dir;
        }
    }
}
