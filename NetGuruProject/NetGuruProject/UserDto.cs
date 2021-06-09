using System;
using System.Collections.Generic;
using System.Text;

namespace NetGuruProject
{
    class UserDto
    {
        public string userEmail { get; set; }
        public string userPassword { get; set; }
        public string userPhone { get; set; }
        public string userFirstName { get; set; }
        public string userLastName { get; set; }
        public string userAddress { get; set; }
        public string userAddressFirstName { get; set; }
        public string userAddressLastName { get; set; }
        public string userCity { get; set; }
        public string userPostalCode { get; set; }

        public UserDto GetUservalid()
        {
            var validUserDto = new UserDto();
            if (this.userEmail != null)
                validUserDto.userEmail = userEmail;
            else
                validUserDto.userEmail = string.Empty;

            if (this.userPassword != null)
                validUserDto.userPassword = userPassword;
            else
                validUserDto.userPassword = string.Empty;

            return validUserDto;
        }
    }
}
