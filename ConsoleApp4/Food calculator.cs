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
            ["C"] = 0,
            ["Cuprum"] = 0,
            ["Zink"] = 0,
            ["Chrome"] = 0,
            ["Triptofan"] = 0,
            ["Gistidin"] = 0,
            ["Licin"] = 0,
        };

        public static Dictionary<string, int> normal_nutrition_values = new Dictionary<string, int>(50)
        {
            ["A"] = 0,
            ["B1"] = 0,
            ["C"] = 0,
            ["Cuprum"] = 0,
            ["Zink"] = 0,
            ["Triptofan"] = 0,
            ["Gistidin"] = 0,
            ["Licin"] = 0,
        };


        public static void Additionplus(string foodname,int weight) //food calculator(добавь в аргументы название food и weight) (for CALCULATOR)
        {

            if (foodWeightHis.ContainsKey(foodname))
            {
                foodWeightHis.Remove(foodname);
                nutrition_values["A"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * A[foodname];
                nutrition_values["B1"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * B1[foodname];
                nutrition_values["C"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * C[foodname];
                nutrition_values["Cuprum"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * cuprum[foodname];
                nutrition_values["Zink"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * zink[foodname];
                nutrition_values["Triptofan"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * Triptofan[foodname];
                nutrition_values["Gistidin"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * Gistidin[foodname];
                nutrition_values["Licin"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * Licin[foodname];
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
            nutrition_values["C"] += weight * C[foodname];
            nutrition_values["Cuprum"] += weight * cuprum[foodname];
            nutrition_values["Zink"] += weight * zink[foodname];
            nutrition_values["Triptofan"] += weight * Triptofan[foodname];
            nutrition_values["Gistidin"] += weight * Gistidin[foodname];
            nutrition_values["Licin"] += weight * Licin[foodname];
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
            nutrition_values["C"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * C[foodname];
            nutrition_values["Cuprum"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * cuprum[foodname];
            nutrition_values["Zink"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * zink[foodname];
            nutrition_values["Triptofan"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * Triptofan[foodname];
            nutrition_values["Gistidin"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * Gistidin[foodname];
            nutrition_values["Licin"] -= (ccalhistory[foodname] / ccalinfo[foodname]) * Licin[foodname];
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
        public static readonly Dictionary<string, int> Triptofan = new Dictionary<string, int>
        {
            [fruitsname[0]] = 10,
            [fruitsname[1]] = 20,
            [fruitsname[2]] = 30,

            [vegetablesname[0]] = 110,
            [vegetablesname[1]] = 220,
            [vegetablesname[2]] = 330,
        };
        public static readonly Dictionary<string, int> Gistidin = new Dictionary<string, int>
        {
            [fruitsname[0]] = 15,
            [fruitsname[1]] = 28,
            [fruitsname[2]] = 37,

            [vegetablesname[0]] = 11,
            [vegetablesname[1]] = 22,
            [vegetablesname[2]] = 30,
        };
        public static readonly Dictionary<string, int> Licin = new Dictionary<string, int>
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
        public static readonly Dictionary<string, int> C = new Dictionary<string, int>
        {
            [fruitsname[0]] = 5,
            [fruitsname[1]] = 64,
            [fruitsname[2]] = 9,

            [vegetablesname[0]] = 81,
            [vegetablesname[1]] = 28,
            [vegetablesname[2]] = 389,
        };

       //List<string> microname = new List<string> { "Cuprum", "Zink", "Chrome" };
        public static readonly Dictionary<string, int> cuprum = new Dictionary<string, int>
        {
            [fruitsname[0]] = 88,
            [fruitsname[1]] = 16,
            [fruitsname[2]] = 4,

            [vegetablesname[0]] = 181,
            [vegetablesname[1]] = 222,
            [vegetablesname[2]] = 500,
        };
        public static readonly Dictionary<string, int> zink = new Dictionary<string, int>
        {
            [fruitsname[0]] = 3,
            [fruitsname[1]] = 1,
            [fruitsname[2]] = 55,

            [vegetablesname[0]] = 1781,
            [vegetablesname[1]] = 2258,
            [vegetablesname[2]] = 380,
        };
        public static readonly Dictionary<string, int> chrome = new Dictionary<string, int>
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
