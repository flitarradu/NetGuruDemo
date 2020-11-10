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
    public sealed class EditUserAsAdmin : Hooks
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public EditUserAsAdmin(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        //[Given(@"I am logged in as an admin with credentials")]
        //public void GivenIAmLoggedInAsAnAdminWithCredentials(Table table)
        //{

        //}

        [Given(@"I am logged in as an admin with credentials ""(.*)"" and ""(.*)""")]
        public void GivenIAmLoggedInAsAnAdminWithCredentialsAnd(string user, string password)
        {
            HomePage homePage = new HomePage(Driver);
            homePage.Authenticate();
            LoginPage myLoginPage = new LoginPage(Driver);
            myLoginPage.EnterCredentials(user , password);
        }


        [When(@"I click the Admin button")]
        public void WhenIClickTheAdminButton()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.adminButton.Click();
        }

        [When(@"I navigate to Users page")]
        public void WhenINavigateToUsersPage()
        {
            AdminPage adminPage = new AdminPage(Driver);
            adminPage.ClickUsersButton();
        }

        [When(@"I click  Edit and enter the following fields")]
        public void WhenIClickEditAndEnterTheFollowingFields(Table table)
        {
            AdminPage adminPage = new AdminPage(Driver);
            var user = table.CreateInstance<UserDto>();
            adminPage.EditUSer(user.userName, user.userEmail, user.userPhone);
        }

        [Then(@"The user is successfully edited")]
        public void ThenTheUserIsSuccessfullyEdited()
        {
            Assert.IsTrue(Driver.FindElement(By.XPath("/html/body/div/div")).Text.Contains("The user has been successfully updated"));
        }


    }
}
