using Kursach.Data.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kursach.Models
{
    public class InputViewModel
    {
        public string department_name { get; set; }
        public string approver_name { get; set; }

        public string type_name { get; set; }
        public IFormFile File { get; set; }
        public int Input_DocumentsId { get; set; }
        public DateTime? Data_register { get; set; }
        public DateTime? DeadLine { get; set; }

        public int TypeId { get; set; }
        public string Status { get; set; }

        public string FileHref { get; set; }


        public TypeOfDocument Type { get; set; }

        public int? Access_Level { get; set; }

        [ForeignKey("Approver")]
        public int ApproverEmployeeId { get; set; }
        public Employee Approver { get; set; }

        public int? DepartmentId { get; set; }
        public Department department { get; set; }
    }
}
