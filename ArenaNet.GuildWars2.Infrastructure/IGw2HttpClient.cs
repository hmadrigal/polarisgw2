using System;
using System.IO;
using System.Threading.Tasks;

namespace ArenaNet.GuildWars2
{
    public interface IGw2HttpClient
    {
        Task<Stream> GetStreamAsync(Uri uri);
    }
}
