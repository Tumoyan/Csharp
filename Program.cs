using System;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
     
            bool isHasCar = true;
         int a = 5;
         
         if(a > 5 ){
             System.Console.WriteLine("Happy");
         } else if (a < 5){
             System.Console.WriteLine("Undifaded");
         } else if((a == 5 || isHasCar) && a > 6){
             System.Console.WriteLine("URA");
         } else
            {
                System.Console.WriteLine("Recognizer");
            }
            if (isHasCar)
            System.Console.WriteLine("User has car");
         }
        }
    }
