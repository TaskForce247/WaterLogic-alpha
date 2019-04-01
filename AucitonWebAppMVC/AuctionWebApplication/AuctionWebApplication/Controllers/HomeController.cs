using WebApplication.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {

        IProjectService AccService = new ProjectServiceClient("secure");
        public ActionResult Index(string Search)
        {
            if(string.IsNullOrEmpty(Search))
            {
                return RedirectToAction("Index", "Auction");
            }
            var products = AccService.GetProductsWithName(Search);
            if (products != null)
            {
               
               
                    return RedirectToAction("Index","Product");
                
            }
            return View();
        }

        public ViewResult Index()
        {
            throw new NotImplementedException();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult HomePage()
        {
            return RedirectToAction("Index");
        }
    }
}