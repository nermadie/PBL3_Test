using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO.DTO_Order
{
    public class PopcornDrinkOrder
    {
        [Key]
        [Required]
        public string _IDPopcornDrinkOrder { get; set; }
        public string _IDOrder { get; set; }
        public string _NamePopcornDrink { get; set; }
        public int _PopcornDrinkPrice { get; set; }
        public int _Quantity { get; set; }
        //Navigation Properties
        [ForeignKey("_IDOrder")]
        public virtual Order _Order { get; set; }
    }
}
