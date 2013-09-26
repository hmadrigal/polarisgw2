using System.IO;

namespace ArenaNet.GuildWars2
{
    public interface IGw2JsonDeserializer
    {
        T Deserialize<T>(Stream input);
    }
}
