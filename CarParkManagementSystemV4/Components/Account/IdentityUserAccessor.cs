﻿using CarParkManagementSystemV4.Data;
using Microsoft.AspNetCore.Identity;

namespace CarParkManagementSystemV4.Components.Account
{
    internal sealed class IdentityUserAccessor(UserManager<CarParkManagementSystemV4User> userManager, IdentityRedirectManager redirectManager)
    {
        public async Task<CarParkManagementSystemV4User> GetRequiredUserAsync(HttpContext context)
        {
            var user = await userManager.GetUserAsync(context.User);

            if (user is null)
            {
                redirectManager.RedirectToWithStatus("Account/InvalidUser", $"Error: Unable to load user with ID '{userManager.GetUserId(context.User)}'.", context);
            }

            return user;
        }
    }
}
