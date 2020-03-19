using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
               .AddDbContext<LibraryContext>(x => x.UseNpgsql(@"Host=;Database=;Username=;Password=;"))
               .AddScoped<IAppRepository, AppRepository>()
               .BuildServiceProvider();

            var _repository = serviceProvider.GetService<IAppRepository>();

            _repository.Add<Library>(new Library { Title = "LibraryName" });
            _repository.SaveAll();

            var libraries = _repository.GetLibraries();
            foreach (var library in libraries)
            {
                System.Console.WriteLine(library.Title);
            }
        }
    }
}
