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
        public void BinarySearch()
        {
            char ch;
            do
            {
                //accpect the number to be searched 
                Console.Write("\nEnter element want you to Search : ");
                int item = Convert.ToInt32(Console.ReadLine());

                //applt binary search
                int lowerbound = 0;
                int upperbound = n - 1;

                //obtain the index of the middle elemets
                int mid = (lowerbound + upperbound) / 2;
                int ctr = 1;

                //loop to search for the elements in the array 
                while ((item != arr[mid]) && (lowerbound <= upperbound))
                {
                    if (item > arr[mid])
                        lowerbound = mid + 1;
                    else
                        upperbound = mid - 1;
                    mid = (lowerbound + upperbound) / 2;
                    ctr++;
                }
                if (item == arr[mid])
                    Console.WriteLine("\n" + item.ToString() + "Found at position" + (mid + 1).ToString());
                else
                    Console.WriteLine("\n" + item.ToString() + "Not Found in the array \n");
                Console.WriteLine("\nNumber of comprasion : " + ctr);

                Console.Write("\nCOntinue search (y/n) : ");
                ch = char.Parse(Console.ReadLine());

            } while ((ch != 'y') || (ch == 'y'));

        }


        static void main()
        {

        }



    }

}
