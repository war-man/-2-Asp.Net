using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kursach.Data.Entities
{
    public class Output_Documents
    {
        public int Output_DocumentsId { get; set; }
        public DateTime? Data_register { get; set; }
        public DateTime? Date_of_Execution { get; set; }

        public string Status { get; set; }

        public string FileHref { get; set; }

        [ForeignKey("Executor")]
        public int ExecutorEmployeeId { get; set; }
       
        public int TypeId { get; set; }
        public TypeOfDocument Type { get; set; }

        public int? Access_Level { get; set; }

        
       
        public Employee Executor { get; set; }

        public int DepartmentId { get; set; }
        public Department department { get; set; }
    }
}
