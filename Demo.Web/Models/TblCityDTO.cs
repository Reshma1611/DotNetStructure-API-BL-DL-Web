using System.ComponentModel.DataAnnotations;

namespace Demo.Web.Models
{
    public class TblCityDTO
    {
        public int Id { get; set; }

        [Required]
        public int StateId { get; set; }

        [Required]
        public string CityName { get; set; }
    }
}
