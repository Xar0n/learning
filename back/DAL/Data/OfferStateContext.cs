using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.StateMachines;
using MassTransit;
using MassTransit.EntityFrameworkCoreIntegration;
using Microsoft.EntityFrameworkCore;

namespace DAL.Data
{
    public class OfferStateContext : SagaDbContext
    {
        public OfferStateContext(DbContextOptions options)
       : base(options)
        {
        }

        protected override IEnumerable<ISagaClassMap> Configurations
        {
            get { yield return new OfferStateMap(); }
        }
    }
}
