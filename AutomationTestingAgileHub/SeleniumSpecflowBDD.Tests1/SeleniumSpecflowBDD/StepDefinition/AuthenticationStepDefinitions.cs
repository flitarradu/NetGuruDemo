using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumSpecflowBDD.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SeleniumSpecflowBDD.StepDefinition
{
    [Binding]
    public sealed class AuthenticationStepDefinitions : Hooks
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public AuthenticationStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I login with valid user")]
        public void GivenILoginWithValidUser()
        {
            HomePage myHomePage = new HomePage(Driver);            myHomePage.Authenticate();            LoginPage myLoginPage = new LoginPage(Driver);            myLoginPage.EnterCredentials("admin.test3@gmail.com", "password123");            Assert.IsTrue(Driver.FindElement(By.XPath("//a[text()='Deconectare']")).Displayed);

        }

    }
}
