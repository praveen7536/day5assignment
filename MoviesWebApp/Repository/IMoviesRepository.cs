
using MoviesWebApp.Models;
using MoviesWebApp.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesWebApp.Repository
{
    public interface IMoviesRepository
    {
        bool AddMovie(AddMovieRequest request);
        
        bool AddLanguage(AddLanguageRequest request);
        bool AddReview(AddReviewsRequest request);
        List<Language> GetLanguages();
        List<string> GetReviews(int movieId);
        List<Movie> Getmoviesbylang(int languageId);







    }
}
