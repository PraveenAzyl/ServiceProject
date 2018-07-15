using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoreCodeAdmin.WEB.UI.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult Ctrl_RightSliderSideBar()
        {
            return Ctrl_RightSliderSideBar();
        }

        public PartialViewResult Ctrl_ContentHeader()
        {
            return Ctrl_ContentHeader();
        }
        [AllowAnonymous]
        public PartialViewResult Ctrl_Footer()
        {
            return Ctrl_Footer();
        }

        public PartialViewResult Ctrl_MainSodebarContainer()
        {
            return PartialView();
        }

        public PartialViewResult Ctrl_NavigationBar()
        {
            return Ctrl_NavigationBar();
        }
        [AllowAnonymous]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }



        [AllowAnonymous]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}