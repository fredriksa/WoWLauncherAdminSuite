namespace ServerAdmin
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.nameField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.websiteField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.patchField = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.configureButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.downloadField = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.realmlistField = new System.Windows.Forms.TextBox();
            this.versionLabel = new System.Windows.Forms.Label();
            this.versionCombo = new System.Windows.Forms.ComboBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(64, 22);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(208, 20);
            this.nameField.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Website";
            // 
            // websiteField
            // 
            this.websiteField.Location = new System.Drawing.Point(64, 63);
            this.websiteField.Name = "websiteField";
            this.websiteField.Size = new System.Drawing.Size(208, 20);
            this.websiteField.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Patch Dir";
            // 
            // patchField
            // 
            this.patchField.Location = new System.Drawing.Point(367, 21);
            this.patchField.Name = "patchField";
            this.patchField.Size = new System.Drawing.Size(213, 20);
            this.patchField.TabIndex = 3;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(293, 146);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(287, 23);
            this.generateButton.TabIndex = 7;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // configureButton
            // 
            this.configureButton.Location = new System.Drawing.Point(15, 146);
            this.configureButton.Name = "configureButton";
            this.configureButton.Size = new System.Drawing.Size(257, 23);
            this.configureButton.TabIndex = 6;
            this.configureButton.Text = "Configure Patch File";
            this.configureButton.UseVisualStyleBackColor = true;
            this.configureButton.Click += new System.EventHandler(this.configureButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Download Dir";
            // 
            // downloadField
            // 
            this.downloadField.Location = new System.Drawing.Point(367, 59);
            this.downloadField.Name = "downloadField";
            this.downloadField.Size = new System.Drawing.Size(213, 20);
            this.downloadField.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 183);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(599, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Realmlist";
            // 
            // realmlistField
            // 
            this.realmlistField.Location = new System.Drawing.Point(367, 101);
            this.realmlistField.Name = "realmlistField";
            this.realmlistField.Size = new System.Drawing.Size(213, 20);
            this.realmlistField.TabIndex = 5;
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Location = new System.Drawing.Point(12, 108);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(42, 13);
            this.versionLabel.TabIndex = 16;
            this.versionLabel.Text = "Version";
            // 
            // versionCombo
            // 
            this.versionCombo.FormattingEnabled = true;
            this.versionCombo.Location = new System.Drawing.Point(64, 105);
            this.versionCombo.Name = "versionCombo";
            this.versionCombo.Size = new System.Drawing.Size(208, 21);
            this.versionCombo.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 205);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.versionCombo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.realmlistField);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.downloadField);
            this.Controls.Add(this.configureButton);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.patchField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.websiteField);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameField);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Admin Suite";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox websiteField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox patchField;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button configureButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox downloadField;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox realmlistField;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.ComboBox versionCombo;
    }
}

