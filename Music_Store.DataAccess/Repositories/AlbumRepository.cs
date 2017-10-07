using Music_Store.DataAccess.Context;
using Music_Store.Domain.Models;
using Music_Store.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Music_Store.DataAccess.Repositories
{
    public class AlbumRepository : IAlbumRepository
    {
        protected MusicStoreContext Db = new MusicStoreContext();

        public List<Album> SearchAlbum()
        {
            var cn = Db.Database.Connection;
            var sql = @"SELECT * FROM Album ab " +
                      "JOIN Artist a " +
                      "ON ab.Artist_Id = a.Id " +
                      "JOIN Genre g " +
                      "ON ab.Genre_Id = g.Id "; 

            var album = new List<Album>();
            var artist = new List<Artist>();
            var genre = new List<Genre>();
            cn.Query<Album, Artist, Genre, List<Album>>(sql,
                (c, a, g) =>
                {
                    album.Add(c);
                    artist.Add(a);
                    genre.Add(g);

                    for (int i = 0; i < album.Count; i++)
                    {
                        album[i].Artist.Id = artist[i].Id;
                        album[i].Artist.Name = artist[i].Name;
                        album[i].Genre.Id = genre[i].Id;
                        album[i].Genre.Name = genre[i].Name;
                    }

                    return album.ToList();
                }, new {}, splitOn: "Artist_Id, Id, Genre_Id, Id");

            return album.ToList();
        }

        public List<Album> SearchAlbumById(int id)
        {
            var cn = Db.Database.Connection;
            var sql = string.Format(@"SELECT * FROM Album ab " +
                      "JOIN Artist a " +
                      "ON ab.Artist_Id = a.Id " +
                      "JOIN Genre g " +
                      "ON ab.Genre_Id = g.Id " +
                      "WHERE ab.Id = {0} ",id);

            var album = new List<Album>();
            var artist = new List<Artist>();
            var genre = new List<Genre>();
            cn.Query<Album, Artist, Genre, List<Album>>(sql,
                (c, a, g) =>
                {
                    album.Add(c);
                    artist.Add(a);
                    genre.Add(g);

                    for (int i = 0; i < album.Count; i++)
                    {
                        album[i].Artist.Id = artist[i].Id;
                        album[i].Artist.Name = artist[i].Name;
                        album[i].Genre.Id = genre[i].Id;
                        album[i].Genre.Name = genre[i].Name;
                    }

                    return album.ToList();
                }, new { }, splitOn: "Artist_Id, Id, Genre_Id, Id");

            return album.ToList();
        }

        public void CreateAlbum(Album album)
        {
            var cn = Db.Database.Connection;
            var sql = string.Format(@"INSERT INTO Album " +
                      "Values ('{0}',{1},'{2}',{3},{4})"
                      ,album.Title, album.Price, album.ArtAlbumUrl
                      ,album.Artist.Id, album.Genre.Id);
          
            cn.Execute(sql);

        }

        public void AlterAlbum(Album album)
        {
            var cn = Db.Database.Connection;
            var sql = string.Format(@"UPDATE Album " +
                      "SET Title = '{0}', Price = {1}, ArtAlbumUrl = '{2}', Artist_Id = {3}, Genre_Id = {4}" +
                      "WHERE Id = {5}"
                      , album.Title, album.Price, album.ArtAlbumUrl
                      , album.Artist.Id, album.Genre.Id, album.Id);

            cn.Execute(sql);
        }

        public void DeleteAlbum(int id)
        {
            var cn = Db.Database.Connection;
            var sql = string.Format(@"DELETE FROM Album " +                      
                      "WHERE Id = {0} ", id);

            cn.Execute(sql);
        }

    }    
}
