//Write a public method that accepts a number
// 1. access modifier
// 2. return type
// 3. method name
// 4. parameters
// 5. scope
//when the number is divisible by 3 return the word fizz

//when the number is divisible by 5 return the word buzz

//when the number is divisible by both, return the word fizzbuzz
/*using System;
using System.Linq;

namespace Fizzbuzz
{
    class program
    {
        static string Main()
        {

        }
    }    
}*/
using System;
using System.Linq;

namespace FizzBuzz
{
    class Program
    {
        // write a method
        
        static void Main()
        {
            Console.WriteLine($"The output for FizzBuzz(3) is: {FizzBuzz(3)}");
            Console.WriteLine($"The output for FizzBuzz(5) is: {FizzBuzz(5)}");
            Console.WriteLine($"The output for FizzBuzz(15) is: {FizzBuzz(15)}");
            Console.WriteLine($"The output for FizzBuzz(30) is: {FizzBuzz(30)}");
            Console.WriteLine($"The output for FizzBuzz(4) is: {FizzBuzz(4)}");
            Console.WriteLine($"The output for FizzBuzz(27) is: {FizzBuzz(27)}");
            Console.WriteLine($"The output for FizzBuzz(-25) is: {FizzBuzz(-25)}");
            Console.WriteLine($"The output for FizzBuzz(0) is: {FizzBuzz(0)}");
            Console.WriteLine();
            Console.WriteLine($"Trying this another way Fizzy(3), Fizzy(5), Fizzy(15) is: {Fizzy(3)} {Fizzy(5)} {Fizzy(15)}");
        }
        public static string FizzBuzz(int num)
        {
            return (Math.Abs(num) % 15 == 0) ? "fizzbuzz" : (Math.Abs(num) % 5 == 0) ? "buzz" : (Math.Abs(num) % 3 == 0) ? "fizz" : "This is not a good number.";
        }

        public static string Fizzy(int num)
        {
            var ans = "";
            if (num % 3 == 0)
            {
                ans = "fizz";
            }
            if (num % 5 == 0)
            {
                ans += "buzz";
            }

            return ans; 
        }

    }
}

