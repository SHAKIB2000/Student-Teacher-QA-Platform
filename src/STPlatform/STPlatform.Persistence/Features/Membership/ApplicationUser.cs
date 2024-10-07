
using Microsoft.AspNetCore.Identity;

namespace STPlatform.Persistence.Features.Membership
{
	public class ApplicationUser : IdentityUser<Guid>
	{
        public string? Name { get; set; }
        public string? InstituteName { get; set; }
        public string? InstituteID { get; set; }
    }
}
