using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject.PageObjects
{
    partial class HomePage
    {
        private IWebElement signInButton => _driver.FindElement(By.XPath("/html/body/div/div[1]/header/div[2]/div/div/nav/div[1]/a"));
        public IWebElement registerButton => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/div[1]/form/div/div[3]/button"));
        private IWebElement loginButton => _driver.FindElement(By.XPath("/html/body/nav/div/div[2]/ul/li[2]/ul/li[2]/a"));
        public IWebElement homeButton => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[1]/a[1]"));
        public IWebElement shortSleeveShirtButton => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[2]/div/div[1]/ul[1]/li[1]/div/div[1]/div/a[1]/img"));
        private IWebElement shortSleeveShirtAddCartButton => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/div/div[4]/form/div/div[3]/div[1]/p/button"));
        public IWebElement proceedCheckoutButton => _driver.FindElement(By.XPath("/html/body/div/div[1]/header/div[3]/div/div/div[4]/div[1]/div[2]/div[4]/a"));
        public IWebElement emailAddressTextBox => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/div[1]/form/div/div[2]/input"));
        public IWebElement searchTextBox => _driver.FindElement(By.XPath("/html/body/div/div[1]/header/div[3]/div/div/div[2]/form/input[4]"));
        public IWebElement searchButton => _driver.FindElement(By.XPath("/html/body/div/div[1]/header/div[3]/div/div/div[2]/form/button"));
        public IWebElement dressButton => _driver.FindElement(By.XPath("/html/body/div/div[1]/header/div[3]/div/div/div[6]/ul/li[2]/a"));
        
        public IWebElement shortSleeveDress => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[2]/div/div[1]/ul[1]/li[1]/div/div[1]/div/a[1]"));


    }
}
