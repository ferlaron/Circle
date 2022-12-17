using System;
namespace Circle
{
    class Circle
    {
        static void Main()
        {
            System.Console.WriteLine("Введите радиус круга");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius,2);
            System.Console.WriteLine("Площадь круга c радиусом {0} равна {1}",radius,area);
        }
    }
}    
