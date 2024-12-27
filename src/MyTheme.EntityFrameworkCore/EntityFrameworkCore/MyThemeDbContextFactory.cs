using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MyTheme.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class MyThemeDbContextFactory : IDesignTimeDbContextFactory<MyThemeDbContext>
{
    public MyThemeDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        MyThemeEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<MyThemeDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new MyThemeDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../MyTheme.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
