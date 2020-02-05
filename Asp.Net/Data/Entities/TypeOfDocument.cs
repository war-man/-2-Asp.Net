using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kursach.Data.Entities
{
    public class TypeOfDocument
    {
        public int Id { get; set; }
        public string type_name { get; set; }
        public List<Input_Documents> input_Documents { get; set; }

        public List<Output_Documents> output_Documents { get; set; }
        public List<Interior_Document> interior_Documents { get; set; }

        public List<Department> departments { get; set; }

        public TypeOfDocument()
        {
            input_Documents = new List<Input_Documents>();
            output_Documents = new List<Output_Documents>();
            interior_Documents = new List<Interior_Document>();
            departments = new List<Department>();
        }

    }
}
