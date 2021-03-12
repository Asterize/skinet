using System.ComponentModel.DataAnnotations;

namespace API.Dtos
{
    public class AddressDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Street { get; set; }

        [Required]
        public string Ward { get; set; }

        [Required]
        public string District { get; set; }

        [Required]
        public string City { get; set; }
        
        [Required]
        public string Zipcode { get; set; }
    }
}