using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetGuruProject.PageObjects
{
    partial class RegisterPage
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;
        public RegisterPage(IWebDriver driver)
        {
            _driver = driver;

            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));

            _driverWait.IgnoreExceptionTypes();

        }

        public void EnterRegistrationCredentials(UserDto user)
        {
            System.Threading.Thread.Sleep(5000);
            maleGenderRadio.Click();
            firstNameTextBox.Click();
            firstNameTextBox.SendKeys(user.userFirstName);
            LastNameTextBox.SendKeys(user.userLastName);
            passwordTextBox.Click();
            passwordTextBox.SendKeys(user.userPassword);
            daysDropdown.Click();
            day1DropdownOption.Click();
            monthsDropdown.Click();
            firstMonthDropdownOption.Click();
            yearsDropdown.Click();
            YearDropdownOption.Click();
            addressFirstNameTextBox.Click();
            addressFirstNameTextBox.SendKeys(user.userAddressFirstName);
            addressLastNameTextBox.SendKeys(user.userAddressLastName);
            addressTextBox.Click();
            addressTextBox.SendKeys(user.userAddress);
            cityTextBox.Click();
            cityTextBox.SendKeys(user.userCity);
            stateDropdown.Click();
            stateDropdownOption.Click();
            zipCodeTextBox.Click();
            zipCodeTextBox.SendKeys(user.userPostalCode);
            phoneTextBox.Click();
            phoneTextBox.SendKeys(user.userPhone);

        }
    }
}
