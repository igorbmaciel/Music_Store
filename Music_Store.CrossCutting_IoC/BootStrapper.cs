using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Music_Store.DataAccess.Context;
using Music_Store.DataAccess.Repositories;
using Music_Store.Domain.Repositories;
using Music_Store.Domain.Services;
using Music_Store.Service.Services;
using SimpleInjector;

namespace Music_Store.CrossCutting_IoC
{
    public class BootStrapper
    {
        public static void RegisterServices(Container container)
        {
            // Lifestyle.Transient => Uma instancia para cada solicitacao;
            // Lifestyle.Singleton => Uma instancia unica para a classe
            // Lifestyle.Scoped => Uma instancia unica para o request

            // App
            container.Register<IAlbumAppService, AlbumAppService>();

            // Domain
            container.Register<IAlbumService, AlbumService>();

            // Infra Dados
            container.Register<IAlbumRepository, AlbumRepository>();
            //container.Register<MusicStoreContext>();

            //container.Register(typeof (IRepository<>), typeof (Repository<>));
        }
    }
}
