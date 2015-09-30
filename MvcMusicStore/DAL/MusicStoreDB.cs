using System;
using System.Collections.Generic;
using System.Data.Entity;
using MvcMusicStore.Models;
using System.Linq;
using System.Web;

namespace MvcMusicStore.DAL
{
    public class MusicStoreDB : DbContext
    {
        public MusicStoreDB() : base("name=MusicStoreDB")
        {

        }

        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres{ get; set; }
        public DbSet<Artist> Artists { get; set; }
    }
}