using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO.DTO_ShowTimes;

namespace WindowsFormsApp1.DTO.DTO_Order

{
    public class TicketOrder
    {
        [Key]
        [Required]
        public string _IDTicketOrder { get; set; }
        public string _IDOrder { get; set; }

        public string _IDRoom { get; set; }
        public DateTime _Time { get; set; }
        public string _SeatPurchased { get; set; }
        //Navigation Properties
        [ForeignKey("_IDRoom, _Time")]
        public virtual ShowTime _ShowTime { get; set; }
        [ForeignKey("_IDOrder")]
        public virtual Order _Order { get; set; }
    }
}
