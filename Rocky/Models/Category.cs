using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } 

        [DisplayName("Display Order")]
        [Required]
        [Range(1,10,ErrorMessage ="Display Order must be grater than 0 and less than 11")]
        public int DisplayOrder { get; set; }

    }
}
