using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentAPI.Models
{
    public class PaymentDetailContext : DbContext
    {
        public PaymentDetailContext(DbContextOptions<PaymentDetailContext> options) : base(options) // ctor Tab Tab to make a constructor
        {
        }

        public DbSet<PaymentDetail> PaymentDetails { get; set; }

    }
}
