using WebApplication.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace WebApplication.Controllers
{
    public class ProductController : Controller
    {
        IProjectService AccService = new ProjectServiceClient("secure");

        #region GET METHODS
        // GET: Product
        public ActionResult Index()
        {
            return View(AccService.GetAllProducts());
        }

        public ActionResult List(int CategoryId)
        {
            var products = AccService.GetAllProductsInCategory(CategoryId);

            

            return RedirectToAction("Index", "Auction", new { Search = " ", Products = products });
        }

        public ActionResult Create()
        {
            ViewBag.CategoryId = new SelectList(AccService.GetAllCategories(), "Id", "Name");
            return View();
        }

        public ActionResult Detailss(int id)
        {
            var pr = AccService.GetProductById(id);
            return RedirectToAction("Details", new { id = pr.Id });
        }
        public ActionResult Delete(int id)
        {
            var acc = AccService.GetProductById(id);
            if (acc != null)
                return View(acc);
            else
                return View();
        }
        #endregion

        #region POST METHODS

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Name,Description,Price,Stock,CategoryId")] Product product)
        {
            
                   
                    AccService.AddProduct(product);
            return RedirectToAction("Index", "Product");





        }
        public  ActionResult Show()
        {
            Product pr = null;
            if (Session["Auction"] != null)
            {
                
               
                if(pr.Picture != null)
                {
                    
                   
                    return RedirectToAction("Index", "Auction");
                }
            }
                return View(pr);
        }
        public ActionResult Details(int Id)
        {
            var auc = AccService.GetProductById(Id);
            if (auc != null)
            {
                

                return View(auc);
            }
            else
            {
                return View();
            }
        }

        public ActionResult Edit(int Id)
        {
            var acc = AccService.GetProductById(Id);
            if (acc != null)
                return View(acc);
            else
                return View();

        }
        [HttpPost]
        // POST: Products/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.

        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Description,Price,Picture,CategoryId,Stock,RowVersion")] Product product)
        {  
            if (ModelState.IsValid)
            {
               
                AccService.UpdateProduct(product);
                return RedirectToAction("Index", "Product");
            }
            else
            {
                ModelState.AddModelError(string.Empty, "There is something wrong! Try again!.");
            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete()
        {
            int id = int.Parse(Url.RequestContext.RouteData.Values["id"].ToString());
            AccService.RemoveProductById(id);
            return RedirectToAction("Index", "Product");
        }


        #endregion

    }

}