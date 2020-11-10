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
    public sealed class SignUpAndLogin : Hooks
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public SignUpAndLogin(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I navigate to my website and click SignUp")]
        public void GivenINavigateToMyWebsiteAndClickSignUp()
        {
            SignUp signUp = new SignUp(Driver);
            signUp.EnterSignup();
        }

        [When(@"I fill the signup form with following data")]
        public void WhenIFillTheSignupFormWithFollowingData(Table table)
        {
            SignUp signUp = new SignUp(Driver);
            var newUser = table.CreateInstance<UserDto>();
            signUp.SigUpFormFill(newUser);
        }

        [When(@"I click the sign up button")]
        public void WhenIClickTheSignUpButton()
        {
            SignUp signUp = new SignUp(Driver);
            signUp.signUpInscriereButton.Click();
        }

        [When(@"I login with newly created user")]
        public void WhenILoginWithNewlyCreatedUser(Table table)
        {
            SignUp signUp = new SignUp(Driver);
            var user = table.CreateInstance<UserDto>();
            signUp.AuthenticateNewUser(user);

        }

        [Then(@"I am successfully logged in with new aacount")]
        public void ThenIAmSuccessfullyLoggedInWithNewAacount()
        {
            Assert.IsTrue(Driver.FindElement(By.XPath("//a[text()='Deconectare']")).Displayed);
        }

    }
}
