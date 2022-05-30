using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO.DTO_ShowTimes
{
    public class Movie
    {
        public Movie()
        {
            _ShowTimes = new HashSet<ShowTime>();
        }
        [Key]
        [Required]
        public string _IDMovie { get; set; }
        public string _NameMovie { get; set; }
        public string _Director { get; set; }
        public TimeSpan _Duration { get; set; }
        public string _Actor { get; set; }
        public string _Category { get; set; }
        public double _Rate { get; set; }
        public string _Description { get; set; }
        //Navigation Properties
        public virtual ICollection<ShowTime> _ShowTimes { get; set; }
    }
}
