using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThirdPartyPolicy.Models
{
    public class VehicleInfo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(1000)]
        [Display(Name = "Vehicle Make")]
        public string VehicleMake { get; set; }

        [Required]
        [MaxLength(1000)]
        [Display(Name = "Vehicle Registration Number")]
        public string RegNo { get; set; }

        [Required]
        [MaxLength(1000)]
        [Display(Name = "Vehicle Model")]
        public string VehicleModel { get; set; }

        [Required]
        [MaxLength(1000)]
        [Display(Name = "Vehicle Body Type")]
        public string BodyType { get; set; }
    }
}
