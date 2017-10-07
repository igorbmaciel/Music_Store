using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Store.Application.ViewModels
{
    public class AlbumViewModel
    {
        public AlbumViewModel()
        {
            Artist = new ArtistViewModel();
            Genre = new GenreViewModel();
        }

        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Title é obrigatório")]
        [MaxLength(150, ErrorMessage = "Máximo 150 caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo 2 caracteres")]
        public string Title { get; set; }
        public double Price { get; set; }

        [Required(ErrorMessage = "O campo ArtAlbumUrl é obrigatório")]
        [MaxLength(150, ErrorMessage = "Máximo 150 caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo 2 caracteres")]
        public string ArtAlbumUrl { get; set; }
        public GenreViewModel Genre { get; set; }
        public ArtistViewModel Artist { get; set; }
    }
}
