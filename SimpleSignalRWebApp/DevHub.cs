using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SimpleSignalRWebApp
{
    public class DevHub : Hub
    {
        public void Hello()
        {
            Clients.All.hello();
        }

        public void BroadCastReply(string reply)
        {
            Clients.Others.QueryResponder(reply);
        }

        public void askQuery(string id,string qry)
        {
            Clients.Others.QueryReciever(id,qry);
        }
    }
}