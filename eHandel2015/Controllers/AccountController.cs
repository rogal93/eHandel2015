using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using eHandel2015.Helpers;
using eHandel2015.Repository.Abstract.User;
using Microsoft.AspNet.Identity;
using eHandel2015.Repository.DTO.User;
using eHandel2015.Repository.Helpers;

namespace eHandel2015.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserService _userService;

        public AccountController(IUserService userService)
        {
            _userService = userService;
        }

        // GET: Account
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult LogOn()
        {
            UserDto model = new UserDto();

            return View(model);
        }

        [HttpPost]
        public ActionResult LogOn(UserDto model)
        {
            var user = _userService.GetUserByLogin(model.Login);
            if (user !=null) // todo dodać obsługę wyjątków
            {
                if (CustomPasswordHasher.GeneratePassword(model.Password).Equals(user.Password))
                {
                    CreateUserTicket(model.Login, (int)user.Id);
                }
            }
            return View();
        }
        private void CreateUserTicket(string login,int userId)
        {
            Response.SetCookie(new HttpCookie("login", login));
            var user = HttpContext.User as CustomPrincipal;

            var authTicket = new FormsAuthenticationTicket(1, 
                                login, 
                                DateTime.Now,             
                                DateTime.Now.AddMinutes(FormsAuthentication.Timeout.TotalMinutes), 
                                false, 
                                Guid.NewGuid().ToString(),         
                                FormsAuthentication.FormsCookiePath);
            var encTicket = FormsAuthentication.Encrypt(authTicket);

            var userIdCookie = new HttpCookie("userId", userId.ToString());
            userIdCookie.Expires = DateTime.Now.AddYears(1);
            Response.SetCookie(userIdCookie);
            Response.Cookies.Add(new HttpCookie(FormsAuthentication.FormsCookieName, encTicket));



        }
    }
}