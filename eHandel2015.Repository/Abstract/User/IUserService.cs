using eHandel2015.Repository.DTO.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eHandel2015.Repository.DTO.User;

namespace eHandel2015.Repository.Abstract.User
{
    public interface IUserService : IModel
    {

        OperationResult LogOn(UserDto model);
        UserDto GetUserByLogin(string login);

    }
}
