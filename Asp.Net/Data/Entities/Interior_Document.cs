using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Kursach.Data.Entities
{
    public class Interior_Document
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Interior_DocumentId {get;set;}
        public DateTime? Data_register { get; set; }
        public DateTime? DeadLine { get; set; }

        public string Status { get; set; }

        public string FileHref { get; set; }

       
        public TypeOfDocument Type { get; set; }

        public int? Access_Level { get; set; }

       
        public int? ApproverEmployeeId { get; set; }

        public int TypeId { get; set; }


        public Employee ApproverEmployee { get; set; }

        [ForeignKey("ExecutorEmployee")]
        public int? ExecutorEmployeeId { get; set; }

        [ForeignKey("department")]
        public int? DepartmentId { get; set; }

        public Department department { get; set; }

        

        [ForeignKey("ExecutorEmployeeId")]
        public Employee ExecutorEmployee { get; set; }
    }
}
