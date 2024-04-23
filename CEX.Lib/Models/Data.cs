namespace CEX.Console.Models
{
    public class Data
    {
        public Supercat[] superCats { get; set; }
        public Store[] stores { get; set; }
        public Productline[] productLines { get; set; }
        public Category[] categories { get; set; }
        public Neareststore[] nearestStores { get; set; }
        public Boxlistsbox[] boxlistsBoxes { get; set; }
        public Boxdetail[] boxDetails { get; set; }
        public object masterBoxDetails { get; set; }
    }
}
