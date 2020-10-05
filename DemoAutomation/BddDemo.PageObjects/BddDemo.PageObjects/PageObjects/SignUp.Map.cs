using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BddDemo.PageObjects.PageObjects
{
    public partial class SignUp:BasePage
    {
        public SignUp(IWebDriver driver) : base(driver) { }
        private IWebElement CreateAccountButton => Driver.FindElement(By.Id("SubmitCreate"));
        private IWebElement EmailAdressTextBox => Driver.FindElement(By.Id("email_create"));
    }
}
