using System.Collections.Generic;

namespace MusicStore.Models
{
    public class Album
    {
        public int AlbumID { get; set; }

        public string Title { get; set; }

        public Artist Artist { get; set; }

        public List<Review> Reviews { get; set; }
    }
}