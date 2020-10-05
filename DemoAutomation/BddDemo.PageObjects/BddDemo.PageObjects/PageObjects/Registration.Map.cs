using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BddDemo.PageObjects.PageObjects
{
    public partial class Registration:BasePage
    {
        public Registration(IWebDriver driver) : base(driver) 
        { 
        
        }

        private IWebElement FirstNameTextBox => Driver.FindElement(By.Id("customer_firstname"));
        private IWebElement LastNameTextBox => Driver.FindElement(By.Id("customer_lastname"));
        private IWebElement PasswordTextBox => Driver.FindElement(By.Id("passwd"));
        private SelectElement DayDobDropdown => new SelectElement( Driver.FindElement(By.Id("days")));
        private SelectElement MonthDobDropdown => new SelectElement( Driver.FindElement(By.Id("months")));
        private SelectElement YearDobDropdown => new SelectElement( Driver.FindElement(By.Id("years")));
        private IWebElement ZipCodeTextBox => Driver.FindElement(By.Id("postcode"));
        private IWebElement MobilePhoneTextBox => Driver.FindElement(By.Id("phone_mobile"));
        private IWebElement AliasAddressTextBox => Driver.FindElement(By.Id("alias"));
        private IWebElement CityTextBox => Driver.FindElement(By.Id("city"));
        private IWebElement AddressTextBox => Driver.FindElement(By.Id("address1"));
        private SelectElement StateDropdown => new SelectElement(Driver.FindElement(By.Id("id_state")));
        private SelectElement CountryDropdown => new SelectElement(Driver.FindElement(By.Id("id_country")));
        private IWebElement RegisterButton => Driver.FindElement(By.Id("submitAccount"));


    }
}
