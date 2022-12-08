using System;
namespace fuctionCall
{
    class function
    {
        static void Main(string[] args)
        {
            fun();
        }
        static void fun()
        {
            int monthlyWage1 = 1200;
            int monthlyWage2 = 2000;
            int month1 = 12;
            int month2 = 7;
            int bonus = 300;

            int yearlyWageEmployee1 = Calculate(monthlyWage1, month1, bonus); //function Calling by Value
            Console.WriteLine("YEARLY WAGE OF EMPLOYEE 1:"+yearlyWageEmployee1+"\n"); //He will get double bonus

            int yearlyWageEmployee2 = Calculate(monthlyWage2, month2, bonus);  //fuction calling by value
            Console.WriteLine("YEARLY WAGE OF EMPLOYEE 2:" + yearlyWageEmployee2+"\n"); //he will get bonus
        }

        static int Calculate(int mw,int m,int b) 
        {
            if (mw < 2000)
                b = b * 2;
            
            Console.WriteLine("The Employee got bonus:" + b);
            Console.WriteLine($"Yearly Wage = {mw}*{m}+{b}");
            return (mw * m + b);
        }
       
        }
    }
