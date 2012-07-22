using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SmartMart3.Models;

namespace SmartMart3.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Error()
        {
            return View();
        }



        public ActionResult MakeOrder()
        {
            
                Order NewOrder = new Order();
                NewOrder.Id = SaleEntities.sample.OrderCount;
                SaleEntities.sample.OrderCount++;
                SaleEntities.sample.order.Add(NewOrder);
                SaleEntities.sample.CheckOrder = true;
                SaleEntities.sample.cproduct.Clear();
           
                return View("Index");
          
            
        }
        
    }
}
