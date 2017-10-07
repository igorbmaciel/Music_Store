using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Music_Store.Application.ViewModels;
using Music_Store.Domain.Models;

namespace Music_Store.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<Album, AlbumViewModel>();
            CreateMap<Artist, ArtistViewModel>();
            CreateMap<Genre, GenreViewModel>();
        }
    }
}
