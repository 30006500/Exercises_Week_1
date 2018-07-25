using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please enter the first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Number 1 is {0}, Number 2 is {1}", num2, num1);
            Console.ReadLine();
        }
    }
}
