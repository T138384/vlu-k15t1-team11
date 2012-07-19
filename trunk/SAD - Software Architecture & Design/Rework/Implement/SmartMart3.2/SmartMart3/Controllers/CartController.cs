using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SmartMart3.Models;

namespace SmartMart3.Controllers
{
    public class CartController : Controller
    {
        public ActionResult Cart()
        {
            return View();
        }
        [HttpGet]
        public ActionResult AddToCart(int Id)
        {
            Order NewOrder = new Order();
            NewOrder.Id = SaleEntities.sample.OrderCount;
            foreach (Order or in SaleEntities.sample.order)
            {
                
            }

            SaleEntities.sample.OrderCount++;
            SaleEntities.sample.order.Add(NewOrder);

            if (Id == 2)
                return RedirectToAction("Cart");
            else
                return View("");
        }
        
    }
}
