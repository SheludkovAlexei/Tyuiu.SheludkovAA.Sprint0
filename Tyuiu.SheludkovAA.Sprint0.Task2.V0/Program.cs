using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SheludkovAA.Sprint0.Task2.V0.Lib; //референс

namespace Tyuiu.SheludkovAA.Sprint0.Task2.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(DataService.GetMessage("Алексей"));
            Console.ReadKey(); // не закрывает командную строку

        }
    }
}
