using System;

namespace Assessment3Practice

{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an object with the NEW keyword.
            Town town = new Town(); // Default constructor object

            // Accessing a NON-STATIC Method
            // object.Method(); White lettering
            var result = town.SurviveTheWinter();

            // Accessing a STATIC Method
            // Class.Method(); Blue lettering or capital letter

            Console.WriteLine(result);
        }
    }
}
