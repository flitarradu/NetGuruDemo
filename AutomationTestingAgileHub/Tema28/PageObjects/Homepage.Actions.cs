using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tema28.PageObjects
{
    partial class Homepage
    {
        private IWebDriver _driver;
        private WebDriverWait _driverWait;
        public Homepage(IWebDriver driver)
        {
            _driver = driver;

            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(20));

            _driverWait.IgnoreExceptionTypes();
        }

        public void SearchGoogleImage(string query)
        {
            searchTextBox.SendKeys(query);
            searchTextBox.SendKeys(Keys.Return);
        }

        public void SelectGoogleImage()
        {
            imageButton.Click();
            firstImage.Click();
        }

        public void AcceptGoogleTerms()
        {
           
            acceptButton.Click();
            
        }

        public void FillDemoQAForm()
        {
            firstNameTextBox.SendKeys("Flitar");
            lastNameTextBox.SendKeys("Radu");
            emailTextBox.SendKeys("radu@gmail.com");
            genderRadioButton.Click();
            mobilePhoneTextBox.SendKeys("0744655998");
            dateTextBox.Click();
            dayPick.Click();

            subjectsTextBox.SendKeys("English");
            subjectsTextBox.SendKeys(Keys.Tab);
            //Actions actions = new Actions(_driver);
            //actions.MoveToElement(hobbiesCheckbox).Click().Perform();
            //Actions action = new Actions(_driver);
            //action.MoveToElement(hobbiesCheckbox);
            //if (hobbiesCheckbox.Displayed)
            //    action.Perform();
            var x = hobbiesCheckbox.FindElements(By.TagName("value"));
            hobbiesCheckbox.Click();
            addressTextBox.SendKeys("Sanpetru, Brasov");
            stateTextBox.SendKeys("NCR");
            stateTextBox.SendKeys(Keys.Tab);
            cityTextBox.SendKeys("Delhi");
            cityTextBox.SendKeys(Keys.Tab);
            submitButton.Click();




        }


    }
}
