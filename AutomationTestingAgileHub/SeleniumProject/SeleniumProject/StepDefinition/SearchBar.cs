using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using SeleniumProject.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SeleniumProject.StepDefinition
{
    [Binding]
    public sealed class SearchBar : Hooks
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public SearchBar(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"I write '(.*)' in the search bar")]
        public void GivenIWriteInTheSearchBar(string p0)
        {
            HomePage homePage = new HomePage(Driver);
            homePage.searchTextBox.Click();
            homePage.searchTextBox.SendKeys(p0);
        }

        [Given(@"I press the search button")]
        public void GivenIPressTheSearchButton()
        {
            HomePage homePage = new HomePage(Driver);
            homePage.searchButton.Click();
        }

        [Then(@"I am shown only '(.*)' articles")]
        public void ThenIAmShownOnlyArticles(string p0)
        {
            var result = "\"" + p0.ToUpper() + "\"";
            Assert.IsTrue(Driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div[2]/h1/span[1]")).Text == result );
        }

    }
}
