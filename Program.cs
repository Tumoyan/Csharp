using System;

namespace Csharp
{
    class Program
    {

        //MASTER BRANCH
        static void Main(string[] args)
        {
     
         System.Console.WriteLine("Введите радиус круга: " );
        double radius = Convert.ToDouble(Console.ReadLine());
        double area = Math.PI * Math.Pow(radius , 2);
        System.Console.WriteLine("Площадь круга с радиусом {0} равана {1}" , radius, area);


        }
    }
}
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                double firstNum, secondNum;
                string action;

                try
                {
                    Console.WriteLine("Enter firstNum");
                    firstNum = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter secondNum");
                    secondNum = double.Parse(Console.ReadLine());

                }
                catch (Exception)
                {
                    Console.WriteLine("Input correct type");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("Choose action: +, -, *, / ");
                action = Console.ReadLine();

                if (action == "+")
                {
                    Console.WriteLine(firstNum + secondNum);
                }
                else if (action == "-")
                {
                    Console.WriteLine(firstNum - secondNum);
                }
                else if (action == "*")
                {
                    Console.WriteLine(firstNum * secondNum);
                }
                else if (action == "/")
                {
                    if (secondNum == 0)
                    {
                        Console.WriteLine(0);
                    }
                    else
                    {
                        Console.WriteLine(firstNum / secondNum);
                    }
                }

                Console.ReadLine();
            }
        }
    }
}
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

 static void Main(string[] args)
        {
            int count = 0;
            int limit = int.Parse(Console.ReadLine());
            while (count < limit)
            {
                count++;
                Console.WriteLine(count);
            }
        }
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using System;

namespace MyProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            uint oddNumbersCount = 0;
            uint evenNumbersCount = 0;

            int oddNumbersSum = 0;
            int evenNumbersSum = 0;

            Console.WriteLine("Enter first diapozon vaule");
            int currentValue = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter last diapazon value");
            int limit = int.Parse(Console.ReadLine());

            while (currentValue <= limit)
            {
                if (currentValue % 2 == 0)
                {
                    evenNumbersCount++;
                    evenNumbersSum += currentValue;
                }
                else
                {
                    oddNumbersCount++;
                    oddNumbersSum += currentValue;
                }
                currentValue++;
            }

            Console.WriteLine("Odd count numbers: " + oddNumbersCount);
            Console.WriteLine("Even count numbers: " + evenNumbersCount);
            Console.WriteLine("Odd sum  numbers: " + oddNumbersSum);
            Console.WriteLine("Even sun numbers: " + evenNumbersSum);
            Console.ReadLine();
        }
    }
}
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
using System;
/*
 *
 **
 ***
 ****
 *****
 */
namespace MyProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter height triangle:");
            int height = int.Parse(Console.ReadLine());

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}
