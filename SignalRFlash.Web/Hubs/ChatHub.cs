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
        //Hello this is jayant
        public void BroadcastMessage(string fromUser, string message)
        {
            Clients.All.writeMessage(fromUser, message);
        }
    }
}