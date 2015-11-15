using eHandel2015.Repository.Abstract.User;
using eHandel2015.Repository.DTO.Shared;
using eHandel2015.Repository.DTO.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eHandel2015.Repository.Concrete.User
{
    public class UserService : Model, IUserService
    {
        public DTO.Shared.OperationResult LogOn(DTO.User.UserDto model)
        {
            OperationResult result = new OperationResult {Result = false};
            return result;
        }


        public DTO.User.UserDto GetUserByLogin(string login)
        {
            var user = Entities.User.Single(x => x.Login == login);

            if (user != null)
            {


                return new UserDto
                {
                    Id = user.Id,
                    Password = user.Password,
                    Login = user.Login,
                    Email = user.Email
                };
            }


            return null;
        }

    }
}
