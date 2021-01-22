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

    // GET api/businesses
    [HttpGet]
    public ActionResult<IEnumerable<Business>> Get(string address, string name)
    {
      var query = _db.Businesses.AsQueryable();

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

    // POST api/businesses
    [HttpPost]
    public void Post([FromBody] Business business) 
    {
      _db.Businesses.Add(business);
      _db.SaveChanges();
    }

    // GET api/busineses/5
    [HttpGet("{id}")]
    public ActionResult<Business> Get(int id)
    {
        return _db.Businesses.FirstOrDefault(entry => entry.BusinessId == id);
    }
    
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Business business)
    {
        business.BusinessId = id;
        _db.Entry(business).State = EntityState.Modified;
        _db.SaveChanges();
    }

        // DELETE api/businesses/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var businessToDelete = _db.Businesses.FirstOrDefault(entry => entry.BusinessId == id);
      _db.Businesses.Remove(businessToDelete);
      _db.SaveChanges();
    }

  }
}