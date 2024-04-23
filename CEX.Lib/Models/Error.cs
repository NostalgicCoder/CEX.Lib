namespace CEX.Console.Models
{
    public class Error
    {
        public string code { get; set; }
        public string internal_message { get; set; }
        public object[] moreInfo { get; set; }
    }
}
