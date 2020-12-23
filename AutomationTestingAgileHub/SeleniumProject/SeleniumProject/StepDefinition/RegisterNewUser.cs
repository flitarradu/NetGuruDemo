using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumProject.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SeleniumProject.StepDefinition
{
    [Binding]
    public sealed class RegisterNewUser : Hooks
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public RegisterNewUser(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I navigate to website and click login")]
        public void GivenINavigateToWebsiteAndClickLogin()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.Authenticate();
        }

        [Then(@"I fill desired email")]
        public void ThenIFillDesiredEmail(Table table)
        {
            var user = table.CreateInstance<UserDto>();
            HomePage homePage = new HomePage(Driver);
            homePage.emailAddressTextBox.SendKeys(user.userEmail);
            homePage.registerButton.Click();
        }

        [When(@"I fill the register form with following data")]
        public void WhenIFillTheRegisterFormWithFollowingData(Table table)
        {
            var user = table.CreateInstance<UserDto>();
            RegisterPage registerPage = new RegisterPage(Driver);
            registerPage.EnterRegistrationCredentials(user);
        }

        [When(@"I click the register button")]
        public void WhenIClickTheRegisterButton()
        {
            RegisterPage registerPage = new RegisterPage(Driver);
            registerPage.submitButton.Click();
        }

        [Then(@"I am successfully logged in")]
        public void ThenIAmSuccessfullyLoggedIn()
        {
            Assert.IsTrue(Driver.FindElement(By.XPath("/html/body/div/div[1]/header/div[2]/div/div/nav/div[2]/a")).Displayed);
        }

    }
}
