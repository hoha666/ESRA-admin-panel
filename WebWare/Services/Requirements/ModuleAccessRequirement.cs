using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;


namespace WebWare.Services.Requirements
{
    public class ModuleAccessRequirement : IAuthorizationRequirement
    {
        public int userID { get; private set; }
        public ModuleAccessRequirement(int ModuleId)
        {
            userID = ModuleId;
        }
    }
}
