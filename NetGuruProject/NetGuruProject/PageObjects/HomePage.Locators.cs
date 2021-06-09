using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetGuruProject.PageObjects
{
    partial class HomePage
    {
        private IWebElement signInButton => _driver.FindElement(By.XPath("/html/body/div/div[1]/header/div[2]/div/div/nav/div[1]/a"));
        public IWebElement registerButton => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/div[1]/form/div/div[3]/button"));
        private IWebElement loginButton => _driver.FindElement(By.XPath("/html/body/nav/div/div[2]/ul/li[2]/ul/li[2]/a"));
        public IWebElement homeButton => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[1]/a[1]"));
        public IWebElement emailAddressTextBox => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/div[1]/form/div/div[2]/input"));

    }
}
