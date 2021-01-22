using System.ComponentModel.DataAnnotations;

namespace BusinessLookupMvc.Models
{
  public class Shop
  {
    public int ShopId { get; set; }

    public string Name { get; set; }

    public string Address { get; set; }

  public static List<Shop> GetShop()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.result;
      JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
      List<Shop> shopList = JsonConvert.DeserializeObject<List<Shop>>(jsonResponse.ToString());

      return shopList;

    }
    public static Shop GetDetails(int id)
    {
      var apiCallTask = ApiHelper.Get(id);
      var result = apiCallTask.Result;

      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      Shop shop = JsonConvert.DeserializeObject<Shop>(jsonResponse.ToString());

      return shop;
    }
    public static void Post(Shop shop)
    {
      string jsonShop = JsonConvert.SerializeObject(shop);
      var apiCallTask = ApiHelper.Post(jsonShop);
    }
    public static void Put(Shop shop)
    {
      string jsonShop = JsonConvert.SerializeObject(shop);
      var apiCallTask = ApiHelper.Put(shop.ShopId, jsonShop);
    }
  }
}