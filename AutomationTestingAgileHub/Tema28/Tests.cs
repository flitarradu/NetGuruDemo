using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tema28.PageObjects;

namespace Tema28
{
    [TestFixture]
    class Tests : Hooks
    {
        [Test]
        public void GoogleImagesTest()
        {
            Driver.Manage().Window.Maximize();


            Driver.Navigate().GoToUrl("http://google.com/");
            // Arrange
            Homepage homePage = new Homepage(Driver);

            // Act
            Driver.SwitchTo().Frame(0);
            homePage.AcceptGoogleTerms();
            homePage.SearchGoogleImage("paris");
            homePage.SelectGoogleImage();

            Driver.Navigate().Back();

            //Assert
            Assert.IsTrue(! homePage.imageFrame.Displayed);

        }

        [Test]
        public void DemoQATest()
        {
            Driver.Manage().Window.Maximize();


            Driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");
            // Arrange
            Homepage homePage = new Homepage(Driver);

            // Act
            homePage.FillDemoQAForm();

            //Assert
            Assert.IsTrue(homePage.thanksForm.Displayed);
        }

    }
}
