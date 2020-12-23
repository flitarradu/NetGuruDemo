using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumProject.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SeleniumProject.StepDefinition
{
    public class TermsOfServicePopupShown : Hooks
    {
        [Given(@"I am logged in with following user")]
        public void GivenIAmLoggedInWithFollowingUser(Table table)
        {
            HomePage homePage = new HomePage(Driver);
            homePage.Authenticate();
            var user = table.CreateInstance<UserDto>();
            LoginPage myLoginPage = new LoginPage(Driver);
            myLoginPage.EnterCredentials(user);
        }

        [Given(@"I add a product into cart")]
        public void GivenIAddAProductIntoCart()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.AddTshirtToCart();
            Thread.Sleep(2000);
            homePage.proceedCheckoutButton.Click();
        }

        [When(@"I complete the checkout process")]
        public void WhenICompleteTheCheckoutProcess()
        {
            CheckoutPage checkoutPage = new CheckoutPage(Driver);
            checkoutPage.TermsOfServiceCheckout();
        }

        [Then(@"I am shown a popup if terms of service is not checked")]
        public void ThenIAmShownAPopupIfTermsOfServiceIsNotChecked()
        {
            Assert.IsTrue(Driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div/p")).Displayed);
        }

    }
}
