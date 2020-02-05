using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kursach.Data;
using Kursach.Data.Entities;
using Kursach.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Kursach.Controllers
{
    public class DepartmentsController : Controller
    {
        private DocumentsDbContext _db;

        public DepartmentsController(DocumentsDbContext db)
        {
            _db = db;
        }
        public IActionResult Index(string sort, int page = 1)
        {
            int pageSize = 8;
            List<Department> departments;
            if (!string.IsNullOrEmpty(sort))
            {

                departments = _db.Departments.Include(x => x.type).Where(x => x.type.type_name.Contains(sort) || x.Department_name.Contains(sort)).ToList();
            }
            else
            {
                departments = _db.Departments.Include(x => x.type).ToList();
            }
            int count = departments.Count;
            List<Department> model = departments.Skip((page - 1) * 8).Take(pageSize).ToList();
            PaginationViewModel pagemodel = new PaginationViewModel(count, page, pageSize);
            return View(new PagempViewmodel { departments = model, pagination = pagemodel, sortparam = sort });
        }
        [HttpPost]
        public IActionResult Index(string sort, int page = 1, int x = 0)
        {
            var callbackUrl = Url.Action(
                        "Index",
                        "Departments",
                        new { sort = sort, page = page },
                        protocol: HttpContext.Request.Scheme);

            return Redirect(callbackUrl);
        }
        public IActionResult CreateDepartment()
        {
            SelectList types = new SelectList(_db.TypeOfDocuments.ToList(), "Id", "type_name");
            ViewBag.types = types;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateDepartment(Department department)
        {
            _db.Departments.Add(department);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> DeleteDepartment(int id)
        {
            Department department = _db.Departments.Find(id);
            _db.Departments.Remove(department);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> EditDepartment(int id)
        {
            List<TypeOfDocument> types = _db.TypeOfDocuments.ToList();
            ViewBag.types = types;
            Department department = _db.Departments.Find(id);
            return View(department);
        }
        [HttpPost]
        public async Task<IActionResult> EditDepartment(Department department)
        {
            _db.Departments.Update(department);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}