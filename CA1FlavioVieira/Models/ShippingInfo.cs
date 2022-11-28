using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CA1FlavioVieira.Models
{
    public class ShippingInfo
    {
        public int PackageId { get; set; }

        [Display(Name = "Shipping Address")]
        public string ShippingAddress { get; set; }

        [Display(Name = "Package Volume")]
        public double Volume { get; set; }

        [Display(Name = "Package Density")]
        public double Density { get; set; }

        [Display(Name = "Shipping Category")]
        public string ShippingCategory { get; set; }
    }
}
