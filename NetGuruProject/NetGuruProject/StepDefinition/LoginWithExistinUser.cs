﻿using NetGuruProject.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace NetGuruProject.StepDefinition
{
    [Binding]
    public sealed class LoginWithExistinUser : Hooks
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public LoginWithExistinUser(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I click the login button")]
        public void GivenIClickTheLoginButton()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.Authenticate();
        }

        [When(@"I login with the following credentials")]
        public void WhenILoginWithTheFollowingCredentials(Table table)
        {
            var user = table.CreateInstance<UserDto>();
            LoginPage myLoginPage = new LoginPage(Driver);
            myLoginPage.EnterCredentials(user);
        }

        [Then(@"I am succsfully logged in")]
        public void ThenIAmSuccsfullyLoggedIn()
        {
            Assert.IsTrue(Driver.FindElement(By.XPath("/html/body/div/div[1]/header/div[2]/div/div/nav/div[2]/a")).Displayed);
        }

    }
}
