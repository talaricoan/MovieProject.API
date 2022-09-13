using Microsoft.AspNetCore.Mvc;
using MovieProject.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.JsonPatch;


namespace MovieProject.API.Controllers
{
    [ApiController]
    [Route("api/movies")]
    public class MoviesController : ControllerBase
    {
        [HttpGet]

        public ActionResult<IEnumerable<MovieDTO>> GetMovies()
        {
            return Ok(MovieDataStore.Current.Movies);
        }

        [HttpGet("{id}")]

        public ActionResult<MovieDTO> GetMovie(int id)
        {
            var movieToReturn = MovieDataStore.Current.Movies
                    .FirstOrDefault(c => c.Id == id);
            if (movieToReturn == null)
            {
                return NotFound();
            }
            return Ok(movieToReturn);
        }
        //[HttpPost]

        //public ActionResult<MovieForCreationDTO> PostMovie(
        //    int movieId,
        //    MovieForCreationDTO MovieCreation)
        //{
        //    var movie = MovieDataStore.Current.Movies.FirstOrDefault(c => c.Id == movieId);
        //    if (movie == null)
        //    {
        //        return NotFound();
        //    }

        //    var maxMovieId = MovieDataStore.Current.Movies.SelectMany(
        //            c => c.Id).Max(p => p.Id);
            
        //    var finalMovie = new MovieDTO()
        //    {
        //        Id = ++maxMovieId,
        //        Title = MovieCreation.Name,
        //        Description = MovieCreation.Description,
        //    };
        //    movie.TheMovies.Add(finalMovie);

        //    return CreatedAtRoute("GetMovies",
        //           new
        //           {
        //               movieId = movieId,
        //           },
        //           finalMovie);
        //}

        //[HttpDelete("{movieId}")]

        //public ActionResult DeleteMovie(int movieID)
        //{
        //    var movie = MovieDataStore.Current.Movies
        //        .FirstOrDefault(c => c.Id == movieID);
        //    if (movie == null)
        //    {
        //        return NotFound();
        //    }
        //    var pointOfInterestFromStore = movie
        //        .FirstOrDefault(c => c.Id == pointOfInterestId);
        //    if (pointOfInterestFromStore == null)
        //    {
        //        return NotFound();
        //    }

        //    //movie.PointsOfInterest.Remove(pointOfInterestFromStore);
        //    return NoContent();

        //}
    }
}

