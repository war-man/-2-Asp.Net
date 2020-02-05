using Kursach.Data.Entities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kursach.Models
{
    public class OutputViewModel
    {
        public IFormFile File { get; set; }

        public string department_name { get; set; }
        public string executor_name { get; set; }

        public string type_name { get; set; }
        public int Output_DocumentsId { get; set; }
        public DateTime? Data_register { get; set; }
        public DateTime? Date_of_Execution { get; set; }

        public string Status { get; set; }

        public string FileHref { get; set; }


        public TypeOfDocument Type { get; set; }

        public int? Access_Level { get; set; }

        public int TypeId { get; set; }

        public int ApproverEmployeeId { get; set; }
        public Employee Approver { get; set; }

        public int DepartmentId { get; set; }
        public Department departmentTo { get; set; }
    }
}
