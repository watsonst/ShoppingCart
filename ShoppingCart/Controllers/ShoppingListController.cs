using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Controllers
{
   public class TempCartData
    {
        public static List<CartItems> Items = new List<CartItems>()
        {
               new CartItems() {Id = 1, Name = "Pasta", Type = "Food"} //By putting it in a static it will be there the whole process. but once we restart the application will be gone.
        };
    }
    
   
    
    
    public class ShoppingListController : Controller
    {

        private List<CartItems> _allItems; // allitems list here only lives in the controllor. won't store, wont be available for the life of the MVC process



        public ShoppingListController()
        {
            _allItems = TempCartData.Items;
        }

        // GET: ShoppingListController
        public ActionResult Index()
        {
            ViewBag.Name = "Paul";
            ViewData["Message"] = "here is the shopping cart: ";
            return View(_allItems);
        }

        // GET: ShoppingListController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ShoppingListController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ShoppingListController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("Id", "Name", "Type")]CartItems newItem)
        {
            try
            {
                TempCartData.Items.Add(newItem);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ShoppingListController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ShoppingListController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ShoppingListController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ShoppingListController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
