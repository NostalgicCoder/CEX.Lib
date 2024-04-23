namespace CEX.Console.Models
{
    public class Boxdetail
    {
        public string boxId { get; set; }
        public string boxName { get; set; }
        public int categoryId { get; set; }
        public string categoryName { get; set; }
        public string categoryFriendlyName { get; set; }
        public int superCatId { get; set; }
        public string superCatName { get; set; }
        public string superCatFriendlyName { get; set; }
        public int cannotBuy { get; set; }
        public int isNewBox { get; set; }
        public float cashPrice { get; set; }
        public int exchangePrice { get; set; }
        public float sellPrice { get; set; }
        public int firstPrice { get; set; }
        public float previousPrice { get; set; }
        public string lastPriceUpdatedDate { get; set; }
        public float boxRating { get; set; }
        public int collectionQuantity { get; set; }
        public int outOfStock { get; set; }
        public int ecomQuantityOnHand { get; set; }
        public int webSellAllowed { get; set; }
        public int webBuyAllowed { get; set; }
        public int webShowSellPrice { get; set; }
        public int webShowBuyPrice { get; set; }
        public int boxSaleAllowed { get; set; }
        public int boxBuyAllowed { get; set; }
        public int boxWebSaleAllowed { get; set; }
        public int boxWebBuyAllowed { get; set; }
        public Imageurls imageUrls { get; set; }
        public int isMasterBox { get; set; }
        public string boxDescription { get; set; }
        public object operatorId { get; set; }
        public object gradeId { get; set; }
        public Productguide productGuide { get; set; }
        public object boxRatingText { get; set; }
        public object attributeDetails { get; set; }
        public object variantGroupValue { get; set; }
        public object displayableBoxAttributes { get; set; }
        public Attributeinfo[] attributeInfo { get; set; }
        public object imageNames { get; set; }
        public object isImageTypeInternal { get; set; }
    }
}
