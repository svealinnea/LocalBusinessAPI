using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using BusinessLookupApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BusinessLookupApi.Controllers
{
  [Route("api/[controller]")] 
  [ApiController]
  public class BusinessesController : ControllerBase
  {
    private BusinessLookupApiContext _db;

    public BusinessesController(BusinessLookupApiContext db)  
    {
      _db = db;
    }

   
    [HttpGet]
    public ActionResult<IEnumerable<Restaurant>> Get(string address, string name)
    {
      var query = _db.Restaurants.AsQueryable();

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
    public void Post([FromBody] Restaurant restaurant) 
    {
      _db.Restaurants.Add(restaurant);
      _db.SaveChanges();
    }

    
    [HttpGet("{id}")]
    public ActionResult<Restaurant> Get(int id)
    {
        return _db.Restaurants.FirstOrDefault(entry => entry.RestaurantId == id);
    }
    
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Restaurant restaurant)
    {
        restaurant.RestaurantId = id;
        _db.Entry(restaurant).State = EntityState.Modified;
        _db.SaveChanges();
    }

  
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var restaurantToDelete = _db.Restaurants.FirstOrDefault(entry => entry.RestaurantId == id);
      _db.Restaurants.Remove(restaurantToDelete);
      _db.SaveChanges();
    }

  }
}