using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pittig.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Display(Name="Naam categorie")]
        [Required]
        public string Name { get; set; }
    }
}
