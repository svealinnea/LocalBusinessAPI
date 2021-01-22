using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using BusinessLookupApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BusinessLookupApi.Controllers
{
  [Route("api/[controller]")] 
  [ApiController]
  public class ShopsController : ControllerBase
  {
    private BusinessLookupApiContext _db;

    public ShopsController(BusinessLookupApiContext db)  
    {
      _db = db;
    }

    // GET api/shops
    [HttpGet]
    public ActionResult<IEnumerable<Shop>> Get(string address, string name)
    {
      var query = _db.Shops.AsQueryable();

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

    // POST api/shops
    [HttpPost]
    public void Post([FromBody] Shop shop) 
    {
      _db.Shops.Add(shop);
      _db.SaveChanges();
    }

    // GET api/shops/5
    [HttpGet("{id}")]
    public ActionResult<Shop> Get(int id)
    {
        return _db.Shops.FirstOrDefault(entry => entry.ShopId == id);
    }
    
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Shop shop)
    {
        shop.ShopId = id;
        _db.Entry(shop).State = EntityState.Modified;
        _db.SaveChanges();
    }

        // DELETE api/shops/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var shopToDelete = _db.Shops.FirstOrDefault(entry => entry.ShopId == id);
      _db.Shops.Remove(shopToDelete);
      _db.SaveChanges();
    }

  }
}