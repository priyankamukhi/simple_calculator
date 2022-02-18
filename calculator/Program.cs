using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            Console.WriteLine("enter first input");
            int num1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second input");
            int num2 = Convert.ToInt32(Console.ReadLine());
            result = num1 + num2;
            Console.WriteLine("the result is {0}",result);
            result = num1 - num2;
            Console.WriteLine("the result is {0}", result);
            result = num1 / num2;
            Console.WriteLine("the result is {0}", result);
            result = num1 num2;
            Console.WriteLine("the result is {0}", result);


        }
        
    }
}
