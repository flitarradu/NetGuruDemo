using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestProject
{
    public class Hooks
    {
        protected IWebDriver Driver; 
        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
                        // setam driverul sa stea cate o secunda pentru fiecere element unde e folosit
            //Driver.Manage().Timeouts().ImplicitWait = TimeSpan
            //.FromSeconds(2);
            Driver.Manage().Window.Maximize();


            Driver.Navigate().GoToUrl("http://demosite.casqad.org/");
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
