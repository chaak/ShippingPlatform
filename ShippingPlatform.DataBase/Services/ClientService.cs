﻿using ShippingPlatform.DataBase.Repositories;
using System.Collections.Generic;
using System.Data;

namespace ShippingPlatform.DataBase.Services
{
    public class ClientService
    {
        private ClientRepository clientRepository = new ClientRepository();
        public Client FindOneClient(IDbConnection connection, int searchId)
        {
            return clientRepository.GetClient(connection, searchId);
        }
        public IEnumerable<Client> FindAllClients(IDbConnection connection)
        {
            return clientRepository.GetAllClients(connection);
        }
    }
}