using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex38
    {
        public static void Main(string[] args)
        {
            string[] name = new string[5] { "John","Venkat","Mary","Victor","Betty"};
            int[] mark = new int[5] { 63, 29, 75, 82, 55 };
            for (int i = 0; i < mark.Length-1; i++)
            {
                for (int j = i+1; j < mark.Length; j++)
                {
                     int temp1=0;
                     string temp2="";
                     if (mark[j]>mark[i])
                     {
                         
                         // swap mark
                         temp1 = mark[j];
                         mark[j] = mark[i];
                         mark[i] = temp1;
                         //swap name
                         temp2 = name[j];
                         name[j] = name[i];
                         name[i] = temp2;
                   
                    }
                }
 
            }

            //printing array needs another for loop
            for (int k = 0; k < 5; k++)
            {
                Console.WriteLine("the student{0} gets the mark{1}", name[k], mark[k]);
            }
           
 

        }
    }
}
