using System.ComponentModel.DataAnnotations;

namespace ticketEccommerce.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Profile Picture")]
        public string ProfilePictureURL { get; set; }

        [Display (Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Biography")]
        public string Bio { get; set; }

        //Relations

        public List<Movie> Movies { get; set; }

    }
}
