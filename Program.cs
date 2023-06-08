using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int guess = 0;
            int tries = 5;
            string input;

            Random random = new Random();
            number = random.Next(100) + 1;


            
            
                while (number != guess)
                {

                    Console.WriteLine("guess a number between 1 and 100");
                    Console.WriteLine("you have " + tries + " tries left");
                    input = Console.ReadLine();
                    guess = Convert.ToInt32(input);

                if (tries != 0)
                {

                    if (guess > number)
                    {
                        Console.WriteLine("lower");
                        guess = 0;
                        tries = tries - 1;
                    }

                    else if (guess < number)
                    {
                        Console.WriteLine("higher");
                        guess = 0;
                        tries = tries - 1;
                    }
                    else
                    {
                        Console.WriteLine("yes");
                    }

                }
                else if (tries == 0)
                {
                    Console.WriteLine("out of tries");
                    break;
                }
                }
            
            Console.ReadKey();
        }
    }
}
