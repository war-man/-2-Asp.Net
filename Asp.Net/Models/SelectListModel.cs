using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kursach.Models
{
    public class SelectListModel
    {
        public SelectList Departments { get; set; }

        public SelectList Positions { get; set; }
    }
}
