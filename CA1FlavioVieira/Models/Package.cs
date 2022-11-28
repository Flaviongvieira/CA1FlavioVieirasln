using System.ComponentModel.DataAnnotations;

namespace CA1FlavioVieira.Models
{
    public class Package
    {
        [Key]
        public int PackageId { get; set; }

        [Required]
        [StringLength(maximumLength:60)]
        [Display(Name = "Client Name")]
        public string ClientName { get; set; }

        [Required]
        [StringLength(maximumLength: 200)]
        [Display(Name = "Shipping Address")]
        public string ShippingAddress { get; set; }

        [Range(0, 100, ErrorMessage = "Max 100Kg")]
        [Display(Name = "Package Weigth - Kg")]
        public double Weight { get; set; }

        [Range(0, 200, ErrorMessage = "Max 200cm")]
        [Display(Name = "Package Lenght - cm")]
        public double Length { get; set; }

        [Range(0, 200, ErrorMessage = "Max 200cm")]
        [Display(Name = "Package Width - cm")]
        public double Width { get; set; }

        [Range(0, 200, ErrorMessage = "Max 200cm")]
        [Display(Name = "Package Height - cm")]
        public double Height { get; set; }
    }
}
