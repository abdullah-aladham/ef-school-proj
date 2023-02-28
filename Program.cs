using System;
using System.Net.Mime;
using static System.Runtime.InteropServices.JavaScript.JSType;
//using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Globalization;

namespace ConsoleApp2
{
    public class Program
    {

       
        static void Main(string[] args)
        {
          Random random= new Random();
            int secretNum = random.Next(1, 11);
            //Console.WriteLine(x);
            int guessednum = 0;//number guessed by user
            Console.WriteLine("You have a 3 attempts to guess a random secret number with input");
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine("enter random number between 1 and 10");
                guessednum = Convert.ToInt32(Console.ReadLine());
                if(guessednum==secretNum)
                {
                    Console.WriteLine("You gussed it, it was {0}", secretNum);

                }
                else if(i<3) { Console.WriteLine("You haven't guessed the number"); }
            }
            
            
        }
            

        }
    }


