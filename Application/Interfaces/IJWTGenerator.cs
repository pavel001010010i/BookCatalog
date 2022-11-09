using Domain.Models;
using System.Security.Claims;

namespace Application.Interfaces
{
    public interface IJwtService
    {
        string GenerateAccessToken(IEnumerable<Claim> claims);
        string GenerateRefreshToken();
        ClaimsPrincipal? GetPrincipalFromExpiredToken(string token);
        Task<IEnumerable<Claim>> GetClaimsUser(AppUser user);
    }
}
