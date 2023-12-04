﻿#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Genre //: Record
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Movie> Movies { get; set; }
    }
}
