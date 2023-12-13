using System.ComponentModel.DataAnnotations;

namespace Demo.Web.Models
{
    public class TblUserRegistrationDTO
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Phone { get; set; }

        public string Address { get; set; }

        [Required]
        public int CityId { get; set; }
    }
}
