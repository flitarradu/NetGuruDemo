using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema28.PageObjects
{
    partial class Homepage
    {
         private IWebElement firstNameTextBox => _driver.FindElement(By.XPath("//input[@id='firstName']"));
        private IWebElement lastNameTextBox => _driver.FindElement(By.XPath("//input[@id='lastName']"));
        private IWebElement emailTextBox => _driver.FindElement(By.XPath("//input[@id='userEmail']"));
        private IWebElement genderRadioButton => _driver.FindElement(By.XPath("//*[@id='genterWrapper']/div[2]/div[1]/label"));
        private IWebElement mobilePhoneTextBox => _driver.FindElement(By.XPath("//input[@id='userNumber']"));
        private IWebElement dateTextBox => _driver.FindElement(By.XPath("//input[@id='dateOfBirthInput']"));
        private IWebElement subjectsTextBox => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@id='subjectsInput']")));
        //private IWebElement hobbiesCheckbox => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='hobbies-checkbox-1']")));
        private IWebElement hobbiesCheckbox =>  _driver.FindElement(By.XPath("//*[@id='hobbiesWrapper']/div[2]"));

        private IWebElement addressTextBox => _driver.FindElement(By.XPath("//*[@id='currentAddress']"));
        private IWebElement stateTextBox => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='react-select-3-input']")));
        private IWebElement cityTextBox => _driver.FindElement(By.XPath("//*[@id='react-select-4-input']"));
        private IWebElement submitButton => _driver.FindElement(By.XPath("//*[@id='submit']"));
        public IWebElement thanksForm => _driver.FindElement(By.XPath("//*[@id='example-modal-sizes-title-lg']"));
        public IWebElement dayPick => _driver.FindElement(By.XPath("//*[@id='dateOfBirth']/div[2]/div[2]/div/div/div[2]/div[2]/div[4]/div[5]"));
        

    }
}
