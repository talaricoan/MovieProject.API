//using MovieProject.API.Controllers.Models;
using MovieProject.API.Models;

namespace MovieProject.API
{
    public class MovieDataStore
    {
        public List<MovieDTO> Movies { get; set; }

        public static MovieDataStore Current { get; } = new MovieDataStore();

        public MovieDataStore()
        {
            Movies = new List<MovieDTO>()
            {
                new MovieDTO()
                {
                    Id = 1,
                    Title = "The Lord of the Rings: The Fellowship of the Ring",
                    Director = "Peter Jackson",
                    Description = "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.",
                    ReleaseDate = "2001",
                    Cast = new List<CastDTO>()
                    {
                        new CastDTO(){

                            Member1 = "Elijah Wood",
                            Member2 = "Ian Mckellen",
                            Member3 = "Orlando Bloom"},
                    },
                    Reviews = new List<ReviewDTO>()
                    {
                        new ReviewDTO()
                        {

                            Id = 1,
                            Name = "Sarah Horn",
                            Rating = 10,
                            Comment = "I watch this every Christmas! It's the best!",
                            IsVerified = true
                        },
                        new ReviewDTO()
                        {

                            Id = 2,
                            Name = "Andrew Talarico",
                            Rating = 10,
                            Comment = "I watch this every Christmas with my wife!",
                            IsVerified = true
                        },
                        new ReviewDTO()
                        {
                            Id = 3,
                            Name = "Jake Vermillion",
                            Rating = 5,
                            Comment = "I don't know how I feel about this movie.",
                            IsVerified = false
                        }
                    }
                },
                    new MovieDTO()
                    {
                        Id = 2,
                        Title = "Cats",
                        Director = "Nalla (The dog)",
                        Description = "A movie for cats, directed by cats, made by cats.",
                        ReleaseDate = "2022",
                        Cast = new List<CastDTO>()
                        {
                            new CastDTO()
                            {
                                Member1 = "Chip",
                                Member2 = "Misha",
                                Member3 = "Newt",
                            }
                        },
                        Reviews = new List<ReviewDTO>()
                        {
                            new ReviewDTO()
                            {
                                Id = 1,
                                Name = "Mr. Fish",
                                Rating = 10,
                                Comment = "I like this, meow.",
                                IsVerified = true
                            }
                        }
                    }
            };
        }
    }
}





            




