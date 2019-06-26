//using System;


// Namespace
// Namespaces declare the scope that contains a set of related objects  
// You can define and use your own name spaces in a program
// "using" states that the program is using a specific namespace

namespace NameSpaces_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            // if namespace is not defined with the "using" keyword
            // it can still be accessed explicitely

            System.Console.WriteLine("Hello World!");
            System.Console.ReadKey();

        }
    }
}
