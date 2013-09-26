namespace ArenaNet.GuildWars2
{
    using UriParameter = System.Collections.Generic.KeyValuePair<string, object>;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using ArenaNet.GuildWars2.Models;
    using System;

    public partial class Gw2WebClient : IGw2WebClient
    {
        public async Task<IGuild> GetGuild(string guildId = null, string guildName = null)
        {
            if (string.IsNullOrEmpty(guildId) && string.IsNullOrEmpty(guildName))
            {
                throw new ArgumentException("guildId and guildName cannot be null");
            }
            var optionalParameters = new List<UriParameter>();
            if (!string.IsNullOrEmpty(guildId))
            {
                optionalParameters.Add(new UriParameter("guild_id", guildId));
            }
            else if (!string.IsNullOrEmpty(guildName))
            {
                optionalParameters.Add(new UriParameter("guild_name", guildName));
            }
            var uri = _routeManager.Resolve(Gw2ApiWebMethods.GuildAPI.GuildDetails, optionalParameters: optionalParameters);
#if CRASH_TEST
            uri = GetCrashTestUri(uri);
#endif
            try
            {
                var result = await GetJsonFromUri<Guild>(uri);
                return result;
            }
            catch (System.Net.WebException innerException)
            {
                throw new GuildWars2ApiException(string.Format(Exceptions.GetGuildError, uri), innerException);
            }
        }
    }
}
