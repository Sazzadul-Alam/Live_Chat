﻿using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LiveChat.SignalR.Hubs
{
    public class ChatHub : Hub
    {
       public void Send(string name, string message)
        {
            Clients.All.addNewMessageToPage(name, message);
        }
    }
}