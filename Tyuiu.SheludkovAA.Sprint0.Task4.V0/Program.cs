using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SheludkovAA.Sprint0.Task4.V0.Lib;

namespace Tyuiu.SheludkovAA.Sprint0.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        { 
            
            Console.WriteLine("Сложение чисел = "+ DataService.Addition(10, 5));
            Console.WriteLine("Вычитание чисел = " + DataService.Subtraction(10, 5));
            Console.WriteLine("Умножение чисел = " + DataService.Multiplication(10, 5));
            Console.WriteLine("Деление чисел = " + DataService.Division(10, 5));
            Console.ReadKey();
        }
    }
}
