using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] fizzbuzzArray = new int[101];
            for (int i = 0; i < fizzbuzzArray.Length; i++)
            {

                if(i % 3 == 0 && i % 5 == 0)
                {
                    BuzzFizz();
                }
                else if(i % 3 == 0)
                {
                    Fizz();
                }
                else if(i % 5 == 0)
                {
                    Buzz();
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
        static void Buzz()
        {
            Console.WriteLine("Buzz.");
        }
        static void Fizz()
        {
            Console.WriteLine("Fizz.");
        }
        static void BuzzFizz()
        {
            Console.WriteLine("FizzBuzz.");
        }
    }
}
