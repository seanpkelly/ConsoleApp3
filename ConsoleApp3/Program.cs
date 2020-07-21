using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool bContinue = true;
            while (bContinue)
            {


                Console.WriteLine("Please input your length in feet.");
                string input = Console.ReadLine();
                double length = double.Parse(input);
                Console.WriteLine("Please input your width in feet.");

                double width = double.Parse(Console.ReadLine());

                double area = length * width;
                Console.WriteLine("Your area is " + area);

                double perimeter = (length * 2 + width * 2);
                Console.WriteLine("Your perimeter is " + perimeter);

                Console.WriteLine("Would you like to continue? Y/N ");
                string option = Console.ReadLine();
                option = option.ToLower();
                char[] charArray = option.ToCharArray();

                if (charArray[0] == 'y')
                {
                    bContinue = true;
                }
                else if (charArray[0] == 'n')
                {
                    bContinue = false;
                }
                

            
            }

            }
        }
    }

