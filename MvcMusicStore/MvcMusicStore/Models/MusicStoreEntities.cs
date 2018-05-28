using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcMusicStore.Models
{
    public class MusicStoreEntities :DbContext
    {
        public DbSet<Album> Albums { get; set; }
        public DbSet<Gen> Gen { get; set; }
    }
}