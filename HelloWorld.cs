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

- C# is very strict about types and is a statically typed language. Types indicate what form of data is stored in variables, expected from 
methods, and C# expects a lot from the programmer related to keeping types in conformity.

- With regards the `numbers` as a Type, there are whole numbers referred to as INTEGERS and there are numbers that can have
decimal points typically referred to as FLOATS. Regular FLOATS take 4 bytes and give less precision while DOUBLES take 8 bytes
and give extra precision (up to around 15-17 digit precision). FLOATS and DOUBLES are found in .NET languages.

- The `void` keyword is used for methods to indicate that said method does NOT return a value.

`float temperatureCelsius = (temperatureFahrenheit - 32) / 1.8f;`
The float `temperatureFahrenheit` can be divided by the integer `32` as C# will convert the integer to a float in this case. However,
in the case of `1.8`, C# treats it like a more precise double and cannot be divided against the float unless you program that `1.8` to be
treated as a float as opposed to a double. The regular `1.8` with decimal usage is a literal template for a double, add an `f` at the end
and the number will be treated as a float. There is also a LONG which is an integer that is very large, but is an uncommon occurrence.
DECIMAL is another integer type that is best used for money calculations.

- There are STRING types built-in to C# as well as CHAR (Unicode UTF-16 characters), and BOOL (true or false).

- Type Inference is present in C#, the `var` keyword can be used and C# can infer the type based on context in a given method or elsewhere.

*/