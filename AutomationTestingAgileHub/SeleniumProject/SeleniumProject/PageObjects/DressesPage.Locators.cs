using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumProject.PageObjects
{
    partial class DressesPage
    {
        private IWebElement printedDressButton => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div[2]/ul/li[1]/div/div[2]/div[2]/a[1]"));
        private IWebElement pricyPritedDressButton => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div[2]/ul/li[2]/div/div[2]/div[2]/a[1]"));
        private IWebElement summerPritedDressButton => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div[2]/ul/li[5]/div/div[2]/div[2]/a[1]"));
        private IWebElement continueShoppingButton => _driver.FindElement(By.XPath("/html/body/div/div[1]/header/div[3]/div/div/div[4]/div[1]/div[2]/div[4]/span/span"));
        public IWebElement proceedCheckoutButton => _driver.FindElement(By.XPath("/html/body/div/div[1]/header/div[3]/div/div/div[4]/div[1]/div[2]/div[4]/a"));
        private IWebElement printedDressElement => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div[2]/ul/li[1]/div/div[1]/div/a[1]"));
        private IWebElement pricyPritedDressElement=> _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div[2]/ul/li[2]/div/div[1]/div/a[1]/img"));
        private IWebElement summerPritedDressElement => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div[2]/ul/li[4]/div/div[1]/div/a[1]/img"));
        private IWebElement addToWishListButton => _driver.FindElement(By.XPath("/html/body/div/div[2]/div/div[3]/div/div/div/div[4]/form/div/div[3]/p/a"));
        private IWebElement addedToWishListText => _driver.FindElement(By.XPath("/html/body/div[2]/div/div/div/div"));
        private IWebElement addedToWishListBannerCloseButton => _driver.FindElement(By.XPath("/html/body/div[2]/div/div/a"));


        





    }
}
