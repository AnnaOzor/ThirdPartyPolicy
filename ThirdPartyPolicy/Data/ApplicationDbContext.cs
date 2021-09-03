using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThirdPartyPolicy.Models;

namespace ThirdPartyPolicy.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<CustomerInfo> CustomerInfos { get; set; }
        public DbSet<Policy> Policies { get; set; }
        public DbSet<PurchasePolicy> PurchasePolicies { get; set; }
        public DbSet<ChangeUserPassword> ChangeUserPasswords { get; set; }
        public DbSet<UserLogin> UserLogins { get; set; }
        public DbSet <VehicleInfo> VehicleInfos { get; set; }

    }
}
