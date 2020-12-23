using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumProject.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SeleniumProject.StepDefinition
{
    [Binding]
    public sealed class BuyShortSleeveTShirt : Hooks
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public BuyShortSleeveTShirt(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I am logged in with existing user")]
        public void GivenIAmLoggedInWithExistingUser(Table table)
        {

            HomePage homePage = new HomePage(Driver);
            homePage.Authenticate();
            var user = table.CreateInstance<UserDto>();
            LoginPage myLoginPage = new LoginPage(Driver);
            myLoginPage.EnterCredentials(user);
        }

        [When(@"I add the T-shirt to cart")]
        public void WhenIAddTheT_ShirtToCart()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.AddTshirtToCart();

        }

        [When(@"I access the cart to proceed to checkout")]
        public void WhenIAccessTheCartToProceedToCheckout()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.proceedCheckoutButton.Click();
        }

        [When(@"I finish the checkout steps")]
        public void WhenIFinishTheCheckoutSteps()
        {
            CheckoutPage checkoutPage = new CheckoutPage(Driver);
            checkoutPage.ProceedCheckout();
        }

        [Then(@"My order is completed")]
        public void ThenMyOrderIsCompleted()
        { 
            Assert.IsTrue(Driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/p/strong")).Text == "Your order on My Store is complete.");
 
        }

    }
}
