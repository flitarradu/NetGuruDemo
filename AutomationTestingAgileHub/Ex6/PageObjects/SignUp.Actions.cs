using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumSpecflowBDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6.PageObjects
{
    partial class SignUp
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;
        public SignUp(IWebDriver driver)
        {
            _driver = driver;

            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));

            _driverWait.IgnoreExceptionTypes();

        }

        public void EnterSignup()
        {
            signUpButton.Click();
        }

        public void SigUpFormFill(UserDto user)
        {
            signUpNameTextBox.SendKeys(user.userName);
            signUpEmailTextBox.SendKeys(user.userEmail);
            signUpPhoneTextBox.SendKeys(user.userPhone);
            signUpAddressTextBox.SendKeys(user.userAddress);
            signUpPasswordextBox.SendKeys(user.userPassword);
            signUpPasswordRepeatTextBox.SendKeys(user.userPasswordRepeat);
            
        }

        public void AuthenticateNewUser(UserDto user)
        {
            userEmailTextBox.SendKeys(user.userEmail);
            userPasswordTextBox.SendKeys(user.userPassword);
            userAAuthenticateButton.Click();
        }
    }
}
