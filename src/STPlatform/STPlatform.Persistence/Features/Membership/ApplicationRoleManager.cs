using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using STPlatform.Persistence.Features.Membership;

namespace STPlatform.Persistence.Features.Membership
{
    public class ApplicationRoleManager
		: RoleManager<ApplicationRole>
	{
		public ApplicationRoleManager(IRoleStore<ApplicationRole> store, IEnumerable<IRoleValidator<ApplicationRole>> roleValidators, ILookupNormalizer keyNormalizer, IdentityErrorDescriber errors, ILogger<RoleManager<ApplicationRole>> logger)
			: base(store, roleValidators, keyNormalizer, errors, logger)
		{
		}
	}
}
