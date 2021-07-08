using Holism.Api;

namespace Holism.Orders.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Startup.AddControllerSearchAssembly(typeof(Controllers.CartController).Assembly);
            Holism.Api.Config.ConfigureEverything();
            Application.Run();
        }
    }
}
