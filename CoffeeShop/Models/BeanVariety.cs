using System.ComponentModel.DataAnnotations;

namespace CoffeeShop.Models
{
    public class BeanVariety
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        [Required]
        [StringLength(255, MinimumLength = 3)]
        public string Region { get; set; }
        //Notes is not required, wehich is why ID 1 can be null
        public string Notes { get; set; }
    }
}