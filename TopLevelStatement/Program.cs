// This file demonstrates C# 9 top-level statements.
// The code runs directly without a Main method boilerplate.

Console.WriteLine("Demonstrating top-level statements!");

int a = 10;
a = 2;
a = 4; // The final value of 'a' is 4.

Console.WriteLine($"The final value of a is: {a}");

// You can define and call methods from helper classes.
Console.WriteLine(TestStatement.Test.StaticTest());

// You can even return a value, which becomes the process exit code.
return 0; // Return 0 to indicate successful execution.

namespace TestStatement
{
    public class Test
    {
        public static string StaticTest()
        {
            return "This is a call from a static method in a nested namespace.";
        }
    }
}