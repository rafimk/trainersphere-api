using System.Security.Claims;

namespace Authorization.Extensions;

/// <summary>
/// Contains extension methods for the <see cref="ClaimsPrincipal"/> class.
/// </summary>
internal static class ClaimsPrincipalExtensions
{
    internal static string GetIdentityProviderId(this ClaimsPrincipal claimsPrincipal) =>
        claimsPrincipal.Claims.SingleOrDefault(claim => claim.Type == ClaimTypes.NameIdentifier)?.Value ?? string.Empty;
}
