using System;

namespace ChapterTwoStudio
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter a radius: ");
            string radiusInput = Console.ReadLine();
            double radius = double.Parse(radiusInput);

            while (radiusInput == "")
            {
                Console.WriteLine("Enter a radius: ");
                radiusInput = Console.ReadLine();
                radius = double.Parse(radiusInput);
            }

            Console.WriteLine("Enter the mpg of your car: ");
            string mpgInput = Console.ReadLine();
            double mpg = double.Parse(mpgInput);
            double gallons = Circle.CircleInformation(radius, "circumference") / mpg;

            Console.WriteLine("You would need " + gallons.ToString() + " gallons to drive around the circle.");
            Console.WriteLine("The area of a circle of radius " + radius + " is: " + Circle.CircleInformation(radius, "area").ToString());
            Console.WriteLine("The circumference of a circle of radius " + radius + " is: " + Circle.CircleInformation(radius, "circumference").ToString());
        }
    }
}
