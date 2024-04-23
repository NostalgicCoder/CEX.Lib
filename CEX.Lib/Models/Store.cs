namespace CEX.Console.Models
{
    public class Store
    {
        public int storeId { get; set; }
        public string storeName { get; set; }
        public string regionName { get; set; }
        public float latitude { get; set; }
        public float longitude { get; set; }
        public object regionImageUrls { get; set; }
        public object phoneNumber { get; set; }
        public string closingTime { get; set; }
    }
}
