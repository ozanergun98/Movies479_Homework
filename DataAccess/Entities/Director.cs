#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Director //: Record
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        [DisplayName("Birth Date")]
        public DateTime? BirthDate { get; set; }

        [DisplayName("Is Retired?")]
        public bool IsRetired { get; set; }

        public List<Movie> Movies { get; set; }
    }
}
