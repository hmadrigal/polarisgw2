using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArenaNet.GuildWars2
{
    internal static class Gw2ApiWebMethods
    {

        internal const string ApiGuildWars2BaseApiUri = @"https://api.guildwars2.com";
        internal const string TilesGuildWars2BaseApi = @"https://tiles.guildwars2.com";

        internal static class DynamicEventsAPI
        {
            internal const string Events = ApiGuildWars2BaseApiUri + @"/v1/events.json";
            internal const string EventNames = ApiGuildWars2BaseApiUri + @"/v1/event_names.json";
            internal const string MapNames = ApiGuildWars2BaseApiUri + @"/v1/map_names.json";
            internal const string WorldNames = ApiGuildWars2BaseApiUri + @"/v1/world_names.json";
            internal const string EventDetails = ApiGuildWars2BaseApiUri + @"/v1/event_details.json";

        }
        internal static class WvWAPI
        {
            internal const string Matches = ApiGuildWars2BaseApiUri + @"/v1/matches.json";
            internal const string MatchDetails = ApiGuildWars2BaseApiUri + @"/v1/match_details.json";
            internal const string ObjectiveNames = ApiGuildWars2BaseApiUri + @"/v1/objective_names.json";
        }
        internal static class ItemAndRecipeDatabaseAPI
        {
            internal const string Items = ApiGuildWars2BaseApiUri + @"/v1/items.json";
            internal const string ItemDetails = ApiGuildWars2BaseApiUri + @"/v1/item_details.json";
            internal const string Recipes = ApiGuildWars2BaseApiUri + @"/v1/recipes.json";
            internal const string RecipeDetails = ApiGuildWars2BaseApiUri + @"/v1/recipe_details.json";
        }

        internal static class GuildAPI
        {
            internal const string GuildDetails = ApiGuildWars2BaseApiUri + @"/v1/guild_details.json";
        }

        internal static class MapAPI
        {
            internal const string Continents = ApiGuildWars2BaseApiUri + @"/v1/continents.json";
            internal const string Maps = ApiGuildWars2BaseApiUri + @"/v1/maps.json";
            internal const string MapFloor = ApiGuildWars2BaseApiUri + @"/v1/map_floor.json";
        }

        internal static class MiscellaneousAPI
        {
            internal const string Build = ApiGuildWars2BaseApiUri + @"/v1/build.json";
            internal const string Colors = ApiGuildWars2BaseApiUri + @"/v1/colors.json";
        }


        internal static IRouteManager RouteManager
        {
            get { return Gw2ApiWebMethods._routeManager; }
        }
        private static readonly IRouteManager _routeManager;

        static Gw2ApiWebMethods()
        {
            _routeManager = new RouteManager();

            //Dynamic Events API
            _routeManager.Register(Gw2ApiWebMethods.DynamicEventsAPI.Events, string.Concat(Gw2ApiWebMethods.ApiGuildWars2BaseApiUri, "/v1/events.json"));
            _routeManager.Register(Gw2ApiWebMethods.DynamicEventsAPI.EventNames, string.Concat(Gw2ApiWebMethods.ApiGuildWars2BaseApiUri, "/v1/event_names.json"));
            _routeManager.Register(Gw2ApiWebMethods.DynamicEventsAPI.MapNames, string.Concat(Gw2ApiWebMethods.ApiGuildWars2BaseApiUri, "/v1/map_names.json"));
            _routeManager.Register(Gw2ApiWebMethods.DynamicEventsAPI.WorldNames, string.Concat(Gw2ApiWebMethods.ApiGuildWars2BaseApiUri, "/v1/world_names.json"));
            _routeManager.Register(Gw2ApiWebMethods.DynamicEventsAPI.EventDetails, string.Concat(Gw2ApiWebMethods.ApiGuildWars2BaseApiUri, "/v1/event_details.json"));

            //WvW API
            _routeManager.Register(Gw2ApiWebMethods.WvWAPI.Matches, string.Concat(Gw2ApiWebMethods.ApiGuildWars2BaseApiUri, "/v1/wvw/matches.json"));
            _routeManager.Register(name: Gw2ApiWebMethods.WvWAPI.MatchDetails, path: string.Concat(Gw2ApiWebMethods.ApiGuildWars2BaseApiUri, "/v1/wvw/match_details.json"), parameters: "match_id");
            _routeManager.Register(Gw2ApiWebMethods.WvWAPI.ObjectiveNames, string.Concat(Gw2ApiWebMethods.ApiGuildWars2BaseApiUri, "/v1/wvw/objective_names.json"));

            //Item and Recipe Database API 
            _routeManager.Register(Gw2ApiWebMethods.ItemAndRecipeDatabaseAPI.Items, string.Concat(Gw2ApiWebMethods.ApiGuildWars2BaseApiUri, "/v1/items.json"));
            _routeManager.Register(name: Gw2ApiWebMethods.ItemAndRecipeDatabaseAPI.ItemDetails, path: string.Concat(Gw2ApiWebMethods.ApiGuildWars2BaseApiUri, "/v1/item_details.json"), parameters: "item_id");
            _routeManager.Register(Gw2ApiWebMethods.ItemAndRecipeDatabaseAPI.Recipes, string.Concat(Gw2ApiWebMethods.ApiGuildWars2BaseApiUri, "/v1/recipes.json"));
            _routeManager.Register(name: Gw2ApiWebMethods.ItemAndRecipeDatabaseAPI.RecipeDetails, path: string.Concat(Gw2ApiWebMethods.ApiGuildWars2BaseApiUri, "/v1/recipe_details.json"), parameters: "recipe_id");

            //Guild API
            _routeManager.Register(Gw2ApiWebMethods.GuildAPI.GuildDetails, string.Concat(Gw2ApiWebMethods.ApiGuildWars2BaseApiUri, "/v1/guild_details.json"));

            //Map API
            _routeManager.Register(Gw2ApiWebMethods.MapAPI.Continents, string.Concat(Gw2ApiWebMethods.ApiGuildWars2BaseApiUri, "/v1/continents.json"));
            _routeManager.Register(Gw2ApiWebMethods.MapAPI.Maps, string.Concat(Gw2ApiWebMethods.ApiGuildWars2BaseApiUri, "/v1/maps.json"));
            _routeManager.Register(name: Gw2ApiWebMethods.MapAPI.MapFloor, path: string.Concat(Gw2ApiWebMethods.ApiGuildWars2BaseApiUri, "/v1/map_floor.json"), parameters: new string[] { "continent_id", "floor" });

            //Miscellaneous APIs
            _routeManager.Register(Gw2ApiWebMethods.MiscellaneousAPI.Build, string.Concat(Gw2ApiWebMethods.ApiGuildWars2BaseApiUri, "/v1/build.json"));
            _routeManager.Register(Gw2ApiWebMethods.MiscellaneousAPI.Colors, string.Concat(Gw2ApiWebMethods.ApiGuildWars2BaseApiUri, "/v1/colors.json"));

        }
    }
}
