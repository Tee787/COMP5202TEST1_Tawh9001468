using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********************************************************");

            
            Console.WriteLine("\nEnter a number between 1 and 1000: ");
            int num = int.Parse(Console.ReadLine());

            bool even = true, odd = false;

            

            if (even)
            {
                Console.WriteLine("That number is even");
                
            }
            else if (odd)
            {
                Console.WriteLine("That number is not even");
            }
            

            Console.ReadLine();
            
            
        }
    }
}
