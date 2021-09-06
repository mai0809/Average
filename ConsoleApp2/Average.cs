using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, sum = 0;
                double avg;
            Console.Write("\n\n");
            Console.Write("read the 10 numbers and calculate sum and avergae:\n");
            Console.Write("\n\n");
            Console.Write("Enter 10 numbers:/n");
            for (i = 1; i <= 10; i++)
            {
                Console.Write("number -{0}:", i);
                n = Convert.ToInt32(Console.ReadLine());
                sum += n;
            }
            avg = sum / 10.0;
            Console.Write("the sum of 10 no is:{0}\n the average is:{1}\n", sum, avg);


        }
    }
}
