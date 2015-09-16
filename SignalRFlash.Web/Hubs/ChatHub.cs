using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//ulfa class by admin
namespace SignalRFlash.Web.Hubs
{
    public class ChatHub : Hub
    {
        //Added by feature branch to say hello
        //Hello this is jayant
        public void BroadcastMessage(string fromUser, string message)
        {
            //pakodi
            Clients.All.writeMessage(fromUser, message);
        }
    }
}