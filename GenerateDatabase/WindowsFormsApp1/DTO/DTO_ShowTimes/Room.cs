using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO.DTO_ShowTimes
{
    public class Room
    {
        public Room()
        {
            _ShowTimes = new HashSet<ShowTime>();
        }
        [Key]
        [Required]
        public string _IDRoom { get; set; }
        public string _NameRoom { get; set; }
        public int _NumofSeats { get; set; }
        //Navigation Properties
        public virtual ICollection<ShowTime> _ShowTimes { get; set; }
    }
}
