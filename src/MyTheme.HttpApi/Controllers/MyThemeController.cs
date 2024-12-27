﻿using MyTheme.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace MyTheme.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class MyThemeController : AbpControllerBase
{
    protected MyThemeController()
    {
        LocalizationResource = typeof(MyThemeResource);
    }
}
