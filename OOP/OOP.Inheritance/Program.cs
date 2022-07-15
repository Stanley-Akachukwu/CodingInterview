
using System;
namespace program
{
    class InheritedClass
    {
        public string name;
        public void print(string name)
        {
            this.name = name;
            Console.WriteLine("My name is: " + name);

        }
    }
    class child : InheritedClass
    {
        public child()
        {
            Console.WriteLine("child class executing ...");
        }
    }
    class test
    {
        static void Main(string[] args)
        {
            child c = new child();
            c.print("Nedum");

        }
    }
}
