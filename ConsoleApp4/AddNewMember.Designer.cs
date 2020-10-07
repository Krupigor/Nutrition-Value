namespace ConsoleApp4
{
    partial class AddNewMember
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
            this.textBoxNameAddNewMem = new System.Windows.Forms.TextBox();
            this.textBoxAgeAddnewMem = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAge = new System.Windows.Forms.Label();
            this.buttonOkaddnewmemb = new System.Windows.Forms.Button();
            this.checkBoxMale = new System.Windows.Forms.CheckBox();
            this.checkBoxFemale = new System.Windows.Forms.CheckBox();
            this.labelWarningFM = new System.Windows.Forms.Label();
            this.labelWarningNA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNameAddNewMem
            // 
            this.textBoxNameAddNewMem.Location = new System.Drawing.Point(92, 27);
            this.textBoxNameAddNewMem.Name = "textBoxNameAddNewMem";
            this.textBoxNameAddNewMem.Size = new System.Drawing.Size(100, 22);
            this.textBoxNameAddNewMem.TabIndex = 0;
            // 
            // textBoxAgeAddnewMem
            // 
            this.textBoxAgeAddnewMem.Location = new System.Drawing.Point(279, 27);
            this.textBoxAgeAddnewMem.Name = "textBoxAgeAddnewMem";
            this.textBoxAgeAddnewMem.Size = new System.Drawing.Size(100, 22);
            this.textBoxAgeAddnewMem.TabIndex = 1;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(13, 32);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(49, 17);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Name:";
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(224, 32);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(37, 17);
            this.labelAge.TabIndex = 3;
            this.labelAge.Text = "Age:";
            // 
            // buttonOkaddnewmemb
            // 
            this.buttonOkaddnewmemb.Location = new System.Drawing.Point(400, 27);
            this.buttonOkaddnewmemb.Name = "buttonOkaddnewmemb";
            this.buttonOkaddnewmemb.Size = new System.Drawing.Size(75, 23);
            this.buttonOkaddnewmemb.TabIndex = 4;
            this.buttonOkaddnewmemb.Text = "Ok";
            this.buttonOkaddnewmemb.UseVisualStyleBackColor = true;
            this.buttonOkaddnewmemb.Click += new System.EventHandler(this.buttonOkaddnewmemb_Click);
            // 
            // checkBoxMale
            // 
            this.checkBoxMale.AutoSize = true;
            this.checkBoxMale.Checked = true;
            this.checkBoxMale.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMale.Location = new System.Drawing.Point(92, 55);
            this.checkBoxMale.Name = "checkBoxMale";
            this.checkBoxMale.Size = new System.Drawing.Size(60, 21);
            this.checkBoxMale.TabIndex = 9;
            this.checkBoxMale.Text = "Male";
            this.checkBoxMale.UseVisualStyleBackColor = true;
            this.checkBoxMale.CheckedChanged += new System.EventHandler(this.checkBoxMale_CheckedChanged);
            // 
            // checkBoxFemale
            // 
            this.checkBoxFemale.AutoSize = true;
            this.checkBoxFemale.Location = new System.Drawing.Point(279, 55);
            this.checkBoxFemale.Name = "checkBoxFemale";
            this.checkBoxFemale.Size = new System.Drawing.Size(76, 21);
            this.checkBoxFemale.TabIndex = 10;
            this.checkBoxFemale.Text = "Female";
            this.checkBoxFemale.UseVisualStyleBackColor = true;
            this.checkBoxFemale.CheckedChanged += new System.EventHandler(this.checkBoxFemale_CheckedChanged);
            // 
            // labelWarningFM
            // 
            this.labelWarningFM.AutoSize = true;
            this.labelWarningFM.ForeColor = System.Drawing.Color.Blue;
            this.labelWarningFM.Location = new System.Drawing.Point(140, 79);
            this.labelWarningFM.Name = "labelWarningFM";
            this.labelWarningFM.Size = new System.Drawing.Size(194, 17);
            this.labelWarningFM.TabIndex = 11;
            this.labelWarningFM.Text = "Select male or female, please";
            this.labelWarningFM.Visible = false;
            // 
            // labelWarningNA
            // 
            this.labelWarningNA.AutoSize = true;
            this.labelWarningNA.ForeColor = System.Drawing.Color.Blue;
            this.labelWarningNA.Location = new System.Drawing.Point(140, 96);
            this.labelWarningNA.Name = "labelWarningNA";
            this.labelWarningNA.Size = new System.Drawing.Size(185, 17);
            this.labelWarningNA.TabIndex = 12;
            this.labelWarningNA.Text = "Fill in name and age, please";
            this.labelWarningNA.Visible = false;
            // 
            // AddNewMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 131);
            this.Controls.Add(this.labelWarningNA);
            this.Controls.Add(this.labelWarningFM);
            this.Controls.Add(this.checkBoxFemale);
            this.Controls.Add(this.checkBoxMale);
            this.Controls.Add(this.buttonOkaddnewmemb);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxAgeAddnewMem);
            this.Controls.Add(this.textBoxNameAddNewMem);
            this.Name = "AddNewMember";
            this.Text = "AddNewMember";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNameAddNewMem;
        private System.Windows.Forms.TextBox textBoxAgeAddnewMem;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Button buttonOkaddnewmemb;
        private System.Windows.Forms.CheckBox checkBoxMale;
        private System.Windows.Forms.CheckBox checkBoxFemale;
        private System.Windows.Forms.Label labelWarningFM;
        private System.Windows.Forms.Label labelWarningNA;
    }
}