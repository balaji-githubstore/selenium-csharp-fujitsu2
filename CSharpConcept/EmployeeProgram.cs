using CSharpConcept;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fujitsu.CSharpConcept
{
    public class Program2
    {
        static void Main1(string[] args)
        {
           
            Employee.companyName = "Fujitsu";

            Employee emp1 = new Employee(101);
            emp1.empId = 101;
            emp1.empName = "Saul";
            emp1.EmpSalary = 5000.5;   //set

            Employee emp2 = new Employee(102, "Peter");
            emp2.empId = 102;
            emp2.empName = "Peter";
            emp2.EmpSalary = 9000;

            Employee emp3=new Employee(5000.2);
            emp3.empId = 103;
            emp3.empName = "Casey";
            emp3.EmpSalary = 2000.5;

            Employee emp4 = new Employee();



            Console.WriteLine(emp2.EmpSalary); //get

            string authorName=Employee.GetAuthorName();
            Console.WriteLine(authorName);

            //Console.WriteLine(Employee.GetAuthorName());
            //Employee.companyName = "Fujitsu ltd";
            emp2.DisplayEmployeeDetails();
            emp1.DisplayEmployeeDetails();
            emp3.DisplayEmployeeDetails();
            emp4.DisplayEmployeeDetails();

            double sal = emp1.CalculatorSalary(100);
            Console.WriteLine(sal);

            Employee emp5 = Employee.GetEmployeeInstance();
            Employee emp6 = Employee.GetEmployeeInstance();

            emp5.empName = "Ken";

            emp5.DisplayEmployeeDetails();
            emp6.DisplayEmployeeDetails ();

            string name=Employee.GetEmployeeNameWithHighSalary(emp1, emp2);
            Console.WriteLine("Employee with high salary"+name);
        }

    }


}
