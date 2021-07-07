using Holism.DataAccess;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Holism.Orders.Models;

namespace Holism.Orders.DataAccess
{
    public class OrderContext : DatabaseContext
    {
        public override string ConnectionStringName => "OrderContext";
        
        public DbSet<Order> Orders { get; set; }
        
        public DbSet<OrderItem> OrderItems { get; set; }
        
        public DbSet<ServiceOrder> ServiceOrders { get; set; }
        
        public DbSet<ServiceOrderView> ServiceOrderViews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().Ignore(i => i.RelatedItems);
            modelBuilder.Entity<OrderItem>().Ignore(i => i.RelatedItems);
            modelBuilder.Entity<ServiceOrder>().Ignore(i => i.RelatedItems);
            modelBuilder.Entity<ServiceOrderView>().Ignore(i => i.RelatedItems);
            base.OnModelCreating(modelBuilder);
        }
    }
}
