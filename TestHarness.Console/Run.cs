using CEX.Console.Models;
using CEX.Lib;

namespace TestHarness.Console
{
    public class Run
    {
        public void CallApi()
        {
            Cex cex = new Cex();

            List<Neareststore> eg1 = cex.GetNearestStoresBySku("5021290026490", "51.454266", "-0.978130");

            List<Boxlistsbox> eg2 = cex.GetTopSellers();

            cex.GetStoreNames();

            Store result = cex.GetStoreDataByName("reading");

            System.Console.ReadLine();
        }
    }
}