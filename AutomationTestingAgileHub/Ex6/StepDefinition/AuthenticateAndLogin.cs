using Ex6.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumSpecflowBDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Tema28;

namespace Ex6.StepDefinition
{
    [Binding]
    public sealed class AuthenticateAndLogin : Hooks
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public AuthenticateAndLogin(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I navigate to my authentication page")]
        public void GivenINavigateToMyAuthenticationPage()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.Authenticate();
        }

        [When(@"I login with following credentials")]
        public void WhenILoginWithFollowingCredentials(Table table)
        {
            var user = table.CreateInstance<UserDto>();
            LoginPage myLoginPage = new LoginPage(Driver);
            myLoginPage.EnterCredentials(user);
        }

        [Then(@"I am logged in")]
        public void ThenIAmLoggedIn()
        {
            Assert.IsTrue(Driver.FindElement(By.XPath("//a[text()='Deconectare']")).Displayed);
        }


    }
}
