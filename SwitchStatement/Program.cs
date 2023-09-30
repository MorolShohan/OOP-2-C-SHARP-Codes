using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(GetDay(1));
        }

        static string GetDay(int dayNum)
        {
            string dayName;

            switch(dayNum)
            {
                case 0: dayName = "Sunday";
                    break;
                    case 1: dayName = "Monday";
                    break ;     
                    case 2: dayName = "Tuesday";    
                    break;
                    case 3: dayName = "Wednesday";
                    break;
                case 4: dayName = "Thursday";
                    break;
                case 5: dayName = "Friday";
                    break;
                case 6: dayName = "Satuday";
                    break;
                    default: dayName = "INVALID DAY NUMBER";
                    break;
            }

            return dayName;


        }
    }
}
