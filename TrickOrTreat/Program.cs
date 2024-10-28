// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/*
 *Print out numbers from 1 to 100
If a number is a multiple of 3, say "Trick" instead of the number.
If it's a multiple of 5, say "Treat".
For numbers that are multiples of both 3 and 5, shout out "Trick or Treat!" 🕸️🎃
Otherwise, just print the number.
For example:

1, 2, Trick, 4, Treat, Trick, 7, 8, Trick, Treat, 11, Trick, 13, 14, Trick or Treat!
Can you code it up and bring some Halloween spirit to the challenge? 🎃

Advanced Challenge: Fizz Buzz... But Make It Big! 🚀

Think you’ve mastered Fizz Buzz? Let’s raise the stakes:

Write a Fizz Buzz program that can handle arbitrarily large values of n. This means your code should be efficient and able to handle massive inputs without breaking a sweat. 💪
Bonus points if you can implement this in a streaming or memory-efficient way—think about how you would handle a number that’s larger than what you can store in memory.
Show off your code, share your thoughts, and discuss how you approached the problem! Let’s see who can come up with the most efficient (and spooky) solution! 🧙‍♂️👹 
 */


//***********************************************************
int numbersToPrint = 100;
 
for(int i = 1; i <= numbersToPrint; i++)
{
    if(i%3 == 0 && i% 5 == 0)
    {
        Console.WriteLine("Trick or Treat");       
    }
    else if(i%3 == 0)
    {
        Console.WriteLine("Trick");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine("Treat");
    }
    else
    {
        Console.WriteLine($"{i} ");
    }
}
/*First, you need to install BenchmarkDotNet using NuGet. You can do this via the NuGet Package Manager or using the following command in the NuGet Package Manager Console:
 * 
 */
//On Shell
//Install-Package BenchmarkDotNet

//BEST WAY
/*
 * Try benchmarking it with BenchmarkDotNet. It's a library I've used in the past to see how well my algorithms do in real time. 
 * Crank up the numbers to a million and see how it does.*/

/*
 * So if you did a console applicaton you can use the NuGet Package manager, 
 * search for it, and install it that way into your project
 * 
 */
//Next, create a C# console application and set up the code like this:

/*using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

public class Program
{
    public static void Main(string[] args)
    {
        var summary = BenchmarkRunner.Run<TrickOrTreatBenchmark>();
    }
}

public class TrickOrTreatBenchmark
{
    [Benchmark]
    public void PrintTrickOrTreat()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.WriteLine("Trick or Treat!");
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Trick");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Treat");
            }
            else
            {
                Console.WriteLine(i);
            }
        }
    }
}

 * 
 * 
 * 
 */