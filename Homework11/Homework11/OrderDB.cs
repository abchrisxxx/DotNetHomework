using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Homework11
{
    class OrderDB :DbContext
    {
        public OrderDB() : base("OrderDataBase")
        {
            Database.SetInitializer(
                new DropCreateDatabaseIfModelChanges<OrderDB>()
            );
        }
        public DbSet<Order> orders { get; set; }
         
        
    }
}
