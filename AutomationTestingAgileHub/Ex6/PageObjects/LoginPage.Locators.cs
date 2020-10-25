using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6.PageObjects
{
    partial class LoginPage
    {
        private IWebElement emailTextBox => _driver.FindElement(By.XPath("/html/body/div/div/div[2]/form/div[1]/input"));
        private IWebElement passwordTextBox => _driver.FindElement(By.XPath("/html/body/div/div/div[2]/form/div[2]/input"));
        private IWebElement submitButton => _driver.FindElement(By.XPath("/html/body/div/div/div[2]/form/button"));


    }
}
