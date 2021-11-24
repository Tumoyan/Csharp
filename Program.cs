using System;

namespace Csharp
{
    public class Program
    {
                //DEVELOP BRANCH
     static void Main(string[] args)
        {
            Random random = new Random();
int daysUntilExpiration = 1;//random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon.  Renew now!");
}

if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}

            //Random dice = new Random();

// // int roll1 = dice.Next(1,7);
// // int roll2 = dice.Next(1,7);
// // int roll3 = dice.Next(1,7);
// int roll1 = 6;
// int roll2 = 6;
// int roll3 = 5;

// int result = roll1 + roll2 + roll3;

// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {result}");

// if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
// {
//     if ((roll1 == roll2) && (roll2==roll3)) {
//         Console.WriteLine("You rolled triples!  +6 bonus to total!");
//         result +=6;
//     }
//     else {
//         Console.WriteLine("You rolled doubles!  +2 bonus to total!");
//         result += 2;
//     }
// if (result >= 16)
// {
//     Console.WriteLine("You win a new car!");
// }
// else if (result >= 10)
// {
//     Console.WriteLine("You win a new laptop!");
// }
// else if (result ==7) {
//     Console.WriteLine("You win a trip for two!");
// }
// else {
//     Console.WriteLine("You win a kitten!");
// }
     
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
}