using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;

namespace ServerAdmin
{
    public partial class PatchesForm : Form
    {
        private Form1 form;

        private double patchesVersion = 1.0;
        private OpenFileDialog ofd = new OpenFileDialog();

        Dictionary<string, string> fileNames = new Dictionary<string, string>(); //Key safefilename, full value
        Dictionary<string, byte[]> hash = new Dictionary<string, byte[]>();

        public PatchesForm(Form1 form)
        {
            InitializeComponent();

            this.form = form;

            ofd.Title = "Browse patch files";
            ofd.Multiselect = true;
            ofd.Filter = "MPQ|*.mpq";
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() != DialogResult.OK) return;

            for (int i = 0; i < ofd.SafeFileNames.Length; i++)
            {
                fileNames.Add(ofd.SafeFileNames[i], ofd.FileNames[i]);
                patchList.Items.Add($"{ofd.SafeFileNames[i]}"); 
            }
                
            
        }

        private void configureButton_Click(object sender, EventArgs e)
        {
            foreach (var file in fileNames)
                hash.Add(file.Key, computeHash(file.Value));

            BinaryWriter writer = new BinaryWriter(File.Open("patchfile.dat", FileMode.Create));

            writer.Write(patchesVersion);
            writer.Write(hash.Keys.Count);

            foreach (var pair in hash)
            {
                writer.Write(pair.Key);
                writer.Write(pair.Value.Length);
                writer.Write(pair.Value);
            }
            
            writer.Close();

            statusLabel.Text = $"{DateTime.Now.ToString("HH:mm:ss")}: Configured Patch File";
 
        }

        private byte[] computeHash(string file)
        {
            using (var md5 = MD5.Create())
                using (var stream = File.OpenRead(file))
                    return md5.ComputeHash(stream);

            return null;
        }

        private void PatchesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.patchesForm = null;
        }
    }
}
