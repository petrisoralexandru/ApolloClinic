using System;
using Microsoft.EntityFrameworkCore;

namespace ApolloClinic.DataAccess.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}
        
        

    }
}
