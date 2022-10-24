using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithm
{
     class Program
    {
        //Array to be Searched 
        int[] arr = new int[20];
        //NUMBER OF EL  ELEMT in the array
        int n;
        // get the number of element to store in the array
        int i;

        public void input()
        {
            while (true)
            {
                Console.Write("Enter the number elements in the array  ");
                string s = Console.ReadLine();
                if ((n > 0) && (n <= 20))
                    break;
                else
                    Console.WriteLine("\nArray should have minimum 1 and maximum 20 elemets.\n");
            }
            // accpect array element
            Console.WriteLine("");
            Console.WriteLine("-----------------------------");
            Console.WriteLine(" Enter array elements ");
            Console.WriteLine("-----------------------------");
            for (i = 0; i< n; i++)
            {
                Console.Write("<" + (i + 1)+ ">");
                string s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }

        }



        static void main()
        {

        }



    }

}
