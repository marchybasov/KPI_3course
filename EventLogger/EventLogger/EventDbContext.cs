using System.Collections.Generic;
using System.Text;
using System.Data;

using Microsoft.EntityFrameworkCore;
using Microsoft.Data.SqlClient;

namespace EventLogger
{
    public class EventDbContext:DbContext
    {
        public DbSet<EventEntity> EventsLog { get; set; }
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new SqlConnectionStringBuilder
            {
                DataSource = @"myserver\MSSQL16",
                InitialCatalog = "EventLoggerDB",
                UserID = "sa",
                Password = "Ghjcnj123"
            };

            var connectionString = builder.ConnectionString;

            optionsBuilder.UseSqlServer(connectionString);
        }

    }

   
}
