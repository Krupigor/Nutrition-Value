using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Food_calculator
    {
        public static readonly List<string> fruitsname = new List<string>
        {
            "Apple",
            "Mango",
            "Orange",
        }; //(only for CALCULATOR)
        public static readonly List<string> vegetablesname = new List<string>
        {
            "Potato",
            "Cucumber",
            "Onion",
        }; //(only for CALCULATOR)
        public static readonly Dictionary<string, int> ccalinfo = new Dictionary<string, int>//info about food ccal (only for CALCULATOR)
        {
            [fruitsname[0]] = 10,
            [fruitsname[1]] = 20,
            [fruitsname[2]] = 30,

            [vegetablesname[0]] = 40,
            [vegetablesname[1]] = 50,
            [vegetablesname[2]] = 60,

        };


        // public static List<string> nutrition_values = new List<string> { "A", "B1", "C", "Cuprum", "Zink", "Chrome", "Triptofan", "Gistidin", "Licin" };


        public static readonly Dictionary<string, int> ccalhistory = new Dictionary<string, int>//load info for WINDOWONE
        {
           

        };
        public static readonly Dictionary<string, int> foodWeightHis = new Dictionary<string, int>//load info for WINDOWONE
        {

        };

        
        public static int ccaltotal=0;//total ccal per day(change in methods: Additional and Substraction (for WINDOWONE)


        public static Dictionary<string, int> nutrition_values = new Dictionary<string, int>(50)  //take foodname from windowadd and take from history previous value
        {                                                               //first time previous value null (for WINDOWONE)
            ["A"] = 0,
            ["B1"] = 0,
            ["B2"] = 0,
            ["B3"] = 0,
            ["B4"] = 0,
            ["B5"] = 0,
            ["B6"] = 0,
            ["B7"] = 0,
            ["B9"] = 0,
            ["B12"] = 0,
            ["C"] = 0,
            ["D"] = 0,
            ["E"] = 0,
            ["K"] = 0,

            ["Copper"] = 0,
            ["Zinc"] = 0,
            ["Chromium"] = 0,
            ["Iron"] = 0,
            ["Magnesium"] = 0,
            ["Phosphorus"] = 0,
            ["Calcium"] = 0,
            ["Selenium"] = 0,
            ["Iodine"] = 0,
            ["Manganese"] = 0,
            ["Fluoride"] = 0,
            ["Potassium"] = 0,

            ["Tryptophan"] = 0,
            ["Histidine"] = 0,
            ["Leucine"] = 0,
            ["Isoleucine"]=0,
            ["Lysine"]= 0,
            ["Methionine"] = 0,
            ["Phenylalanine"] = 0,
            ["Threonine"] = 0,
            ["Valine"] = 0,
        };

        public static Dictionary<string, int> normal_nutrition_values = new Dictionary<string, int>(50)
        {
            ["A"] = 0,
            ["B1"] = 0,
            ["B2"] = 0,
            ["B3"] = 0,
            ["B4"] = 0,
            ["B5"] = 0,
            ["B6"] = 0,
            ["B7"] = 0,
            ["B9"] = 0,
            ["B12"] = 0,
            ["C"] = 0,
            ["D"] = 0,
            ["E"] = 0,
            ["K"] = 0,

            ["Copper"] = 0,
            ["Zinc"] = 0,
            ["Chromium"] = 0,
            ["Iron"] = 0,
            ["Magnesium"] = 0,
            ["Phosphorus"] = 0,
            ["Calcium"] = 0,
            ["Selenium"] = 0,
            ["Iodine"] = 0,
            ["Manganese"] = 0,
            ["Fluoride"] = 0,
            ["Potassium"] = 0,

            ["Tryptophan"] = 0,
            ["Histidine"] = 0,
            ["Leucine"] = 0,
            ["Isoleucine"] = 0,
            ["Lysine"] = 0,
            ["Methionine"] = 0,
            ["Phenylalanine"] = 0,
            ["Threonine"] = 0,
            ["Valine"] = 0,
        };


        public static void Additionplus(string foodname,int weight) //food calculator(добавь в аргументы название food и weight) (for CALCULATOR)
        {

            if (foodWeightHis.ContainsKey(foodname))
            {
                foodWeightHis.Remove(foodname);
                nutrition_values["A"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * A[foodname];
                nutrition_values["B1"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * B1[foodname];
                nutrition_values["B2"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * B2[foodname];
                nutrition_values["B3"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * B3[foodname];
                nutrition_values["B4"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * B4[foodname];
                nutrition_values["B5"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * B5[foodname];
                nutrition_values["B6"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * B6[foodname];
                nutrition_values["B7"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * B7[foodname];
                nutrition_values["B9"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * B9[foodname];
                nutrition_values["B12"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * B12[foodname];
                nutrition_values["C"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * C[foodname];
                nutrition_values["D"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * D[foodname];
                nutrition_values["E"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * E[foodname];
                nutrition_values["K"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * K[foodname];
                
                nutrition_values["Copper"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * copper[foodname];
                nutrition_values["Zinc"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * zinc[foodname];
                nutrition_values["Chromium"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * chromium[foodname];
                nutrition_values["Iron"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * iron[foodname];
                nutrition_values["Magnesium"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * magnesium[foodname];
                nutrition_values["Phosphorus"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * phosphorus[foodname];
                nutrition_values["Calcium"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * calcium[foodname];
                nutrition_values["Selenium"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * selenium[foodname];
                nutrition_values["Iodine"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * iodine[foodname];
                nutrition_values["Manganese"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * manganese[foodname];
                nutrition_values["Fluoride"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * fluoride[foodname];
                nutrition_values["Potassium"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * potassium[foodname];

                nutrition_values["Tryptophan"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * Tryptophan[foodname];
                nutrition_values["Histidine"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * Histidine[foodname];
                nutrition_values["Leucine"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * Leucine[foodname];
                nutrition_values["Isoleucine"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * Isoleucine[foodname];
                nutrition_values["Lysine"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * Lysine[foodname];
                nutrition_values["Methionine"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * Methionine[foodname];
                nutrition_values["Phenylalanine"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * Phenylalanine[foodname];
                nutrition_values["Threonine"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * Threonine[foodname];
                nutrition_values["Valine"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * Valine[foodname];


                /*для того, чтобы удалить нужное нутрвал А
нужно знать сколько удалять нутрвал А.
Чтобы узнать сколько нутрвал А удалять
нужно знать вес того, что удаляем.
Чтобы узнать вес, того, что удаляем, нужно его 
вычислить 
ccalhistory[foodname]=weight*ccalinfo[foodname]
      50             = 5     * 10
ccalhistory[foodname]/ccalinfo[foodname]=weight

(ccalhistory[foodname]/ccalinfo[foodname])*A[foodname]*/
                ccaltotal -= ccalhistory[foodname];
                ccalhistory.Remove(foodname);
                
                

            }
            nutrition_values["A"] += weight*A[foodname];
            nutrition_values["B1"] += weight * B1[foodname];
            nutrition_values["B2"] += weight * B2[foodname];
            nutrition_values["B3"] += weight * B3[foodname];
            nutrition_values["B4"] += weight * B4[foodname];
            nutrition_values["B5"] += weight * B5[foodname];
            nutrition_values["B6"] += weight * B6[foodname];
            nutrition_values["B7"] += weight * B7[foodname];
            nutrition_values["B9"] += weight * B9[foodname];
            nutrition_values["B12"] += weight * B12[foodname];
            nutrition_values["C"] += weight * C[foodname];
            nutrition_values["D"] += weight * D[foodname];
            nutrition_values["E"] += weight * E[foodname];
            nutrition_values["K"] += weight * K[foodname];

           

            nutrition_values["Copper"] += weight * copper[foodname];
            nutrition_values["Zinc"] += weight * zinc[foodname];
            nutrition_values["Chromium"] += weight * chromium[foodname];
            nutrition_values["Iron"] += weight * iron[foodname];
            nutrition_values["Magnesium"] += weight * magnesium[foodname];
            nutrition_values["Phosphorus"] += weight * phosphorus[foodname];
            nutrition_values["Calcium"] += weight * calcium[foodname];
            nutrition_values["Selenium"] += weight * selenium[foodname];
            nutrition_values["Iodine"] += weight * iodine[foodname];
            nutrition_values["Manganese"] += weight * manganese[foodname];
            nutrition_values["Fluoride"] += weight * fluoride[foodname];
            nutrition_values["Potassium"] += weight * potassium[foodname];

            nutrition_values["Tryptophan"] += weight * Tryptophan[foodname];
            nutrition_values["Histidine"] += weight * Histidine[foodname];
            nutrition_values["Leucine"] += weight * Leucine[foodname];
            nutrition_values["Isoleucine"] += weight * Isoleucine[foodname];
            nutrition_values["Lysine"] += weight * Lysine[foodname];
            nutrition_values["Methionine"] += weight * Methionine[foodname];
            nutrition_values["Phenylalanine"] += weight * Phenylalanine[foodname];
            nutrition_values["Threonine"] += weight * Threonine[foodname];
            nutrition_values["Valine"] += weight * Valine[foodname];

            foodWeightHis.Add(foodname,weight);
            ccalhistory.Add(foodname, weight * ccalinfo[foodname]);
            //ccalhistory.Add(foodname, );//информация для ccalinfo складывается издобавления нужного food
            ////и высчитаных ккал, путем умножения весе, который был выбран в окне window add на ккал за грамм из коллекции
            ////ccalinfo по индексу нужного food
            ccaltotal+= ccalhistory[foodname];
        }
        public static void Substraction(string foodname)// (добавь в аргументы название food) (for CALCULATOR)
        {
            foodWeightHis.Remove(foodname);
            nutrition_values["A"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * A[foodname];
            nutrition_values["B1"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * B1[foodname];
            nutrition_values["B2"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * B2[foodname];
            nutrition_values["B3"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * B3[foodname];
            nutrition_values["B4"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * B4[foodname];
            nutrition_values["B5"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * B5[foodname];
            nutrition_values["B6"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * B6[foodname];
            nutrition_values["B7"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * B7[foodname];
            nutrition_values["B9"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * B9[foodname];
            nutrition_values["B12"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * B12[foodname];
            nutrition_values["C"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * C[foodname];
            nutrition_values["D"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * D[foodname];
            nutrition_values["E"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * E[foodname];
            nutrition_values["K"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * K[foodname];

            nutrition_values["Copper"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * copper[foodname];
            nutrition_values["Zinc"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * zinc[foodname];
            nutrition_values["Chromium"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * chromium[foodname];
            nutrition_values["Iron"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * iron[foodname];
            nutrition_values["Magnesium"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * magnesium[foodname];
            nutrition_values["Phosphorus"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * phosphorus[foodname];
            nutrition_values["Calcium"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * calcium[foodname];
            nutrition_values["Selenium"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * selenium[foodname];
            nutrition_values["Iodine"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * iodine[foodname];
            nutrition_values["Manganese"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * manganese[foodname];
            nutrition_values["Fluoride"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * fluoride[foodname];
            nutrition_values["Potassium"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * potassium[foodname];

            nutrition_values["Tryptophan"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * Tryptophan[foodname];
            nutrition_values["Histidine"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * Histidine[foodname];
            nutrition_values["Leucine"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * Leucine[foodname];
            nutrition_values["Isoleucine"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * Isoleucine[foodname];
            nutrition_values["Lysine"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * Lysine[foodname];
            nutrition_values["Methionine"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * Methionine[foodname];
            nutrition_values["Phenylalanine"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * Phenylalanine[foodname];
            nutrition_values["Threonine"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * Threonine[foodname];
            nutrition_values["Valine"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * Valine[foodname];


            /*для того, чтобы удалить нужное нутрвал А
нужно знать сколько удалять нутрвал А.
Чтобы узнать сколько нутрвал А удалять
нужно знать вес того, что удаляем.
Чтобы узнать вес, того, что удаляем, нужно его 
вычислить 
ccalhistory[foodname]=weight*ccalinfo[foodname]
  50             = 5     * 10
ccalhistory[foodname]/ccalinfo[foodname]=weight

(ccalhistory[foodname]/ccalinfo[foodname])*A[foodname]*/
            ccaltotal -= ccalhistory[foodname];
            ccalhistory.Remove(foodname);





        }


        //List<string> Aminosname = new List<string> { "Triptofan", "Gistidin", "Licin" };//for visual window one
        public static readonly Dictionary<string, int> Tryptophan = new Dictionary<string, int>
        {
            [fruitsname[0]] = 10,
            [fruitsname[1]] = 20,
            [fruitsname[2]] = 30,

            [vegetablesname[0]] = 110,
            [vegetablesname[1]] = 220,
            [vegetablesname[2]] = 330,
        };
        public static readonly Dictionary<string, int> Histidine = new Dictionary<string, int>
        {
            [fruitsname[0]] = 15,
            [fruitsname[1]] = 28,
            [fruitsname[2]] = 37,

            [vegetablesname[0]] = 11,
            [vegetablesname[1]] = 22,
            [vegetablesname[2]] = 30,
        };
        public static readonly Dictionary<string, int> Leucine = new Dictionary<string, int>
        {
            [fruitsname[0]] = 5,
            [fruitsname[1]] = 64,
            [fruitsname[2]] = 9,

            [vegetablesname[0]] = 1,
            [vegetablesname[1]] = 2,
            [vegetablesname[2]] = 3,
        };
        public static readonly Dictionary<string, int> Isoleucine = new Dictionary<string, int>  
        {
            [fruitsname[0]] = 5,
            [fruitsname[1]] = 64,
            [fruitsname[2]] = 9,

            [vegetablesname[0]] = 1,
            [vegetablesname[1]] = 2,
            [vegetablesname[2]] = 3,
        };
    public static readonly Dictionary<string, int> Lysine = new Dictionary<string, int> 
        {
            [fruitsname[0]] = 5,
            [fruitsname[1]] = 64,
            [fruitsname[2]] = 9,

            [vegetablesname[0]] = 1,
            [vegetablesname[1]] = 2,
            [vegetablesname[2]] = 3,
        };
        public static readonly Dictionary<string, int> Methionine = new Dictionary<string, int>
        {
            [fruitsname[0]] = 15,
            [fruitsname[1]] = 28,
            [fruitsname[2]] = 37,

            [vegetablesname[0]] = 11,
            [vegetablesname[1]] = 22,
            [vegetablesname[2]] = 30,
        };
        public static readonly Dictionary<string, int> Phenylalanine = new Dictionary<string, int>
        {
            [fruitsname[0]] = 5,
            [fruitsname[1]] = 64,
            [fruitsname[2]] = 9,

            [vegetablesname[0]] = 1,
            [vegetablesname[1]] = 2,
            [vegetablesname[2]] = 3,
        };
        public static readonly Dictionary<string, int> Threonine = new Dictionary<string, int>
        {
            [fruitsname[0]] = 5,
            [fruitsname[1]] = 64,
            [fruitsname[2]] = 9,

            [vegetablesname[0]] = 1,
            [vegetablesname[1]] = 2,
            [vegetablesname[2]] = 3,
        };
        public static readonly Dictionary<string, int> Valine = new Dictionary<string, int>
        {
            [fruitsname[0]] = 5,
            [fruitsname[1]] = 64,
            [fruitsname[2]] = 9,

            [vegetablesname[0]] = 1,
            [vegetablesname[1]] = 2,
            [vegetablesname[2]] = 3,
        };

        // List<string> vitaminsname = new List<string> { "A", "B1", "C" };
        public static readonly Dictionary<string, int> A = new Dictionary<string, int>
        {
            [fruitsname[0]] = 88,
            [fruitsname[1]] = 16,
            [fruitsname[2]] = 4,

            [vegetablesname[0]] = 71,
            [vegetablesname[1]] = 222,
            [vegetablesname[2]] = 1,
        };
        public static readonly Dictionary<string, int> B1 = new Dictionary<string, int>
        {
            [fruitsname[0]] = 3,
            [fruitsname[1]] = 1,
            [fruitsname[2]] = 55,

            [vegetablesname[0]] = 1147,
            [vegetablesname[1]] = 225,
            [vegetablesname[2]] = 300,
        };
        public static readonly Dictionary<string, int> B2 = new Dictionary<string, int>
        {
            [fruitsname[0]] = 5,
            [fruitsname[1]] = 64,
            [fruitsname[2]] = 9,

            [vegetablesname[0]] = 81,
            [vegetablesname[1]] = 28,
            [vegetablesname[2]] = 389,
        };
        public static readonly Dictionary<string, int> B3 = new Dictionary<string, int>
        {
            [fruitsname[0]] = 88,
            [fruitsname[1]] = 16,
            [fruitsname[2]] = 4,

            [vegetablesname[0]] = 71,
            [vegetablesname[1]] = 222,
            [vegetablesname[2]] = 1,
        };
        public static readonly Dictionary<string, int> B4 = new Dictionary<string, int>
        {
            [fruitsname[0]] = 3,
            [fruitsname[1]] = 1,
            [fruitsname[2]] = 55,

            [vegetablesname[0]] = 1147,
            [vegetablesname[1]] = 225,
            [vegetablesname[2]] = 300,
        };
        public static readonly Dictionary<string, int> B5 = new Dictionary<string, int>
        {
            [fruitsname[0]] = 5,
            [fruitsname[1]] = 64,
            [fruitsname[2]] = 9,

            [vegetablesname[0]] = 81,
            [vegetablesname[1]] = 28,
            [vegetablesname[2]] = 389,
        };
        public static readonly Dictionary<string, int> B6 = new Dictionary<string, int>
        {
            [fruitsname[0]] = 88,
            [fruitsname[1]] = 16,
            [fruitsname[2]] = 4,

            [vegetablesname[0]] = 71,
            [vegetablesname[1]] = 222,
            [vegetablesname[2]] = 1,
        };
        public static readonly Dictionary<string, int> B7 = new Dictionary<string, int>
        {
            [fruitsname[0]] = 3,
            [fruitsname[1]] = 1,
            [fruitsname[2]] = 55,

            [vegetablesname[0]] = 1147,
            [vegetablesname[1]] = 225,
            [vegetablesname[2]] = 300,
        };
        public static readonly Dictionary<string, int> B9 = new Dictionary<string, int>
        {
            [fruitsname[0]] = 5,
            [fruitsname[1]] = 64,
            [fruitsname[2]] = 9,

            [vegetablesname[0]] = 81,
            [vegetablesname[1]] = 28,
            [vegetablesname[2]] = 389,
        };
        public static readonly Dictionary<string, int> B12 = new Dictionary<string, int>
        {
            [fruitsname[0]] = 88,
            [fruitsname[1]] = 16,
            [fruitsname[2]] = 4,

            [vegetablesname[0]] = 71,
            [vegetablesname[1]] = 222,
            [vegetablesname[2]] = 1,
        };
        public static readonly Dictionary<string, int> C = new Dictionary<string, int>
        {
            [fruitsname[0]] = 3,
            [fruitsname[1]] = 1,
            [fruitsname[2]] = 55,

            [vegetablesname[0]] = 1147,
            [vegetablesname[1]] = 225,
            [vegetablesname[2]] = 300,
        };
        public static readonly Dictionary<string, int> D = new Dictionary<string, int>
        {
            [fruitsname[0]] = 5,
            [fruitsname[1]] = 64,
            [fruitsname[2]] = 9,

            [vegetablesname[0]] = 81,
            [vegetablesname[1]] = 28,
            [vegetablesname[2]] = 389,
        };
        public static readonly Dictionary<string, int> E = new Dictionary<string, int>
        {
            [fruitsname[0]] = 88,
            [fruitsname[1]] = 16,
            [fruitsname[2]] = 4,

            [vegetablesname[0]] = 71,
            [vegetablesname[1]] = 222,
            [vegetablesname[2]] = 1,
        };
        public static readonly Dictionary<string, int> K = new Dictionary<string, int>
        {
            [fruitsname[0]] = 3,
            [fruitsname[1]] = 1,
            [fruitsname[2]] = 55,

            [vegetablesname[0]] = 1147,
            [vegetablesname[1]] = 225,
            [vegetablesname[2]] = 300,
        };
       
        //List<string> microname = new List<string> { "Cuprum", "Zink", "Chrome" };
        public static readonly Dictionary<string, int> copper = new Dictionary<string, int>
        {
            [fruitsname[0]] = 88,
            [fruitsname[1]] = 16,
            [fruitsname[2]] = 4,

            [vegetablesname[0]] = 181,
            [vegetablesname[1]] = 222,
            [vegetablesname[2]] = 500,
        };
        public static readonly Dictionary<string, int> zinc = new Dictionary<string, int>
        {
            [fruitsname[0]] = 3,
            [fruitsname[1]] = 1,
            [fruitsname[2]] = 55,

            [vegetablesname[0]] = 1781,
            [vegetablesname[1]] = 2258,
            [vegetablesname[2]] = 380,
        };
        public static readonly Dictionary<string, int> chromium = new Dictionary<string, int>
        {
            [fruitsname[0]] = 5,
            [fruitsname[1]] = 64,
            [fruitsname[2]] = 9,

            [vegetablesname[0]] = 991,
            [vegetablesname[1]] = 922,
            [vegetablesname[2]] = 930,
        };
        public static readonly Dictionary<string, int> iron = new Dictionary<string, int>
        {
            [fruitsname[0]] = 88,
            [fruitsname[1]] = 16,
            [fruitsname[2]] = 4,

            [vegetablesname[0]] = 181,
            [vegetablesname[1]] = 222,
            [vegetablesname[2]] = 500,
        };
        public static readonly Dictionary<string, int> magnesium = new Dictionary<string, int>
        {
            [fruitsname[0]] = 3,
            [fruitsname[1]] = 1,
            [fruitsname[2]] = 55,

            [vegetablesname[0]] = 1781,
            [vegetablesname[1]] = 2258,
            [vegetablesname[2]] = 380,
        };
        public static readonly Dictionary<string, int> phosphorus = new Dictionary<string, int>
        {
            [fruitsname[0]] = 5,
            [fruitsname[1]] = 64,
            [fruitsname[2]] = 9,

            [vegetablesname[0]] = 991,
            [vegetablesname[1]] = 922,
            [vegetablesname[2]] = 930,
        };
        public static readonly Dictionary<string, int> calcium = new Dictionary<string, int>
        {
            [fruitsname[0]] = 88,
            [fruitsname[1]] = 16,
            [fruitsname[2]] = 4,

            [vegetablesname[0]] = 181,
            [vegetablesname[1]] = 222,
            [vegetablesname[2]] = 500,
        };
        public static readonly Dictionary<string, int> selenium = new Dictionary<string, int>
        {
            [fruitsname[0]] = 3,
            [fruitsname[1]] = 1,
            [fruitsname[2]] = 55,

            [vegetablesname[0]] = 1781,
            [vegetablesname[1]] = 2258,
            [vegetablesname[2]] = 380,
        };
        public static readonly Dictionary<string, int> iodine = new Dictionary<string, int>
        {
            [fruitsname[0]] = 5,
            [fruitsname[1]] = 64,
            [fruitsname[2]] = 9,

            [vegetablesname[0]] = 991,
            [vegetablesname[1]] = 922,
            [vegetablesname[2]] = 930,
        };
        public static readonly Dictionary<string, int> manganese = new Dictionary<string, int>
        {
            [fruitsname[0]] = 88,
            [fruitsname[1]] = 16,
            [fruitsname[2]] = 4,

            [vegetablesname[0]] = 181,
            [vegetablesname[1]] = 222,
            [vegetablesname[2]] = 500,
        };
        public static readonly Dictionary<string, int> fluoride = new Dictionary<string, int>
        {
            [fruitsname[0]] = 3,
            [fruitsname[1]] = 1,
            [fruitsname[2]] = 55,

            [vegetablesname[0]] = 1781,
            [vegetablesname[1]] = 2258,
            [vegetablesname[2]] = 380,
        };
        public static readonly Dictionary<string, int> potassium = new Dictionary<string, int>
        {
            [fruitsname[0]] = 5,
            [fruitsname[1]] = 64,
            [fruitsname[2]] = 9,

            [vegetablesname[0]] = 991,
            [vegetablesname[1]] = 922,
            [vegetablesname[2]] = 930,
        };
        


    }

    
}
