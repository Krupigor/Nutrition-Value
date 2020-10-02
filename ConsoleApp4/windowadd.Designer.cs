namespace ConsoleApp4
{
    partial class windowadd
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
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.buttonOk = new System.Windows.Forms.Button();
            this.labelWeight = new System.Windows.Forms.Label();
            this.listBoxFruits = new System.Windows.Forms.ListBox();
            this.listBoxVeget = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Location = new System.Drawing.Point(480, 361);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(75, 22);
            this.textBoxWeight.TabIndex = 8;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(480, 389);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 9;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(480, 338);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(56, 17);
            this.labelWeight.TabIndex = 10;
            this.labelWeight.Text = "Weight:";
            // 
            // listBoxFruits
            // 
            this.listBoxFruits.FormattingEnabled = true;
            this.listBoxFruits.ItemHeight = 16;
            this.listBoxFruits.Location = new System.Drawing.Point(12, 36);
            this.listBoxFruits.Name = "listBoxFruits";
            this.listBoxFruits.Size = new System.Drawing.Size(198, 84);
            this.listBoxFruits.TabIndex = 11;
            this.listBoxFruits.SelectedIndexChanged += new System.EventHandler(this.listBoxFruits_SelectedIndexChanged);
            // 
            // listBoxVeget
            // 
            this.listBoxVeget.FormattingEnabled = true;
            this.listBoxVeget.ItemHeight = 16;
            this.listBoxVeget.Location = new System.Drawing.Point(228, 36);
            this.listBoxVeget.Name = "listBoxVeget";
            this.listBoxVeget.Size = new System.Drawing.Size(198, 84);
            this.listBoxVeget.TabIndex = 12;
            this.listBoxVeget.SelectedIndexChanged += new System.EventHandler(this.listBoxVeget_SelectedIndexChanged);
            // 
            // windowadd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 462);
            this.Controls.Add(this.listBoxVeget);
            this.Controls.Add(this.listBoxFruits);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.textBoxWeight);
            this.Name = "windowadd";
            this.Text = "windowadd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.ListBox listBoxFruits;
        private System.Windows.Forms.ListBox listBoxVeget;
    }
}