using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kursach.Data.Entities
{
    public class Employee
    {
        
        public int EmployeeId { get; set; }
        public string employee_name { get; set; }

        public Department employee_department { get; set; }
        public int DepartmentId { get; set; }

        public Position employee_position { get; set; }
        public int PositionId { get; set; }

        public List<Input_Documents> input_Documents { get; set; }

        public List<Output_Documents> output_Documents { get; set; }
        public List<Interior_Document> interior_Documents_approver { get; set; }

        public List<Interior_Document> interior_Documents_executor { get; set; }

        public Employee()
        {
            input_Documents = new List<Input_Documents>();
            output_Documents = new List<Output_Documents>();
            interior_Documents_executor = new List<Interior_Document>();
            interior_Documents_approver = new List<Interior_Document>();
        }
    }
}
