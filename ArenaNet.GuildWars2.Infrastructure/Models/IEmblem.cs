using System;
using System.Collections.ObjectModel;
namespace ArenaNet.GuildWars2.Models
{
    public interface IEmblem
    {
        int BackgroundColorId { get; set; }
        int BackgroundId { get; set; }
        Collection<object> flags { get; set; }
        int ForegroundId { get; set; }
        int ForegroundPrimaryColorId { get; set; }
        int ForegroundSecondaryColorId { get; set; }
    }
}
