#nullable disable

using System.ComponentModel.DataAnnotations;
using System.IO;

namespace Business.Models
{
    public class MovieModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public short? Year { get; set; }

        public double Revenue { get; set; }

        public int? DirectorId { get; set; }
        //public int? GenreId { get; set; }

        //public string GenreOutput { get; set; }

        public string DirectorOutput { get; set; }
    }
}
