using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Music_Store.Domain.Models
{
    public class Album
    {
        public Album()
        {
            Artist = new Artist();
            Genre = new Genre();           
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public string ArtAlbumUrl { get; set; }
        public Genre Genre { get; set; }
        public Artist Artist { get; set; }
    }
}
