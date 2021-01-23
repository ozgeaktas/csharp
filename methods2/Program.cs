using System;

namespace methods2
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();
           var result= Add2(20);
            Console.WriteLine(result);

            int number1 = 20;
            int number2 = 100;
            var result2 = Add3(ref number1, number2);
            Console.WriteLine(result2);//sonuç 130 olacak.
            Console.WriteLine(number1);//20 göstericek.
            Console.WriteLine(Multiply(2, 3));
            Console.WriteLine(Add4(2, 3, 4, 5, 6, 7));


        }
        static void Add()
        {
            Console.WriteLine("Added!");
        }
        static int Add2(int number1, int number2=30)
        {
          var result = number1 + number2;
          return result;
        }
        static int Add3(ref int number1,int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
        static int Multiply(int number1,int number2)
        {

            return number1 * number2;
        }

        static int Multiply(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        static int Add4(int number1, int number2)
        {
            return number1 + number2;
        }
        static int Add4(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
