using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex36
    {
        public static void Main(string[] args)
        {

           
          //36a
            Console.WriteLine("Please give a string:");


            string s = System.Console.ReadLine();
            bool result = false;

            int L=s.Length;
            Console.WriteLine("the length of string is:{0}", L);

       

            for (int i = 0; i <L; i++)
            {

                string a=s.Substring(i,1);
               
                string b=s.Substring(L-i-1,1);

                if (a != b)
                {
                   result= false;
                   break;
                }
                else
                  result=true;
            }

            if (result==true)
            {
                Console.WriteLine("palindrome");  
            }

            if (result ==false)
            {
                Console.WriteLine("Not Palindrome");
            }
          
          
            // start 36b
            Console.WriteLine("Please give a string:");


             s = System.Console.ReadLine();
             string r = s.ToLower();
             Console.WriteLine("the string in lower case is:{0}", r);
             
     

     
        }
    }
}
