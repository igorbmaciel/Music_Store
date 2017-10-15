using Music_Store.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Music_Store.Domain.Services
{
    public interface IArtistService
    {
        List<Artist> SearchArtist();
        List<Artist> SearchArtistById(int id);
        void CreateArtist(Artist artist);
        void AlterArtist(Artist artist);
        void DeleteArtist(int id);
    }
}
