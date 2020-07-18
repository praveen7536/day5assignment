using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebApp.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Name { get; set; }

        public int Year { get; set; }

        public string Director { get; set; }

        //public List<Review> Reviews { get; set; }
        public Language Language { get; set; }

        public int LanguageId { get; set; }
       







    }
}
