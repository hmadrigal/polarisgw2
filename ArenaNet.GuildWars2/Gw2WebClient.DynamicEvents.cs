namespace ArenaNet.GuildWars2
{
    using UriParameter = System.Collections.Generic.KeyValuePair<string, object>;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using ArenaNet.GuildWars2.Models;
    using System.Linq;

    partial class Gw2WebClient : IGw2WebClient
    {



        public async Task<IDynamicEvents> GetEvents(string language, int? worldId = null, int? mapId = null, int? eventId = null)
        {
            var optionalParameters = new List<UriParameter>() { new UriParameter("lang", language) };
            if (worldId.HasValue)
            {
                optionalParameters.Add(new UriParameter("world_id", worldId.Value));
            }
            if (mapId.HasValue)
            {
                optionalParameters.Add(new UriParameter("map_id", mapId.Value));
            }
            if (eventId.HasValue)
            {
                optionalParameters.Add(new UriParameter("event_id", eventId.Value));
            }
            var uri = _routeManager.Resolve(Gw2ApiWebMethods.DynamicEventsAPI.Events, optionalParameters);
#if CRASH_TEST
            uri = GetCrashTestUri(uri);
#endif
            try
            {
                var result = await GetJsonFromUri<IDynamicEvents>(uri);
                return result;
            }
            catch (System.Net.WebException innerException)
            {
                throw new GuildWars2ApiException(string.Format(Exceptions.GetEventsError, uri), innerException);
            }
        }

        public async Task<IEnumerable<IWorld>> GetWorlds(string language)
        {
            var optionalParameters = new List<UriParameter>() { new UriParameter("lang", language) };
            var uri = _routeManager.Resolve(Gw2ApiWebMethods.DynamicEventsAPI.WorldNames, optionalParameters);

#if CRASH_TEST
            uri = GetCrashTestUri(uri);
#endif

            try
            {
                var instance = (await GetJsonFromUri(uri, typeof(List<IWorld>)));
                var result = GetEnumerable<IWorld>(instance);
                return result;
            }
            catch (System.Net.WebException innerException)
            {
                throw new GuildWars2ApiException(string.Format(Exceptions.GetWorldsError, uri), innerException);
            }
        }

        public async Task<IEnumerable<IMap>> GetMapNames(string language)
        {
            var optionalParameters = new List<UriParameter>() { new UriParameter("lang", language) };
            var uri = _routeManager.Resolve(Gw2ApiWebMethods.DynamicEventsAPI.MapNames, optionalParameters);
#if CRASH_TEST
            uri = GetCrashTestUri(uri);
#endif
            try
            {
                var instance = (await GetJsonFromUri(uri, typeof(List<IMap>)));
                var result = GetEnumerable<IMap>(instance);
                return result;
            }
            catch (System.Net.WebException innerException)
            {
                throw new GuildWars2ApiException(string.Format(Exceptions.GetMapNamesError, uri), innerException);
            }
        }

        public async Task<IEnumerable<IEventName>> GetEventNames(string language)
        {

            var optionalParameters = new List<UriParameter>() { new UriParameter("lang", language) };
            var uri = _routeManager.Resolve(Gw2ApiWebMethods.DynamicEventsAPI.EventNames, optionalParameters);
#if CRASH_TEST
            uri = GetCrashTestUri(uri);
#endif
            try
            {
                var instance = (await GetJsonFromUri(uri, typeof(List<IEventName>)));
                var result = GetEnumerable<IEventName>(instance);
                return result;
            }
            catch (System.Net.WebException innerException)
            {
                throw new GuildWars2ApiException(string.Format(Exceptions.GetEventNamesError, uri), innerException);
            }
        }

        public async Task<IEventDescriptions> GetEventDescriptions(string language, string eventId = null)
        {
            var optionalParameters = new List<UriParameter>() { new UriParameter("lang", language) };
            if (!string.IsNullOrEmpty(eventId))
            {
                optionalParameters.Add(new UriParameter("event_id", eventId));
            }
            var uri = _routeManager.Resolve(Gw2ApiWebMethods.DynamicEventsAPI.EventDetails, optionalParameters);
#if CRASH_TEST
            uri = GetCrashTestUri(uri);
#endif
            try
            {
                var result = await GetJsonFromUri<IEventDescriptions>(uri);
                return result;
            }
            catch (System.Net.WebException innerException)
            {
                throw new GuildWars2ApiException(string.Format(Exceptions.GetEventDescriptionsError, uri), innerException);
            }
        }

    }
}
