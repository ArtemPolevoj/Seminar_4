using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_4
{
    internal class Value
    {
        public static int getInt(string str)
        {
            int number;
        checkNumber:
            Console.WriteLine(str);
            string srtNumber = Console.ReadLine();
            try
            {
                number = int.Parse(srtNumber);
            }
            catch (Exception e)
            {
                Console.WriteLine("Ввели не целое число или не число");
                goto checkNumber;
            }
            return number;
        }


        public static double getDouble(string str)
        {
            double number;
        checkNumber:
            Console.WriteLine(str);
            string srtNumber = Console.ReadLine();
            try
            {
                number = double.Parse(srtNumber);
            }
            catch (Exception e)
            {
                Console.WriteLine("Ввели не число или не верный формат числа");
                goto checkNumber;
            }
            return number;
        }

        public static string getString(string str) 
        {
        checkString:
            Console.WriteLine(str);
            string input = Console.ReadLine();
            string[] array = input.Split(',');
            if (array.Length > 8)
            {
                Console.WriteLine("Ввели больше восьми цифр или поставили запятую в конце.");
                goto checkString;
            }
            else if (array.Length < 8)
            {
                Console.WriteLine("Ввели меньше восьми цифр.");
                goto checkString;
            }
            else
            {
                return input;
            }

        }

    }
}
