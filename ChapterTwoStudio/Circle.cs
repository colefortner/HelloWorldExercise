using System;
namespace ChapterTwoStudio
{
    public class Circle
    {
        public static double CircleInformation(double radius, string information)
        {
            if (information.Equals("area"))
            {
                double area = Math.PI * Math.Pow(radius, 2);
                return area;
            }
            if (information.Equals("circumference"))
            {
                double circumference = 2 * Math.PI * radius;
                return circumference;
            }
            // would not work without this final return, what are some other solutions?
            return -1;
        }
    }
}
