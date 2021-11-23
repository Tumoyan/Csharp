using System;

namespace Csharp
{
    class Program
    {
                //DEVELOP BRANCH
     static void Main(string[] args)
        {
     
int fahrenheit = 94;
int celsNum = 32;
int result = fahrenheit - celsNum;

decimal result1 = result * 5m/9;
decimal result2 = result1;

Console.WriteLine("The temperature is " + result2 + " Celsiues. "); 

// int fahrenheit = 94;
// decimal celsius = (fahrenheit - 32) * (5 / 9m);
// Console.WriteLine("The temperature is " + celsius + " Celsius.");

}
    }
}
