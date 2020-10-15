// <see cref="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-directive"
using System;

/// <summary>
/// This is the namespace "HelloWorld", which is used to organize classes
/// <see cref="https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/namespaces/"/>
/// </summary>
namespace HelloWorld
{
    /// <summary>
    /// C# is an object-oriented programming language.
    /// As a result, everything is associated with classes.
    /// <see cref="https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/classes"/>
    /// 
    /// Here we have a class called "Program" with the method called "Main"
    /// </summary>
    class Program
    {

        /// <summary>
        /// Main entry point of the application
        /// </summary>
        /// <param name="args">Optional command arguments</param>
        static void Main(string[] args)
        {
            // Console is a class in the namespace "System" and has the method called "WriteLine"
            Console.WriteLine("Hello World!");
            Console.WriteLine("Test");
        }
    }
}
