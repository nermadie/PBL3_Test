using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO.DTO_Order;

namespace WindowsFormsApp1.DTO.DTO_ShowTimes
{
    public class ShowTime
    {
        public ShowTime()
        {
            _TicketOrders = new HashSet<TicketOrder>();
        }
        public string _IDMovie { get; set; }
        [Key, Column(Order = 1)]
        public string _IDRoom { get; set; }
        [Key, Column(Order = 2)]
        public DateTime _Time { get; set; }
        public string _Seat { get; set; }
        public int _TicketPrice { get; set; }
        //Navigaion Properties
        [ForeignKey("_IDMovie")]
        public virtual Movie Movie { get; set; }
        [ForeignKey("_IDRoom")]
        public virtual Room Room { get; set; }
        public virtual ICollection<TicketOrder> _TicketOrders { get; set; }
    }
}
