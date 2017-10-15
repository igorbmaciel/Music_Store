using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Music_Store.Application.ViewModels;
using Music_Store.Domain.Models;

namespace Music_Store.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        protected override void Configure()
        {
            CreateMap<AlbumViewModel, Album>();
            CreateMap<ArtistViewModel, Artist>();
            CreateMap<GenreViewModel, Genre>();
        }
    }
}
