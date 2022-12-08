using System;
namespace FatArrow
{
    class A
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Result:" + fun(30, 40));
        }
        static float fun(int x, int y) =>  x + y ;
    }
}