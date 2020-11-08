using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Pizza_StoreV1.Models
{
    public class Pizza
    {
        [Required(ErrorMessage = "The ID is required"), Range(1,100)]
        public int Id { get; set; }

        [Required(ErrorMessage = "The name is Required")]
        [StringLength(20, ErrorMessage = "The Name can't be longer than 20 chars")]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required(ErrorMessage = "The Price is Required")]
        [Range(1,1000)]
        public decimal Price { get; set; }
        
        public string ImageName { get; set; }
    }
}
