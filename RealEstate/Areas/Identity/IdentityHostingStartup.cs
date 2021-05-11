using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RealEstate.Areas.Identity.Data;
using RealEstate.Data;

//[assembly: HostingStartup(typeof(RealEstate.Areas.Identity.IdentityHostingStartup))]
namespace RealEstate.Areas.Identity
{
    //public class IdentityHostingStartup : IHostingStartup
    //{
    //    //public void Configure(IWebHostBuilder builder)
    //    //{
    //    //    builder.ConfigureServices((context, services) => {
    //    //        services.AddDbContext<RealEstateContext>(options =>
    //    //            options.UseSqlServer(
    //    //                context.Configuration.GetConnectionString("RealEstateContextConnection")));

    //    //        services.AddDefaultIdentity<RealEstateUser>(options => options.SignIn.RequireConfirmedAccount = true)
    //    //            .AddEntityFrameworkStores<RealEstateContext>();
    //    //    });
    //    //}
    //}
}