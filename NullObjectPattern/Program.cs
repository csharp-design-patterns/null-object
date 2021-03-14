using NullObjectPattern.Models;
using NullObjectPattern.Services;
using System;

namespace NullObjectPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IClient client = new Client();

            var clientService = new ClientService();

            if (client == null)
                client = new NullClient();

            clientService.CreateClient(client);
        }
    }
}
