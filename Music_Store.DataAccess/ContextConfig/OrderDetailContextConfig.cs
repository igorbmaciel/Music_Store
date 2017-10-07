using Music_Store.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Store.DataAccess.ContextConfig
{
    public class OrderDetailContextConfig : EntityTypeConfiguration<OrderDetail>
    {
        public OrderDetailContextConfig()
        {
            ToTable("OrderDetail");
            HasKey(x => x.Id);
        }
    }
}
