using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Library
{
    public class AppRepository : IAppRepository
    {
        private readonly LibraryContext _context;
        public AppRepository(LibraryContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public Book GetBook(int id)
        {
            return _context.Books.Include(x => x.Photos).FirstOrDefault(x => x.Id == id);
        }

        public List<Book> GetBooksByLibrary(int libraryId)
        {
            return _context.Books.Where(x => x.LibraryId == libraryId).ToList();
        }

        public List<Library> GetLibraries()
        {

            // return _context.Libraries.Include(x => x.Books).ToList();
            return _context.Libraries.ToList();

        }

        public Library GetLibrary(int id)
        {
            return _context.Libraries.Find(id);

        }

        public Photo GetPhoto(int id)
        {
            return _context.Photos.Find(id);

        }

        public List<Photo> GetPhotosByBook(int bookId)
        {
            return _context.Photos.Where(x => x.BookId == bookId).ToList();

        }

        public bool SaveAll()
        {
            return _context.SaveChanges() > 0;
        }


    }
}