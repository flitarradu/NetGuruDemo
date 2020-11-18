using HW6.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumSpecflowBDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using HW6;

namespace HW6.StepDefinition
{
    [Binding]
    public sealed class AddToCartUser : Hooks
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public AddToCartUser(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I login with user")]
        public void GivenILoginWithUser(Table table)
        {
            HomePage homePage = new HomePage(Driver);
            homePage.Authenticate();
            var user = table.CreateInstance<UserDto>();
            LoginPage myLoginPage = new LoginPage(Driver);
            myLoginPage.EnterCredentials(user);
        }

        [When(@"I add a product in the cart")]
        public void WhenIAddAProductInTheCart()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.AddToCart(Driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div/div/div/div/a")));
        }

        [Then(@"I can see the product in the cart")]
        public void ThenICanSeeTheProductInTheCart()
        {
            Assert.IsTrue(Driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/table/tbody/tr[1]/td[2]")).Text == "Laptop ASUS X509FJ");
        }

    }
}
