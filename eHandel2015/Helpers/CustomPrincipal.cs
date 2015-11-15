using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace eHandel2015.Helpers
{
    public class CustomPrincipal : IPrincipal
    {
        private readonly IIdentity _IIdentity;

        public CustomPrincipal(IIdentity identity)
        {
            _IIdentity = identity;
        }

        public IIdentity Identity
        {
            get { return _IIdentity; }
        }

        public bool IsInRole(string role)
        {
            throw new NotImplementedException();
        }
        public long? UserId
        {
            get
            {
                var userId = HttpContext.Current.Request.Cookies["userId"];
                if (userId != null)
                    return long.Parse(userId.Value);

                return null;
            }
        }

        public string Login
        {
            get
            {
                var login = HttpContext.Current.Request.Cookies["login"];
                if (login != null)
                    return login.Value;

                return null;
            }
        }
    }
}