using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_Section02_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //define few variables
            int age = 31;
            string name = "Alfonso";
            string job = "Developer";


            // 1. string concatenation
            Console.WriteLine("String Concatenation");
            Console.WriteLine("Hello my name is " + name + " , I am " + age + " years old");

            // 2. String formatting.
            // string formatting uses index
            Console.WriteLine("String Formatting");
            Console.WriteLine("Hello my name is {0} . I am {1} years old. I'm a {2}", name, age, job);

            // 3. String interpolation
            // string Interpolation uses $ at the start which will allow us to write our
            // variables like this {variableName}
            Console.WriteLine("String Interpolation");
            Console.WriteLine($"Hello my name is {name}, I am {age} years old");

            // 4. Verbatim strings.
            // verbatim strings start with @ and tells the compiler to take the string
            // literally and ignore any spaces and escape characters like \n
            Console.WriteLine("Verbatim strings");
            Console.WriteLine(@"Lorem ipsum dolor sit amet,
           Lorem Ipsum is simply dummy text of the printing and typesetting
            industry. Lorem Ipsum has been the industry's standard dummy
            text ever since the 1500s, when an unknown printer took a galley
            of type and scrambled it to make a type specimen book.
            It has survived not only five centuries, but also the leap into
            electronic typesetting, remaining essentially unchanged.


            It was popularised in the 1960s with the release of Letraset
            sheets containing Lorem Ipsum passages, and more recently with
            desktop publishing software like Aldus PageMaker including
            versions of Lorem Ipsum.");

            //instead of using \\ to write file paths we can use verbatim strings to make it easier
            //if you remove the @ you will get an error because \U, \A and \D are not valid escape characters.
            Console.WriteLine(@"C:\Users\jackk\Desktop\SAIT\INTP-362 Emerging\2. Blog Post1 laptop.jpg");


            //with verbatim strings even valid escape characters won't work
            Console.WriteLine(@"Muahaha \n you have no powers here!.");
            Console.WriteLine("Muahaha \n you have powers here!.");

            Console.Read();

        }
    }
}
