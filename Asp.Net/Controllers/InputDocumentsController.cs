using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Kursach.Data;
using Kursach.Data.Entities;
using Kursach.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Kursach.Controllers
{
    public class InputDocumentsController : Controller
    {
        private readonly IHostingEnvironment env;

        private DocumentsDbContext _db;

        public InputDocumentsController(DocumentsDbContext db, IHostingEnvironment env1)
        {
            env = env1;
            _db = db;
        }
        public IActionResult Index(string sort, int page = 1)
        {
            int pageSize = 8;
            List<Input_Documents> input_Documents;
            if (!string.IsNullOrEmpty(sort))
            {

                input_Documents = _db.input_Documents.Include(x => x.department).Include(x => x.Approver).Include(x=>x.Type).Where(x => x.Access_Level.ToString().Contains(sort) || x.FileHref.Contains(sort) || x.Status.Contains(sort) || x.Type.type_name.Contains(sort) || x.Approver.employee_name.Contains(sort) || x.DeadLine.ToString().Contains(sort) || x.Data_register.ToString().Contains(sort) || x.department.Department_name.Contains(sort)).ToList();
            }
            else
            {
                input_Documents = _db.input_Documents.Include(x => x.department).Include(x => x.Approver).Include(x => x.Type).ToList();
            }
            int count = input_Documents.Count;
            List<Input_Documents> model = input_Documents.Skip((page - 1) * 8).Take(pageSize).ToList();
            PaginationViewModel pagemodel = new PaginationViewModel(count, page, pageSize);
            return View(new PagempViewmodel { input_Documents = model, pagination = pagemodel, sortparam = sort });
        }
        [HttpGet]
        public IActionResult Indexing(string sort, int page = 1, int x = 0)
        {
            var callbackUrl = Url.Action(
                        "Index",
                        "InputDocuments",
                        new { sort = sort, page = page },
                        protocol: HttpContext.Request.Scheme);

            return Redirect(callbackUrl);
        }
        public IActionResult PreCreate()
        {
            SelectList departments = new SelectList(_db.Departments.ToList(), "DepartmentId", "Department_name");
            ViewBag.departments = departments;
            return View();
        }
        [HttpPost]
        public IActionResult PreCreate(int Access_Level, int DepartmentId  )
        {
            string redirectUrl = Url.Action("CreateinputDocument", "InputDocuments", new { Access_Level = Access_Level, DepartmentId = DepartmentId }, protocol: HttpContext.Request.Scheme);
            return Redirect(redirectUrl);
        }
        public IActionResult CreateinputDocument(int Access_Level, int DepartmentId, int smth)
        {
            ViewBag.access = Access_Level;
            ViewBag.department = DepartmentId;
            List<Employee> employees1 = _db.Employees.Where(x => x.employee_position.AccessLevel >= Access_Level && x.employee_department.DepartmentId == DepartmentId).ToList();
            SelectList types = new SelectList(_db.TypeOfDocuments.ToList(), "Id", "type_name");
            ViewBag.types = types;
            SelectList employees = new SelectList(employees1, "EmployeeId", "employee_name");
            ViewBag.employees = employees;
            return View();

        }
        [HttpPost]
        public IActionResult CreateinputDocument(InputViewModel model)
        {
            string filename = Path.GetFileName(model.File.FileName);
            string path = "/imgrepository/" + filename;
            using (var filestream = new FileStream(env.WebRootPath + path, FileMode.Create))
            {
                model.File.CopyTo(filestream);
            }
            Input_Documents document = new Input_Documents { Access_Level = model.Access_Level, ApproverEmployeeId= model.ApproverEmployeeId, TypeId = model.TypeId, DepartmentId = model.DepartmentId, Data_register = model.Data_register, DeadLine = model.DeadLine, FileHref = filename, Status = model.Status };
            _db.input_Documents.Add(document);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult DeleteDoc(int id)
        {
            Input_Documents document = _db.input_Documents.FirstOrDefault(x => x.Input_DocumentsId == id);
            _db.input_Documents.Remove(document);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult EditStatus(int id)
        {
            Input_Documents doc = _db.input_Documents.Find(id);
            return View(doc);
        }
        [HttpPost]
        public IActionResult EditStatus(int Input_DocumentId, string Status)
        {
            Input_Documents doc = _db.input_Documents.Find(Input_DocumentId);
            doc.Status = Status;
            _db.input_Documents.Update(doc);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}