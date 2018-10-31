using System.Reflection;

namespace Nes.IdentityModel.Keycloak
{
    public static class Global
    {
        public static string GetVersion()
        {
            return Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }

        public static bool CheckVersion(string version)
        {
            return GetVersion() == version;
        }
    }
}