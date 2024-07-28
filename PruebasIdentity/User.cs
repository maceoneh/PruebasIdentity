using Microsoft.AspNetCore.Identity;

namespace PruebasIdentity
{
    public class User : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Name { get; set; }
    }
}
