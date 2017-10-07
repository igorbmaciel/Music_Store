using System.Collections.Generic;
using AutoMapper;
using Music_Store.Application.ViewModels;
using Music_Store.Domain.Models;
using Music_Store.Domain.Services;

namespace Music_Store.Service.Services
{
    public class AlbumAppService : IAlbumAppService
    {
        private readonly IAlbumService _AlbumService;

        public AlbumAppService(IAlbumService albumService)
        {
            _AlbumService = albumService;
        }

        public IEnumerable<AlbumViewModel> ObterTodos()
        {
            return Mapper.Map<IEnumerable<Album>, IEnumerable<AlbumViewModel>>(_AlbumService.SearchAlbum());
        }

        public AlbumViewModel Adicionar(AlbumViewModel albumviewmodel)
        {
            var album = Mapper.Map<AlbumViewModel, Album>(albumviewmodel);

            _AlbumService.CreateAlbum(album);  

            return albumviewmodel;
        }

        public IEnumerable<AlbumViewModel> ObterPorId(int id)
        {
            return Mapper.Map<IEnumerable<Album>, IEnumerable<AlbumViewModel>>(_AlbumService.SearchAlbumById(id));
        }

        public void Remover(int id)
        {
            _AlbumService.DeleteAlbum(id);           
        }

        public AlbumViewModel Atualizar(AlbumViewModel albumviewmodel)
        {
            _AlbumService.AlterAlbum(Mapper.Map<AlbumViewModel, Album>(albumviewmodel));

            return albumviewmodel;
        }
    }
}