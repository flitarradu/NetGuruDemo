using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Threading;
using SeleniumTestProject.PageObjects;

namespace SeleniumTestProject
{   
    [TestFixture]
    class Tests : Hooks
    {
        [Test, Category("Login")]
        public void MyFirstTest()
        {
            // Arrange
            HomePage homePage = new HomePage(Driver);
            homePage.GoToAuthentication();

            //Act
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.AuthenticateUser("admin.test3@gmail.com", "password123");

            //Assert
            Assert.IsTrue(homePage.VerifyElementIsDisplayed(homePage.DeconectareButton));

            Thread.Sleep(1000);
        }

    }
}
