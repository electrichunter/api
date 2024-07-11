// IAuthService.cs

using api.Server.Models;
using System.Threading.Tasks;

namespace api.Server.Servisler
{
    public interface IAuthService
    {
        Task<AuthResult> LoginAsync(string email, string password);
    }
}
