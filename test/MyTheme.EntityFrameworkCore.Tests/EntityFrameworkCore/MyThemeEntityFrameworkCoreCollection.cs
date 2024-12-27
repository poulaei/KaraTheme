using Xunit;

namespace MyTheme.EntityFrameworkCore;

[CollectionDefinition(MyThemeTestConsts.CollectionDefinitionName)]
public class MyThemeEntityFrameworkCoreCollection : ICollectionFixture<MyThemeEntityFrameworkCoreFixture>
{

}
