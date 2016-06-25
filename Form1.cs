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

namespace ServerAdmin
{
    public partial class Form1 : Form
    {
        private double formVersion = 1.0;

        public PatchesForm patchesForm;
        private Dictionary<string, string> versionComboItems = new Dictionary<string, string>();

        public Form1()
        {
            InitializeComponent();

            patchesForm = new PatchesForm(this);

            versionComboItems.Add("1", "Vanilla");
            versionComboItems.Add("2", "The Burning Crusade");
            versionComboItems.Add("3", "Wrath of the Lich King");

            versionCombo.DataSource = new BindingSource(versionComboItems, null);
            versionCombo.DisplayMember = "Value";
            versionCombo.ValueMember = "Key";
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            if (nameField.Text == string.Empty)
            {
                MessageBox.Show("You must enter a name!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (websiteField.Text == string.Empty)
            {
                MessageBox.Show("You must enter a website!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (patchField.Text == string.Empty)
            {
                MessageBox.Show("You must enter a patch directory!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (downloadField.Text == string.Empty)
            {
                MessageBox.Show("You must enter a download directory!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (realmlistField.Text == string.Empty)
            {
                MessageBox.Show("You must enter a realmlist!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            BinaryWriter writer = new BinaryWriter(File.Open("server.dat", FileMode.Create));

            writer.Write(formVersion);

            writer.Write(nameField.Text);
            writer.Write(websiteField.Text);
            Console.WriteLine(VersionHelper.toVersion(((KeyValuePair<string, string>)versionCombo.SelectedItem).Value).ToString());
            writer.Write(VersionHelper.toVersion(((KeyValuePair<string, string>)versionCombo.SelectedItem).Value).ToString());
            writer.Write(patchField.Text);
            writer.Write(downloadField.Text);
            writer.Write(realmlistField.Text);
            writer.Write(string.Empty);
            writer.Write(string.Empty);

            writer.Close();

            statusLabel.Text = $"{DateTime.Now.ToString("HH:mm:ss")}: Generated Server File";
        }

        private void configureButton_Click(object sender, EventArgs e)
        {
            if (patchesForm == null)
                patchesForm = new PatchesForm(this);

            if (!patchesForm.Visible)
                patchesForm.Show();
        }

    }
}
