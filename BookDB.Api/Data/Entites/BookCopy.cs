namespace BookDB.Api.Entites
{
    public class BookCopy
    {
        public string BookId { get; set; }
        public int CopyNumber { get; set; }
        public string Description { get; set; }
        public Book Book { get; set; }
    }
}