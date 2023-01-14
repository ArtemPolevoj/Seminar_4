using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminar_4
{
    internal class ArrayStr
    {
       public static void getString() 
        {
            string input = Value.getString("Введите восемь чисел через запятую.");
            string[] array = input.Split(',');
            string output = "Вывод:\n[";
            for(int i = 0; i < array.Length; i++)
            {
                if(i == 7 || i == 4)
                {
                    output+= array[i] + "]";
                }
                else if (i == 5)
                {
                   output+= "\n[" + array[i] + ", ";
                }
                else
                {
                    output+= array[i] + ", ";
                }
            }

            Console.WriteLine(output);
        }   

    }
}
