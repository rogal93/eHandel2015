using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHandel2015.Repository.DTO.User
{
    public class UserDto
    {
        public long Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool PasswordConfirmed { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
