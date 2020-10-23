// <see cref="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-directive"
using HelloWorld;
using System;

/// <summary>
/// This is the namespace "HelloWorld", which is used to organize classes
/// <see cref="https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/namespaces/"/>
/// </summary>
namespace Programm
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
            Parameter parameter = new Parameter();
            parameter.EinlesenDerParameter();
            parameter.LösenEinerQuadratischenGleichung();
            Console.ReadKey();
        }
        
    }
}
