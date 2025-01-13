namespace ControllersExample.Models
{
    public class Book
    {
        public int? BookId { get; set; }
        public string? Author { get; set; }
        public override string ToString()
        {
            return $"Book obhect-Book id {BookId}Author: { Author}" ;
        }
    }
}
