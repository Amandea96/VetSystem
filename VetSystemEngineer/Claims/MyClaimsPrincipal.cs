using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using VetSystemEngineer.Models;

namespace VetSystemEngineer.Claims { 

public class MyClaimsPrincipal : UserClaimsPrincipalFactory<ApplicationUser, IdentityRole>
{
    public MyClaimsPrincipal(

        UserManager<ApplicationUser> userManager,
        RoleManager<IdentityRole> roleManager,
        IOptions<IdentityOptions> optionsAccessor)
            : base(userManager, roleManager,optionsAccessor)
    {
    }

    protected override async Task<ClaimsIdentity> GenerateClaimsAsync(ApplicationUser user)
    {
        var identity = await base.GenerateClaimsAsync(user);
            identity.AddClaim(new Claim("MyInst", user.IdInst.ToString()));
            identity.AddClaim(new Claim("LogName", user.Name.ToString()));
            identity.AddClaim(new Claim("LogSurName", user.Surname.ToString()));
           
            
            return identity;
    }
}
}