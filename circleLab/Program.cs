using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace circleLab
{
    class Program
    {
    static void Main(string[] args)
    {
        int amountOfCircles = 0;
        for (int i = 0; i == 0;)
        {
            Circle userCircle = new Circle();
            Console.WriteLine("\nPlease enter the radius of a circle");
            string input = Console.ReadLine();              
            userCircle.Radius = double.Parse(input);
            Console.WriteLine("\nThe area of your circle is " + userCircle.FormatArea());
            Console.WriteLine("\nThe circumference of your circle is " + userCircle.FormatCircumference());
            amountOfCircles++;
            Console.WriteLine("\nWould you like to continue?");
            string choice = Console.ReadLine().ToLower();
            for (int j = 0; j == 0;)
            {
                 if (choice == "n")
                    {
                        Console.WriteLine("\nGoodbye. You made {0} circle(s)", amountOfCircles);
                        Console.ReadLine();
                        i++;
                        j++;
                    }
                    else if (choice == "y")
                    {
                        j++;
                    }
                    else if (choice != "n" && choice != "y")
                    {
                        Console.WriteLine("\nInvalid entry, Please enter y or n");    
                        choice = Console.ReadLine().ToLower();
                    }
                }
            }
        }
    }
}
class Circle
{
    private double radius;
    public double Radius
    {
        get
        {
            return radius;
        }
        set
        {
            radius = value;
        }
    }
    public const double Pi = Math.PI;
    public Circle()
    {
        Radius = radius;
    }
    public double Area()
    {
        double area = Pi * radius * radius;
        return area;
    }
    public double FormatArea()
    {
        return Math.Round(Area(), 2);
    }
    public double Circumference()
    {
        double circumference = 2 * Pi * radius;
        return circumference;
    }
    public double FormatCircumference()
    {
        return Math.Round(Circumference(), 2);
    }
    public string FormatNumber(double num)
    {
        string formatNum = Convert.ToString(num);
        return formatNum;
    }
}