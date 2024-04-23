namespace CEX.Console.Models
{
    public class Boxlistsbox
    {
        public string boxId { get; set; }
        public string boxName { get; set; }
        public string categoryName { get; set; }
        public string categoryFriendlyName { get; set; }
        public int superCatId { get; set; }
        public string superCatName { get; set; }
        public string superCatFriendlyName { get; set; }
        public Imageurls imageUrls { get; set; }
        public int isNewBox { get; set; }
        public int sellPrice { get; set; }
        public int cashPrice { get; set; }
        public int exchangePrice { get; set; }
        public float? boxRating { get; set; }
        public int outOfEcomStock { get; set; }
        public int collectionQuantity { get; set; }
        public Displayableboxattribute[] displayableBoxAttributes { get; set; }
        public int boxSaleAllowed { get; set; }
        public int boxBuyAllowed { get; set; }
        public int boxWebSaleAllowed { get; set; }
        public int boxWebBuyAllowed { get; set; }
        public object imageNames { get; set; }
        public object isImageTypeInternal { get; set; }
    }
}
