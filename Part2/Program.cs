/// Chapter No.2 		Exercise No. 2
/// File Name: Program.cs
/// @author: Chester Brock 
/// Date:  Sep 13, 2021
///
/// Problem Statement:  Write a program that converts degrees Fahrenheit to Celsius
/// 
/// 
/// Overall Plan:
/// 1) using formula degreesC = 5(degreesF – 32)/9, convert farhrenheit  to celsius
/// 2) Prompt the user to enter a temperature in degrees Fahrenheit 
/// 3) let the program print out the equivalent Celsius temperature
/// 4) fractional part to one decimal point
///

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            double fahren, celsius;

            // prompt user to enter fahrenheit
            Console.WriteLine("Enter a temperature in degrees Fahrenheit (just a whole number of degrees without a fractional part): ");
            // Read in the users number 
            fahren = Int32.Parse(Console.ReadLine());

            // creating the conversion 
            celsius = 5 * (fahren - 32) / 9;

            // display to only one decimal 
            Console.WriteLine(fahren + " degrees Fahrenheit = " + Math.Round(celsius, 1) + " degrees Celsius");

            // for pausing the screen 
            Console.ReadLine();
        }
    }
}
