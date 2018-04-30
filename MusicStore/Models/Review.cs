using System.ComponentModel.DataAnnotations;

namespace MusicStore.Models
{
    public class Review
    {
        public int ReviewID { get; set; }
        
        public int AlbumID { get; set; }

        [Display(Name = "Select Album")]
        public virtual Album Album { get; set; }

        [Display(Name = "Review")]
        public string Contents { get; set; }

        [Required()]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Reviewermail { get; set; }
    }
}