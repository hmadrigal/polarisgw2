namespace ArenaNet.GuildWars2
{
    using UriParameter = System.Collections.Generic.KeyValuePair<string, object>;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using ArenaNet.GuildWars2.Models;

    public partial class Gw2WebClient : IGw2WebClient
    {
        public async Task<IColorDescriptions> GetColorDescriptions(string language)
        {
            var optionalParameters = new List<UriParameter>() { new UriParameter("lang", language) };
            var uri = _routeManager.Resolve(Gw2ApiWebMethods.MiscellaneousAPI.Colors, optionalParameters: optionalParameters);
#if CRASH_TEST
            uri = GetCrashTestUri(uri);
#endif
            try
            {
                var result = await GetJsonFromUri<ColorDescriptions>(uri);
                return result;
            }
            catch (System.Net.WebException innerException)
            {
                throw new GuildWars2ApiException(string.Format(Exceptions.GetColorDescriptionsError, uri), innerException);
            }
        }

        public async Task<IBuild> GetBuild()
        {
            var uri = _routeManager.Resolve(Gw2ApiWebMethods.MiscellaneousAPI.Build);
#if CRASH_TEST
            uri = GetCrashTestUri(uri);
#endif
            try
            {
                var result = await GetJsonFromUri<Build>(uri);
                return result;
            }
            catch (System.Net.WebException innerException)
            {
                throw new GuildWars2ApiException(string.Format(Exceptions.GetBuildError, uri), innerException);
            }
        }
    }
}
