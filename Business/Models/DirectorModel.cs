#nullable disable

using System.ComponentModel.DataAnnotations;
using System.IO;

namespace Business.Models
{
    public class DirectorModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public DateTime? BirthDate { get; set; }

        public bool IsRetired { get; set; }
    }
}
