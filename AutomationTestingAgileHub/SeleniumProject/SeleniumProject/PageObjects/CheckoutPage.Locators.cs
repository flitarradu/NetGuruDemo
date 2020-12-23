using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject.PageObjects
{
    partial class CheckoutPage
    {
        private IWebElement proceedCheckoutButton => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/p[2]/a[1]"));
        private IWebElement addressProceedCheckoutButton => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/form/p/button"));
        private IWebElement shippingProceedCheckoutButton => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/p/button"));
        private IWebElement payBankWireButton => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/div[3]/div[1]/div/p/a"));
        private IWebElement confirmOrderButton => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/form/p/button"));
        private IWebElement orderCompleteText => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/p/strong")); //Your order on My Store is complete.
        private IWebElement agreeTermsButton => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div/p[2]/div/span/input"));
        private IWebElement termsOfServicePopup => _driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div/p"));




    }
}
