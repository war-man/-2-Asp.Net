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
using iTextSharp;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace Kursach.Controllers
{
    public class InteriorDocumentsController : Controller
    {
        private readonly IHostingEnvironment env;

        private DocumentsDbContext _db;

        public InteriorDocumentsController(DocumentsDbContext db, IHostingEnvironment env1)
        {
            env = env1;
            _db = db;
        }
        public IActionResult Index(string sort, int page = 1)
        {
            int pageSize = 8;
            List<Interior_Document> interior_Documents;
            if (!string.IsNullOrEmpty(sort))
            {

                interior_Documents = _db.Interior_Documents.Include(x => x.ApproverEmployee).ThenInclude(x => x.employee_department).Include(x => x.ExecutorEmployee).ThenInclude(x => x.employee_department).Include(x => x.Type).Include(x => x.department).Where(x => x.Access_Level.ToString().Contains(sort) || x.FileHref.Contains(sort) || x.Status.Contains(sort) || x.Type.type_name.Contains(sort) || x.ApproverEmployee.employee_name.Contains(sort) || x.ExecutorEmployee.employee_name.Contains(sort) || x.DeadLine.ToString().Contains(sort) || x.Data_register.ToString().Contains(sort) || x.department.Department_name.Contains(sort)).ToList();
            }
            else
            {
                interior_Documents = _db.Interior_Documents.Include(x => x.ApproverEmployee).ThenInclude(x => x.employee_department).Include(x => x.ExecutorEmployee).ThenInclude(x => x.employee_department).Include(x => x.department).Include(x => x.Type).ToList();
            }
            int count = interior_Documents.Count;
            List<Interior_Document> model = interior_Documents.Skip((page - 1) * 8).Take(pageSize).ToList();
            PaginationViewModel pagemodel = new PaginationViewModel(count, page, pageSize);
            return View(new PagempViewmodel { interior_Documents = model, pagination = pagemodel, sortparam = sort });
        }
        [HttpGet]
        public IActionResult Indexing(string sort, int page = 1, int x = 0)
        {
            var callbackUrl = Url.Action(
                        "Index",
                        "InteriorDocuments",
                        new { sort = sort, page = page },
                        protocol: HttpContext.Request.Scheme);

            return Redirect(callbackUrl);
        }
        [HttpGet]
        public IActionResult Downloading(string file)
        {
            string path = Path.Combine(env.WebRootPath, "imgrepository/" + file);
            FileStream fs = new FileStream(path, FileMode.Open);
            if (file[file.Length - 1].Equals('x'))
            {
                string file_type = "application/vnd.openxmlformats-officedocument.wordprocessingml.document";
                string file_name = "smth.docx";
                return File(fs, file_type, file_name);
            }
            else if (file[file.Length - 1].Equals('f'))
            {
                string file_type = "application/pdf";
                string file_name = "smth.docx";
                return File(fs, file_type, file_name);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
        public IActionResult PreCreate()
        {
            SelectList departments = new SelectList(_db.Departments.ToList(), "DepartmentId", "Department_name");
            ViewBag.departments = departments;
            return View();
        }
        [HttpPost]
        public IActionResult PreCreate(int Access_Level, int DepartmentId)
        {
            string redirectUrl = Url.Action("CreateInteriorDocument", "InteriorDocuments", new { Access_Level = Access_Level, DepartmentId = DepartmentId }, protocol: HttpContext.Request.Scheme);
            return Redirect(redirectUrl);
        }
        [HttpGet]
        public IActionResult CreateInteriorDocument(int Access_Level, int DepartmentId)
        {
            ViewBag.access = Access_Level;
            ViewBag.department = DepartmentId;
            List<Employee> employees1 = _db.Employees.Where(x => x.employee_position.AccessLevel >= Access_Level && x.employee_department.DepartmentId == DepartmentId).ToList();
            SelectList types = new SelectList(_db.TypeOfDocuments.ToList(), "Id", "type_name");
            ViewBag.types = types;
            SelectList employees = new SelectList(employees1, "EmployeeId", "employee_name");
            ViewBag.employees = employees;
            SelectList departments = new SelectList(_db.Departments.ToList(), "DepartmentId", "Department_name");
            ViewBag.departments = departments;
            return View();
        }
        [HttpPost]
        public IActionResult CreateInteriorDocument(InteriorViewModel model)
        {
            string filename = Path.GetFileName(model.File.FileName);
            string path = "/imgrepository/" + filename;
            using (var filestream = new FileStream(env.WebRootPath + path, FileMode.Create))
            {
                model.File.CopyTo(filestream);
            }
            Interior_Document document = new Interior_Document { Access_Level = model.Access_Level, ApproverEmployeeId = model.ApproverEmployeeId, ExecutorEmployeeId = model.ExecutorEmployeeId, DepartmentId = model.DepartmentId, TypeId = model.TypeId, Data_register = model.Data_register, DeadLine = model.DeadLine, FileHref = filename, Status = model.Status };
            _db.Interior_Documents.Add(document);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult DeleteDoc(int id)
        {
            Interior_Document document = _db.Interior_Documents.FirstOrDefault(x => x.Interior_DocumentId == id);
            _db.Interior_Documents.Remove(document);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult PreEditDocument(int id)
        {
            ViewBag.departments = _db.Departments.ToList();
            Interior_Document model = _db.Interior_Documents.FirstOrDefault(x => x.Interior_DocumentId == id);
            return View(model);
        }
        [HttpPost]
        public IActionResult PreEditDocument(int Interior_DocumentId, int Access_Level, int DepartmentId)
        {
            string redirectUrl = Url.Action("EditDocument", "InteriorDocuments", new { id = Interior_DocumentId, Access_Level = Access_Level, DepartmentId = DepartmentId }, protocol: HttpContext.Request.Scheme);
            return Redirect(redirectUrl);
        }
        [HttpGet]
        public IActionResult EditDocument(int id, int Access_Level, int DepartmentId)
        {

            ViewBag.type = _db.TypeOfDocuments.ToList();
            ViewBag.employeesexec = _db.Employees.Where(x => x.employee_position.AccessLevel >= Access_Level && x.employee_department.DepartmentId == DepartmentId).ToList();
            ViewBag.departments = _db.Departments.ToList();
            Interior_Document model = _db.Interior_Documents.FirstOrDefault(x => x.Interior_DocumentId == id);
            InteriorViewModel document = new InteriorViewModel { Interior_DocumentId = id, Access_Level = Access_Level, ApproverEmployeeId = model.ApproverEmployeeId, ExecutorEmployeeId = model.ExecutorEmployeeId, DepartmentId = DepartmentId, TypeId = model.TypeId, Data_register = model.Data_register, DeadLine = model.DeadLine, FileHref = model.FileHref, Status = model.Status };
            return View(document);
        }
        [HttpPost]
        public IActionResult EditDocument(InteriorViewModel model)
        {
            string filename = Path.GetFileName(model.File.FileName);
            string path = "/imgrepository/" + filename;
            using (var filestream = new FileStream(env.WebRootPath + path, FileMode.Create))
            {
                model.File.CopyTo(filestream);
            }
            Interior_Document document = new Interior_Document { Interior_DocumentId = model.Interior_DocumentId, Access_Level = model.Access_Level, ApproverEmployeeId = model.ApproverEmployeeId, ExecutorEmployeeId = model.ExecutorEmployeeId, DepartmentId = model.DepartmentId, TypeId = model.TypeId, Data_register = model.Data_register, DeadLine = model.DeadLine, FileHref = filename, Status = model.Status, };
            Update(document);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public void Update(Interior_Document entity)
        {
            if (entity == null)
            {
                throw new ArgumentException("Cannot add a null entity.");
            }

            var entry = _db.Entry<Interior_Document>(entity);

            if (entry.State == EntityState.Detached)
            {
                var set = _db.Set<Interior_Document>();
                Interior_Document attachedEntity = set.Local.FirstOrDefault(x => x.Interior_DocumentId == entity.Interior_DocumentId); ;

                if (attachedEntity != null)
                {
                    var attachedEntry = _db.Entry(attachedEntity);
                    attachedEntry.CurrentValues.SetValues(entity);
                }
                else
                {
                    entry.State = EntityState.Modified; // This should attach entity
                }
            }
        }

        public IActionResult EditStatus(int id)
        {
            Interior_Document doc = _db.Interior_Documents.FirstOrDefault(x => x.Interior_DocumentId == id);
            return View(doc);
        }
        [HttpPost]
        public IActionResult EditStatus(int Interior_DocumentId, string Status)
        {
            Interior_Document doc = _db.Interior_Documents.FirstOrDefault(x => x.Interior_DocumentId == Interior_DocumentId);
            doc.Status = Status;
            _db.Interior_Documents.Update(doc);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult OutPutReports()
        {
            List<Output_Documents> documents = _db.Output_Documents.Include(x => x.department).Include(x => x.Executor).Include(x => x.Type).ToList();
            return View(documents);
        }
        [HttpPost]
        public IActionResult OutPutReports(OutputViewModel model)
        {
            System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
            Document document1 = new Document(PageSize.A4, 10, 10, 10, 10);
            PdfWriter writer = PdfWriter.GetInstance(document1, memoryStream);
            writer.CloseStream = false;
            BaseFont baseFont2 = BaseFont.CreateFont(Environment.GetEnvironmentVariable("windir") + @"\fonts\arial.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            iTextSharp.text.Font font1 = new iTextSharp.text.Font(baseFont2, 10, 0);
            iTextSharp.text.Font font2 = new iTextSharp.text.Font(baseFont2, 20, 0);
            document1.Open();
            Paragraph paragraph1 = new Paragraph() { Font = font1 };
            Paragraph paragraph2 = new Paragraph() { Font = font1 };
            Paragraph paragraph3 = new Paragraph() { Font = font1 };
            Paragraph paragraph4 = new Paragraph() { Font = font1 };
            Paragraph paragraph5 = new Paragraph() { Font = font1 };
            Paragraph paragraph6 = new Paragraph() { Font = font2 };
            Paragraph paragraph = new Paragraph() { Font = font1 };
            paragraph6.Add("Отчет о выпущенном документе");
            document1.Add(paragraph6);
            paragraph.Add("Дата регистрации документа: " + model.Data_register);
            document1.Add(paragraph);
            paragraph1.Add("Дата выпуска документа: " + model.Date_of_Execution);
            document1.Add(paragraph1);
            paragraph2.Add("Компания которая занималась выпуском документа: " + model.department_name);
            document1.Add(paragraph2);
            paragraph3.Add("Работник компании, который занимался выпуском документа: " + model.executor_name);
            document1.Add(paragraph3);
            paragraph4.Add("Имя документа в файловой системе: " + model.FileHref);
            document1.Add(paragraph4);
            paragraph5.Add("Тип документа: " + model.type_name);
            document1.Add(paragraph5);
            document1.Close();


            memoryStream.Position = 0;
            return File(memoryStream, "application/pdf", "book2.pdf");
        }
        public IActionResult InputReports()
        {
            List<Input_Documents> documents = _db.input_Documents.Include(x => x.department).Include(x => x.Approver).Include(x => x.Type).ToList();
            return View(documents);
        }
        [HttpPost]
        public IActionResult InputReports(InputViewModel model)
        {
            System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
            Document document1 = new Document(PageSize.A4, 10, 10, 10, 10);
            PdfWriter writer = PdfWriter.GetInstance(document1, memoryStream);
            writer.CloseStream = false;
            BaseFont baseFont2 = BaseFont.CreateFont(Environment.GetEnvironmentVariable("windir") + @"\fonts\arial.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            iTextSharp.text.Font font1 = new iTextSharp.text.Font(baseFont2, 10, 0);
            iTextSharp.text.Font font2 = new iTextSharp.text.Font(baseFont2, 20, 0);
            document1.Open();
            Paragraph paragraph1 = new Paragraph() { Font = font1 };
            Paragraph paragraph2 = new Paragraph() { Font = font1 };
            Paragraph paragraph3 = new Paragraph() { Font = font1 };
            Paragraph paragraph4 = new Paragraph() { Font = font1 };
            Paragraph paragraph5 = new Paragraph() { Font = font1 };
            Paragraph paragraph6 = new Paragraph() { Font = font2 };
            Paragraph paragraph = new Paragraph() { Font = font1 };
            paragraph6.Add("Отчет о полученном документе");
            document1.Add(paragraph6);
            paragraph.Add("Дата регистрации документа: " + model.Data_register);
            document1.Add(paragraph);
            paragraph1.Add("Дедлайн: " + model.DeadLine);
            document1.Add(paragraph1);
            paragraph2.Add("Компания которая получила документ: " + model.department_name);
            document1.Add(paragraph2);
            paragraph3.Add("Работник компании, который занимался утверждением документа: " + model.approver_name);
            document1.Add(paragraph3);
            paragraph4.Add("Имя документа в файловой системе: " + model.FileHref);
            document1.Add(paragraph4);
            paragraph5.Add("Тип документа: " + model.type_name);
            document1.Add(paragraph5);
            document1.Close();
            memoryStream.Position = 0;
            return File(memoryStream, "application/pdf", "book2.pdf");
        }
        public IActionResult InteriorReports()
        {
            List<Interior_Document> interior_Documents = _db.Interior_Documents.Include(x => x.department).Include(x => x.ApproverEmployee).Include(x => x.ExecutorEmployee).Include(x => x.Type).ToList();
            return View(interior_Documents);
        }
        [HttpPost]
        public IActionResult InteriorReports(InteriorViewModel model)
        {
            System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();
            Document document1 = new Document(PageSize.A4, 10, 10, 10, 10);
            PdfWriter writer = PdfWriter.GetInstance(document1, memoryStream);
            writer.CloseStream = false;
            BaseFont baseFont2 = BaseFont.CreateFont(Environment.GetEnvironmentVariable("windir") + @"\fonts\arial.ttf", BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            iTextSharp.text.Font font1 = new iTextSharp.text.Font(baseFont2, 10, 0);
            iTextSharp.text.Font font2 = new iTextSharp.text.Font(baseFont2, 20, 0);
            document1.Open();
            Paragraph paragraph1 = new Paragraph() { Font = font1 };
            Paragraph paragraph2 = new Paragraph() { Font = font1 };
            Paragraph paragraph3 = new Paragraph() { Font = font1 };
            Paragraph paragraph4 = new Paragraph() { Font = font1 };
            Paragraph paragraph5 = new Paragraph() { Font = font1 };
            Paragraph paragraph6 = new Paragraph() { Font = font2 };
            Paragraph paragraph = new Paragraph() { Font = font1 };
            Paragraph paragraph10 = new Paragraph() { Font = font1 };
            paragraph10.Add("Работник компании, который занимался выполнением документа: " + model.executor_name);
            paragraph6.Add("Отчет об обработанном документе");
            document1.Add(paragraph6);
            paragraph.Add("Дата регистрации документа: " + model.Data_register);
            document1.Add(paragraph);
            paragraph1.Add("Дедлайн: " + model.DeadLine);
            document1.Add(paragraph1);
            paragraph2.Add("Компания которая работала с документом: " + model.department_name);
            document1.Add(paragraph2);
            paragraph3.Add("Работник компании, который занимался утверждением документа: " + model.approver_name);
            document1.Add(paragraph3);
            document1.Add(paragraph10);
            paragraph4.Add("Имя документа в файловой системе: " + model.FileHref);
            document1.Add(paragraph4);
            paragraph5.Add("Тип документа: " + model.type_name);
            document1.Add(paragraph5);
            document1.Close();
            memoryStream.Position = 0;
            return File(memoryStream, "application/pdf", "book2.pdf");
        }
        public IActionResult PreStatistics()
        {
            SelectList departments = new SelectList(_db.Departments.ToList(), "DepartmentId", "Department_name");
            ViewBag.departments = departments;
            return View();

        }
        [HttpPost]
        public IActionResult PreStatistics(int DepartmentId)
        {
            var callbackUrl = Url.Action(
                       "Statistics",
                       "InteriorDocuments",
                       new { id = DepartmentId },
                       protocol: HttpContext.Request.Scheme);

            return Redirect(callbackUrl);
        }
        public IActionResult Statistics(int id)
        {
            List<Employee> employees = _db.Employees.Include(x => x.input_Documents).Include(x => x.output_Documents).Include(x => x.interior_Documents_approver).Include(x => x.interior_Documents_executor).ToList();
            Dictionary<Employee, int> dict = new Dictionary<Employee, int>();
            foreach(var x in employees)
            {
                dict.Add(x, x.input_Documents.Count + x.interior_Documents_approver.Count + x.interior_Documents_executor.Count + x.output_Documents.Count);

            }
            return View(dict);
        }

    }
}