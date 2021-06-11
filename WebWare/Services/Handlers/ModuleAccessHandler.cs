using Microsoft.AspNetCore.Authorization;
using WebWare.Services.Requirements;
using System;
using System.Security.Claims;
using System.Threading.Tasks;
using WebWare.Models;
using Microsoft.EntityFrameworkCore;

namespace WebWare.Authorization
{
    public class ModuleAccessHandler : AuthorizationHandler<ModuleAccessRequirement>
    {
        private WebWareContext _context;

        public ModuleAccessHandler(WebWareContext context)
        {
            _context = context;
        }

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, ModuleAccessRequirement requirement)
        {
            var userId = context.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            if (_context.UserModules.AnyAsync(o => o.UserId == userId && o.ModuleId == requirement.userID).Result)
                context.Succeed(requirement);
            else
                context.Fail();
            return Task.CompletedTask;

        }
    }
}
