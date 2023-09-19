using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class NewProductStepDefinitions
    {
        [When(@"I filled all the mandatory fields")]
        public void WhenIFilledAllTheMandatoryFields(Table table)
        {
            ////var productObj = table.CreateInstance<Product>();//Single Object
            //var productList = table.CreateSet<Product>();
            //foreach (var product in productList)
            //{
            //    Console.WriteLine(product.ProductName);
            //    Console.WriteLine(product.UnitPrice);
            //    Console.WriteLine(product.UnitsInStock);
            //}

            //Above works using the Product class, we can create the class dynamically using Specflow.Assist.Dynamic
            var productList = table.CreateDynamicSet();
            foreach (var product in productList)
            {
                Console.WriteLine("Using DynamicSet");
                Console.WriteLine(product.ProductName);
                Console.WriteLine(product.UnitPrice);
                Console.WriteLine(product.UnitsInStock);
            }
        }

        //Scenario Outline Example

        [When(@"I filled all the mandatory fields (.*), (.*) and (.*)")]
        public void WhenIFilledAllTheMandatoryFields(string productName, decimal unitPrice, int unitsInStock)
        {            
            Console.WriteLine(productName);
            Console.WriteLine(unitPrice);
            Console.WriteLine(unitsInStock);            
        }

    }
}
