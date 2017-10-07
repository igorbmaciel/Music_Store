using Music_Store.DataAccess.Context;
using Music_Store.Domain.Models;
using Music_Store.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Store.DataAccess.Repositories
{
    public class GenreRepository : IGenreRepository
    {
        protected MusicStoreContext Db = new MusicStoreContext();

        public List<Genre> SearchGenre()
        {
            return Db.Set<Genre>().ToList();
        }
    }
}
