using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp4
{
    public partial class windowone : Form
    {
        public windowone()
        {
            InitializeComponent();


            listBox1.DataSource = Food_calculator.foodWeightHis.Keys.ToList();
            listBoxWeight.DataSource = Food_calculator.foodWeightHis.Values.ToList();

            listBoxCcalHistory.DataSource = Food_calculator.ccalhistory.ToList();
            listBoxNV.DataSource = Food_calculator.nutrition_values.ToList();
        }
        public void refreshDataSource()
        {
            listBox1.DataSource = null;
            listBoxWeight.DataSource = null;
            listBoxCcalHistory.DataSource = null;
            listBoxNV.DataSource = null;

            listBox1.DataSource = Food_calculator.foodWeightHis.Keys.ToList();
            listBoxWeight.DataSource = Food_calculator.foodWeightHis.Values.ToList();
             listBoxCcalHistory.DataSource = Food_calculator.ccalhistory.ToList();
            listBoxNV.DataSource = Food_calculator.nutrition_values.ToList();
            
            labelTotalCcal.Text= Food_calculator.ccaltotal.ToString();
        }
        private void windowone_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            windowadd w = new windowadd(this);
            w.Show();
        }

        private void buttonAddNewMember_Click(object sender, EventArgs e)
        {
            
            AddNewMember w = new AddNewMember(this);
            w.Show();
            
        }
        public void ChangeTextNameandAge(string s,int a)
        {
            this.textBoxName.Text = s;
            this.textBoxAge.Text = a.ToString();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
           

            if (listBox1.SelectedItem!=null)
            {
                
                Food_calculator.Substraction(listBox1.SelectedItem.ToString());
                
             refreshDataSource();
                
            }
            
            
                
            

            
        }

        private void listBoxNV_DataSourceChanged(object sender, EventArgs e)
        {
            // Members.normal_nutrition_values["A"] this is norma
            // Food_calculator.nutrition_values["A"] this is value moment calculator
            // 10 step  in progress bar ; 100 divider
            if (Food_calculator.nutrition_values["A"] != 0)
            {
                int coefficientRightNow = Food_calculator.nutrition_values["A"] / 10;
                int coefficientNormal = Food_calculator.normal_nutrition_values["A"] / 100;
                int forProgressBar = coefficientRightNow / coefficientNormal;  //%
                if(forProgressBar<=0)
                {
                    progressBarA.Value = 0;
                }
                else if (forProgressBar > 0 && forProgressBar <= 1)
                {

                    progressBarA.Value = 10;
                }
                else if (forProgressBar > 1 && forProgressBar <= 2)
                {
                    progressBarA.Value = 20;
                }
                else if (forProgressBar > 2 && forProgressBar <= 3)
                {
                    progressBarA.Value = 30;
                }
                else if (forProgressBar > 3 && forProgressBar <= 4)
                {
                    progressBarA.Value = 40;
                }
                else if (forProgressBar > 4 && forProgressBar <= 5)
                {
                    progressBarA.Value = 50;
                }
                else if (forProgressBar > 5 && forProgressBar <= 6)
                {
                    progressBarA.Value = 60;
                }
                else if (forProgressBar > 6 && forProgressBar <= 7)
                {
                    progressBarA.Value = 70;
                }
                else if (forProgressBar > 7 && forProgressBar <= 8)
                {
                    progressBarA.Value = 80;
                }
                else if (forProgressBar > 8 && forProgressBar <= 9)
                {
                    progressBarA.Value = 90;
                }
                else if (forProgressBar > 9 && forProgressBar <= 10)
                {
                    progressBarA.Value = 100;
                }
                else
                {
                    progressBarA.Value = 100;
                }
            }
                
        }





        
    }
}
