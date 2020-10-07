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
            
            AddNewMember w = new AddNewMember();
            w.Show();
            
        }
        //public static void ChangeTextNameandAge()
        //{
        //    this.textBoxName.Text =Members.name ;
        //    this.textBoxAge.Text = Members.age.ToString();
        //}
         

        private void buttonDelete_Click(object sender, EventArgs e)
        {
           

            if (listBox1.SelectedItem!=null)
            {
                
                Food_calculator.Substraction(listBox1.SelectedItem.ToString());
                
             refreshDataSource();
                
            }
            
            
                
            

            
        }

        private void listBoxNV_DataSourceChanged(object sender, EventArgs e) //change ProgressBar
        {
            // Members.normal_nutrition_values["A"] this is norma
            // Food_calculator.nutrition_values["A"] this is value moment calculator
            // 10 step  in progress bar ; 100 divider

            string[] vitamins = { "A", "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B9", "B12", "C", "D", "E", "K" };
            ProgressBar[] vitaminsBar = 
                {
                progressBarA,
                progressBarB1,
                progressBarB2, 
                progressBarB3,
                progressBarB4,
                progressBarB5,
                progressBarB6,
                progressBarB7,
                progressBarB9,
                progressBarB12,
                progressBarC,
                progressBarD,
                progressBarE,
                progressBarK,
            };
          
            for (int i = 0; i < vitamins.Length; i++)
            {
                double coefficientRightNow = Food_calculator.nutrition_values[vitamins[i]] / 10;
                double coefficientNormal = Food_calculator.normal_nutrition_values[vitamins[i]] / 100;
                ProgressBar progressBar = vitaminsBar[i];
                double forProgressBar = coefficientRightNow / coefficientNormal;  //%
                if (forProgressBar <= 0)
                {
                    progressBar.Value = 0;
                }
                else if (forProgressBar > 0 && forProgressBar <= 1)
                {

                    progressBar.Value = 10;
                }
                else if (forProgressBar > 1 && forProgressBar <= 2)
                {
                    progressBar.Value = 20;
                }
                else if (forProgressBar > 2 && forProgressBar <= 3)
                {
                    progressBar.Value = 30;
                }
                else if (forProgressBar > 3 && forProgressBar <= 4)
                {
                    progressBar.Value = 40;
                }
                else if (forProgressBar > 4 && forProgressBar <= 5)
                {
                    progressBar.Value = 50;
                }
                else if (forProgressBar > 5 && forProgressBar <= 6)
                {
                    progressBar.Value = 60;
                }
                else if (forProgressBar > 6 && forProgressBar <= 7)
                {
                    progressBar.Value = 70;
                }
                else if (forProgressBar > 7 && forProgressBar <= 8)
                {
                    progressBar.Value = 80;
                }
                else if (forProgressBar > 8 && forProgressBar <= 9)
                {
                    progressBar.Value = 90;
                }
                else if (forProgressBar > 9 && forProgressBar <= 10)
                {
                    progressBar.Value = 100;
                }
                else if (forProgressBar >10)
                {
                    progressBar.Value = 100;
                }
                else
                {
                    progressBar.Value = 0;
                }
            }
            string[] amino = { "Tryptophan", "Histidine", "Leucine", "Isoleucine", "Lysine", "Methionine", "Phenylalanine", "Threonine", "Valine" };
            ProgressBar[] aminoBar =
                {
                progressBarTryptofan,
                progressBarHistidine,
                progressBarLeucine,
                progressBarIsoleucine,
                progressBarLysine,
                progressBarMethionine,
                progressBarPhenylalanine,
                progressBarThreonine,
                progressBarValine,

            };
            for (int i = 0; i < amino.Length; i++)
            {
                double coefficientRightNow = Food_calculator.nutrition_values[amino[i]] / 10;
                double coefficientNormal = Food_calculator.normal_nutrition_values[amino[i]] / 100;
                ProgressBar progressBar = aminoBar[i];
                double forProgressBar = coefficientRightNow / coefficientNormal;  //%
                if (forProgressBar <= 0)
                {
                    progressBar.Value = 0;
                }
                else if (forProgressBar > 0 && forProgressBar <= 1)
                {

                    progressBar.Value = 10;
                }
                else if (forProgressBar > 1 && forProgressBar <= 2)
                {
                    progressBar.Value = 20;
                }
                else if (forProgressBar > 2 && forProgressBar <= 3)
                {
                    progressBar.Value = 30;
                }
                else if (forProgressBar > 3 && forProgressBar <= 4)
                {
                    progressBar.Value = 40;
                }
                else if (forProgressBar > 4 && forProgressBar <= 5)
                {
                    progressBar.Value = 50;
                }
                else if (forProgressBar > 5 && forProgressBar <= 6)
                {
                    progressBar.Value = 60;
                }
                else if (forProgressBar > 6 && forProgressBar <= 7)
                {
                    progressBar.Value = 70;
                }
                else if (forProgressBar > 7 && forProgressBar <= 8)
                {
                    progressBar.Value = 80;
                }
                else if (forProgressBar > 8 && forProgressBar <= 9)
                {
                    progressBar.Value = 90;
                }
                else if (forProgressBar > 9 && forProgressBar <= 10)
                {
                    progressBar.Value = 100;
                }
                else if (forProgressBar > 10)
                {
                    progressBar.Value = 100;
                }
                else
                {
                    progressBar.Value = 0;
                }
            }

            string[] minerals = { "Copper", "Zinc", "Chromium", "Iron", "Magnesium", "Phosphorus", "Calcium", "Selenium", "Iodine", "Manganese", "Fluoride", "Potassium" };
          
            ProgressBar[] mineralsBar =
                {
                progressBarCopper,
                progressBarZinc,
                progressBarChromium,
                progressBarIron,
                progressBarMagnesium,
                progressBarPhosphorus,
                progressBarCalcium,
                progressBarSelenium,
                progressBarIodine,
                progressBarManganese,
                progressBarFluoride,
                progressBarPotassium,

            };
            for (int i = 0; i < minerals.Length; i++)
            {
                double coefficientRightNow = Food_calculator.nutrition_values[minerals[i]] / 10;
                double coefficientNormal = Food_calculator.normal_nutrition_values[minerals[i]] / 100;
                ProgressBar progressBar = mineralsBar[i];
                double forProgressBar = coefficientRightNow / coefficientNormal;  //%
                if (forProgressBar <= 0)
                {
                    progressBar.Value = 0;
                }
                else if (forProgressBar > 0 && forProgressBar <= 1)
                {

                    progressBar.Value = 10;
                }
                else if (forProgressBar > 1 && forProgressBar <= 2)
                {
                    progressBar.Value = 20;
                }
                else if (forProgressBar > 2 && forProgressBar <= 3)
                {
                    progressBar.Value = 30;
                }
                else if (forProgressBar > 3 && forProgressBar <= 4)
                {
                    progressBar.Value = 40;
                }
                else if (forProgressBar > 4 && forProgressBar <= 5)
                {
                    progressBar.Value = 50;
                }
                else if (forProgressBar > 5 && forProgressBar <= 6)
                {
                    progressBar.Value = 60;
                }
                else if (forProgressBar > 6 && forProgressBar <= 7)
                {
                    progressBar.Value = 70;
                }
                else if (forProgressBar > 7 && forProgressBar <= 8)
                {
                    progressBar.Value = 80;
                }
                else if (forProgressBar > 8 && forProgressBar <= 9)
                {
                    progressBar.Value = 90;
                }
                else if (forProgressBar > 9 && forProgressBar <= 10)
                {
                    progressBar.Value = 100;
                }
                else if (forProgressBar > 10)
                {
                    progressBar.Value = 100;
                }
                else
                {
                    progressBar.Value = 0;
                }
            }




        }

       
    }
}
