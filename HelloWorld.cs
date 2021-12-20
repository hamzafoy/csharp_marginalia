using System;

namespace FirstProgramStudyingCSharp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        static float InchToFoot(float measurementInch)
        {
            float measurementFoot = (measurementInch / 12);
            return measurementFoot;
        }
         static float FahrenheitToCelsius(float temperatureFahrenheit)
        {
            float temperatureCelsius = (temperatureFahrenheit - 32) / 1.8f;
            return temperatureCelsius;
        }
    }
}

//Study of some Basic C# Syntax from a Basic 'Hello World' Program

/*

- PascalCase (also called CamelCase) is the convention used for naming. Words without spaces between each other
and every word's first letter capitalized. Bear in mind that variableNames and argumentParameterNames are going
to have their first word's first letter lowercased (also called lowerCamelCase).

- The curly braces that encapsulate the body of a function is also put in the next line, which is a different
convention from languages such as JavaScript.

- Statements are terminated with a semicolon.

- C# has `static methods`, similar to `functions` which are found in JavaScript. A `static method` is declared with
the `static` keyword and must be wrapped in a `class`. `Classes` in C# can contain multiple methods, each method relates
to that declared `class` in some way.

*/