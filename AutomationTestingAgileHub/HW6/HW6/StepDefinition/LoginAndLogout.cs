using HW6.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumSpecflowBDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using HW6;

namespace HW6.StepDefinition
{
    [Binding]
    public sealed class LoginAndLogout : Hooks
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public LoginAndLogout(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I am logged in on my site")]
        public void GivenIAmLoggedInOnMySite(Table table)
        {
            HomePage homePage = new HomePage(Driver);
            homePage.Authenticate();
            var user = table.CreateInstance<UserDto>();
            LoginPage myLoginPage = new LoginPage(Driver);
            myLoginPage.EnterCredentials(user);
        }

        [When(@"I click disconnect button")]
        public void WhenIClickDisconnectButton()
        {
            Driver.FindElement(By.XPath("//*[@id='collapsibleNavbar']/ul[2]/li[2]/a")).Click();
        }

        [Then(@"I am successfully logged out")]
        public void ThenIAmSuccessfullyLoggedOut()
        {
            Assert.IsTrue(Driver.FindElement(By.XPath("//*[@id='collapsibleNavbar']/ul[2]/li[1]/a")).Displayed);
        }

    }
}
