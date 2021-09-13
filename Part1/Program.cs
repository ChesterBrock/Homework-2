/// Chapter No. 2		Exercise No. 1
/// File Name: Part1.java
/// @author: Chester Brock 
/// Date:  Sep 12, 2021
///
/// Problem Statement:  create a new string that contains your full name in pig latin 
/// with the first letter capitalized for the first and last name. 
/// 
/// 
/// Overall Plan:
/// 1) string variable first set to your first name
/// 2) string variable last set to your last name
/// 3) Make sure its all lowercase
/// 4) move the first letter to the back of the first and last name. 
/// 5) add "ay" at the back of the first and last name 
/// 6) Print the results. 
///

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = "chester";
            string second = "brock";
            string ending = "ay";

            first = (first.Substring(1).ToUpper() + first[0] + ending);
            // making all letters after first lowercase. 
            first = (first.Substring(0).ToLower());

            // Last name 
            second = (second.Substring(1).ToUpper() + second[0] + ending);
            second = (second.Substring(0).ToLower());


            Console.WriteLine(first + " " + second); // the pig latin sentence.
            // To pause the program
            Console.ReadLine();
        }
    }
}
