using Microsoft.AspNetCore.Builder;
using MyTheme;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
builder.Environment.ContentRootPath = GetWebProjectContentRootPathHelper.Get("MyTheme.Web.csproj"); 
await builder.RunAbpModuleAsync<MyThemeWebTestModule>(applicationName: "MyTheme.Web");

public partial class Program
{
}
