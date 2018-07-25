using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please enter the first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the third number");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {

                Console.WriteLine("{0} is the highest number", num1);
            }
            else if (num2 > num3 && num2 > num1)
            {
                Console.WriteLine("{0} is the highest number", num2);
            }
            
            else
            {
                Console.WriteLine("{0} is the highest number", num3);
            }
            Console.ReadLine(); 
        }
    }
}
