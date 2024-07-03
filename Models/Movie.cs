namespace movie_analysis_application.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public decimal Budget { get; set; }
        public int ReleaseYear { get; set; }
        public string Category { get; set; }
    }
}
