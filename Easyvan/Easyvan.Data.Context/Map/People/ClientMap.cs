﻿using Easyvan.Data.Entity.People;
using System.Data.Entity.ModelConfiguration;

namespace Easyvan.Data.Context.Map.People
{
    public class ClientMap : EntityTypeConfiguration<Client>
    {
        public ClientMap()
        {
            this.ToTable(typeof(Client).Name);
            this.HasKey(x => x.Id);
        }
    }
}