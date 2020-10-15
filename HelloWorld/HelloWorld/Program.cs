// <see cref="https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/using-directive"
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
            Mensch person1 = new Mensch();
            // Console is a class in the namespace "System" and has the method called "WriteLine"
            Console.WriteLine("Bitte gib deinen Namen ein:");
            person1.Name = Console.ReadLine();

            Console.WriteLine("Bitte gib dein Gewicht in [kg] ein:");
            double.TryParse(Console.ReadLine(), out double gewicht);

            Console.WriteLine("Bitte gib deine Groesse in [cm] ein:");
            double.TryParse(Console.ReadLine(), out double groesse);

            person1.Gewicht = gewicht;
            person1.Groesse = groesse;

            Console.WriteLine("Hallo " + person1.Name.ToString() + " dein BMI ist: " + person1.bmiBerechnen().ToString());

        }
    }
}
