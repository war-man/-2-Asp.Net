using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kursach.Data.Entities
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Department_name { get; set; }

        public List<Employee> employees { get; set; }

        public List<Input_Documents> input_Documents { get; set; }
        public List<Output_Documents> output_Documents { get; set; }

        public int TypeOfDocumentId { get; set; }
        public TypeOfDocument type { get; set; }

        public Department()
        {
            input_Documents = new List<Input_Documents>();
            output_Documents = new List<Output_Documents>();
        }
    }
}
