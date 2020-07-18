using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebApp.Requests
{
    public class AddMovieRequest
    {
        public string Name { get; set; }
        public  string Director { get; set; }
        public int Year { get; set; }

        public int LanguageId { get; set; }


    }   
}
