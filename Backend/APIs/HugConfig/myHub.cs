using System;
using Microsoft.AspNetCore.SignalR;
using APIs.models;

namespace APIs.HubConfig
{
    public class MyHub : Hub
    {
        public async Task BroadcastTableData(List<ErrorMessage> data) =>
            await Clients.All.SendAsync("broadcasttabledata", data);
    }
}

