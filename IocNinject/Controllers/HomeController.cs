using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ioc.Service;

namespace Ioc.Web.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        private IUserService userService;

        public HomeController(IUserService userService)
        {
            this.userService = userService;
        }

      

    }
}
