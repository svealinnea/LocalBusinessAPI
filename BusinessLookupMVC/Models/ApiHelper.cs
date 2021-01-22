using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CretaceousParkMvc.Models
{
  public class Shop
  {
    public int ShopId { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }


    public static List<Shop> GetShops()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

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
  public class Business
  {
    public int BusinessId { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }


    public static List<Business> GetBusinesses()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;

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
      var apiCallTask = ApiHelper.Put(shop.BusinessId, jsonBusiness);
    }
    
  }
}