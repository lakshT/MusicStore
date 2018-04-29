using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStore.Models
{
    public class Artist
    {
        public int ArtistID { get; set; }

        public string ArtistName { get; set; }

        public List<Album> Albums { get; set; }
    }
}