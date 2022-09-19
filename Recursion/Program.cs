using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number you want the factorial of: ");
            Console.WriteLine(FactorialRec(Convert.ToInt32(Console.ReadLine())));

            Console.ReadLine();
        }
        static int FactorialRec(int n)
        {

            if(n == 0)
            {
                n = 1;
            }
            else
            {
                n = n * FactorialRec(n - 1);
            }




            return n;
        }
    }
}
