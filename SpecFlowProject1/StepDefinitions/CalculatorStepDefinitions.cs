using ClassLibrary1;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class CalculatorStepDefinitions
    {
        int num1, num2, result;
        Calculator obj = new Calculator();
        [Given(@"the first number is (.*)")]
        public void GivenTheFirstNumberIs(int p0)
        {            
            num1 = p0;
        }

        [Given(@"the second number is (.*)")]
        public void GivenTheSecondNumberIs(int p0)
        {
            num2 = p0;
        }

        [When(@"the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            result = obj.Add(num1, num2);
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            Assert.AreEqual(p0, result);
        }
    }
}
