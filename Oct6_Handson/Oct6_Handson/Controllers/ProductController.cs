using Oct6_Handson.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Oct6_Handson.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product

        public ActionResult Index()
        { 
            List<ProductModel> prodlist = new List<ProductModel>();
            prodlist.Add(new ProductModel { ProductId = 1, ProductName = "Samsung Tv", ProductPrice = 23500, ManufacturingDate = new DateTime(2000,11,12) });
            prodlist.Add(new ProductModel { ProductId = 2, ProductName = "Intex Tv", ProductPrice = 20500, ManufacturingDate = new DateTime(2020,12,03) });
            prodlist.Add(new ProductModel { ProductId = 3, ProductName = "Apple mobile", ProductPrice = 80000, ManufacturingDate = new DateTime(2022,09,11) });
            prodlist.Add(new ProductModel { ProductId = 4, ProductName = "Oneplus mobile", ProductPrice = 50000, ManufacturingDate = new DateTime(2008,11,09) });

            return View(prodlist);

        }
    }

  
}