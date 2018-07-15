using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Rservices.Operation.BusinessLogic;
using CoreCodeAdmin.WEB.UI.Models;

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
            using (var obj = new RServiceFactory().VendorOperation())
            {
                obj.SaveVendor();
            }


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

        
        public PartialViewResult Ctrl_VendorRegistration()
        {
            return PartialView();
        }

        [HttpPost]
        public JsonResult Ctrl_VendorRegistration(Ctrl_VendorRegistrationViewModel Model)
        {
            return Json(new { ErrorCode = 0,ErrorMessage="Boom"});
        }

        [Authorize]
        public ActionResult Vendors()
        {
            return View();
        }


    }
}