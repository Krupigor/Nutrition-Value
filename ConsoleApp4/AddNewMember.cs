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
        windowone winone;
        
        public AddNewMember(windowone win1)
        {
            InitializeComponent();
            winone = win1;
            
        }

        private void buttonOkaddnewmemb_Click(object sender, EventArgs e)
        {
            int age=Int32.Parse(textBoxAgeAddnewMem.Text);
            Members ID = new Members(textBoxNameAddNewMem.Text, age);
            
           
            winone.ChangeTextNameandAge(textBoxNameAddNewMem.Text, age);
            Members.listMembers.Add(ID);
          
            Close();
            
            
            
        }
    }
}
