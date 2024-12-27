using MyTheme.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace MyTheme.Web.Pages;

public abstract class MyThemePageModel : AbpPageModel
{
    protected MyThemePageModel()
    {
        LocalizationResourceType = typeof(MyThemeResource);
    }
}
