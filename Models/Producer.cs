using System.ComponentModel.DataAnnotations;

namespace ticketEccommerce.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }

        public string Bio { get; set; }

        //Relations

        public List<Movie> Movies { get; set; }

    }
}
