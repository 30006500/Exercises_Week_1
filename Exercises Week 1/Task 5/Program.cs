using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please enter a number between 1 an 12");
            int num = int.Parse(Console.ReadLine());
            for(int i = 0; i <= 12; i++)
            {
                int result = num * i;
                Console.WriteLine("{0} x {1} = {2}",num, i, result);
            }

            Console.ReadLine();
        }
        
    }
}
