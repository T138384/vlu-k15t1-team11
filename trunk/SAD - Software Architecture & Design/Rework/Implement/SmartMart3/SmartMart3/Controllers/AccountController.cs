using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SmartMart3.Models;
using System.Web.Security;

namespace SmartMart3.Controllers
{
    public class AccountController : Controller
    {
        SaleEntities db = new SaleEntities();
        //
        // GET: /Account/
        private void MigrateSale(string UserName)
        {
            // Associate shopping cart items with logged-in user
            //var cart = ShoppingCart.GetCart(this.HttpContext);

            //cart.MigrateCart(UserName);
            //Session[ShoppingCart.CartSessionKey] = UserName;
        }
        public ActionResult LogIn()
        {
            return View();
        }
        public bool CheckLogin(string user, string pass)
        {
            //Account acc = (from dbAccount in db.dbAccount
            //               where dbAccount.strUsername == user && dbAccount.strPassword == pass
            //               select dbAccount);

           //Account acc = (from account in db.dbAccount
           //               where account.strUsername == user && account.strPassword == pass select account);

            //Account acc = db.dbAccount.Single(c => c.strUsername == user && c.strPassword == pass);
            Sample s = new Sample();
            s.cheat();
            foreach(Account acc in s.account)
            {
                if (acc.strUsername == user && acc.strPassword==pass)
                    return true;
                else
                    return false;
            }
            return false;
            
        }
        [HttpPost]
        public ActionResult LogIn(Account model, string returnUrl)
        {
            
            bool c = CheckLogin(model.strUsername, model.strPassword);
            if (c==true)
                 return RedirectToAction("Index", "Home");
            else
                return View(model);
            //if (ModelState.IsValid)
            //{
            //    if (Membership.ValidateUser(model.strUsername, model.strPassword))
            //    {
            //        return RedirectToAction("Index", "Home");
            //    }
            //    else
            //    {
            //        ModelState.AddModelError("", "The user name or password provided is incorrect.");
            //    }
            //}
            
        }


    }

}
