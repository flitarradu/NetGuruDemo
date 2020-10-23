using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema28.PageObjects
{
    partial class Homepage
    {
        private IWebElement menuButton => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='untold-container']/header/div[2]/div[3]/div/button")));
        private IWebElement homeButton => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='untold-container']/header/div[2]/div[2]/div[1]/nav/div[1]/a[1]")));

    }
}
