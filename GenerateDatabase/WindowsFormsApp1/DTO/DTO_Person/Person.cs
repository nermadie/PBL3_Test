using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO.DTO_Person
{
    public abstract class Person
    {
        [Key]
        [Required]
        public string _IDPerson { get; set; }
        [Required]
        public string _NamePerson { get; set; }
        public string _Phone { get; set; }
        public string _Address { get; set; }
        public bool _Gender { get; set; }
        public DateTime _Birth { get; set; }
        [Required]
        public string _Username { get; set; }
        [Required]
        public string _Password { get; set; }
    }
}
