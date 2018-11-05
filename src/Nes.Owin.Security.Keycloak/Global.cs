using System.Collections.Concurrent;
using Nes.Keycloak.IdentityModel.Utilities.Caching;

namespace Nes.Owin.Security.Keycloak
{
    internal static class Global
    {
        public static StateCache StateCache { get; } = new StateCache();

        public static ConcurrentDictionary<string, KeycloakAuthenticationOptions> KeycloakOptionStore { get; } =
            new ConcurrentDictionary<string, KeycloakAuthenticationOptions>();
    }
}