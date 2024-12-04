using Deploye.Domain.Abstractions;
using Deploye.Domain.Entities;
using Deploye.Infrastructure.Data;
using Microsoft.AspNetCore.Identity;
using System;

namespace Deploye.Web.Modules;

public class AuthModule : IModule
{
    public void Load(IServiceCollection services)
    {
        services
        .AddIdentity<User, IdentityRole>()
            .AddEntityFrameworkStores<ApplicationDbContext>()
            .AddDefaultTokenProviders();

        services.ConfigureApplicationCookie(options =>
        {
            options.LoginPath = "/Users/Login";
        });
    }
}
