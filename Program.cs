using System;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
     
         System.Console.WriteLine("Введите радиус круга: " );
        double radius = Convert.ToDouble(Console.ReadLine());
        double area = Math.PI * Math.Pow(radius , 2);
        System.Console.WriteLine("enter");
        System.Console.WriteLine("Площадь круга с радиусом {0} равана {1}" , radius, area);


        }
    }
}
