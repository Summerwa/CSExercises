using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        
        
        {



            Random n = new Random();
            int computer = n.Next(0, 10);
            int guess = 0;
            int counter = 1;

            // 23 a
            //this green is plan B: bool tocontinue = true;

            do
            {
                Console.WriteLine("Please enter your guess (0-9):");
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess == computer)
                {
                    Console.WriteLine("Congratulation!");
                    Console.WriteLine("you have tried {0} times", counter);
                    //tocontinue = false;
                }
                else
                {
                    Console.WriteLine("It's wrong. Please try again.");
                    counter = counter + 1;
                }
            } while (guess != computer);
            //} while (tocontinue);


            //23 b   when you want to execute 23b, please make 23a as comments.

             n = new Random();
            computer = n.Next(0, 10);
            guess = 0;
             counter = 1;
            do
            {
                Console.WriteLine("Please enter your guess (0-9):");
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess == computer)
                {
                    
                    if (counter<=2)
                    {
                        Console.WriteLine("You are a Wizard!");
                    }
                    else if (counter<=5)
                    {
                       Console.WriteLine("You are a good guess!"); 
                    }
                    else
                    {
                        Console.WriteLine("You are lousy!");
                    }

                }
                else
                {
                    Console.WriteLine("Try again.");
                    counter = counter + 1;
                }
            } while (guess != computer);
	











        }
    }
}



       