namespace library_backend.Models.Book
{
    public class ReviewDTO
    {
        public int UserBookId { get; set; }
        public string Review { get; set; }
        public int Rating { get; set; }
        public DateTime CreatedDateTime { get; set; }

    }
}
