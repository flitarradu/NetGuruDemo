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
        private IWebElement teamButton => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='menu-item-2914']/a/span[2]")));
        private IWebElement actorButton => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='av-masonry-1-item-2697']/figure/div/div")));
        private IWebElement actorImageButton => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='av-masonry-1-item-2697']/figure/div/div/img")));
        private IWebElement showButton => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='av-layout-grid-1']/div[1]/div/div[1]/section/div/p[2]/a")));
        public IWebElement showNameText => _driverWait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='av-layout-grid-1']/div[2]/div/div/h3")));

        
    }
}
