using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MySytik.Areas.Identity.Data;
using MySytik.Data;

[assembly: HostingStartup(typeof(MySytik.Areas.Identity.IdentityHostingStartup))]
namespace MySytik.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<MySytikdDbContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("MySytikdDbContextConnection")));

                services.AddDefaultIdentity<MySytikUser>(options =>
                {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;

                 })
                    .AddEntityFrameworkStores<MySytikdDbContext>();
            });
        }
    }
}