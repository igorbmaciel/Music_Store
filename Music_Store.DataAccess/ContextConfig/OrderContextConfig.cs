using Music_Store.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Store.DataAccess.ContextConfig
{
    public class OrderContextConfig : EntityTypeConfiguration<Order>
    {
        public OrderContextConfig()
        {
            ToTable("Order");
            HasKey(x => x.Id);
        }
    }
}
