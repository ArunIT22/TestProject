using System;
using TechTalk.SpecFlow;
using ClassLibrary1;
using TechTalk.SpecFlow.Assist;
using AutoFixture;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class EmployeeStepDefinitions
    {
        private EmployeeService _employee = null;
        Fixture _fixture = new Fixture();

        [Given(@"I have connected to the EmployeeService class")]
        public void GivenIHaveConnectedToTheEmployeeServiceClass()
        {
            _employee = new EmployeeService();
        }

        [When(@"I enter Id, Name and MobileNo")]
        public void WhenIEnterIdNameAndMobileNo(Table table)
        {
            var emp = _fixture.Create<Employee>();
            _employee.AddEmployee(emp);
        }

        //[Then(@"It store the employee details in the List")]
        //public void ThenItStoreTheEmployeeDetailsInTheList()
        //{
        //    throw new PendingStepException();
        //}
    }
}
