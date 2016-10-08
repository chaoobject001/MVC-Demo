using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PartyInvites.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Input for name is required")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Input for email is required")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage = "Invaid email format")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Input for phone number is required")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Specification of attendance is required")]
        public bool? WillAttend { get; set; }
    }
}
