using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using BusinessLookupApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BusinessLookupApi.Controllers
{
  [Route("api/[controller]")] 
  [ApiController]
  public class HotelsController : ControllerBase
  {
    private BusinessLookupApiContext _db;

    public HotelsController(BusinessLookupApiContext db)  
    {
      _db = db;
    }


    [HttpGet]
    public ActionResult<IEnumerable<Hotel>> Get(string address, string name)
    {
      var query = _db.Hotels.AsQueryable();

      if (address !=null)
      {
        query = query.Where(entry => entry.Address == address);
      }

      if (name != null)
      {
        query = query.Where(entry => entry.Name ==  name);
      }  

      return query.ToList();
    }


    [HttpPost]
    public void Post([FromBody] Hotel hotel) 
    {
      _db.Hotels.Add(hotel);
      _db.SaveChanges();
    }

    [HttpGet("{id}")]
    public ActionResult<Hotel> Get(int id)
    {
        return _db.Hotels.FirstOrDefault(entry => entry.HotelId == id);
    }
    
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Hotel hotel)
    {
        hotel.HotelId = id;
        _db.Entry(hotel).State = EntityState.Modified;
        _db.SaveChanges();
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var hotelToDelete = _db.Hotels.FirstOrDefault(entry => entry.HotelId == id);
      _db.Hotels.Remove(hotelToDelete);
      _db.SaveChanges();
    }

  }
}