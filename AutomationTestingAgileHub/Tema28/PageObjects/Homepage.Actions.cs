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

            _driverWait = new WebDriverWait(_driver, TimeSpan.FromSeconds(30));

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
            addressTextBox.SendKeys("Sanpetru, Brasov");
            var x = hobbiesCheckbox.FindElements(By.TagName("label"));

            x.Where(i => i.Text.Equals("Sports")).FirstOrDefault().Click();
            stateTextBox.SendKeys("NCR");
            stateTextBox.SendKeys(Keys.Tab);
            cityTextBox.SendKeys("Delhi");
            cityTextBox.SendKeys(Keys.Tab);
            submitButton.Click();

            Thread.Sleep(400);


        }

        public void DemoQATextBox()
        {
            
            nameTBTextBox.SendKeys("Flitar Radu");
            emailTBTextBox.SendKeys("flitar.radu@gmail.com");
            addressTBTextBox.SendKeys("Fagaras");
            permanentAddressTBTextBox.SendKeys("Sanpetru");
            ((IJavaScriptExecutor)_driver).ExecuteScript("window.scrollTo(0, 300)"); 
            submitFormButton.Click();
        }

        public void TheatreShow()
        {
            teamButton.Click();
            ((IJavaScriptExecutor)_driver).ExecuteScript("window.scrollTo(0, 500)"); 
            actorButton.Click();
            ((IJavaScriptExecutor)_driver).ExecuteScript("window.scrollTo(0, 600)"); 
            showButton.Click();
        }


    }
}
