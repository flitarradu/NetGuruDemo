using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumSpecflowBDD
{
    class UserDto
    {
        public string userEmail { get; set; }
        public string userPassword { get; set; }
        public string userPasswordRepeat { get; set; }
        public string userPhone { get; set; }
        public string userName { get; set; }
        public string userAddress { get; set; }


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
