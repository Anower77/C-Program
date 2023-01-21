using System;
namespace swappin_number
{
    class swapping_number
    {
        public static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("swapping a :" + a);//swapping : 10
            Console.WriteLine("swapping b :" + b);//swapping : 5
        }
    }
}