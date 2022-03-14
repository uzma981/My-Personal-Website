using FirstASPTodo.data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FirstASPTodo.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace FirstASPTodo.Controllers
{
    public class AddExpenseController : Controller
    {
        public readonly ApplicationDbContext _db;

        public AddExpenseController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<Expenses> obj = _db.ExpensesList;// retrieve all the categories from the table.
            return View(obj);
        }
        //get action method
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Expenses obj)
        {
            //if (obj.ExpenseName == obj.ex.ToString())
            //{
            //    ModelState.AddModelError("name", "The Display Order cannot exactly match the Name.");
            //}
            if (ModelState.IsValid)
            {
                _db.ExpensesList.Add(obj);//whenever you create a new 'todo' it will add it to the database, and save the change
                _db.SaveChanges();
                TempData["success"] = "Expense created successfully";
                return RedirectToAction("Index");
            }

            return View(obj);
        }




        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var expenseFromDb = _db.ExpensesList.Find(id);
            if (expenseFromDb == null)
            {
                return NotFound();
            }
            return View(expenseFromDb);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Expenses obj)
        {
            //if (obj.Name == obj.DisplayOrder.ToString())
            //{
            //    ModelState.AddModelError("name", "The Display Order cannot exactly match the Name.");
            //}
            if (ModelState.IsValid)
            {
                _db.ExpensesList.Update(obj);//whenever you create a new 'todo' it will add it to the database, and save the change
                _db.SaveChanges(); return RedirectToAction("Index");
            }

            return View(obj);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var expenseFromDb = _db.ExpensesList.Find(id);
            if (expenseFromDb == null)
            {
                return NotFound();
            }
            return View(expenseFromDb);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var obj = _db.ExpensesList.Find(id);
            if (obj == null)
            {
                return NotFound();
            }

            _db.ExpensesList.Remove(obj);//whenever you create a new 'todo' it will add it to the database, and save the change
            _db.SaveChanges();
            TempData["success"] = "Task deleted successfully";
            return RedirectToAction("Index");



        }
    }
}
