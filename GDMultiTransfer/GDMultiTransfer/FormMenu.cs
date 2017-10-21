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
using Microsoft.VisualBasic;

namespace GDMultiTransfer
{
    public partial class FormMenu : Form
    {
        private string pathTransferCur;
        private string pathTransferGame = "";
        private string dir = Directory.GetCurrentDirectory();
        private string dirSaves = "Saves";
        private string pathSaves;
        private string dirEmpty = "Empty";
        private string pathEmpty;
        private string fileEmpty;

        public FormMenu()
        {
            InitializeComponent();
            this.Text = "GDMultiTransfer";
            pathSaves = AddOrGetDirectory(dirSaves);
            pathEmpty = AddOrGetDirectory(dirEmpty);
            fileEmpty = pathEmpty + "\\" + "empty.gst";
        }

        string AddOrGetDirectory(string name)
        {
            if (!Directory.Exists(name)) Directory.CreateDirectory(dir + "\\" + name);
            return dir + "\\" + name;
        }

        string GetGameTransfer()
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Title = "Find game transfer.gst";
                var result = ofd.ShowDialog();
                return ofd.FileName;
            }
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            var transfer = GetGameTransfer();
            if (string.IsNullOrWhiteSpace(transfer) || !transfer.Contains(".gst"))
            {
                MessageBox.Show("File did not have .gst extension", "Wrong file!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

            pathTransferGame = transfer;
            UpdateTransferCombobox();
        }

        private void buttonAddTransfer_Click(object sender, EventArgs e)
        {
            var name = Interaction.InputBox("Please input the name of the transfer", "Set name", "transfer");
            if(!string.IsNullOrWhiteSpace(name))
            {
                try
                {
                    Console.WriteLine(fileEmpty);
                    Console.WriteLine(pathSaves + "\\" + name + ".gst");
                    File.Copy(fileEmpty, pathSaves + "\\" + name + ".gst");
                    UpdateTransferCombobox();
                }
                catch(UnauthorizedAccessException ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }
                catch (PathTooLongException ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }
                catch (DirectoryNotFoundException ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }
                catch (IOException ex)
                {
                    Console.WriteLine(ex.StackTrace);
                }
            }
            else
            {
                MessageBox.Show("File name cannot be empty", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRemoveTransfer_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete this transfer?", "Confirm deletion", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                File.Delete(pathTransferCur);
                UpdateTransferCombobox();
            }
            else if(DialogResult == DialogResult.No)
            {

            }
        }

        void UpdateTransferCombobox()
        {
            comboBox1.Items.Clear();
            var files = Directory.GetFiles(pathSaves);
            for(int i = 0; i < files.Length; i++)
            {
                var file = files.ElementAt(i);
                comboBox1.Items.Add(Path.GetFileNameWithoutExtension(file));
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cb = (ComboBox)sender;
            int idx = cb.SelectedIndex;
            pathTransferCur = Directory.GetFiles(pathSaves).ElementAt(idx);
            File.Copy(pathTransferCur, pathTransferGame, true);
        }

        private void buttonUpdateTransfer_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to update this transfer?", "Confirm update", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                File.Copy(pathTransferGame, pathTransferCur, true);
            }
            else if (DialogResult == DialogResult.No)
            {

            }
        }
    }
}
