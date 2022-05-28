using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.DTO.DTO_Order

{
    //APIFluent
    //public class Context : DbContext
    //{
    //    public DbSet<TicketOrder> TicketOrders { get; set; }
    //    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    //    {
    //        modelBuilder.Entity<TicketOrder>()
    //            .HasKey(o => new { o._IDOrder, o._IDRoom, o._Time });

    //        modelBuilder.Entity<TicketOrder>()
    //        .HasRequired(p => p.ShowTimes)
    //        .WithMany(c => c.Products)
    //        .HasForeignKey(p => new { p.CategoryId1, p.CategoryId2 });
    //    }
    //}
    public class TicketOrder
    {
        public string _IDOrder { get; set; }
        public string _IDRoom { get; set; }
        public string _Time { get; set; }
        public string _SeatPurchased { get; set; }
    }
}
