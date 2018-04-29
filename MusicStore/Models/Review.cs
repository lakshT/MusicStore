using System.ComponentModel.DataAnnotations;

namespace MusicStore.Models
{
    public class Review
    {
        public int ReviewID { get; set; }

        public int AlbumID { get; set; }

        public virtual Album Album { get; set; }

        public string Contents { get; set; }

        [Required()]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Reviewermail { get; set; }
    }
}