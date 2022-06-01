using System;
using System.Data.Entity;
using System.Linq;
using WindowsFormsApp1.DTO.DTO_Order;
using WindowsFormsApp1.DTO.DTO_Person;
using WindowsFormsApp1.DTO.DTO_PopcornDrink;
using WindowsFormsApp1.DTO.DTO_ShowTimes;

namespace WindowsFormsApp1
{
    public class QLCinema : DbContext
    {
        public QLCinema()
            : base("name=QLCinema")
        {
            Database.SetInitializer<QLCinema>(new CreateDB());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
        public virtual DbSet<Customer> _Customers { get; set; }
        public virtual DbSet<Employee> _Employees { get; set; }
        public virtual DbSet<Order> _Orders { get; set; }
        public virtual DbSet<PopcornDrinkOrder> _PopcornDrinkOrders { get; set; }
        public virtual DbSet<TicketOrder> _TicketOrders { get; set; }
        public virtual DbSet<PopcornDrink> _PopcornDrinks { get; set; }
        public virtual DbSet<Movie> _Movies { get; set; }
        public virtual DbSet<Room> _Rooms { get; set; }
        public virtual DbSet<ShowTime> _ShowTimes { get; set; }
    }
}