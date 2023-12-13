using CSharp_8.CovariantReturnType;
using System;
using System.Runtime.CompilerServices;

namespace CSharp_8
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Covariant Return type
            Book book = new Book("My Book", 1, "123-567-7890");
            BookOrder orderBook = (BookOrder)book.Order(2);
           

            //Switch Case 
            var choice = 3;
            var res = choice switch
            {
                0 => "Fresher",
                var x when (x>=1 && x<=2) => "Beginner",
                var x when (x<5) => "Intermediate",
                _ => "Experienced",
            };
            Console.WriteLine(res);
        }
    }
}