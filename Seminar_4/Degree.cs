using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_4
{
    internal class Degree
    {
        public static void getValue()
        {
            int number = Value.getInt("Введите целое число для возведения в степень.");
            int degree = Value.getInt("Введите целое число для степени возведения");
            int result = 1;
            for (int i = 0; i < degree; i++)
            {
                result = result * number;
            }

            Console.WriteLine(number + " в степени " + degree + " = " + result);
        }


    }
}
