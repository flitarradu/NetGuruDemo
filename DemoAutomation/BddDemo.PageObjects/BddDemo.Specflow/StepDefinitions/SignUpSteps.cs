using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using BddDemo.PageObjects.Dto;
using BddDemo.PageObjects.PageObjects;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace BddDemo.Specflow
{
    [Binding]
    public sealed class BasicSteps:BeforeAfter
    {
        private readonly ScenarioContext _context;
        public BasicSteps(ScenarioContext injectedContext)
        {
            _context = injectedContext;
        }

        [Given(@"I navigate to ""(.*)""")]
        public void GivenINavigateTo(string p0)
        {
           
        }

        [Given(@"I am on ""(.*)"" page")]
        public void GivenIAmOnPage(string p0)
        {
            var homePage = new HomePage(Driver);

            homePage.GoToRegister();


            Thread.Sleep(5000);
        }
        [When(@"I create my account and I ""(.*)""")]
        [When(@"I create my account")]
        public void WhenICreateMyAccount(Table table)
        {
            var myUser = table.CreateInstance<User>();
            var signUpPage = new SignUp(Driver);
            signUpPage.CreateAccount(myUser.Email);

            var registerPage = new Registration(Driver);

            registerPage.FillRegisterForm(myUser);
            
        }


    }
}
