using Bulky.DataAccess.Data;
using Bulky.DataAccess.RepositoryBase.IRepository;
using Bulky.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BulkyWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly IUniteOfWork _uniteOfWork;
        public CategoryController(IUniteOfWork uniteOfWork)
        {
            _uniteOfWork = uniteOfWork;
        }
        public IActionResult Index()
        {
            List<Category> categoriesList = _uniteOfWork.categoryRepo.GetAll().ToList();
            return View(categoriesList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                _uniteOfWork.categoryRepo.Add(category);
                _uniteOfWork.save();
                TempData["success"] = "Category created successfully";
                return RedirectToAction("Index");
            }
            return View();
        }


        public IActionResult Edit(int? id)
        {
            if (id == null || id <= 0)
                return NotFound();
            var categoryDb = _uniteOfWork.categoryRepo.Get(c => c.CategoryId == id);
            if (categoryDb == null)
                return NotFound();
            return View(categoryDb);
        }

        [HttpPost]
        public IActionResult Edit(Category category)
        {
            if (ModelState.IsValid)
            {
                _uniteOfWork.categoryRepo.Update(category);
                _uniteOfWork.save();
                TempData["success"] = "Category Edited successfully";
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id <= 0)
                return NotFound();
            var categoryDb = _uniteOfWork.categoryRepo.Get(c => c.CategoryId == id);
            if (categoryDb == null)
                return NotFound();
            return View(categoryDb);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
            Category categoryDb = _uniteOfWork.categoryRepo.Get(c => c.CategoryId == id);
            if (categoryDb == null)
                return NotFound();
            _uniteOfWork.categoryRepo.Delete(categoryDb);
            _uniteOfWork.save();
            TempData["success"] = "Category Deleated successfully";
            return RedirectToAction("Index");
        }

    }
}
