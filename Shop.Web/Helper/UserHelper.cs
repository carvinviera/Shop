namespace Shop.Web.Helper
{
    using Microsoft.AspNetCore.Identity;
    using Shop.Web.Data;
    using System.Threading.Tasks;

    public class UserHelper : IUserHelper
    {
        private readonly UserManager<User> userManager;

        public UserHelper(UserManager<User> userManager)
        {
            this.userManager = userManager;
        }

        public async Task<IdentityResult> AddUserAsync(User user, string password)
        {
            return await userManager.CreateAsync(user, password);
        }

        public async Task<User> GetUserByMailAsync(string email)
        {
            return await userManager.FindByEmailAsync(email);
        }

    }
}
