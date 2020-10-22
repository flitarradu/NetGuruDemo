using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema28
{
    public class Hooks
    {
        protected IWebDriver Driver;
        [SetUp]
        public void Setup()
        {            
            Driver = new ChromeDriver();
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
