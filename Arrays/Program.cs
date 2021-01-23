using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];

            string[] students2 = new[] { "Engin", "derin", "salih" };



            foreach(var student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
