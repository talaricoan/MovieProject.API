using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using MovieProject.API.Models;


namespace MovieProject.API.Models
{
    public class MovieForCreationDTO
    {
        [Required(ErrorMessage = "You must provide a name.")]
        [MaxLength(20)]
        public string Name { get; set; } = string.Empty;

        //[MaxLength(200)]
        public int Rating { get; set; }

        public string? Comment { get; set; }

        public bool? IsVerified { get; set; }

    }
}
