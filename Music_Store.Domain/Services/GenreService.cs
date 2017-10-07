using Music_Store.Domain.Models;
using Music_Store.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Music_Store.Domain.Services
{
    public class GenreService : IGenreService
    {
        private readonly IGenreRepository _repository;

        public GenreService(IGenreRepository repository)
        {
            _repository = repository;
        }

        public List<Genre> SearchGenre()
        {
            return _repository.SearchGenre();
        }
    }
}
