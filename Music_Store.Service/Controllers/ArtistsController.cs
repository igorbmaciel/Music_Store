using Music_Store.DataAccess.Repositories;
using Music_Store.Domain.Models;
using Music_Store.Domain.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Music_Store.Service.Controllers
{
    public class ArtistsController : ApiController
    {
        private readonly IArtistService _service;

        public ArtistsController()
        {
            var _repository = new ArtistRepository();
            _service = new ArtistService(_repository);
        }

        // GET: api/Artists
        [HttpGet]
        public List<Artist> ListarTodos()
        {
            return _service.SearchArtist();
        }

        // GET: api/Artists/5
        public List<Artist> Get(int id)
        {
            return _service.SearchArtistById(id);
        }

        // POST: api/Artists/
        public void Post([FromBody]Artist value)
        {
            _service.CreateArtist(value);
        }

        // PUT: api/Artists/5
        public void Put(int id, [FromBody]Artist value)
        {
            _service.AlterArtist(value);
        }

        // DELETE: api/Artists/5
        public void Delete(int id)
        {
            _service.DeleteArtist(id);
        }

    }
}
