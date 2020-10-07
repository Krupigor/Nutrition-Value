using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
      public class Members
    {

        public  static string name;
        public static int age;
        public static bool malevalue;
        public static int Age
        {
            get
            {
                return age;
            }
            set
            {
                if(malevalue)
                {
                    if (value > 100 || value <= 0)
                    {
                        Console.WriteLine("Please, one more. You age is impossible");
                    }
                    else
                    {
                        switch (value)
                        {
                            case 1:
                                break;
                            case 2:
                                break;
                            case 3:
                                break;
                            case 4:
                                break;
                            case 5:
                                break;
                            case 6:
                                break;
                            case 7:
                                break;
                            case 8:
                                break;
                            case 9:
                                break;
                            case 10:
                                break;
                            case 11:
                                break;
                            case 12:
                                break;
                            case 13:
                                break;
                            case 14:
                                break;
                            case 15:
                                break;
                            case 16:
                                break;
                            case 17:
                                break;
                            case 18:
                                break;
                            case 19:
                                break;
                            case 20:
                                break;
                            case 21:
                                break;
                            case 22:
                                break;
                            case 23:
                                break;
                            case 24:
                                break;
                            case 25:
                                break;
                            case 26:
                                break;
                            case 27:
                                break;
                            case 28:
                                break;
                            case 29:
                                break;
                            case 30:
                                break;
                            case 31:
                                break;
                            case 32:
                                age = value;
                                Food_calculator.normal_nutrition_values["A"] = 300;
                                Food_calculator.normal_nutrition_values["B1"] = 50;
                                Food_calculator.normal_nutrition_values["B2"] = 47;
                                Food_calculator.normal_nutrition_values["B3"] = 300;
                                Food_calculator.normal_nutrition_values["B4"] = 50;
                                Food_calculator.normal_nutrition_values["B5"] = 47;
                                Food_calculator.normal_nutrition_values["B6"] = 300;
                                Food_calculator.normal_nutrition_values["B7"] = 50;
                                Food_calculator.normal_nutrition_values["B9"] = 47;
                                Food_calculator.normal_nutrition_values["B12"] = 300;
                                Food_calculator.normal_nutrition_values["C"] = 50;
                                Food_calculator.normal_nutrition_values["D"] = 47;
                                Food_calculator.normal_nutrition_values["E"] = 300;
                                Food_calculator.normal_nutrition_values["K"] = 50;

                                Food_calculator.normal_nutrition_values["Copper"] = 54;
                                Food_calculator.normal_nutrition_values["Zinc"] = 41;
                                Food_calculator.normal_nutrition_values["Chromium"] = 41;
                                Food_calculator.normal_nutrition_values["Iron"] = 54;
                                Food_calculator.normal_nutrition_values["Magnesium"] = 41;
                                Food_calculator.normal_nutrition_values["Phosphorus"] = 41;
                                Food_calculator.normal_nutrition_values["Calcium"] = 54;
                                Food_calculator.normal_nutrition_values["Selenium"] = 41;
                                Food_calculator.normal_nutrition_values["Iodine"] = 41;
                                Food_calculator.normal_nutrition_values["Manganese"] = 54;
                                Food_calculator.normal_nutrition_values["Fluoride"] = 41;
                                Food_calculator.normal_nutrition_values["Potassium"] = 41;

                                Food_calculator.normal_nutrition_values["Tryptophan"] = 11;
                                Food_calculator.normal_nutrition_values["Histidine"] = 90;
                                Food_calculator.normal_nutrition_values["Leucine"] = 70;
                                Food_calculator.normal_nutrition_values["Isoleucine"] = 70;
                                Food_calculator.normal_nutrition_values["Lysine"] = 70;
                                Food_calculator.normal_nutrition_values["Methionine"] = 90;
                                Food_calculator.normal_nutrition_values["Phenylalanine"] = 70;
                                Food_calculator.normal_nutrition_values["Threonine"] = 70;
                                Food_calculator.normal_nutrition_values["Valine"] = 70;
                                break;
                            case 33:
                                break;
                            case 34:
                                break;
                            case 35:
                                break;
                            case 36:
                                age = value;
                                Food_calculator.normal_nutrition_values["A"] = 300;
                                Food_calculator.normal_nutrition_values["B1"] = 500;
                                Food_calculator.normal_nutrition_values["B2"] = 47;
                                Food_calculator.normal_nutrition_values["B3"] = 300;
                                Food_calculator.normal_nutrition_values["B4"] = 50;
                                Food_calculator.normal_nutrition_values["B5"] = 47;
                                Food_calculator.normal_nutrition_values["B6"] = 300;
                                Food_calculator.normal_nutrition_values["B7"] = 50;
                                Food_calculator.normal_nutrition_values["B9"] = 47;
                                Food_calculator.normal_nutrition_values["B12"] = 300;
                                Food_calculator.normal_nutrition_values["C"] = 50;
                                Food_calculator.normal_nutrition_values["D"] = 47;
                                Food_calculator.normal_nutrition_values["E"] = 300;
                                Food_calculator.normal_nutrition_values["K"] = 50;

                                Food_calculator.normal_nutrition_values["Copper"] = 54;
                                Food_calculator.normal_nutrition_values["Zinc"] = 41;
                                Food_calculator.normal_nutrition_values["Chromium"] = 41;
                                Food_calculator.normal_nutrition_values["Iron"] = 54;
                                Food_calculator.normal_nutrition_values["Magnesium"] = 41;
                                Food_calculator.normal_nutrition_values["Phosphorus"] = 41;
                                Food_calculator.normal_nutrition_values["Calcium"] = 54;
                                Food_calculator.normal_nutrition_values["Selenium"] = 41;
                                Food_calculator.normal_nutrition_values["Iodine"] = 41;
                                Food_calculator.normal_nutrition_values["Manganese"] = 54;
                                Food_calculator.normal_nutrition_values["Fluoride"] = 41;
                                Food_calculator.normal_nutrition_values["Potassium"] = 41;

                                Food_calculator.normal_nutrition_values["Tryptophan"] = 11;
                                Food_calculator.normal_nutrition_values["Histidine"] = 90;
                                Food_calculator.normal_nutrition_values["Leucine"] = 70;
                                Food_calculator.normal_nutrition_values["Isoleucine"] = 70;
                                Food_calculator.normal_nutrition_values["Lysine"] = 70;
                                Food_calculator.normal_nutrition_values["Methionine"] = 90;
                                Food_calculator.normal_nutrition_values["Phenylalanine"] = 70;
                                Food_calculator.normal_nutrition_values["Threonine"] = 70;
                                Food_calculator.normal_nutrition_values["Valine"] = 70;

                                break;
                            case 37:
                                break;
                            case 38:
                                break;
                            case 39:
                                break;
                            case 40:
                                break;
                            case 41:
                                break;
                            case 42:
                                break;
                            case 43:
                                break;
                            case 44:
                                break;
                            case 45:
                                break;
                            case 46:
                                break;
                            case 47:
                                break;
                            case 48:
                                break;
                            case 49:
                                break;
                            case 50:
                                break;
                            case 51:
                                break;
                            case 52:
                                break;
                            case 53:
                                break;
                            case 54:
                                break;

                            default:
                                age = value;
                                break;
                        }
                    }
                }
                else
                {
                    if (value > 100 || value <= 0)
                    {
                        Console.WriteLine("Please, one more. You age is impossible");
                    }
                    else
                    {
                        switch (value)
                        {
                            case 1:
                                break;
                            case 2:
                                break;
                            case 3:
                                break;
                            case 4:
                                break;
                            case 5:
                                break;
                            case 6:
                                break;
                            case 7:
                                break;
                            case 8:
                                break;
                            case 9:
                                break;
                            case 10:
                                break;
                            case 11:
                                break;
                            case 12:
                                break;
                            case 13:
                                break;
                            case 14:
                                break;
                            case 15:
                                break;
                            case 16:
                                break;
                            case 17:
                                break;
                            case 18:
                                break;
                            case 19:
                                break;
                            case 20:
                                break;
                            case 21:
                                break;
                            case 22:
                                break;
                            case 23:
                                break;
                            case 24:
                                break;
                            case 25:
                                break;
                            case 26:
                                break;
                            case 27:
                                break;
                            case 28:
                                break;
                            case 29:
                                break;
                            case 30:
                                break;
                            case 31:
                                break;
                            case 32:
                                age = value;
                                Food_calculator.normal_nutrition_values["A"] = 300;
                                Food_calculator.normal_nutrition_values["B1"] = 50;
                                Food_calculator.normal_nutrition_values["B2"] = 47;
                                Food_calculator.normal_nutrition_values["B3"] = 300;
                                Food_calculator.normal_nutrition_values["B4"] = 50;
                                Food_calculator.normal_nutrition_values["B5"] = 47;
                                Food_calculator.normal_nutrition_values["B6"] = 300;
                                Food_calculator.normal_nutrition_values["B7"] = 50;
                                Food_calculator.normal_nutrition_values["B9"] = 47;
                                Food_calculator.normal_nutrition_values["B12"] = 300;
                                Food_calculator.normal_nutrition_values["C"] = 50;
                                Food_calculator.normal_nutrition_values["D"] = 47;
                                Food_calculator.normal_nutrition_values["E"] = 300;
                                Food_calculator.normal_nutrition_values["K"] = 50;

                                Food_calculator.normal_nutrition_values["Copper"] = 54;
                                Food_calculator.normal_nutrition_values["Zinc"] = 41;
                                Food_calculator.normal_nutrition_values["Chromium"] = 41;
                                Food_calculator.normal_nutrition_values["Iron"] = 54;
                                Food_calculator.normal_nutrition_values["Magnesium"] = 41;
                                Food_calculator.normal_nutrition_values["Phosphorus"] = 41;
                                Food_calculator.normal_nutrition_values["Calcium"] = 54;
                                Food_calculator.normal_nutrition_values["Selenium"] = 41;
                                Food_calculator.normal_nutrition_values["Iodine"] = 41;
                                Food_calculator.normal_nutrition_values["Manganese"] = 54;
                                Food_calculator.normal_nutrition_values["Fluoride"] = 41;
                                Food_calculator.normal_nutrition_values["Potassium"] = 41;

                                Food_calculator.normal_nutrition_values["Tryptophan"] = 11;
                                Food_calculator.normal_nutrition_values["Histidine"] = 90;
                                Food_calculator.normal_nutrition_values["Leucine"] = 70;
                                Food_calculator.normal_nutrition_values["Isoleucine"] = 70;
                                Food_calculator.normal_nutrition_values["Lysine"] = 70;
                                Food_calculator.normal_nutrition_values["Methionine"] = 90;
                                Food_calculator.normal_nutrition_values["Phenylalanine"] = 70;
                                Food_calculator.normal_nutrition_values["Threonine"] = 70;
                                Food_calculator.normal_nutrition_values["Valine"] = 70;
                                break;
                            case 33:
                                break;
                            case 34:
                                break;
                            case 35:
                                break;
                            case 36:
                                age = value;
                                Food_calculator.normal_nutrition_values["A"] = 300;
                                Food_calculator.normal_nutrition_values["B1"] = 500;
                                Food_calculator.normal_nutrition_values["B2"] = 47;
                                Food_calculator.normal_nutrition_values["B3"] = 300;
                                Food_calculator.normal_nutrition_values["B4"] = 50;
                                Food_calculator.normal_nutrition_values["B5"] = 47;
                                Food_calculator.normal_nutrition_values["B6"] = 300;
                                Food_calculator.normal_nutrition_values["B7"] = 50;
                                Food_calculator.normal_nutrition_values["B9"] = 47;
                                Food_calculator.normal_nutrition_values["B12"] = 300;
                                Food_calculator.normal_nutrition_values["C"] = 50;
                                Food_calculator.normal_nutrition_values["D"] = 47;
                                Food_calculator.normal_nutrition_values["E"] = 300;
                                Food_calculator.normal_nutrition_values["K"] = 50;

                                Food_calculator.normal_nutrition_values["Copper"] = 54;
                                Food_calculator.normal_nutrition_values["Zinc"] = 41;
                                Food_calculator.normal_nutrition_values["Chromium"] = 41;
                                Food_calculator.normal_nutrition_values["Iron"] = 54;
                                Food_calculator.normal_nutrition_values["Magnesium"] = 41;
                                Food_calculator.normal_nutrition_values["Phosphorus"] = 41;
                                Food_calculator.normal_nutrition_values["Calcium"] = 54;
                                Food_calculator.normal_nutrition_values["Selenium"] = 41;
                                Food_calculator.normal_nutrition_values["Iodine"] = 41;
                                Food_calculator.normal_nutrition_values["Manganese"] = 54;
                                Food_calculator.normal_nutrition_values["Fluoride"] = 41;
                                Food_calculator.normal_nutrition_values["Potassium"] = 41;

                                Food_calculator.normal_nutrition_values["Tryptophan"] = 11;
                                Food_calculator.normal_nutrition_values["Histidine"] = 90;
                                Food_calculator.normal_nutrition_values["Leucine"] = 70;
                                Food_calculator.normal_nutrition_values["Isoleucine"] = 70;
                                Food_calculator.normal_nutrition_values["Lysine"] = 70;
                                Food_calculator.normal_nutrition_values["Methionine"] = 90;
                                Food_calculator.normal_nutrition_values["Phenylalanine"] = 70;
                                Food_calculator.normal_nutrition_values["Threonine"] = 70;
                                Food_calculator.normal_nutrition_values["Valine"] = 70;

                                break;
                            case 37:
                                break;
                            case 38:
                                break;
                            case 39:
                                break;
                            case 40:
                                break;
                            case 41:
                                break;
                            case 42:
                                break;
                            case 43:
                                break;
                            case 44:
                                break;
                            case 45:
                                break;
                            case 46:
                                break;
                            case 47:
                                break;
                            case 48:
                                break;
                            case 49:
                                break;
                            case 50:
                                break;
                            case 51:
                                break;
                            case 52:
                                break;
                            case 53:
                                break;
                            case 54:
                                break;

                            default:
                                age = value;
                                break;
                        }
                    }
                }

                
                
            }
        }
        public Members(string namearg, int agearg, bool male)
        {
           name = namearg;
            Age = agearg;
            malevalue = male;

        }
     

        


        
        public static List<Members> listMembers = new List<Members> // collection members for WINDOW ONE
        {
            
        };

    }
}
