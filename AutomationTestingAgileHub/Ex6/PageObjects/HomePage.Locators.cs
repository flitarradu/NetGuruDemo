using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6.PageObjects
{
    partial class HomePage
    {
        private IWebElement authenticationButton => _driver.FindElement(By.XPath("//a[text()='Autentificare']"));
        private IWebElement addToCartButton => _driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/div/div[2]/a"));
        public IWebElement orderNowButton => _driver.FindElement(By.XPath("/html/body/div/div[1]/div[2]/table/tbody/tr[3]/th[4]/a"));
        public IWebElement laptopuriButton => _driver.FindElement(By.XPath("//*[@id='collapsibleNavbar']/ul[1]/li[1]/a"));
        public IWebElement telefoaneButton => _driver.FindElement(By.XPath("//*[@id='collapsibleNavbar']/ul[1]/li[2]/a"));
        public IWebElement fotoButton => _driver.FindElement(By.XPath("//*[@id='collapsibleNavbar']/ul[1]/li[3]/a"));
        public IWebElement cartiButton => _driver.FindElement(By.XPath("//*[@id='collapsibleNavbar']/ul[1]/li[4]/a"));
        public IWebElement accesoriiButton => _driver.FindElement(By.XPath("//*[@id='collapsibleNavbar']/ul[1]/li[5]/a"));
        public IWebElement adminButton => _driver.FindElement(By.XPath("//*[@id='collapsibleNavbar']/ul[2]/li[3]/a"));









    }
}
