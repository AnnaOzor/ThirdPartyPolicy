using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThirdPartyPolicy.Models
{
    public class Policy
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(1000)]
        [Display(Name = "Premium")]
        public string Premium { get; set; }

        [Display(Name = "Duration")]
        public string Duration { get; set; }

        [Required]
        [MaxLength(1000)]
        [Display(Name = "Vehicle Body Type")]
        public string BodyType { get; set; }
    }
}
