using Microsoft.EntityFrameworkCore;

namespace MyWebAPI.Data
{
    public class RoomDBContext : DbContext
    {
        public RoomDBContext(DbContextOptions options) : base(options)
        {

        }
        #region DbSet
        public DbSet<Room> Rooms { get; set; }
        #endregion
    }
}
