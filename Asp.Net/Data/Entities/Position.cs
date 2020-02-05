using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kursach.Data.Entities
{
    public class Position
    {
        public int PositionId { get; set; }
        public int? AccessLevel { get; set; }

        public string Name_of_position { get; set; }

        public List<Employee> employees { get; set; }
        public Position()
        {
            employees = new List<Employee>();
        }

    }
}
