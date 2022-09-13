using Microsoft.AspNetCore.Mvc;
using MovieProject.API.Models;

namespace MovieProject.API.Models
{
    public class MovieDTO
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string? Description { get; set; }

        public string Director { get; set; } = string.Empty;

        public string ReleaseDate { get; set; } = string.Empty;


        public int NumberOfCast
        {
            get
            {
                return Cast.Count;
            }
        }
        public int NumberOfReviews
        {
            get
            {
                return Reviews.Count;
            }
        }
        public ICollection<ReviewDTO> Reviews { get; set; }
            = new List<ReviewDTO>();

        public ICollection<CastDTO> Cast { get; set; }
            = new List<CastDTO>();

        //public ICollection<MovieDTO> TheMovies { get; set; }
        //    = new List<MovieDTO>();
    }
}
