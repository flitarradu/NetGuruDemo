using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW6.PageObjects
{
    partial class AdminPage
    {

        public IWebElement addProductButton => _driver.FindElement(By.XPath("/html/body/div/div/div/a[2]"));
        private IWebElement usersButton => _driver.FindElement(By.XPath("//*[@id='collapsibleNavbar']/ul[1]/li[4]/a"));

        private IWebElement editUserButton=> _driver.FindElement(By.XPath("/html/body/div/div/div/table/tbody/tr[4]/td[8]/a[1]"));

        public IWebElement userNameAdminTextBox => _driver.FindElement(By.XPath("/html/body/div/form/div/div[1]/div[1]/input"));
        public IWebElement userEmailAdminTextBox => _driver.FindElement(By.XPath("/html/body/div/form/div/div[1]/div[2]/input"));
        public IWebElement userPhoneAdminTextBox => _driver.FindElement(By.XPath("/html/body/div/form/div/div[1]/div[3]/input"));

        private IWebElement updateUserButton => _driver.FindElement(By.XPath("/html/body/div/form/div/div[1]/button"));








    }
}
