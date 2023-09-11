using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.SheludkovAA.Sprint0.Task6.V0.Lib
{
    public class DataService
    {
        public static object AdditionArray(int[] numbers)
        {
            var total = 0;
            for (var i = 0; i < numbers.Length; i++) // изначально 0 и пока i не будет больше длины массива наращиваем
            {
                total = total + numbers[i];
            }
            return total;
        }
        public static object SubtractionArray(int[] numbers)
        {
            var total = 0;
            int index = 0;
            while (index < numbers.Length) //пока индекс не будет равен длине массива
            {
                total = total - numbers[index]; 
                index++; //привавляем к индексу единичку 
            }
            return total;
        }
        public static object MultiplicationArray(int[] numbers)
        {
            var total = 1;
            int index = 0;
            do
            {
                total = total * numbers[index];
                index++;
            }
            while (index < numbers.Length);//выполнится хотя бы раз

            return total;
        }
    }
}
