using System.Collections.Generic;
using System.Net.Configuration;
using Employee.Model;

namespace EmployeeProject
{
    public class EmployeeDetails
    {
        private Employee.Model.Employee objEmp;
        private static List<Employee.Model.Employee> employees;
        public Employee.Model.Employee Demo(int id)
        {
            foreach (var emp in employees)
            {
                if (emp.Id == id.ToString())
                {
                    objEmp = emp;
                    break;
                }
            }
            return objEmp;
        }

    }
}
