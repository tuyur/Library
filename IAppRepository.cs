using System.Collections.Generic;

namespace Library
{
    public interface IAppRepository
    {
        void Add<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;

        // read operations 
        List<Library> GetLibraries();
        Library GetLibrary(int id);
        List<Book> GetBooksByLibrary(int libraryId);
        Book GetBook(int id);
        List<Photo> GetPhotosByBook(int bookId);
        Photo GetPhoto(int id);
        
        // unit of work
        bool SaveAll();

    }
}