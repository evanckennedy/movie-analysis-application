using Microsoft.AspNetCore.Mvc;
using movie_analysis_application.Models;

namespace movie_analysis_application.Controllers
{
    public class MovieAnalysisController : Controller
    {
        private static List<Movie> Movies = new List<Movie>
        {
            new Movie { MovieId = 1, Title = "The Shawshank Redemption", Budget = 25000000, ReleaseYear = 1994, Category = "Drama" },
            new Movie { MovieId = 2, Title = "The Godfather", Budget = 6000000, ReleaseYear = 1972, Category = "Crime" },
            new Movie { MovieId = 3, Title = "The Dark Knight", Budget = 185000000, ReleaseYear = 2008, Category = "Action" },
            new Movie { MovieId = 4, Title = "Schindler's List", Budget = 22000000, ReleaseYear = 1993, Category = "Biography" },
            new Movie { MovieId = 5, Title = "Pulp Fiction", Budget = 8000000, ReleaseYear = 1994, Category = "Crime" },
            new Movie { MovieId = 6, Title = "The Lion King", Budget = 45000000, ReleaseYear = 1994, Category = "Animation" },
            new Movie { MovieId = 7, Title = "Fight Club", Budget = 63000000, ReleaseYear = 1999, Category = "Drama" },
            new Movie { MovieId = 8, Title = "Forrest Gump", Budget = 55000000, ReleaseYear = 1994, Category = "Drama" },
            new Movie { MovieId = 9, Title = "Inception", Budget = 160000000, ReleaseYear = 2010, Category = "Sci-Fi" },
            new Movie { MovieId = 10, Title = "The Matrix", Budget = 63000000, ReleaseYear = 1999, Category = "Sci-Fi" }
        };

        private static List<Rating> Ratings = new List<Rating>
        {
            new Rating { MovieId = 1, Stars = 5 },
            new Rating { MovieId = 1, Stars = 4 },
            new Rating { MovieId = 1, Stars = 3 },
            new Rating { MovieId = 1, Stars = 5 },
            new Rating { MovieId = 2, Stars = 5 },
            new Rating { MovieId = 2, Stars = 4 },
            new Rating { MovieId = 2, Stars = 4 },
            new Rating { MovieId = 2, Stars = 5 },
            new Rating { MovieId = 3, Stars = 5 },
            new Rating { MovieId = 3, Stars = 4 },
            new Rating { MovieId = 3, Stars = 3 },
            new Rating { MovieId = 3, Stars = 4 },
            new Rating { MovieId = 4, Stars = 5 },
            new Rating { MovieId = 4, Stars = 3 },
            new Rating { MovieId = 4, Stars = 4 },
            new Rating { MovieId = 4, Stars = 5 },
            new Rating { MovieId = 5, Stars = 4 },
            new Rating { MovieId = 5, Stars = 3 },
            new Rating { MovieId = 5, Stars = 5 },
            new Rating { MovieId = 5, Stars = 4 },
            new Rating { MovieId = 6, Stars = 5 },
            new Rating { MovieId = 6, Stars = 4 },
            new Rating { MovieId = 6, Stars = 3 },
            new Rating { MovieId = 6, Stars = 4 },
            new Rating { MovieId = 7, Stars = 4 },
            new Rating { MovieId = 7, Stars = 5 },
            new Rating { MovieId = 7, Stars = 3 },
            new Rating { MovieId = 7, Stars = 4 },
            new Rating { MovieId = 8, Stars = 5 },
            new Rating { MovieId = 8, Stars = 3 },
            new Rating { MovieId = 8, Stars = 4 },
            new Rating { MovieId = 8, Stars = 5 },
            new Rating { MovieId = 9, Stars = 5 },
            new Rating { MovieId = 9, Stars = 4 },
            new Rating { MovieId = 9, Stars = 5 },
            new Rating { MovieId = 9, Stars = 4 },
            new Rating { MovieId = 10, Stars = 5 },
            new Rating { MovieId = 10, Stars = 4 },
            new Rating { MovieId = 10, Stars = 4 },
            new Rating { MovieId = 10, Stars = 5 }
        };

