namespace Library
{
    public class Photo
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public bool isMain { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }

    }
}