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

        public ActionResult Finish()
        {
            return View();
        }
        public ActionResult CheckOut()
        {

            return View();
        }
        [HttpPost]
        public ActionResult CheckOut(Order model, string returnUrl)
        {
            Order order = new Order();
            SaleEntities.sample.order[SaleEntities.sample.OrderCount-1].CustomerId = model.CustomerId;
            SaleEntities.sample.order[SaleEntities.sample.OrderCount-1].TotalPrice = model.TotalPrice;
            SaleEntities.sample.order[SaleEntities.sample.OrderCount - 1].Score = model.Score;
            foreach(Customer peo in SaleEntities.sample.ccustomer)
            {
                if (peo.Id == model.CustomerId)
                {
                    SaleEntities.sample.order[SaleEntities.sample.OrderCount - 1].customerName = peo.Name;
                    break;
                }
            }
            SaleEntities.sample.CheckOrder = false;
            SaleEntities.sample.OrderCount += 1;

            return View("Finish");
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
        public ActionResult Remove(string input)
        {
            int n = 0;
            foreach (cProduct cpro in SaleEntities.sample.cproduct)
            {
                if (input.Equals(cpro.Name))
                {
                    SaleEntities.sample.cproduct.RemoveAt(n);
                    return View("Cart");
                }
                n++;
            }

            return View("Cart");
        }
        [HttpPost]
        public ActionResult AddToCart(cProduct model, string returnUrl)
        {
            if (model.Quantity > 0)
            {
                int n = SaleEntities.sample.OrderCount;

                cProduct cpro = new cProduct();
                cpro.Name = model.Name;
                cpro.Quantity = model.Quantity;
                cpro.OrderId = model.OrderId;
                cpro.Price = model.Price;
                cpro.cost = cpro.Quantity * cpro.Price;

                SaleEntities.sample.cproduct.Add(cpro);
                return View("Cart");
                
            }
            else
                return View();        
        }

        [HttpGet]
        public ActionResult AddToCart(int Id)
        {
            
            int n = SaleEntities.sample.OrderCount;
            if (SaleEntities.sample.CheckOrder == false)
            {
                SaleEntities.sample.cproduct.Clear();
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
