using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebApp.Requests
{
    public class AddReviewsRequest
    {
        public string Reviews { get; set; }
        public int Movie_Id { get; set; }
    }
}

