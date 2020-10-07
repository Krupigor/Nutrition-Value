using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp4
{
    public partial class AddNewMember : Form
    {
        
        public AddNewMember()
        {
            InitializeComponent();
            
            
        }

        private void buttonOkaddnewmemb_Click(object sender, EventArgs e)
        {
            if (textBoxNameAddNewMem.TextLength >= 1 & textBoxAgeAddnewMem.TextLength >= 1)
            {
                if (checkBoxFemale.Checked | checkBoxMale.Checked)
                {
                    int age = Int32.Parse(textBoxAgeAddnewMem.Text);
                    bool male = true;
                    if (checkBoxMale.Checked)
                    {

                    }
                    else if (checkBoxFemale.Checked)
                    {
                        male = false;
                    }

                    Members ID = new Members(textBoxNameAddNewMem.Text, age, male);

                    
                    Members.listMembers.Add(ID);

                    Close();


                }
                else
                {
                    labelWarningFM.Visible = true;

                }

                
            }
            else
            {

                labelWarningNA.Visible = true;
            }
           
            
            
            
        }

        private void checkBoxFemale_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxMale.Checked = false;
            labelWarningFM.Visible = false;

        }

        private void checkBoxMale_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxFemale.Checked = false;
            labelWarningFM.Visible = false;

        }
    }
}
