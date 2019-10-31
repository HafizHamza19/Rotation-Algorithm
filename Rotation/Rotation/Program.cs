using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            double angle;
            int opt;
            double x;
            double y;
            int x1;
            int y1;
            int x2;
            int y2;
            int x3;
            int y3;
           
            Console.WriteLine("**************************Rotation*******************************");
            Console.WriteLine("Please Select \n1)Clock Wise Rotation \n2)AntiClockWise Rotation");
            opt = Int16.Parse(Console.ReadLine());
            Console.WriteLine("\n\nEnter The Value of Angle :");
            angle = Int16.Parse(Console.ReadLine());
           
            Console.WriteLine("\n\nEnter The Value of x1 :");
            x1 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Value of y1 :");
            y1 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Value of x2 :");
            x2 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Value of y2 :");
            y2 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Value of x3 :");
            x3 = Int16.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Value of y3 :");
            y3 = Int16.Parse(Console.ReadLine());
            if (opt == 1)
            {
                x = Convert.ToInt32(Math.Cos(angle)) * x1 + Convert.ToInt32(Math.Sin(angle)) * y1;
                y = Convert.ToInt32((-Math.Sin(angle))) * x1 + Convert.ToInt32(Math.Cos(angle)) * y1;
                Console.WriteLine("\n\nFirst Point is  (" + x + "," + y + ")");
                x = Convert.ToInt32(Math.Cos(angle)) * x2 + Convert.ToInt32(Math.Sin(angle)) * y2;
                y = Convert.ToInt32((-Math.Sin(angle))) * x2 + Convert.ToInt32(Math.Cos(angle)) * y2;
                Console.WriteLine("Second Point is  (" + x + "," + y + ")");
                x = Convert.ToInt32(Math.Cos(angle)) * x3 + Convert.ToInt32(Math.Sin(angle)) * y3;
                y = Convert.ToInt32((-Math.Sin(angle))) * x3 + Convert.ToInt32(Math.Cos(angle)) * y3;
                Console.WriteLine("Third Point is  (" + x + "," + y + ")");
            }
            if (opt == 2)
            {
                x = Convert.ToInt32(Math.Cos(angle)) * x1 + Convert.ToInt32((-Math.Sin(angle))) * y1;
                y = Convert.ToInt32(Math.Sin(angle)) * x1 + Convert.ToInt32(Math.Cos(angle)) * y1;
                Console.WriteLine("\n\nFirst Point is  (" + x + "," + y + ")");
                x = Convert.ToInt32(Math.Cos(angle)) * x2 + Convert.ToInt32((-Math.Sin(angle))) * y2;
                y = Convert.ToInt32(Math.Sin(angle)) * x2 + Convert.ToInt32(Math.Cos(angle)) * y2;
                Console.WriteLine("Second Point is  (" + x + "," + y + ")");
                x = Convert.ToInt32(Math.Cos(angle)) * x3 + Convert.ToInt32((-Math.Sin(angle))) * y3;
                y = Convert.ToInt32(Math.Sin(angle)) * x3 + Convert.ToInt32(Math.Cos(angle)) * y3;
                Console.WriteLine("Third Point is  (" + x + "," + y + ")");
            }
            Console.ReadLine();

        }
    }
}
