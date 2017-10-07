using Music_Store.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Music_Store.Domain.Models;
using Music_Store.DataAccess.Context;

namespace Music_Store.DataAccess.Repositories
{
    public class ArtistRepository : IArtistRepository
    {
        protected MusicStoreContext Db = new MusicStoreContext();

        public List<Artist> SearchArtist()
        {
            return Db.Set<Artist>().ToList();
        }

        public void CreateArtist(Artist artist)
        {
            Db.Set<Artist>().Add(artist);
            Db.SaveChanges();
        }

        public void AlterArtist(Artist artist)
        {
            Db.Set<Artist>().Attach(artist);
            Db.SaveChanges();
        }   

        public void DeleteArtist(int id)
        {
            Db.Set<Artist>().Remove(Db.Set<Artist>().Find(id));
            Db.SaveChanges();
        }
       
    }
}
