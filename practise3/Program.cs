using System;

namespace practise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Fatima", 21, 5000);
            Employee emp1 = new Employee("Fateima", 21, 5000);
            Employee emp2 = new Employee("Fatima", 21, 5000);
            Employee emp3 = new Employee("Fatrima", 21, 5000);
            Employee emp4 = new Employee("Fatdddima", 21, 5000);
            Employee emp5 = new Employee("Fatsssima", 21, 5000);
            Department department = new Department("department",1);
            department.AddEmployee(emp);
            //department.AddEmployee(emp1);
            //department.AddEmployee(emp2);
            //department.AddEmployee(emp2);
            //department.AddEmployee(emp3);
            //department.AddEmployee(emp4);
            //department.AddEmployee(emp5);
            foreach (var item in department.Employees)
            {
                Console.WriteLine(item.Name);
            }
            Console.WriteLine(department[0]);
        }
    }
}
