using System;
namespace Structure
{
    class Program
    {
        struct Employee
        {
            public int id;
            public string name;

            public void function1(int id)
            {
                Console.WriteLine("Employee Id:" + id);
            }
            public void function2(string name)
            {
                Console.WriteLine("Employee NAME:" + name);
            }
        }
        static void Main(string[] args)
        {


            Employee emp;

            Console.WriteLine("Enter Employee ID:");

            emp.id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employee Name:");

            emp.name = Console.ReadLine();


            emp.function1(emp.id);
            emp.function2(emp.name);

        }


    

   
    }
}