using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    public class Employee
    {
        public int empId; //non-static variable or instance variable 
        public string empName;
        private double _empSalary;
        public static string companyName;  //static variable or class variable 

        public Employee()
        {
            Console.WriteLine("Launch browser!!");
            empId = 3001;
        }

        public Employee(int empId)
        {
            Console.WriteLine("Launch browser!!");
            this.empId = empId;
        }

        public Employee(double empSal)
        {
            
        }

        public Employee(int empId,string empName)
        {
            Console.WriteLine("Launch browser!!");
            this.empId = empId;
            this.empName = empName;
        }

        public Employee(string empName,int empId)
        {
            Console.WriteLine("Launch browser!!");
            this.empId = empId;
            this.empName = empName;
        }

        public double EmpSalary
        {
            get
            {
                return _empSalary;
            }
            set
            {
                if (value >= 5000)
                {
                    _empSalary = value;
                }
                else
                {
                    Console.WriteLine("Invalid Salary! Default value 0 will remain!!");
                }
            }
        }

        public static string GetAuthorName()
        {
            string name = "Balaji Dinakaran";
            return name;
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee Id: " + empId);
            Console.WriteLine("Employee Name: " + empName);
            Console.WriteLine("Employee Salary: " + _empSalary);
            Console.WriteLine("Company Name: " + Employee.companyName);
            Console.WriteLine("------------------------------");
        }

        public double CalculatorSalary(int durationInHours)
        {
            double salary = 1000 * durationInHours;
            return salary;
        }

        public static Employee GetEmployeeInstance()
        {
            Employee emp = new Employee();
            return emp;
        }

        public static string GetEmployeeNameWithHighSalary(Employee e1,Employee e2)
        {
            if(e1.EmpSalary>e2.EmpSalary)
            {
                return e1.empName;
            }
            else
            {
                return e2.empName;
            }
        }

    }
}
