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
        public Order()
        {
            _PopcornDrinkOrders = new HashSet<PopcornDrinkOrder>();
            _TicketOrders = new HashSet<TicketOrder>();
        }
        [Key]
        [Required]
        public string _IDOrder { get; set; }
        public string _IDCustomer { get; set; }
        [Required]
        public DateTime _TimeOrder { get; set; }
        public string _Code { get; set; }
        //Navigation Properties
        [ForeignKey("_IDCustomer")]
        public virtual Customer _Customer { get; set; }
        public virtual ICollection<PopcornDrinkOrder> _PopcornDrinkOrders { get; set; }
        public virtual ICollection<TicketOrder> _TicketOrders { get; set; }
    }
}
