using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace BddDemo.PageObjects.PageObjects
{
    public partial class HomePage:BasePage
    {
        public HomePage(IWebDriver driver) : base(driver){}
        private string HomePageUrl=>"index";

       // public override string Url => "index.php";
        private IWebElement SignInButton => Driver.FindElement(By.ClassName("login"));
        private IWebElement CreateAccountButton => Driver.FindElement(By.Id("SubmitCreate"));
        private IWebElement EmailAdressTextBox => Driver.FindElement(By.Id("email_create"));
    }
}
