using Microsoft.Owin;
using Owin;

namespace SignalRFlash.Web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}