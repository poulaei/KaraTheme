using Volo.Abp.Modularity;

namespace MyTheme;

[DependsOn(
    typeof(MyThemeDomainModule),
    typeof(MyThemeTestBaseModule)
)]
public class MyThemeDomainTestModule : AbpModule
{

}
