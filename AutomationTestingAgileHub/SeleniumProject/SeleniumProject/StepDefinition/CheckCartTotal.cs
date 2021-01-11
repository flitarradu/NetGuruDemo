using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumProject.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;

namespace SeleniumProject.StepDefinition
{
    [Binding]
    public sealed class CheckCartTotal : Hooks
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public CheckCartTotal(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I go to dresses page")]
        public void GivenIGoToDressesPage()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.dressButton.Click();
        }

        [Given(@"I add (.*) dresses into the cart")]
        public void GivenIAddDressesIntoTheCart(int p0)
        {
            DressesPage dressPage = new DressesPage(Driver);
            dressPage.AddDressesTotCart();
        }

        [When(@"I navigate to cart")]
        public void WhenINavigateToCart()
        {
            DressesPage dressPage = new DressesPage(Driver);
            Thread.Sleep(2000);
            dressPage.proceedCheckoutButton.Click();
        }

        [Then(@"the final total should add up")]
        public void ThenTheFinalTotalShouldAddUp()
        {
            CheckoutPage checkoutPage = new CheckoutPage(Driver);
            var total = checkoutPage.GetTotal();
            var totalElementText = Driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div[2]/table/tfoot/tr[1]/td[3]")).Text.Split('$');
            Assert.AreEqual(total, Convert.ToDouble(totalElementText[1]));
        }

    }
}
