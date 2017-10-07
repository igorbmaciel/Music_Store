using Music_Store.DataAccess.Repositories;
using Music_Store.Domain.Models;
using Music_Store.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Music_Store.Service.Controllers
{
    public class ArtistsController 
    {
        private readonly IArtistService _service;

        public ArtistsController()
        {
            var _repository = new ArtistRepository();
            _service = new ArtistService(_repository);
        }

        // GET: api/Processos
        public List<Artist> Get()
        {
            return _service.SearchArtist();
        }

        // GET: api/Processo/5
        public string Get(int id)
        {
            return "value";
        }
        
    }
}
