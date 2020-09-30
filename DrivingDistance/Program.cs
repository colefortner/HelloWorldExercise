using System;

namespace DrivingDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a radius: ");
            string radiusInput = Console.ReadLine();
            double radius = double.Parse(radiusInput);
            double gallons = 
            Console.WriteLine("The area of a circle of radius " + radius + " is: " + Circle.CircleInformation(radius, "area").ToString());
            Console.WriteLine("The circumference of a circle of radius " + radius + " is: " + Circle.CircleInformation(radius, "circumference").ToString());
        }
    }
}
