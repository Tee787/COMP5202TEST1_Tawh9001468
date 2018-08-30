using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            
            Console.WriteLine($"Enter number 1: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter number 2: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter number 3: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter number 4: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter number 5: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter number 6: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter number 7: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter number 8: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter number 9: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Enter number 10: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine($"The total is {0} ", (num * 10));
            Console.WriteLine($"the average of those ten numbers are {0} ",(num / 10) );
            Console.ReadLine();

        }
    }
}
