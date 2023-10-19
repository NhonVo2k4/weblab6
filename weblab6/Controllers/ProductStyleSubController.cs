using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using weblab6.Models;

namespace weblab6.Controllers
{
    public class ProductStyleSubController : Controller
    {
        lab6Entities database = new lab6Entities();
        // GET: ProductStyleSub
        public ActionResult Index(string searchValue)
        {
            if(searchValue != null)
            {
                List<tblProduct> proList = database.tblProducts.ToList();
                List<ProductViewModel> list = proList.Select(
                    x => new ProductViewModel
                    {
                        IdProduct = x.codeProduct,
                        NameProduct = x.nameProduct,
                        NameStyle = x.tblStyle.nameStyle,
                        SupplierName = x.tblSupplierProduct.supplierName
                    }
                    ).Where( x => x.NameProduct.Contains(searchValue) || x.SupplierName.Contains(searchValue) || x.NameStyle.Contains(searchValue)).ToList();
                return View(list);
            }
            else
            {
                List<tblProduct> proList = database.tblProducts.ToList();
                List<ProductViewModel> list = proList.Select(
                    x => new ProductViewModel
                    {
                        IdProduct = x.codeProduct,
                        NameProduct = x.nameProduct,
                        NameStyle = x.tblStyle.nameStyle,
                        SupplierName = x.tblSupplierProduct.supplierName
                    }
                    ).ToList();
                return View(list);
            }
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(ProductViewModel pro)
        {
            database.tblStaffs.Add(pro);
            database.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit()
        {
            return View();
        }

        public ActionResult Delete()
        {
            return View();
        }
    }
}