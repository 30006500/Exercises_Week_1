using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Program
    {
        public static void Main()
        {
            int num1 = 0;
            int num2 = 0;
            

            Console.WriteLine("Please enter the first number");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            num2 = int.Parse(Console.ReadLine());
            int num3 = num1 + num2;
            Console.WriteLine("{0} + {1} = {2}", num1, num2, num3);
            Console.ReadLine();
        }
    }
}
