using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Kursach.Models;
using Kursach.Data;
using Kursach.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Kursach.Controllers
{
    public class HomeController : Controller
    {
        private DocumentsDbContext _db;

        public HomeController(DocumentsDbContext db)
        {
            _db = db;
        }
        public IActionResult Index(string sort,int page = 1)
        {
            int pageSize = 8;
            List<Employee> employees;
            if (!string.IsNullOrEmpty(sort))
            {
               
                employees = _db.Employees.Include(x=>x.employee_department).Include(x=> x.employee_position).Where(s => s.employee_name.Contains(sort) || s.employee_department.Department_name.Contains(sort) || s.employee_position.Name_of_position.Contains(sort) ||s.employee_position.AccessLevel.ToString().Contains(sort)).ToList();
            }
            else
            {
                employees = _db.Employees.Include(x => x.employee_department).Include(x => x.employee_position).ToList();
            }
            int count = employees.Count;
            List<Employee> model = employees.Skip((page - 1) * 8).Take(pageSize).ToList();
            PaginationViewModel pagemodel = new PaginationViewModel(count, page, pageSize);
            return View(new PagempViewmodel {employees=model, pagination=pagemodel , sortparam = sort});
        }
        [HttpPost]
        public IActionResult Index(string sort, int page = 1, int x = 0)
        {
            var callbackUrl = Url.Action(
                        "Index",
                        "Home",
                        new { sort = sort, page = page },
                        protocol: HttpContext.Request.Scheme);

            return Redirect(callbackUrl);
        }
        public IActionResult CreateEmployee()
        {
            SelectList departments = new SelectList(_db.Departments.ToList(), "DepartmentId", "Department_name");
            ViewBag.departments = departments;
            SelectList positions = new SelectList(_db.Positions.ToList(), "PositionId", "Name_of_position");
            ViewBag.positions = positions;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateEmployee(Employee employee)
        {
            _db.Employees.Add(employee);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            Employee employee = _db.Employees.Find(id);
            _db.Employees.Remove(employee);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> EditEmployee(int id)
        {
            
            ViewBag.departments = _db.Departments.ToList();
            
            ViewBag.positions = _db.Positions.ToList();

            Employee employee = _db.Employees.Find(id);
            return View(employee);
        }
        [HttpPost]
        public async Task<IActionResult> EditEmployee(Employee employee)
        {
                _db.Employees.Update(employee);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");

        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
