using eHandel2015.Repository.Abstract.Demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eHandel2015.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDemo _demoService;

        public HomeController(IDemo demoService)
        {
            _demoService = demoService;
        }

        // GET: Home
        public ActionResult Index()
        {
            var model = _demoService.DemoAction();
            return View(model);
        }
    }
}