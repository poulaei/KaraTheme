using Volo.Abp.Modularity;

namespace MyTheme;

/* Inherit from this class for your domain layer tests. */
public abstract class MyThemeDomainTestBase<TStartupModule> : MyThemeTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
