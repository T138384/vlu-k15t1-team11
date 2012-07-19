using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Net;

namespace SmartMart3.Models
{
    public class Sample //: DropCreateDatabaseIfModelChanges<SaleEntities>
    {
        public Account CurrentAccount = new Account();
        public string getCurrentAccount()
        {
            return CurrentAccount.strUsername;
        }
        public void setCurrentAccount(string username)
        {
            CurrentAccount.strUsername = username;
        }
        public int OrderCount = 0;
        public List<Order> order = new List<Order> { };
        public List<Account> account = new List<Account>
        {
            
            new Account {Id = 3,strUsername = "cash02", strPassword = "cash02"},
            new Account {Id = 1,strUsername = "cash01", strPassword = "cash01"},
            new Account {Id = 2,strUsername = "cash03", strPassword = "cash03"}
        };
        public List<Customer> customer = new List<Customer>
        {
        };
        public List<Category> category = new List<Category>
        {
            new Category{Id = 1,strName = "Cosmetics"},
            new Category{Id = 2,strName = "Toothpaste"},
            new Category{Id = 3,strName = "Camera"},
            new Category{Id = 4,strName = "Motor"}
        };
        public List<Product> product = new List<Product>
        {
            new Product{Id = 1,strName = "Omo",nQuantity = 130,categoryId = 1,Price = 100},
            new Product{Id = 2,strName = "Viso",nQuantity = 120,categoryId = 1,Price = 120},
            new Product{Id = 3,strName = "Congate",nQuantity = 110,categoryId = 2,Price = 300},
            new Product{Id = 4,strName = "P/S",nQuantity = 100,categoryId = 2,Price = 140},
            new Product{Id = 5,strName = "Toothless",nQuantity = 20,categoryId = 2,Price = 110},
            new Product{Id = 6,strName = "Canon",nQuantity = 19,categoryId = 3,Price = 1200},
            new Product{Id = 7,strName = "Nikon",nQuantity = 5,categoryId = 3,Price = 1300},
            new Product{Id = 8,strName = "Lenka",nQuantity = 10,categoryId = 3,Price = 1000},
            new Product{Id = 9,strName = "Honda",nQuantity = 8,categoryId = 4,Price = 12000},
            new Product{Id = 10,strName = "Yamaha",nQuantity = 6,categoryId = 4,Price = 12500}
        };
    








        //protected override void Seed(SaleEntities context)
        //{

        //    var account = new List<Account>
        //    {
        //        new Account {Id = 1,strUsername = "cash01", strPassword = "cash01"},
        //        new Account {Id = 3,strUsername = "cash02", strPassword = "cash02"},
        //        new Account {Id = 2,strUsername = "cash03", strPassword = "cash03"}
        //    };
        //}

    }
}