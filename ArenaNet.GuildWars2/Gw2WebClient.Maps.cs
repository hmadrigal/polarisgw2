namespace ArenaNet.GuildWars2
{
    using UriParameter = System.Collections.Generic.KeyValuePair<string, object>;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using ArenaNet.GuildWars2.Models;

    public partial class Gw2WebClient : IGw2WebClient
    {
        public async Task<IContinentDescriptions> GetContinentDescriptions(string language)
        {
            var optionalParameters = new List<UriParameter>() { new UriParameter("lang", language) };
            var uri = _routeManager.Resolve(Gw2ApiWebMethods.MapAPI.Continents, optionalParameters);
#if CRASH_TEST
            uri = GetCrashTestUri(uri);
#endif
            try
            {
                var result = await GetJsonFromUri<ContinentDescriptions>(uri);
                return result;
            }
            catch (System.Net.WebException innerException)
            {
                throw new GuildWars2ApiException(string.Format(Exceptions.GetContinentDescriptionsError, uri), innerException);
            }
        }

        public async Task<IMapDescriptions> GetMapDescriptions(string language, string mapId = null)
        {
            var optionalParameters = new List<UriParameter>() { new UriParameter("lang", language) };
            if (!string.IsNullOrEmpty(mapId))
            {
                optionalParameters.Add(new UriParameter("map_id", mapId));
            }
            var uri = _routeManager.Resolve(Gw2ApiWebMethods.MapAPI.Maps, optionalParameters);
#if CRASH_TEST
            uri = GetCrashTestUri(uri);
#endif
            try
            {
                var result = await GetJsonFromUri<MapDescriptions>(uri);
                return result;
            }
            catch (System.Net.WebException innerException)
            {
                throw new GuildWars2ApiException(string.Format(Exceptions.GetMapDescriptionsError, uri), innerException);
            }
        }

        public async Task<IMapFloor> GetMapFloor(string language, int continentId, int floor)
        {
            var optionalParameters = new List<UriParameter>() { new UriParameter("lang", language) };
            var uri = _routeManager.Resolve(Gw2ApiWebMethods.MapAPI.MapFloor, optionalParameters: optionalParameters, args: new object[] { continentId, floor });
#if CRASH_TEST
            uri = GetCrashTestUri(uri);
#endif
            try
            {
                var result = await GetJsonFromUri<MapFloor>(uri);
                return result;
            }
            catch (System.Net.WebException innerException)
            {
                throw new GuildWars2ApiException(string.Format(Exceptions.GetMapFloorError, uri), innerException);
            }
        }
    }
}
