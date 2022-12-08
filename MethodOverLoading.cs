using System;
namespace Method_Over_LOADING
{
    class program
    {
        static void Main(string[] args)
        {
            
            myFunction(10, 20);
            myFunction(10.2f, 20.3f);
            myFunction("Aman", "Singh");
        }
       static void myFunction(int a, int b)=>
            Console.WriteLine("Integer Type Function Invoked\nValues are :"+ a +" "+ b);
        static void myFunction(float a, float b)=>
            Console.WriteLine("Float Type Function Invoked\nValues are :"+ a +" "+ b);
        static void myFunction(string a, string b)=>
            Console.WriteLine("String Type Function Invoked\nValues are :"+ a +" "+ b);
    }
}