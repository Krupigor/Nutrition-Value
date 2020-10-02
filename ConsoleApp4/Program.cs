using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Members Igor = new Members("Igor", 36);
            windowone I = new windowone();
            AddNewMember w = new AddNewMember(I);
            Application.Run(w);
            Application.Run(I);
            
            




        }


    }
}
