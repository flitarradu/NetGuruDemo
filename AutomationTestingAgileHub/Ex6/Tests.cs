using Ex6.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Tema28
{
    [TestFixture]
    class Tests : Hooks
    {
 
        public void Authenticate()
        {
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("http://demosite.casqad.org/");
            // Arrange
            HomePage homePage = new HomePage(Driver);

            // Act
            homePage.Authenticate();

            //Assert
            Assert.IsTrue(Driver.FindElement(By.XPath("/html/body/div/div/div[2]/h3")).Displayed);
        }

        // a.	Logati-va in aplicatie.
        [Test]
        public void LogInAdmin()
        {

            Authenticate();
            // Arrange
            LoginPage loginPage = new LoginPage(Driver);

            // Act
            loginPage.EnterCredentials("admin.test3@gmail.com", "password123");

            //Assert
            Assert.IsTrue(Driver.FindElement(By.XPath("//a[text()='Deconectare']")).Displayed);
        }


        public void SignUp()
        {
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("http://demosite.casqad.org/");
            // Arrange
            SignUp signUp = new SignUp(Driver);

            // Act
            signUp.EnterSignup();
            signUp.SigUpFormFill();

            //Assert
            Assert.IsTrue(Driver.FindElement(By.XPath("/html/body/div/div/div[2]/div/button")).Displayed);
        }

        public void LogOut()
        {
            Driver.FindElement(By.XPath("//*[@id='collapsibleNavbar']/ul[2]/li[2]/a")).Click();
        }

        // b.	Adaugati in cos un produs ca si utilizator. // c.	Adaugati in cos un produs ca si admin.
        [Test]
        public void UserAddToCart()
        {
            Authenticate();
            // Arrange
            SignUp signUp = new SignUp(Driver);
            HomePage homePage = new HomePage(Driver);
            LoginPage loginPage = new LoginPage(Driver);

            // Act
            loginPage.EnterCredentials("flitar.radu@gmail.com", "parola123"); // user
            // loginPage.EnterCredentials("admin.test3@gmail.com", "password123"); //admin

            homePage.AddToCart(Driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div/div/div/div/a")));

            //Assert
            Assert.IsTrue(Driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/table/tbody/tr[1]/td[2]")).Text == "Laptop ASUS X509FJ");
        }


        // d.	Faceti inscrierea si logati-va cu noul cont.
        [Test]
        public void AuthenticateAndLogin()
        {
            SignUp();
            LogInAdmin();

        }

        // e.	Logati-va si deconectati-va din site.
        [Test]
        public void LoginAndLogOut()
        {
            LogInAdmin();
            LogOut();

            Assert.IsTrue(Driver.FindElement(By.XPath("//*[@id='collapsibleNavbar']/ul[2]/li[1]/a")).Displayed);
        }

        // f.	Dati click pe fiecare meniu (orizontal).
        [Test]
        public void ClickEveryMenu()
        {
            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl("http://demosite.casqad.org/");

            //Arrange
            HomePage homePage = new HomePage(Driver);

            //Act
            homePage.ClickEveryMenu();

            //Assert
            Assert.IsTrue(Driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div/div/div/div/h5")).Text == "Rucsac laptop Trust Lima");
        }


        // g.	Ca si admin, dati click pe buton de administrare.
        [Test]
        public void ClickAdminButton()
        {
            LogInAdmin();

            HomePage homePage = new HomePage(Driver);
            AdminPage adminPage = new AdminPage(Driver);

            homePage.adminButton.Click();

            Assert.IsTrue(adminPage.addProductButton.Displayed);
        }


        // h.	Ca si admin, dati click pe buton de administrare si accesati meniul Utilizatori.
        [Test]
        public void ClickUsersButton()
        {
            LogInAdmin();

            HomePage homePage = new HomePage(Driver);
            AdminPage adminPage = new AdminPage(Driver);

            homePage.adminButton.Click();
            adminPage.ClickUsersButton();

            Assert.IsTrue(Driver.FindElement(By.XPath("/html/body/div/div/div/table/thead/tr/th[8]")).Text == "Acțiuni");
        }

        // i.	Ca si admin, dati click pe buton de administrare si accesati meniul Utilizatori, alegeti un utilizator si editati.
        [Test]
        public void EditUser()
        {
            LogInAdmin();

            HomePage homePage = new HomePage(Driver);
            AdminPage adminPage = new AdminPage(Driver);

            homePage.adminButton.Click();
            adminPage.EditUSer("Radu", "radu@gmail.com", "0733556445");

            Assert.IsTrue(Driver.FindElement(By.XPath("/html/body/div/div")).Text.Contains("The user has been successfully updated"));
            //Assert.IsTrue(adminPage.userEmailAdminTextBox.Text == "radu@gmail.com" && adminPage.userNameAdminTextBox.Text == "Radu" && adminPage.userPhoneAdminTextBox.Text == "0733556445");
        }



    }
}
