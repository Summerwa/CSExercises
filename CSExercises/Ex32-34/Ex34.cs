using System;

namespace CSExercises
{
    public class Ex34
    {
        public static void Main(string[] args)
        {
            int[,] M = new int[12, 4]
            {
           // 0  1  2  3
            {56,84,68,29},{94,73,31,89},{41,63,36,90},
            
            {99,9,18,17},{62,3,65,75},{40,96,53,23},
            
            {81,15,27,30},{21,70,100,22},{88,50,13,12},
            
            {48,54,52,78},{64,71,67,25},{16,93,46,72},

            };

            //int sum = 0;

            //for (int i = 0; i < 12; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        sum = sum + M[i, j];
            //    }
            //}
            //Console.WriteLine("sum{0}", sum);
            //this is used to calculate the sum of the total valuaes in the array.

            int eachsum = 0;

            double overallmark = 0;
            double allaverage = 0;
            for (int stu = 0; stu < 12; stu++)
            {
                for (int sub = 0; sub < 4; sub++)
                {

                    eachsum = eachsum + M[stu, sub];

                }



                Console.WriteLine("the total marks obtained by student {0} is : {1}", stu, eachsum);


                overallmark = overallmark + eachsum;

                allaverage = overallmark / 48;
                //this is used to calculate the average number of the whole array.

                eachsum = 0;
                //add value to zero.

            }

            Console.WriteLine();

            Console.WriteLine("the overall average of marks for the whole class for all subjects is: {0:0.00}", allaverage);
            Console.WriteLine();

            double subsum = 0;
            double subavg = 0;
            double[] AVG=new double[4];
            for (int sub = 0; sub < 4; sub++)
            {
                for (int stu = 0; stu < 12; stu++)
                {
                    subsum = subsum + M[stu, sub];
                }

                subavg = subsum / 12;
                AVG[sub] = subavg;

                Console.WriteLine("the class average marks for subject {0} is : {1:0.00}", sub, subavg);

                subsum = 0;
            }

            Console.WriteLine();


            double sum=0;
            double A=0;
            double variance=0;
            double deviation = 0;

             for (int sub = 0; sub < 4; sub++)
            {
                for (int stu = 0; stu < 12; stu++)
                {
                  
                    //every subject has an average so we need to assign every average to an array. 
                    A = M[stu, sub] - AVG[sub];
                    //Console.WriteLine("stu : " + stu+ "   sub : " + sub);
                    //Console.WriteLine("A - " + A);
                    //Console.WriteLine("M[stu, sub] - " + M[stu, sub]);
                    //Console.WriteLine("subavg - " + subavg);
                    sum = sum + Math.Pow(A, 2);
                }



               variance=sum/12;

               deviation = Math.Sqrt(variance);

               Console.WriteLine("standard deviation of marks for subject {0} is : {1:0.00}", sub, deviation);

                
            }

        }
    }
}
