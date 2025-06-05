using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nop.Core.Infrastructure;
using Nop.Plugin.Misc.MediaMigration.Data;


namespace Nop.Plugin.Misc.MediaMigration.Infrastructure;
public class PluginNopStartup : INopStartup
{
    public int Order => 999;

    public void Configure(IApplicationBuilder application)
    {
       
    }

    public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        // اضافه کردن DbContext برای دیتابیس خارجی
        services.AddDbContext<OldStoreDbContext>(options =>
            options.UseSqlServer("Data Source=5.182.44.159,1433;Initial Catalog=Etminanshop;Integrated Security=False;Persist Security Info=False;User ID=sa;Password=!!Etmin@nShop#!@12548012986;Trust Server Certificate=True"));
    }
}
