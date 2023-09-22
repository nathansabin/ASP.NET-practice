using System;

namespace tester 
{
    class tester 
    {
        static void Main() 
        {
            int numOne = GetNum();
            int numTwo = GetNum();
            Console.WriteLine(Add(numOne, numTwo));
        }
        static int Add(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }
        static int GetNum()
        {
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }
    }
}