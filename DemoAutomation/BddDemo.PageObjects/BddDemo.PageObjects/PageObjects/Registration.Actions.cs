using BddDemo.PageObjects.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BddDemo.PageObjects.PageObjects
{
    public partial class Registration
    {
        public void FillRegisterForm(User user, string takeaction="save")
        {
            FirstNameTextBox.SendKeys(user.FirstName);
            LastNameTextBox.SendKeys(user.LastName);
            PasswordTextBox.SendKeys(user.Password);
            AliasAddressTextBox.SendKeys(user.AliasAddress);
            AddressTextBox.SendKeys(user.Address);
            CityTextBox.SendKeys(user.City);
            ZipCodeTextBox.SendKeys(user.ZipCode);
            CountryDropdown.SelectByText(user.Country);
            StateDropdown.SelectByText(user.State);
            MobilePhoneTextBox.SendKeys(user.MobilePhone);
            SelectDateOfBirth(user.DateOfBirth);

            if (takeaction == "save")
            {
                RegisterButton.Click();
            }
        }

        private void SelectDateOfBirth(string dateOfBirth)
        {
            var dobInfo = dateOfBirth.Split('/').ToList();
            DayDobDropdown.SelectByValue(dobInfo[0]);
            MonthDobDropdown.SelectByValue(dobInfo[1]);

            YearDobDropdown.SelectByValue(dobInfo[2]);
        }

    }
}
