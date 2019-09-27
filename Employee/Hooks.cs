using System;
using TechTalk.SpecFlow;

namespace EmployeeProject
{
    [Binding]
    public sealed class Hooks
    {

        [BeforeScenario]
        public void BeforeScenario()
        {
            Console.WriteLine("Before scenario");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("After scenario:");
        }
    }
}
