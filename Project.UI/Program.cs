using System;

namespace Project.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array =
            {
                "nurses run",
                "racecaR",
                "1221",
                "never odd, or even.",
                "one two one",
                "123abccba123"
            };
            foreach (string value in array)
            {
                Console.WriteLine("{0} = {1}", value, IsPalindrome (value)); 
            }
        }
    }
}
