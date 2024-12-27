using MyTheme.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace MyTheme.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(MyThemeEntityFrameworkCoreModule),
    typeof(MyThemeApplicationContractsModule)
)]
public class MyThemeDbMigratorModule : AbpModule
{
}
