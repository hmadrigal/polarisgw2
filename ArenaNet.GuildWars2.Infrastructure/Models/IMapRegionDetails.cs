using System;
using System.Collections.ObjectModel;
namespace ArenaNet.GuildWars2.Models
{
    public interface IMapRegionDetails
    {
        Collection<Collection<int>> ContinentRect { get; set; }
        int DefaultFloor { get; set; }
        Collection<Collection<int>> MapRect { get; set; }
        int MaxLevel { get; set; }
        int MinLevel { get; set; }
        string Name { get; set; }
        Collection<IPointsOfInterest> PointsOfInterest { get; set; }
        Collection<ISector> Sectors { get; set; }
        Collection<ISkillChallenge> SkillChallenges { get; set; }
        Collection<ITask> Tasks { get; set; }
    }
}
