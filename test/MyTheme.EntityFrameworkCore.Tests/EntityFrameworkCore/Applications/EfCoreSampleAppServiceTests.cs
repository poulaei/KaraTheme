using MyTheme.Samples;
using Xunit;

namespace MyTheme.EntityFrameworkCore.Applications;

[Collection(MyThemeTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<MyThemeEntityFrameworkCoreTestModule>
{

}
