using System.ComponentModel.DataAnnotations;

namespace BusinessLookupMvc.Models
{
  public class Business 
  {
    public int BusinessId { get; set; }

    public string Name { get; set; }

    public string Address { get; set; }

    public static List<Business> GetBusiness()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.result;
      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Business> businessList = JsonConvert.DeserializeObject<List<Business>>(jsonResponse.ToString());

      return businessList;

    }
    public static Business GetDetails(int id)
    {
      var apiCallTask = ApiHelper.Get(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Business business = JsonConvert.DeserializeObject<Business>(jsonResponse.ToString());

      return business;
    }
    public static void Post(Business business)
    {
      string jsonBusiness = JsonConvert.SerializeObject(business);
      var apiCallTask = ApiHelper.Post(jsonBusiness);
    }
    public static void Put(Business business)
    {
      string jsonBusiness = JsonConvert.SerializeObject(business);
      var apiCallTask = ApiHelper.Put(business.BusinessId, jsonBusiness);
    }
  }
}