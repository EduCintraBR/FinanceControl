using Microsoft.AspNetCore.Identity;

namespace FinanceControl.Api.Models
{
    public class AppUser : IdentityUser
    {
        public string Nome { get; set; }
    }
}
