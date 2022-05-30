using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.DTO.DTO_Order;

namespace WindowsFormsApp1.DTO.DTO_Person
{
    public class Employee : Person
    {
        public int _Shift { get; set; }
        public int _Wage { get; set; }
    }
}
