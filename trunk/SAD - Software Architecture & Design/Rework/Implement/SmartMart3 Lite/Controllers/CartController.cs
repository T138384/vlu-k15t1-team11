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


        public cProduct addProduct(int n)
        {
            cProduct cpro = new cProduct();
            foreach (Product pPro in SaleEntities.sample.product)
            {
                if (n == pPro.Id)
                {
                    cpro.Name = pPro.strName;
                    cpro.Price = pPro.Price;
                }    
                
            }
            return cpro;
        }

        [HttpPost]
        public ActionResult AddToCart(cProduct model, string returnUrl)
        {
            int n = SaleEntities.sample.OrderCount;
            
            cProduct cpro = new cProduct();
            cpro.OrderId = model.OrderId;
            cpro.Quantity = model.Quantity;
            cpro.OrderId = model.OrderId;
            cpro.Price = model.Price;

            SaleEntities.sample.cproduct.Add(cpro);
            return View("Cart");
        }

        [HttpGet]
        public ActionResult AddToCart(int Id)
        {
            
            int n = SaleEntities.sample.OrderCount;
            if (SaleEntities.sample.CheckOrder == false)
            {
                Order NewOrder = new Order();
                
                NewOrder.Id = n;
                SaleEntities.sample.order.Add(NewOrder);
                //cProduct c = new cProduct();
                //c = addProduct(Id);
                //int x = SaleEntities.sample.order[n].cproduct.Capacity;
                //SaleEntities.sample.order[n].cproduct.Add(c);

                //SaleEntities.sample.order[n].cproduct.Add(addProduct(Id));
                SaleEntities.sample.CheckOrder = true;
            }
            //SaleEntities.sample.order[n].cproduct.Add(addProduct(Id));

            cProduct cpro = new cProduct();
            cpro = addProduct(Id);
            cpro.OrderId = n;
            return View(cpro);          
        }

        //[HttpPost]
        //public ActionResult AddToCart(int Id)
        //{

         
        //    return View();
        //}


        
    }
}
