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
        [Test]
        public void MyFirstTest()
        {
            HomePage myPage = new HomePage(Driver);

            Thread.Sleep(1000);
        }

    }
}
