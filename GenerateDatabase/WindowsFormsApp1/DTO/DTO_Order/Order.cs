using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO.DTO_Person;

namespace WindowsFormsApp1.DTO.DTO_Order
{
    public class Order
    {
        [Key]
        [Required]
        public string _IDOrder { get; set; }
        public string _IDCustomer { get; set; }
        [Required]
        public DateTime _TimeOrder { get; set; }
        public string _Code { get; set; }
        [ForeignKey("_IDCustomer")]
        public virtual Customer Customer { get; set; }
    }
}
