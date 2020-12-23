using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject.PageObjects
{
    partial class RegisterPage
    {
        private IWebElement maleGenderRadio => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[1]/div[1]/div[1]/label/div/span/input"));
        private IWebElement firstNameTextBox => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[1]/div[2]/input"));
        private IWebElement LastNameTextBox => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[1]/div[3]/input"));
        private IWebElement passwordTextBox => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[1]/div[5]/input"));
        private IWebElement daysDropdown => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[1]/div[6]/div/div[1]/div/select"));
        private IWebElement day1DropdownOption => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[1]/div[6]/div/div[1]/div/select/option[2]"));
        private IWebElement monthsDropdown => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[1]/div[6]/div/div[2]/div/select"));
        private IWebElement firstMonthDropdownOption => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[1]/div[6]/div/div[2]/div/select/option[2]"));
        private IWebElement yearsDropdown => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[1]/div[6]/div/div[3]/div/select"));
        private IWebElement YearDropdownOption => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[1]/div[6]/div/div[3]/div/select/option[32]"));
        private IWebElement addressFirstNameTextBox => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[2]/p[1]/input"));
        private IWebElement addressLastNameTextBox => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[2]/p[2]/input"));
        private IWebElement addressTextBox => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[2]/p[4]/input"));
        private IWebElement cityTextBox => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[2]/p[6]/input"));
        private IWebElement stateDropdown => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[2]/p[7]/div/select"));
        private IWebElement stateDropdownOption => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[2]/p[7]/div/select/option[2]"));
        private IWebElement zipCodeTextBox => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[2]/p[8]/input"));
        private IWebElement phoneTextBox => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/form/div[2]/p[13]/input"));
        public IWebElement submitButton => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/div[1]/form/div/div[3]/button"));


    }
}
