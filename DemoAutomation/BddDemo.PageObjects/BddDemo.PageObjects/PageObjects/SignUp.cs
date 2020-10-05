using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BddDemo.PageObjects.PageObjects
{
    public partial class SignUp
    {
        public void CreateAccount(string email)
        {
            EmailAdressTextBox.SendKeys(email);
            CreateAccountButton.Click();
        }
    }
}
