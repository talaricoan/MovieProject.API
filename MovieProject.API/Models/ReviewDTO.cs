using Microsoft.AspNetCore.Mvc;
using MovieProject.API.Models;


namespace MovieProject.API.Models
{
    public class ReviewDTO
    {
        public int Id { get; set; }

        public string Name { get; set; } = String.Empty;

        public int Rating { get; set; }

        public string? Comment { get; set; }

        public bool IsVerified { get; set; }


    }
}
