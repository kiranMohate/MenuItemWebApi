using System.ComponentModel.DataAnnotations;

namespace MenuItemListingWebApi.Models
{
    public class MenuItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name = "FreeDelivery")]
        public bool freeDelivery { get; set; }
        [Required]
        public Double Price { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime dateOfLaunch { get; set; }
        public bool Active { get; set; }

    }
}
