using MovieProject.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;


namespace MovieProject.API.Controllers
{
    [ApiController]
    [Route("api/movies/{movieId}/reviews")]

    public class ReivewController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<ReivewController>> GetReviews(int movieId)
        {
            var movie = MovieDataStore.Current.Movies.FirstOrDefault(c => c.Id == movieId);

            if (movie == null)
            {
                return NotFound();
            }

            return Ok(movie.Reviews);
        }
        [HttpGet("{movieReviewid}", Name = "GetMovieReview")]

        public ActionResult<ReviewDTO> GetMovieReview(
        int movieId, int reviewId)
        {

            var movie = MovieDataStore.Current.Movies
                    .FirstOrDefault(c => c.Id == movieId);
            if (movie == null)
            {
                return NotFound();
            }
            var actualReview = movie.Reviews
                .FirstOrDefault(c => c.Id == reviewId);
            if (actualReview == null)
            {
                return NotFound();

            }
            return Ok(actualReview);
        }
        [HttpPost]

        public ActionResult<ReviewDTO> CreateReview(
            int movieId,
            MovieForCreationDTO movieReview)
        {
            var movie = MovieDataStore.Current.Movies.FirstOrDefault(c => c.Id == movieId);
            if (movie == null)
            {
                return NotFound();
            }

            var maxReviewId = MovieDataStore.Current.Movies.SelectMany(
                    c => c.Reviews).Max(p => p.Id);

            var finalMovieReview = new ReviewDTO()
            {
                Id = ++maxReviewId,
                Name = movieReview.Name,
                Comment = movieReview.Comment,
                Rating = movieReview.Rating,
                IsVerified = true,
            };
            movie.Reviews.Add(finalMovieReview);

            return CreatedAtRoute("GetMovieReview",
                new
                {
                    movieId = movieId,
                    movieReviewid = finalMovieReview.Id
                },
                finalMovieReview);
        }
        [HttpDelete("{movieId}")]

        public ActionResult DeleteMovieReview(int movieId, int ReviewId)
        {
            var movie = MovieDataStore.Current.Movies
                .FirstOrDefault(c => c.Id == movieId);
            if (movie == null)
            {
                return NotFound();
            }
            var movieReviewFromLoc = movie.Reviews
                .FirstOrDefault(c => c.Id == ReviewId);
            if (movieReviewFromLoc == null)
            {
                return NotFound();
            }

            movie.Reviews.Remove(movieReviewFromLoc);
            return NoContent();

        }

    }
}

