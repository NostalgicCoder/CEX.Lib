using CEX.Console.Models;
using Newtonsoft.Json;
using RestSharp;

namespace CEX.Lib
{
    // WeBuy API - 1: https://github.com/Dionakra/webuy-api
    // WeBuy API - 2:https://github.com/martinsirbe/cex-stock-checker
    // WeBuy API - 3:https://github.com/piotrpdev/WeBuy-Cex-Price-Tracker
    // Using REST calls with C#: https://www.youtube.com/watch?v=qm29vYcYBeg

    public class Cex
    {
        private RestClient _client = new RestClient("https://wss2.cex.uk.webuy.io/v3/");

        private Rootobject _stores;
        private Rootobject _categories;
        private Rootobject _subCategories;
        private Rootobject _subSubCategories;

        /// <summary>
        /// Constructor
        /// </summary>
        public Cex()
        {
            _stores = SendRequest("stores");
            _categories = SendRequest("supercats");
            _subCategories = SendRequest("productlines?superCatIds=[1,2,3,4,5,8]");
            _subSubCategories = SendRequest("categories?productLineIds=[70,81,92,91,8,49,59,6,33,29,67,74,39,79,7,10,26,54,17,40,78,13,14,32,25,28,15,61,62,76,27,21,16,51,80,65,18,23,84,83,19,85,71,68,60,73,64,63,75]");

            //Rootobject search = SendRequest("boxes?q=q&firstRecord=1&count=50&sortBy=relevance&sortOrder=desc"); // REST command non-functional as of April 2024
        }

        /// <summary>
        /// Call endpoint, pass parameters over and then if successful result deserialize JSON and map the contents to an object
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        private Rootobject SendRequest(string param)
        {
            RestRequest request = new RestRequest(param);
            RestResponse response = _client.Execute(request, Method.Get);

            Rootobject result = new Rootobject();

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string rawResponse = response.Content;

                result = JsonConvert.DeserializeObject<Rootobject>(rawResponse);
            }

            return result;
        }

        /// <summary>
        /// Get all store names and display to console
        /// </summary>
        public void GetStoreNames()
        {
            foreach(Store x in _stores.response.data.stores)
            {
                System.Console.WriteLine(x.storeName);
            }
        }

        /// <summary>
        /// Get all product line names and display to console
        /// </summary>
        public void GetProductLineNames()
        {
            foreach (Productline x in _subCategories.response.data.productLines)
            {
                System.Console.WriteLine(x.productLineName);
            }
        }

        /// <summary>
        /// Return the top selling items
        /// </summary>
        /// <returns></returns>
        public List<Boxlistsbox> GetTopSellers()
        {
            Rootobject result = SendRequest("boxlists/topsellers");

            return result.response.data.boxlistsBoxes.ToList();
        }

        /// <summary>
        /// List the nearest stores that stock a particular product SKU
        /// - Latitude / longitude can be found by using https://www.latlong.net/
        /// </summary>
        /// <param name="sku"></param>
        /// <param name="lat"></param>
        /// <param name="lng"></param>
        /// <returns></returns>
        public List<Neareststore> GetNearestStoresBySku(string sku, string lat, string lng)
        {
            Rootobject result = SendRequest("boxes/" + sku + "/neareststores?latitude=" + lat + "&longitude=" + lng + "");

            return result.response.data.nearestStores.ToList();
        }

        /// <summary>
        /// Get detail on a particular product SKU
        /// </summary>
        /// <param name="sku"></param>
        /// <returns></returns>
        public Boxdetail GetProductDetailsBySku(string sku)
        {
            Rootobject result = SendRequest("boxes/" + sku + "/detail");

            return result.response.data.boxDetails.FirstOrDefault();
        }

        /// <summary>
        /// Get API data on a particular store that matches your search criteria
        /// </summary>
        /// <param name="storeName"></param>
        /// <returns></returns>
        public Store GetStoreDataByName(string storeName)
        {
            return _stores.response.data.stores.Where(x => x.storeName.ToLower() == storeName.ToLower()).FirstOrDefault();
        }

        /// <summary>
        /// Get API data on a particular product line that matches your search criteria
        /// </summary>
        /// <param name="keyword"></param>
        /// <returns></returns>
        public Productline GetProductLineDataByName(string keyword)
        {
            return _subCategories.response.data.productLines.Where(x => x.productLineName.ToLower().Contains(keyword.ToLower())).FirstOrDefault();
        }
    }
}