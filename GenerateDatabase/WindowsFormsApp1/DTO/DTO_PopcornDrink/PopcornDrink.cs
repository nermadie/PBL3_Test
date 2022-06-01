using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO.DTO_PopcornDrink
{
    public class PopcornDrink
    {
        [Key]
        [Required]
        public string _IDPopcornDrink { get; set; }
        public string _NamePopcornDrink { get; set; }
        public int _PricePopcornDrink { get; set; }
    }
}
