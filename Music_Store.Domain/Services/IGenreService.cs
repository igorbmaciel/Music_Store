using Music_Store.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Music_Store.Domain.Services
{
    public interface IGenreService
    {
        List<Genre> SearchGenre();
    }
}
