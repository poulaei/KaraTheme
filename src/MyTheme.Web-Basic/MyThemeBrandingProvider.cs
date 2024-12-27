using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;
using Microsoft.Extensions.Localization;
using MyTheme.Localization;

namespace MyTheme.Web;

[Dependency(ReplaceServices = true)]
public class MyThemeBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<MyThemeResource> _localizer;

    public MyThemeBrandingProvider(IStringLocalizer<MyThemeResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
