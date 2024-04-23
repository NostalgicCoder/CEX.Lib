namespace CEX.Console.Models
{
    public class Response
    {
        public string ack { get; set; }
        public Data data { get; set; }
        public Error error { get; set; }
    }
}
