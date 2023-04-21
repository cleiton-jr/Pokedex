using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokedex.Models
{
    public class DetailDto
    {
        public Pokemon Prior { get; set; }
        public Pokemon Current { get; set; }
        public Pokemon Next { get; set; }
    }
}