        private static List<MovieActors> MovieActors = new List<MovieActors>
        {
            new MovieActors { MovieId = 1, ActorId = 1 },
            new MovieActors { MovieId = 1, ActorId = 2 },
            new MovieActors { MovieId = 2, ActorId = 3 },
            new MovieActors { MovieId = 2, ActorId = 4 },
            new MovieActors { MovieId = 3, ActorId = 5 },
            new MovieActors { MovieId = 3, ActorId = 6 },
            new MovieActors { MovieId = 4, ActorId = 7 },
            new MovieActors { MovieId = 5, ActorId = 8 },
            new MovieActors { MovieId = 6, ActorId = 9 },
            new MovieActors { MovieId = 7, ActorId = 10 },
            new MovieActors { MovieId = 8, ActorId = 11 },
            new MovieActors { MovieId = 9, ActorId = 12 },
            new MovieActors { MovieId = 10, ActorId = 13 }
        };

        private static List<Actor> Actors = new List<Actor>
        {
            new Actor { ActorId = 1, Name = "Tim Robbins", Salary = 10000000 },
            new Actor { ActorId = 2, Name = "Morgan Freeman", Salary = 15000000 },
            new Actor { ActorId = 3, Name = "Marlon Brando", Salary = 12000000 },
            new Actor { ActorId = 4, Name = "Al Pacino", Salary = 14000000 },
            new Actor { ActorId = 5, Name = "Christian Bale", Salary = 20000000 },
            new Actor { ActorId = 6, Name = "Heath Ledger", Salary = 15000000 },
            new Actor { ActorId = 7, Name = "Liam Neeson", Salary = 11000000 },
            new Actor { ActorId = 8, Name = "John Travolta", Salary = 10000000 },
            new Actor { ActorId = 9, Name = "Matthew Broderick", Salary = 8000000 },
            new Actor { ActorId = 10, Name = "Brad Pitt", Salary = 18000000 },
            new Actor { ActorId = 11, Name = "Tom Hanks", Salary = 25000000 },
            new Actor { ActorId = 12, Name = "Leonardo DiCaprio", Salary = 30000000 },
            new Actor { ActorId = 13, Name = "Keanu Reeves", Salary = 15000000 }
        };

        public IActionResult Index()
        {
            return View(Movies);
        }

        public IActionResult GetAllMoviesInCategory (string category)
        {
            var moviesInCategory = Movies.Where(m => m.Category.Equals(category, StringComparison.OrdinalIgnoreCase)).ToList();
            return View("GetAllMoviesInCategory", moviesInCategory);
        }

        public IActionResult InputCategory()
        {
            return View();
        }

        public IActionResult GetCountInCategory (string category)
        {
            var countInCategory = Movies.Count(m => m.Category.Equals(category, StringComparison.OrdinalIgnoreCase));
            ViewBag.Count = countInCategory;
            return View();
        }

        public IActionResult InputBudget()
        {
            return View();
        }

        public IActionResult MoviesInBudget (decimal budget)
        {
            var moviesWithinBudget = Movies.Where(m => m.Budget < budget).ToList();
            return View("MoviesInBudget", moviesWithinBudget);
        }

        public IActionResult MoviesInThe90s()
        {
            var moviesInThe90s = Movies.Where(m => m.ReleaseYear >= 1990 && m.ReleaseYear < 2000).ToList();
            return View(moviesInThe90s);
        }

        public IActionResult InputId()
        {
            return View();
        }

        public IActionResult CalculateOverallRating(int movieId)
        {
            var ratings = Ratings.Where(r => r.MovieId == movieId).ToList();
            if (!ratings.Any())
            {
                throw new Exception("No ratings available for this movie.");
            }
            var averageRating = ratings.Average(r => r.Stars);
            ViewBag.MovieId = movieId;
            ViewBag.AverageRating = averageRating;
            return View();
        }
    }
}
