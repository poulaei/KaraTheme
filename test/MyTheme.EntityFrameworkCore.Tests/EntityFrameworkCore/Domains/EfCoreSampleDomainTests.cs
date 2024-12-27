using MyTheme.Samples;
using Xunit;

namespace MyTheme.EntityFrameworkCore.Domains;

[Collection(MyThemeTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<MyThemeEntityFrameworkCoreTestModule>
{

}
