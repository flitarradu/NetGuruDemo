using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tema28.TestData;

namespace Tema28
{
    public class Hooks
    {
        protected IWebDriver Driver;
        protected MyTestData TestObject;

        [SetUp]
        public void Setup()
        {            
            Driver = new ChromeDriver();
            TestObject = MyTestData.LoadTestDataFromFile()
                .First(obj => obj.TestCaseName == TestContext.CurrentContext.Test.MethodName);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Quit();
        }
    }
}
