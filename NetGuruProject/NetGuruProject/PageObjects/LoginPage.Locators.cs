using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetGuruProject.PageObjects
{
    partial class LoginPage
    {
        private IWebElement submitButton => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/div[2]/form/div/p[2]/button"));
        private IWebElement emailTextBox => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/div[2]/form/div/div[1]/input"));
        private IWebElement passwordTextBox => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/div[2]/form/div/div[2]/span/input"));
        private IWebElement alertDuplicateEmailTextBox => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/div[1]/form/div/div[1]"));
        private IWebElement createAccountButton => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/div[1]/form/div/div[3]/button"));
    }
}
