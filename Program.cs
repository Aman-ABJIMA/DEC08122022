using System;
using System.Dynamic;

namespace ENUM_BASED_PROGRAM
{
    class Program
    {
        static void Main(string[] args)
        { 
           
               
                foreach (var i in Enum.GetValues(typeof(Day)))
                {
                  Console.WriteLine($"{i}= {(int)i}");
                }

            
        }
     }
        enum Day
        {
            SUNDAY=10,
            MONDAY,
            TUESDAY,
            WEDNESDAY,
            THURSDAY,
            FRIDAY,
            SATURDAY
        }
}
