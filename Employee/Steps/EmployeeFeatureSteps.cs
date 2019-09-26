using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Employee.StepArgumentTransformation;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using  NUnit.Framework;
using Employee.Model;

namespace Employee.Steps
{
    [Binding]
    class EmployeeFeatureSteps
    {
        private List<Model.Employee> allEmployees = new List<Model.Employee>();
        private ScenarioContext sc;
        private EmployeeStepSrgumentTransformation empStepArg = new EmployeeStepSrgumentTransformation();
        //public Model.Employee objEmp = new Model.Employee();
        private static bool isStepExecuted = false;

        [Given(@"insert employee details")]
        public void GivenInsertEmployeeDetails(List<Model.Employee> emps)
        {
            if (isStepExecuted)
            {
                return;
            }

            allEmployees = emps;
            ScenarioContext.Current.Set(true, "isStepExecuted");
            isStepExecuted = ScenarioContext.Current.Get<bool>("isStepExecuted");
        }

        [When(@"I try to find with ID '(.*)'")]
        public void WhenITryToFindWithID(Model.Employee emp)
        {
            ScenarioContext.Current.Set(emp, "empFound");
        }

        [Then(@"the employee details should be displayed")]
        public void ThenTheEmployeeDetailsShouldBeDisplayed()
        {
            var emp = ScenarioContext.Current.Get<Model.Employee>("empFound");
            Console.WriteLine("Found employee details are:\n");
            Console.WriteLine("Employee id: {0}\nEmployee name: {1}\nEmployee phone number: {2}\nEmployee department: {3}", emp.Id, emp.Name, emp.PhoneNo, emp.Dept);
        }


    }
}
