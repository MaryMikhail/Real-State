using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstate.Models
{
    public class Contact
    {
        [Key]
        public int ClientId { get; set; }

        [Required(ErrorMessage = "Name field is required")]
        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email field is required")]

        public string Email { get; set; }
        [Required(ErrorMessage = "Phone field is required")]

        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Message field is required")]

        public string Message { get; set; }
        [Required(ErrorMessage = "subject field is required")]

        public string Subject { get; set; }
    }
}
