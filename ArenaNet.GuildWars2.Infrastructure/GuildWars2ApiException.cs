namespace ArenaNet.GuildWars2
{
    using System;

    public class GuildWars2ApiException : Exception
    {
        public GuildWars2ApiException() { }
        public GuildWars2ApiException(string message) : base(message) { }
        public GuildWars2ApiException(string message, Exception inner) : base(message, inner) { }
    }
}