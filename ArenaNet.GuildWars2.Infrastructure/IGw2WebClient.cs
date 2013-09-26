using System.Collections.Generic;
using System.Threading.Tasks;
using ArenaNet.GuildWars2.Models;
namespace ArenaNet.GuildWars2
{
    public interface IGw2WebClient
    {
        /// <summary>
        /// These resources return an unordered list of the localized world. Each entry contains the world or map id and the localized name.
        /// </summary>
        /// <param name="language">The language to query the names.</param>
        /// <returns></returns>
        Task<IEnumerable<IWorld>> GetWorlds(string language);

        /// <summary>
        /// These resources return an unordered list of the localized map names. Each entry contains the world or map id and the localized name.
        /// </summary>
        /// <param name="language">The language to query the names.</param>
        /// <returns></returns>
        Task<IEnumerable<IMap>> GetMapNames(string language);

        /// <summary>
        /// This resource returns a list of events that match the given filter. Each event contains the world ID and map ID it is taking place in, a unique event ID and the current state of the event. The following event states are possible:
        /// Active – The event is running now.
        /// Success – The event has succeeded.
        /// Fail – The event has failed.
        /// Warmup – The event is inactive, and will only become active once certain criteria are met.
        /// Preparation – The criteria for the event to start have been met, but certain activities (such as an NPC dialogue) have not completed yet. After the activites have been completed, the event will become Active.
        /// </summary>
        /// <param name="language">The language to query the names.</param>
        /// <param name="worldId">Only list events for that world.</param>
        /// <param name="mapId">Only list events in that map.</param>
        /// <param name="eventId">Only list this event.</param>
        /// <returns></returns>
        Task<IDynamicEvents> GetEvents(string language, int? worldId = null, int? mapId = null, int? eventId = null);

        /// <summary>
        /// This resource returns an unordered list of the localized event names for the specified language. Each entry contains the event id and the localized event name.
        /// </summary>
        /// <param name="language">The language to query the names.</param>
        /// <returns></returns>
        Task<IEnumerable<IEventName>> GetEventNames(string language);

        /// <summary>
        /// This resource returns a list of the currently running WvW matches, with the participating worlds included in the result. Further details about a match can be requested using the match details resource below.
        /// </summary>
        /// <returns></returns>
        Task<IWorldVsWorldMatches> GetWorldVsWorldMatches();

        /// <summary>
        /// This resource returns further details about the specified match, including the total score and further details for each map. For each map (identified by the type "&lt;Color&gt;Home" for the Borderlands or "Center" for Eternal Battlegrounds), it lists the local score and a list with the status of each objective on the map. Each objective lists the owner color, and if the objective is claimed by a guild, also the claiming guild’s id.
        /// </summary>
        /// <returns></returns>
        Task<IWorldVsWorldMatchDetails> GetWorldVsWorldMatchDetails(string matchId);

        /// <summary>
        /// This resource returns an unordered list of the localized objective names for the specified language. Each entry contains the objective id and the localized objective name.
        /// </summary>
        /// <param name="language">The language to query the names.</param>
        /// <returns></returns>
        Task<IEnumerable<IObjectiveName>> GetObjectiveNames(string language);

        /// <summary>
        /// This resource returns a list of all items that have been discovered by players in the game.
        /// </summary>
        /// <returns></returns>
        Task<IDiscoveredItems> GetDiscoveredGameItems();

        /// <summary>
        /// This resource returns item details in the specified language. The format of the returned details depends on the type of the item. Some aspects of the item details will be present for all types of items, while some other will be specific to specific item types.
        /// </summary>
        /// <param name="language">The language to query the names.</param>
        /// <param name="itemId">The item to query for.</param>
        /// <returns></returns>
        Task<IItemDetails> GetItemDetails(string language, int itemId);

        /// <summary>
        /// This resource returns a list of all recipes that have been discovered by players in the game.
        /// </summary>
        /// <returns></returns>
        Task<IDiscoveredRecipes> GetDiscoveredRecipes();

        /// <summary>
        /// This resource returns details about the specified recipe. Note that although setting a language is supported, it will not have any effect as the details do not contain any localizable content and the created item is documented using the output_item_id instead.
        /// </summary>
        /// <param name="language">The language to query the names.</param>
        /// <param name="recipeId">The recipe to query for.</param>
        /// <returns></returns>
        Task<IRecipeDetails> GetRecipeDetails(string language, int recipeId);

        /// <summary>
        /// Returns detailed information about events. This includes their static starting location in the world. This location is not updated dynamically, so it’s only accurate for events that don’t move.
        /// </summary>
        /// <param name="language">The language to query the names.</param>
        /// <param name="eventId"></param>
        /// <returns></returns>
        Task<IEventDescriptions> GetEventDescriptions(string language, string eventId = null);

        /// <summary>
        /// Returns a list of continents, and information about each continent. This information is meant to be used in conjunction with the world map tile service, and with the map floor API.
        /// </summary>
        /// <param name="language">The language to query the names.</param>
        /// <returns></returns>
        Task<IContinentDescriptions> GetContinentDescriptions(string language);

        /// <summary>
        /// Returns a list of continents, and information about each continent. This information is meant to be used in conjunction with the world map tile service, and with the map floor API.
        /// </summary>
        /// <param name="language">The language to query the names.</param>
        /// <param name="mapId"></param>
        /// <returns></returns>
        Task<IMapDescriptions> GetMapDescriptions(string language, string mapId = null);

        /// <summary>
        /// Returns detailed information about a map floor. This data can be used to populate a world map. Any coordinates provided have already been translated to map coordinates, which can be used in conjunction with the world map tile service.
        /// The data provided currently only contains static content. Dynamic content, such as vendors, is not currently available.
        /// </summary>
        /// <param name="language">The language to query the names.</param>
        /// <param name="continentId"></param>
        /// <param name="floor"></param>
        /// <returns></returns>
        Task<IMapFloor> GetMapFloor(string language, int continentId, int floor);

        /// <summary>
        /// Returns the current build ID. This can be useful for a number of purposes, such as resetting event timers due to server restarts.
        /// </summary>
        /// <returns></returns>
        Task<IBuild> GetBuild();

        /// <summary>
        /// This API takes a guild_name or guild_id. It returns public data about a guild, including its name, tag, and emblem.
        /// The emblem data is currently only the text metadata that can be used to compose the emblem. In the future, we may be able to provide the emblem as an image through this API, but that’s not currently possible.
        /// The colors in emblem data are color IDs that represent an color value. The color IDs can be translated using the color API detailed below. Emblems use the ‘cloth’ material value in the color. We do not currently have an API to resolve foreground_id or background_id to more useful information about the images they represent.
        /// </summary>
        /// <param name="guildId"></param>
        /// <param name="guildName"></param>
        /// <returns></returns>
        Task<IGuild> GetGuild(string guildId = null, string guildName = null);

        /// <summary>
        /// Returns all of the colors / dyes in the game, and their color component information.
        /// Colors are represented in their original color shifting form (HSL + contrast/brightness) as well as in RGB form. An example of how to interpret the original form is here: http://jsfiddle.net/cliff/jQ8ga/
        /// The exact color applied to an item depends on its material. The different color/material combinations are enumerated in the API for each color.
        /// </summary>
        /// <param name="language">The language to query the names.</param>
        /// <returns></returns>
        Task<IColorDescriptions> GetColorDescriptions(string language);

    }
}
