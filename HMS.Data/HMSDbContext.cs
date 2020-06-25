namespace HMS.Data
{
    using System.Data.Entity;
    using HMS.Models;

    public class HMSDbContext : DbContext
    {
        public HMSDbContext()
            : base(@"Data Source=WORKSTATION;Initial Catalog=master;Integrated Security=True")
        {

        }

        public DbSet<Booking> Booking { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }   
        public DbSet<RoomCategory> RoomCategory { get; set; }
        public DbSet<RoomCapacity> RoomCapacity { get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}