using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String name = "SHOHAN";
            int count = 0;
  
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] != ' ')
                    count++;
            } 
            Console.WriteLine("Total number of characters in a string: " + count);
        }
            
        }
    }
