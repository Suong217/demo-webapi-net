using Microsoft.AspNetCore.Mvc;
using MyWebAPI.Models;

namespace MyWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : Controller
    {
        public static List<Rooms> rooms = new List<Rooms>();
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(rooms);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            try
            {
                //Truy van du lieu
                var room = rooms.SingleOrDefault(r => r.Id == Guid.Parse(id));
                if (room == null)
                {
                    return NotFound();
                }
                return Ok(room);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost]
        public IActionResult Create(RoomType roomType)
        {
            var room = new Rooms
            {
                Id = Guid.NewGuid(),
                Name = roomType.Name,
                Price = roomType.Price,
                isAvailable = roomType.isAvailable,
            };
            rooms.Add(room);
            return Ok(new
            {
                Success = true,
                Data = room
            });
        }

        [HttpPut("{id}")]
        public IActionResult Edit(string id, Rooms roomEdit)
        {
            try
            {
                var room = rooms.SingleOrDefault(r => r.Id == Guid.Parse(id));
                if (room == null)
                {
                    return NotFound();
                }
                if (id != roomEdit.Id.ToString())
                {
                    return BadRequest();
                }
                room.Name = roomEdit.Name;
                room.Price = roomEdit.Price;
                room.isAvailable = roomEdit.isAvailable;

                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpDelete("{id}")]
        public IActionResult Remove(string id)
        {
            try
            {
                var room = rooms.SingleOrDefault(r => r.Id == Guid.Parse(id));
                if (room == null)
                {
                    return NotFound();
                }
               
                rooms.Remove(room);

                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
