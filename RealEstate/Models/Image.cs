using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RealEstate.Models
{
    public class Image
    {
        [Key]
        public int Id { get; set; }

        public string ImageTitle { get; set; }

        [Required(ErrorMessage = "Please choose profile image")]
        public string ImgData { get; set; }

        [ForeignKey("Property")]
        public virtual int PropertyID { get; set; }
    }
}
