#nullable disable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Entities
{
    [PrimaryKey(nameof(MovieId), nameof(GenreId))]
    public class MovieGenre //: Record
    {
        //[Key]
        //[Column(Order = 0)]
        public int MovieId { get; set; }

        public Movie Movie { get; set; }

        //[Key]
        //[Column(Order = 1)]
        public int GenreId { get; set; }

        public Genre Genre { get; set; }
    }
}
