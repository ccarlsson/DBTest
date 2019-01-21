namespace BookDB.Api.Entites
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; } = "http://i.imgur.com/J5LVHEL.jpg";
        public string Author { get; set; }
    }
}