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
            
            
            //start 38a
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

            Console.WriteLine("=====================");


            //start 38b
            for (int m = 0; m < name.Length - 1; m++)
            {
                for (int t = m + 1; t < name.Length; t++)
                {
                    int temp3 = 0;
                    string temp4 = "";
                    string s = name[m];
                    string r = name[t];
                    int result = s.CompareTo(r);

                    if (result == 1)
                    {
                        //swap name
                        temp4 = name[t];
                        name[t] = name[m];
                        name[m] = temp4;
                        // swap mark
                        temp3 = mark[t];
                        mark[t] = mark[m];
                        mark[m] = temp3;

                    }
                }

            }

            for (int n = 0; n < 5; n++)
            {
                Console.WriteLine("the student  {0}  gets the mark  {1}", name[n], mark[n]);
            }


        }
    }
}
