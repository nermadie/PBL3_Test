using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO.DTO_Order;

namespace WindowsFormsApp1.DTO.DTO_Person
{
    public class Customer : Person
    {
        public Customer()
        {
            _Orders = new HashSet<Order>();
        }
        public bool _VIP { get; set; }
        //Navigation Properties
        public virtual ICollection<Order> _Orders { get; set; }
    }
}
