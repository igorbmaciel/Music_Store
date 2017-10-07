using Music_Store.DataAccess.ContextConfig;
using Music_Store.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Store.DataAccess.Context
{
    public class MusicStoreContext : DbContext
    {
        public DbSet<Album> Album { get; set; }
        public DbSet<Artist> Artist { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }


        public MusicStoreContext() : base("name=BD_MusicStore")
        {
            Configuration.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties().Where(p => p.Name == "ID").Configure(p => p.IsKey());
            modelBuilder.Properties<String>().Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<String>().Configure(p => p.HasMaxLength(500));

            modelBuilder.Configurations.Add(new AlbumContextConfig());
            modelBuilder.Configurations.Add(new ArtistContextConfig());
            modelBuilder.Configurations.Add(new GenreContextConfig());
            modelBuilder.Configurations.Add(new OrderContextConfig());
            modelBuilder.Configurations.Add(new OrderDetailContextConfig());

        }
    }
}
