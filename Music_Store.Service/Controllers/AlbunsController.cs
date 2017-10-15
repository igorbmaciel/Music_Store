using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Http;
using Music_Store.DataAccess.Repositories;
using Music_Store.Domain.Models;
using Music_Store.Domain.Services;

namespace Music_Store.Service.Controllers
{
    public class AlbunsController : ApiController
    {
        private readonly IAlbumService _service;

        public AlbunsController()
        {
            var _repository = new AlbumRepository();
            _service = new AlbumService(_repository);
        }

        // GET: api/Albuns
        [HttpGet]
        public List<Album> ListarTodos()
        {
            return _service.SearchAlbum();
        }

        // GET: api/Albuns/5
        public List<Album> Get(int id)
        {
            return _service.SearchAlbumById(id);
        }

        // POST: api/Albuns/
        public void Post([FromBody]Album value)
        {
            _service.CreateAlbum(value);
        }

        // PUT: api/Albuns/5
        public void Put(int id, [FromBody]Album value)
        {
            _service.AlterAlbum(value);
        }

        // DELETE: api/Albuns/5
        public void Delete(int id)
        {
            _service.DeleteAlbum(id);
        }
    }
}