using Business.Models;
using DataAccess.Contexts;

namespace Business.Services
{
    public interface IGenreService
    {
        IQueryable<GenreModel> Query();
    }

    public class GenreService : IGenreService
    {
        private readonly Db _db;

        public GenreService(Db db)
        {
            _db = db;
        }

        public IQueryable<GenreModel> Query()
        {
            return _db.Genres.OrderBy(a => a.Name).Select(a => new GenreModel()
            {
                Id = a.Id,
                Name = a.Name
            });
        }
    }
}
