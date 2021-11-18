using System;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
     

            System.Console.Write("Enter name: ");
           string role = Console.ReadLine();

           if( role == "Admin"){
                System.Console.WriteLine("Enter user name: ");
                string user_name = Console.ReadLine();
                System.Console.Write("Enter {0} age : " , user_name);
                short age = Convert.ToInt16(Console.ReadLine());

                if (age <= 0 || age > 99){
                    System.Console.Write("Enter {0} age : " , user_name);
                 age = Convert.ToInt16(Console.ReadLine());
                }

             if (age <= 0 || age > 99){
                   Console.WriteLine("Error");
                   age = 0;
                }
                else 
                System.Console.WriteLine("User's age is: " + age);

           }   else
           System.Console.WriteLine("You are not admin!");    
    }
    }
}