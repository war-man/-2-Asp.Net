using Kursach.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kursach.Models
{
    public class PagempViewmodel
    {
        public PaginationViewModel pagination { get; set; }

        public List<Employee> employees { get; set; }

        public List<Position> positions { get; set; }

        public List<TypeOfDocument> typeOfDocuments { get; set; }

        public List<Interior_Document> interior_Documents { get; set; }

        public List<Output_Documents> output_Documents { get; set; }

        public List<Input_Documents> input_Documents { get; set; }

        public List<Department> departments { get; set; }

        public string sortparam { get; set; }
    }
}
