namespace Shop.Web.Helper
{
    using Microsoft.AspNetCore.Identity;
    using Shop.Web.Data;
    using System.Threading.Tasks;
    public interface IUserHelper
    {
        Task<User> GetUserByMailAsync(string email);
        Task<IdentityResult> AddUserAsync(User user, string password);
    }
}

