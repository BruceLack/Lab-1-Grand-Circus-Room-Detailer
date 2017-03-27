using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Number_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grand Circus' Room Detail Generator!");
            string answer1;
            string answer2;
            do
            {
                Console.WriteLine("Please Enter Room Length in Feet: ");
                float length = float.Parse(Console.ReadLine());
                Console.WriteLine("Please enter Room Width in Feet: ");
                float width = float.Parse(Console.ReadLine());

                float area = length * width;

                float perimeter = (length * 2) + (width * 2);

                Console.WriteLine("Room Area = " + area + " square feet.");
                Console.WriteLine("Room Perimeter = " + perimeter + " feet.");
                Console.WriteLine("Would you like to calculate the room's volume? y/n ");
                answer1 = Console.ReadLine();
                if (answer1 == "y")
                {
                    Console.WriteLine("Please enter room height in Feet: ");
                    float height = float.Parse(Console.ReadLine());

                    float volume = area * height;

                    Console.WriteLine("The Room's volume is " + volume +" cubic feet.");

                }
                Console.WriteLine("Would you like to continue measuring rooms? y/n ");
                answer2 = Console.ReadLine();
            }
            while (answer2 == "y");
            Console.WriteLine("Thank you for using the Grand Circus Room Detail Generator for all your room detailing needs!");

            
        }
    }
}
