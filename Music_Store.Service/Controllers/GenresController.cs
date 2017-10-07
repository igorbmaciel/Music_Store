using Music_Store.DataAccess.Repositories;
using Music_Store.Domain.Models;
using Music_Store.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Music_Store.Service.Controllers
{
    public class GenresController
    {
        private readonly IGenreService _service;

        public GenresController()
        {
            var _repository = new GenreRepository();
            _service = new GenreService(_repository);
        }

        // GET: api/Processos
        public List<Genre> Get()
        {
            return _service.SearchGenre();
        }

        // GET: api/Processo/5
        public string Get(int id)
        {
            return "value";
        }
    }
}
