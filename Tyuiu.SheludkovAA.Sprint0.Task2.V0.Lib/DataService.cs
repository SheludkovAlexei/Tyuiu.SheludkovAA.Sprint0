using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.SheludkovAA.Sprint0.Task2.V0.Lib
{
    public class DataService
    {
        public static string GetMessage(string name) //возврат строки
        {
            return $"Привет, {name}"; 
        }
    }
}
