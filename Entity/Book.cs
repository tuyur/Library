using System.Collections.Generic;

namespace Library
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int LibraryId { get; set; }
        public Library Library { get; set; }
        public List<Photo> Photos { get; set; }
    }
}