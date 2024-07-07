using DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DataAccess;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<EfContext>
{
    public EfContext CreateDbContext(string[] args)
    {
        DbContextOptionsBuilder<EfContext> dbContextOptionsBuilder = new();
        dbContextOptionsBuilder.UseSqlServer(Configuration.ConnectionString!);
        return new();
    }
}