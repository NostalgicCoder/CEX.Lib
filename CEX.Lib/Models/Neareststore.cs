namespace CEX.Console.Models
{
    public class Neareststore
    {
        public string storeId { get; set; }
        public string storeName { get; set; }
        public string[] storeImageUrls { get; set; }
        public string quantityOnHand { get; set; }
        public string collectionQuantity { get; set; }
        public int isAvailableForCollection { get; set; }
        public int isAvailableForCollectionBeta { get; set; }
        public Timings timings { get; set; }
        public object holidayTimings { get; set; }
        public float distance { get; set; }
    }
}
