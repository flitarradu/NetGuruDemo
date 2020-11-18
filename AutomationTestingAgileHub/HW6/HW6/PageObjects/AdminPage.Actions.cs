using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6.PageObjects
{
    partial class AdminPage
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;
        public AdminPage(IWebDriver driver)
        {
            _driver = driver;

            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));

            _driverWait.IgnoreExceptionTypes();

        }

        public void ClickUsersButton()
        {
            usersButton.Click();
        }

        public void EditUSer(string name, string email, string phone)
        {
            ClickUsersButton();
            editUserButton.Click();
            userNameAdminTextBox.Clear();
            userNameAdminTextBox.SendKeys(name);
            userEmailAdminTextBox.Clear();
            userEmailAdminTextBox.SendKeys(email);
            userPhoneAdminTextBox.Clear();
            userPhoneAdminTextBox.SendKeys(phone);
            updateUserButton.Click();

        }

    }
}
