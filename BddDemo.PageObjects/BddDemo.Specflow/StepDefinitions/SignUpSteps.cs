using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BddDemo.PageObjects.PageObjects;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

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

    }
}
