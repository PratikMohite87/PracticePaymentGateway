using Microsoft.EntityFrameworkCore;
using PaymentGatewayWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentGatewayWebApi.Data
{
    public class PaymentDetailContext : DbContext
    {
                                    // db provider and connection string is passed.
        public PaymentDetailContext(DbContextOptions<PaymentDetailContext> options) : base(options)
        { }

        public DbSet<PaymentDetail> PaymentDetails { set; get; }
    }
}
