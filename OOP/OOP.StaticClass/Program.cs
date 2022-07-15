// C# program to illustrate the
// concept of static class
using System;

namespace ExampleOfStaticClass
{

    // Creating static class
    // Using static keyword
    static class Author
    {

        // Static data members of Author
        public static string Name = "Gloria Ogoo";
        public static string Language = "English";
        public static int Number = 8;

        // Static method of Author
        public static void Details()
        {
            Console.WriteLine("The details of Author is:");
        }
    }

    // Driver Class
    public class Test
    {

        // Main Method
        static public void Main()
        {
            // Calling static method of Author
            Author.Details();
            Author.Name = "ddd";
            // Accessing the static data members of Author
            Console.WriteLine("Author name : {0} ", Author.Name);
            Console.WriteLine("Language : {0} ", Author.Language);
            Console.WriteLine("Total number of articles : {0} ",
                                                Author.Number);
        }
    }
}
