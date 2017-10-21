using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDMultiTransfer
{
    public partial class FormUser : Form
    {
        private string pathTransferCur;
        private string pathTransferGame = "";
        private string pathSaves;
        private string fileEmpty;

        public FormUser(string gameTransferPath, string savePath, string emptyFile)
        {
            InitializeComponent();
            this.Text = "GDMultiTransfer";
            pathTransferGame = gameTransferPath;
            pathSaves = savePath;
            fileEmpty = emptyFile;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cb = (ComboBox)sender;
            int idx = cb.SelectedIndex;
            pathTransferCur = Directory.GetFiles(pathSaves).ElementAt(idx);
            File.Copy(pathTransferCur, pathTransferGame, true);
        }

        void UpdateTransferCombobox()
        {
            comboBox1.Items.Clear();
            var files = Directory.GetFiles(pathSaves);
            for (int i = 0; i < files.Length; i++)
            {
                var file = files.ElementAt(i);
                comboBox1.Items.Add(Path.GetFileNameWithoutExtension(file));
            }
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            UpdateTransferCombobox();
        }
    }
}
