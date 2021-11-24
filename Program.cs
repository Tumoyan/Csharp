using System;

namespace Csharp
{
    public class Program
    {
                //DEVELOP BRANCH
     static void Main(string[] args)
        {

            Random dice = new Random();

int roll1 = dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);

int result = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {result}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    result +=2;
}

if ((roll1==roll2) && (roll2==roll3))
{
Console.WriteLine("You rolled triples! +6 bonus to total!");
result +=6;
}

if ( result >= 15){
    Console.WriteLine("You win!");
}

if (result < 15) {
    Console.WriteLine("Sorry, You lose.");
}
        }
     
// Random dice = new Random();
// int roll = dice.Next(1,7);
// Console.WriteLine(roll);

// int fahrenheit = 94;
// int celsNum = 32;
// int result = fahrenheit - celsNum;

// decimal result1 = result * 5m/9;
// decimal result2 = result1;

// Console.WriteLine("The temperature is " + result2 + " Celsiues. "); 


// int fahrenheit = 94;
// decimal celsius = (fahrenheit - 32) * (5 / 9m);
// Console.WriteLine("The temperature is " + celsius + " Celsius.");

}
    }