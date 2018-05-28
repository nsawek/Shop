using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class Album
    {
        public string Title { get; set; }
        public Gen Gen { get; set; }
        public int AlbumId { get; set; }
        public int GenreId { get; set; }
        public int ArtistId { get; set; }
        public decimal Price { get; set; }
        public Artist Artist { get; set; }
        public string AlbumArtUrl { get; set; }
    }
}