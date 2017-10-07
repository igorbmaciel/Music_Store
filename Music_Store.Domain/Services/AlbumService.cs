using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Music_Store.Domain.Models;
using Music_Store.Domain.Repositories;

namespace Music_Store.Domain.Services
{
    public class AlbumService : IAlbumService
    {
        private readonly IAlbumRepository _repository;       

        public AlbumService(IAlbumRepository repository)
        {
            _repository = repository;
        }

        public List<Album> SearchAlbum()
        {
            return _repository.SearchAlbum();
        }

        public List<Album> SearchAlbumById(int id)
        {
            return _repository.SearchAlbumById(id);
        }

        public void CreateAlbum(Album album)
        {
            _repository.CreateAlbum(album);
        }

        public void AlterAlbum(Album album)
        {
            _repository.AlterAlbum(album);
        }

        public void DeleteAlbum(int id)
        {
           _repository.DeleteAlbum(id);
        }
    }
}
