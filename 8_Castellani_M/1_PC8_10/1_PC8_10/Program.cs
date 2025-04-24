using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_PC8_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("0");
            for (int i = 1; i <= 100; i++) 
            {
                if (((i % 5) == 0) && ((i % 3) == 0))
                {
                    Console.Write(" FizzBuzz ");
                        }
                else if ((i % 5) == 0)
                {
                    Console.Write(" Buzz ");
                    }
                else if ((i % 3) == 0)
                {
                    Console.Write(" Fizz ");
                    }
                Console.WriteLine(i);
            }

           
            Console.ReadKey();
        }


    }
}

