using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        {

            bool tocontinue = true;
             for (int i = 5; i <= 10000; i++)
               {
               
                 for (int j = 2; j <i; j++)
                {
                     
                     if (i % j == 0)
                    {
                        tocontinue=false;
                        break;
                    }
                     else
                     {
                         tocontinue = true;
                     }
                } 

                if (tocontinue==true)
	            {
	               Console.WriteLine("the prime number is:{0}", i);	 
	            }

             }

          }

      }
 }

