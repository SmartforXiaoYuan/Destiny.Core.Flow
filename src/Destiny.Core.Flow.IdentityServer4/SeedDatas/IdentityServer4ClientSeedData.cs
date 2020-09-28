﻿using Destiny.Core.Flow.Dependency;
using Destiny.Core.Flow.Extensions;
using Destiny.Core.Flow.Model.DestinyIdentityServer4;
using Destiny.Core.Flow.Model.SeedDatas;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Destiny.Core.Flow.IdentityServer
{
    [Dependency(ServiceLifetime.Singleton)]
    public class IdentityServer4ClientSeedData : SeedDataDefaults<Client, Guid>
    {
        public IdentityServer4ClientSeedData(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }
        protected override Expression<Func<Client, bool>> Expression(Client entity)
        {
            return o => o.ClientId == entity.ClientId;
        }
        protected override Client[] SetSeedData()
        {
            List<Client> clients = new List<Client>();
            foreach (var item in Config.GetClients())
            {
                clients.Add(item.MapTo<Client>());
            }
            return clients.ToArray();
        }
    }
}
