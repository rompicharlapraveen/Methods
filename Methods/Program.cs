using System;

namespace Methods
{
    class Program
    {
        static void Mymethod(string fname,int age)
        {
            Console.WriteLine(fname+ "\t" + age);
        }
        static void Main(string[] args)
        {
            // single time method
            // Mymethod();

            // Multiple times methods

            /*  Mymethod();
             Mymethod();
             Mymethod(); */

            // Passing Parameters in a method

            /* Mymethod("Praveen");
            Mymethod("Srinu");
            Mymethod("Savitri"); */

            // Default parameter

            Mymethod("liam",5);
            Mymethod("RR",6);

        }
    }
}
