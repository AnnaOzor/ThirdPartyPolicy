using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThirdPartyPolicy.Models
{
    public class ChangeUserPassword
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "User Name")]
        [MaxLength(1000)]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Old Password")]
        public string OldPassword { get; set; }

        [Required]
        [Display(Name = "New Password")]
        public string NewPassword { get; set; }

        [Required]
        [Display(Name = "Confirm New Password")]
        public string ConfirmNewPassword { get; set; }
    }
}
