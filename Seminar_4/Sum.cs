using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_4
{
    internal class Sum
    {
        public static void getValue()
        {
            int number = Value.getInt("Введите целое число для получения суммы цифр.");
            string str = number.ToString();
            double result = 0;
            
            for (int i = 0; i < str.Length; i++)
            {
                result = result + Char.GetNumericValue(str, i);
            }

            Console.WriteLine("Сумма цифр = " + result);
        }


    }
}
