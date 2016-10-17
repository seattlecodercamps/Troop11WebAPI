using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MegaTron.Models
{



    public class Cheese
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Cheese name is Required!")]
        [MinLength(3, ErrorMessage ="Cheese name must be greater than 3 characters.")]
        public string Name { get; set; }

        [Range(0, 10, ErrorMessage ="Cheese smelliness is out of range!")]
        public int Smelliness { get; set; }
        public bool Spreadable { get; set; }
    }
}
