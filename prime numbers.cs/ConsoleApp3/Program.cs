using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" enter n1 ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine(" enter n2 ");
            int n2 = int.Parse(Console.ReadLine());
            bool IsPrime = true;
            Console.WriteLine("Prime number ");
            for (int i = n1; i <= n2; i++)
            {
                for (int j =2; j < n2; j++)
                {
                    if(i!= j && i%j == 0)
                    {
                        IsPrime = false;
                        break;
                    }

                }
                if (IsPrime)
                {
                    Console.WriteLine("\n"+i);

                }
                IsPrime = true;

            }
            Console. ReadKey();

        }
        
    }

}

        
            
           