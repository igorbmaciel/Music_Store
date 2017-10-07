using System.Collections.Generic;
using Music_Store.Application.ViewModels;
using Music_Store.Domain.Models;

namespace Music_Store.Service.Services
{
    public interface IAlbumAppService
    {
        IEnumerable<AlbumViewModel> ObterTodos();
        IEnumerable<AlbumViewModel> ObterPorId(int id);
        AlbumViewModel Adicionar(AlbumViewModel album);
        AlbumViewModel Atualizar(AlbumViewModel album);
        void Remover(int id);
    }

}
