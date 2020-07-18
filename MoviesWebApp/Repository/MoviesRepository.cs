
using MoviesWebApp.Models;
using MoviesWebApp.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MoviesWebApp.Repository
{
    public class MoviesRepository : IMoviesRepository
    {
        private readonly MoviesDbContext _db;
        public MoviesRepository(MoviesDbContext db)
        {
            this._db = db;
        }
        public bool AddMovie(AddMovieRequest request)
        {
            if(request !=null)
            {
                Movie movie = new Movie();
                movie.Name = request.Name;
                movie.Year = request.Year;
                movie.Director = request.Director;
                movie.LanguageId = request.LanguageId;

                _db.Movies.Add(movie);
                _db.SaveChanges();

                return true;

            }
            return false;

          
        }
        public bool AddLanguage(AddLanguageRequest request)
        {
            if (request != null)
            {
                Language language = new Language();
                language.Name = request.Name;
                

                _db.Languages.Add(language);
                _db.SaveChanges();

                return true;

            }
            return false;


        }
        public bool AddReview(AddReviewsRequest request)
        {
            if (request != null)
            {
                Review review = new Review();
                review.Reviews = request.Reviews;
                review.MovieId = request.Movie_Id;


                _db.Reviews.Add(review);
                _db.SaveChanges();

                return true;

            }
            return false;


        }
        public List<Language> GetLanguages()
        {
            List<Language> languages = new List<Language>();
            
            languages = _db.Languages.ToList();
            
            return languages;

        }
        public List<string> GetReviews(int movieId)
        {
            
            List<string> reviews = new List<string>();
            reviews = _db.Reviews.Where(a => a.MovieId == movieId).Select(m=>m.Reviews).ToList();


            return reviews;

        }
        public List<Movie> Getmoviesbylang(int languageId)
        {
            List<Movie> movies = new List<Movie>();

            movies = _db.Movies.Where(a => a.LanguageId == languageId).ToList();

            return movies;

        }


    }
}
