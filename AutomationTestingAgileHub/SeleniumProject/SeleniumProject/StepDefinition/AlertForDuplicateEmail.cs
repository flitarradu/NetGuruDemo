using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumProject.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SeleniumProject.StepDefinition
{
    [Binding]
    public sealed class AlertForDuplicateEmail : Hooks
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public AlertForDuplicateEmail(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I enter the login page")]
        public void GivenIEnterTheLoginPage()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.Authenticate();
        }

        [Given(@"I enter an used email address")]
        public void GivenIEnterAnUsedEmailAddress(Table table)
        {
            var user = table.CreateInstance<UserDto>();
            HomePage homePage = new HomePage(Driver);
            homePage.emailAddressTextBox.Click();
            homePage.emailAddressTextBox.SendKeys(user.userEmail);
        }


        [Then(@"I see an alert")]
        public void ThenISeeAnAlert()
        {
            Thread.Sleep(2000);
            Assert.IsTrue(Driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/div[1]/form/div/div[1]")).Displayed);
        }

    }
}
