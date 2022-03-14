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
    public class AddTodoController : Controller
    {
        public readonly ApplicationDbContext _db;

        public AddTodoController(ApplicationDbContext db) {
            _db = db;
       }
        public IActionResult Index()
        {
            IEnumerable<TodoCategory> objTodoList = _db.Categories;// retrieve all the categories from the table.
            return View(objTodoList);
        }
        //get action method
        public IActionResult Create()
        {
            
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TodoCategory obj)
        {
            if(obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "The Display Order cannot exactly match the Name.");
            }
            if (ModelState.IsValid)
            {
            _db.Categories.Add(obj);//whenever you create a new 'todo' it will add it to the database, and save the change
            _db.SaveChanges();
                TempData["success"] = "Task created successfully";
                    return RedirectToAction("Index");
            }

            return View(obj);
        }




        public IActionResult Edit(int? id)
        {
            if(id==null || id == 0)
            {
                return NotFound();
            }
            var categoryFromDb = _db.Categories.Find(id);
            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(TodoCategory obj)
        {
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                ModelState.AddModelError("name", "The Display Order cannot exactly match the Name.");
            }
            if (ModelState.IsValid)
            {
                _db.Categories.Update(obj);//whenever you create a new 'todo' it will add it to the database, and save the change
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
            var categoryFromDb = _db.Categories.Find(id);
            if (categoryFromDb == null)
            {
                return NotFound();
            }
            return View(categoryFromDb);
        }
        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeletePOST(int? id)
        {
            var obj = _db.Categories.Find(id);
            if (obj == null)
            {
                return NotFound();
            }
           
                _db.Categories.Remove(obj);//whenever you create a new 'todo' it will add it to the database, and save the change
                _db.SaveChanges();
            TempData["success"] = "Task deleted successfully";
            return RedirectToAction("Index");
            

    
        }
    }
}
