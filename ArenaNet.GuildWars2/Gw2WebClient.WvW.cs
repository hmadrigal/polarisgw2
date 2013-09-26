namespace ArenaNet.GuildWars2
{
    using UriParameter = System.Collections.Generic.KeyValuePair<string, object>;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using ArenaNet.GuildWars2.Models;
    using System.Linq;

    public partial class Gw2WebClient : IGw2WebClient
    {
        public async Task<IWorldVsWorldMatches> GetWorldVsWorldMatches()
        {
            var uri = _routeManager.Resolve(Gw2ApiWebMethods.WvWAPI.Matches, EmptyUriParameters);
#if CRASH_TEST
            uri = GetCrashTestUri(uri);
#endif
            try
            {
                var result = await GetJsonFromUri<WorldVsWorldMatches>(uri);
                return result;
            }
            catch (System.Net.WebException innerException)
            {
                throw new GuildWars2ApiException(string.Format(Exceptions.GetWorldVsWorldMatchesError, uri), innerException);
            }
        }

        public async Task<IWorldVsWorldMatchDetails> GetWorldVsWorldMatchDetails(string matchId)
        {
            var uri = _routeManager.Resolve(Gw2ApiWebMethods.WvWAPI.MatchDetails, matchId);
#if CRASH_TEST
            uri = GetCrashTestUri(uri);
#endif
            try
            {
                var result = await GetJsonFromUri<WorldVsWorldMatchDetails>(uri);
                return result;
            }
            catch (System.Net.WebException innerException)
            {
                throw new GuildWars2ApiException(string.Format(Exceptions.GetWorldVsWorldMatchDetailsError, uri), innerException);
            }
        }

        public async Task<IEnumerable<IObjectiveName>> GetObjectiveNames(string language)
        {
            var optionalParameters = new List<UriParameter>() { new UriParameter("lang", language) };
            var uri = _routeManager.Resolve(Gw2ApiWebMethods.WvWAPI.ObjectiveNames, optionalParameters);
#if CRASH_TEST
            uri = GetCrashTestUri(uri);
#endif
            try
            {
                var result = (await GetJsonFromUri<List<ObjectiveName>>(uri)).OfType<IObjectiveName>();
                return result;
            }
            catch (System.Net.WebException innerException)
            {
                throw new GuildWars2ApiException(string.Format(Exceptions.GetObjectiveNamesError, uri), innerException);
            }
        }
    }
}
