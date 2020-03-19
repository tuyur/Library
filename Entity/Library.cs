using System.Collections.Generic;

namespace Library
{
    public class Library
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public List<Book> Books { get; set; }
    }
}