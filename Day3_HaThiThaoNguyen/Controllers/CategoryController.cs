using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Day3_HaThiThaoNguyen.Models;
using System.Reflection.Metadata.Ecma335;
namespace Day3_HaThiThaoNguyen.Controllers
{
    //gia lsp csdl
    public class CategoryController : Controller
    {
        private static List<Category> _categories = new List<Category>()
    {
        new Category() { Id = 1, Name = "Category 1" },
        new Category() { Id = 2, Name = "Category 2" },
        new Category()   { Id = 3, Name = "Category 3" }
    };
        // GET: Category
        public ActionResult Index()
        {
            return View(_categories);
        }

        // GET: Category/Details/5
        public ActionResult Details(int id)
        {
            var category = _categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);

        }

        // GET: Category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Category/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] Category category)
        {
            if (ModelState.IsValid)
            {
                //Them category vao danh sach
                //Tao Id moiw cho category = max Id hien tai
                int newId = _categories.Max(c => c.Id) + 1;
                _categories.Add(category);
                return RedirectToAction(nameof(Index));
            }

            return View(category);

        }

        // GET: Category/Edit/5
        public ActionResult Edit(int id)
        {
            // Tim category theo id
            var category = _categories.FirstOrDefault(c => c.Id == id);
            // Neu khong tim thay category, tra ve NotFound
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: Category/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Category category)
        {
            var existingCatetory = _categories.FirstOrDefault(c => c.Id == category.Id);
            if (existingCatetory == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                existingCatetory.Name = category.Name;
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        // GET: Category/Delete/5
        public ActionResult Delete(int id)
        {
            var category = _categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: Category/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var category = _categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            _categories.Remove(category);
            return RedirectToAction(nameof(Index));
            {
                return View();
            }
        }
        
    }
}