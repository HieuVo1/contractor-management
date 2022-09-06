using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using contractor_management.Models;
using Microsoft.EntityFrameworkCore;

namespace contractor_management.Data
{
    public class ContractorDBContext : DbContext
    {
        public ContractorDBContext(DbContextOptions<ContractorDBContext> options) : base(options)
        {

        }

        public DbSet<Contractor> Contractors { get; set; }
    }
}