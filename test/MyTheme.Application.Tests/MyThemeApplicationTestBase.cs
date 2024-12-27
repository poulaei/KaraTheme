using Volo.Abp.Modularity;

namespace MyTheme;

public abstract class MyThemeApplicationTestBase<TStartupModule> : MyThemeTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
