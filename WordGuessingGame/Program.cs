using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordGuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
       
            string secretword = "giraffe";
            string guess = "";
            int guesscount = 0;
            int guesslimit = 3;
            bool outofguesses = false;

            while(guess!=secretword && !outofguesses)
            {
                if(guesscount < guesslimit)
                {
                    Console.WriteLine("Enter guess :");
                    guess = Console.ReadLine();
                    guesscount++;
                }
                else
                {
                    outofguesses=true;
                }
                
            }
            if(outofguesses)
            {
                Console.WriteLine("You loose ");
            }
            else
            {
                Console.WriteLine("You win! ");
            }

           
        }
    }
}
