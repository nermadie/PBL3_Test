using System;
using System.Collections.Generic;
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
        //API Fluent to set _IDOrder+_IDShowTime = PrimaryKey
        public string _IDOrder { get; set; }
        public string _IDShowTime { get; set; }
        public string _SeatPurchased { get; set; }
        //Navigation Properties
        [ForeignKey("_IDShowTime")]
        public virtual ShowTime _ShowTime { get; set; }
    }
}
