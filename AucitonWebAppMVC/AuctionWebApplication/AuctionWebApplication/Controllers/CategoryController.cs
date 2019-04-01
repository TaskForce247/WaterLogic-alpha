using WebApplication.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class CategoryController : Controller
    {
        IProjectService AccService = new ProjectServiceClient("secure");

        // GET: Category
        public ActionResult Index()
        {
            return View(AccService.GetAllCategories());
        }
    }
}