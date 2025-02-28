namespace MyWebAPI.Models
{
    public class RoomType
    {
        public string Name { get; set; }
        public Boolean isAvailable { get; set; }
        public double Price { get; set; }

    }

    public class Rooms : RoomType
    {
        public Guid Id { get; set; }
    }
}
