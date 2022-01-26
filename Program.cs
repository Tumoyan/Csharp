﻿using System;

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
