using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Music_Store.Domain.Models;
using Music_Store.Domain.Repositories;

namespace Music_Store.Domain.Services
{
    public class ArtistService : IArtistService
    {
        private readonly IArtistRepository _repository;

        public ArtistService(IArtistRepository repository)
        {
            _repository = repository;
        }

        public List<Artist> SearchArtist()
        {
            return _repository.SearchArtist();
        }

        public List<Artist> SearchArtistById(int id)
        {
            return _repository.SearchArtistById(id);
        }

        public void CreateArtist(Artist artist)
        {
            _repository.CreateArtist(artist);
        }

        public void AlterArtist(Artist artist)
        {
            _repository.AlterArtist(artist);
        }

        public void DeleteArtist(int id)
        {
            _repository.DeleteArtist(id);
        }
    }
}
