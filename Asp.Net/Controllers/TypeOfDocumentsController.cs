using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kursach.Data;
using Kursach.Data.Entities;
using Kursach.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Kursach.Controllers
{
    public class TypeOfDocumentsController : Controller
    {
        private DocumentsDbContext _db;

        public TypeOfDocumentsController(DocumentsDbContext db)
        {
            _db = db;
        }
        public IActionResult Index(string sort, int page = 1)
        {
            int pageSize = 8;
            List<TypeOfDocument> typeOfDocuments;
            if (!string.IsNullOrEmpty(sort))
            {

                typeOfDocuments = _db.TypeOfDocuments.Include(x => x.departments).Include(x => x.input_Documents).Include(x => x.interior_Documents).Include(x => x.output_Documents).Where(x => x.type_name.Contains(sort)).ToList();
            }
            else
            {
                typeOfDocuments = _db.TypeOfDocuments.Include(x => x.departments).Include(x => x.input_Documents).Include(x => x.interior_Documents).Include(x => x.output_Documents).ToList();
            }
            int count = typeOfDocuments.Count;
            List<TypeOfDocument> model = typeOfDocuments.Skip((page - 1) * 8).Take(pageSize).ToList();
            PaginationViewModel pagemodel = new PaginationViewModel(count, page, pageSize);
            return View(new PagempViewmodel { typeOfDocuments = model, pagination = pagemodel, sortparam = sort });
            
        }
        [HttpPost]
        public IActionResult Index(string sort, int page = 1, int x = 0)
        {
            var callbackUrl = Url.Action(
                        "Index",
                        "TypeOfDocuments",
                        new { sort = sort, page = page },
                        protocol: HttpContext.Request.Scheme);

            return Redirect(callbackUrl);
        }
        public IActionResult CreateType()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateType(TypeOfDocument type)
        {
            _db.TypeOfDocuments.Add(type);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");

        }
        public async Task<IActionResult> DeleteType(int id)
        {
            TypeOfDocument type = _db.TypeOfDocuments.Find(id);
            _db.TypeOfDocuments.Remove(type);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> EditType(int id)
        {
            TypeOfDocument type = _db.TypeOfDocuments.Find(id);
            return View(type);
        }
        [HttpPost]
        public async Task<IActionResult> EditType(TypeOfDocument type)
        {
            _db.TypeOfDocuments.Update(type);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}