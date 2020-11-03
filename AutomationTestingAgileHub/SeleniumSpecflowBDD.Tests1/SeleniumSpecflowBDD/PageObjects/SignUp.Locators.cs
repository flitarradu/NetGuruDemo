using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumSpecflowBDD.PageObjects
{
    partial class SignUp
    {
        private IWebElement signUpEmailTextBox => _driver.FindElement(By.XPath("/html/body/div/div/div[2]/form/div[2]/input"));
        private IWebElement signUpNameTextBox => _driver.FindElement(By.XPath("/html/body/div/div/div[2]/form/div[1]/input"));
        private IWebElement signUpPhoneTextBox => _driver.FindElement(By.XPath("/html/body/div/div/div[2]/form/div[3]/input"));
        private IWebElement signUpAddressTextBox => _driver.FindElement(By.XPath("/html/body/div/div/div[2]/form/div[4]/textarea"));
        private IWebElement signUpPasswordRepeatTextBox => _driver.FindElement(By.XPath("/html/body/div/div/div[2]/form/div[6]/input"));
        private IWebElement signUpButton => _driver.FindElement(By.XPath("//*[@id='collapsibleNavbar']/ul[2]/li[2]/a"));
        private IWebElement signUpInscriereButton => _driver.FindElement(By.XPath("/html/body/div/div/div[2]/form/button"));
        private IWebElement signUpPasswordextBox => _driver.FindElement(By.XPath("/html/body/div/div/div[2]/form/div[5]/input"));

    }
}
