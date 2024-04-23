namespace CEX.Console.Models
{
    public class Category
    {
        public int superCatId { get; set; }
        public int categoryId { get; set; }
        public string categoryName { get; set; }
        public int isPrimary { get; set; }
        public string categoryFriendlyName { get; set; }
        public int productLineId { get; set; }
        public int totalBoxes { get; set; }
        public int isWizard { get; set; }
    }
}
