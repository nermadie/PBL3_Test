using System;
using System.Data.Entity;
using System.Linq;
using WindowsFormsApp1.DTO.DTO_Order;
using WindowsFormsApp1.DTO.DTO_Person;

namespace WindowsFormsApp1
{
    public class QLCinema : DbContext
    {
        public QLCinema()
            : base("name=QLCinema")
        {
            Database.SetInitializer<QLCinema>(new CreateDB());
        }
        public virtual DbSet<Customer> _Customers { get; set; }
        public virtual DbSet<Employee> _Employees { get; set; }
        public virtual DbSet<Order> _Orders { get; set; }
    }
}