using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise_1;
using Task_2;
using Task_3;
using Task_4;
using Task_5;
using Task_6;
using Task_7;
using Task_8;
using Task_9;

namespace Exercises_Week_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Menu");
            Console.WriteLine("");
            Console.WriteLine("1) Task 1 - Hello World");
            Console.WriteLine("2) Task 2 - Sum of 74 + 36");
            Console.WriteLine("3) Task 3 - Sum of two user numbers");
            Console.WriteLine("4) Task 4 - Welcome user by name");
            Console.WriteLine("5) Task 5 - Times Tables");
            Console.WriteLine("6) Task 6 - Swap Numbers");
            Console.WriteLine("7) Task 7 - Display highest number");
            Console.WriteLine("8) Task 8 - Pass Mark");
            Console.WriteLine("9) Task 9 - Display Array");
            Console.WriteLine("");
            Console.WriteLine("Please enter the number of the program you want to run");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Exercise_1.Program.Main();
                    break;
                case 2:
                    Task_2.Program.Main();
                    break;
                case 3:
                    Task_3.Program.Main();
                    break;
                case 4:
                    Task_4.Program.Main();
                    break;
                case 5:
                    Task_5.Program.Main();
                    break;
                case 6:
                    Task_6.Program.Main();
                    break;
                case 7:
                    Task_7.Program.Main();
                    break;
                case 8:
                    Task_8.Program.Main();
                    break;
                case 9:
                    Task_9.Program.Main();
                    break;
                default:
                    break;
            }

        }
    }
}
