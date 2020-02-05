using Kursach.Data.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kursach.Models
{
    public class InteriorViewModel
    {
     
        public int Interior_DocumentId { get; set; }
        public DateTime? Data_register { get; set; }
        public DateTime? DeadLine { get; set; }

        public string Status { get; set; }

        public string FileHref { get; set; }


        public TypeOfDocument Type { get; set; }

        public int? Access_Level { get; set; }

        public string department_name { get; set; }
        public string approver_name { get; set; }

        public string type_name { get; set; }

        public string executor_name { get; set; }


        public int? ApproverEmployeeId { get; set; }


        public Employee ApproverEmployee { get; set; }

       
        public int? ExecutorEmployeeId { get; set; }

        
        public int? DepartmentId { get; set; }

        public Department department { get; set; }

        public int TypeId { get; set; }
        public IFormFile File { get; set; }
        public Employee ExecutorEmployee { get; set; }
    }
}
