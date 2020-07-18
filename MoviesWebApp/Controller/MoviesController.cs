using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviesWebApp.Repository;
using MoviesWebApp.Requests;

namespace MoviesWebApp.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly IMoviesRepository repository;
        public MoviesController(IMoviesRepository repository)
        {
            this.repository = repository;

        }
       
        [HttpPost("AddLanguage")]
        public IActionResult AddLanguage(AddLanguageRequest data)
        {
            return Ok(repository.AddLanguage(data));
        }
        [HttpPost("AddMovie")]
        public IActionResult AddMovie(AddMovieRequest data)
        {
            return Ok(repository.AddMovie(data));
        }

        [HttpPost("AddReview")]
        public IActionResult AddReview(AddReviewsRequest data)
        {
            return Ok(repository.AddReview(data));
        }
        [HttpGet("GetLanguages")]
        public IActionResult GetLanguages()
        {
            return Ok(repository.GetLanguages());
        }
        [HttpGet("GetReviews")]
        public IActionResult GetReviews(int movieid)
        {
            if(movieid==0)
            {
                return BadRequest();
            }
            return Ok(repository.GetReviews(movieid));
        }
        [HttpGet("GetMoviesbylang")]
        public IActionResult GetMoviesbylang(int languageId)
        {
            if (languageId == 0)
            {
                return BadRequest();
            }
            return Ok(repository.Getmoviesbylang(languageId));
        }





    }
}
