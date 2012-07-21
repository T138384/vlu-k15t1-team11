using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SmartMart3.Models;

namespace SmartMart3.Controllers
{
    public class StoreController : Controller
    {
        //
        // GET: /Store/

        public ActionResult ViewList()
        {
            return View(SaleEntities.sample.product);
        }
       
        public ActionResult CategoryList()
        {
            var Categories = SaleEntities.sample.category.ToList();

            return PartialView(Categories);
        }



        [HttpGet]
        public ActionResult ViewList(int cateId)
        {
            List<Product> listProduct = new List<Product> { };
            foreach (Product pPro in SaleEntities.sample.product)
            {
                if (cateId == pPro.categoryId)
                {
                    listProduct.Add(pPro);
                }
            }
            return View(listProduct);
        }

    }
}
