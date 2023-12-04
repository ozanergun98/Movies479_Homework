#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Movie //: Record
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public short? Year { get; set; }

        [DisplayName("Revenue ($M)")]
        public double Revenue { get; set; }

        [DisplayName("Director")]
        public int? DirectorId { get; set; }

        //[DisplayName("Genre")]
        //public int? GenreId { get; set; }

        public Director Director { get; set; }

        //public Genre Genre { get; set; }
    }
}
