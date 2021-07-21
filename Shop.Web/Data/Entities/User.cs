namespace Shop.Web.Data
{
    using Microsoft.AspNetCore.Identity;
    using Entities;
    public class User : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}


