using System;

namespace Csharp
{
    public class Program
    {
                //DEVELOP BRANCH
     static void Main(string[] args)
        {
            
            string[] firstNnames = {"Bob" , "Narek" , "Ashot" , "Anna" , "Nur"};

            foreach (string firstNname in firstNnames)
            {
                if (firstNname.StartsWith("N")) 
                {
                    System.Console.WriteLine(firstNname);
                }
            }
}
}
}