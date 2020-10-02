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
    public partial class windowadd : Form
    {
        public static readonly string[] fruitsname = 
        {
            "Apple",
            "Mango",
            "Orange",
        };
        public static readonly string[] vegetablesname = 
        {
            "Potato",
            "Cucumber",
            "Onion",
        };
        windowone winone;
        public windowadd(windowone win1)
        {
            InitializeComponent();
            winone = win1;
            
            listBoxFruits.Items.AddRange(fruitsname);
            listBoxVeget.Items.AddRange(vegetablesname);
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            string checkedItems = "";
            if(listBoxFruits.SelectedItem!=null)
            {
                checkedItems = (string)listBoxFruits.SelectedItem;
                
            }
            else if(listBoxVeget.SelectedItem!=null)
            {
                checkedItems = (string)listBoxVeget.SelectedItem;
            }
            Food_calculator.Additionplus(checkedItems, Convert.ToInt32(textBoxWeight.Text));
           
            winone.refreshDataSource(); 
            Close();

        }

        private void listBoxFruits_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxVeget.ClearSelected();
        }

        private void listBoxVeget_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxFruits.ClearSelected();
        }
    }
}
