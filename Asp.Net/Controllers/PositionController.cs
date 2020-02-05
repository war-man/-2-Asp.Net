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
    public class PositionController : Controller
    {
        private DocumentsDbContext _db;

        public PositionController(DocumentsDbContext db)
        {
            _db = db;
        }
        public IActionResult Index(string sort, int page = 1)
        {
            int pageSize = 8;
            List<Position> positions;
            if (!string.IsNullOrEmpty(sort))
            {

                positions = _db.Positions.Include(x => x.employees).Where(x => x.Name_of_position.Contains(sort) || x.AccessLevel.ToString().Contains(sort) ).ToList();
            }
            else
            {
                positions = _db.Positions.Include(x => x.employees).ToList();
            }
            int count = positions.Count;
            List<Position> model = positions.Skip((page - 1) * 8).Take(pageSize).ToList();
            PaginationViewModel pagemodel = new PaginationViewModel(count, page, pageSize);
            return View(new PagempViewmodel { positions = model, pagination = pagemodel, sortparam = sort });
            
        }
        [HttpPost]
        public IActionResult Index(string sort, int page = 1, int x = 0)
        {
            var callbackUrl = Url.Action(
                        "Index",
                        "Position",
                        new { sort = sort, page = page },
                        protocol: HttpContext.Request.Scheme);

            return Redirect(callbackUrl);
        }
        public IActionResult CreatePosition()
        {

            return View();
        }
        [HttpPost]
            public async Task<IActionResult> CreatePosition(Position position)
        {
            _db.Positions.Add(position);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
           
        }
        public async Task<IActionResult> DeletePosition(int id)
        {
            Position position = _db.Positions.Find(id);
            _db.Positions.Remove(position);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> EditPosition(int id)
        {
            Position position = _db.Positions.Find(id);
            return View(position);
        }
        [HttpPost]
        public async Task<IActionResult> EditPosition(Position position)
        {
            _db.Positions.Update(position);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

    }
}