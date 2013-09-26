namespace ArenaNet.GuildWars2
{
    using UriParameter = System.Collections.Generic.KeyValuePair<string, object>;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using ArenaNet.GuildWars2.Models;

    public partial class Gw2WebClient : IGw2WebClient
    {
        public async Task<IDiscoveredItems> GetDiscoveredGameItems()
        {
            var uri = _routeManager.Resolve(Gw2ApiWebMethods.ItemAndRecipeDatabaseAPI.Items, EmptyUriParameters);
#if CRASH_TEST
            uri = GetCrashTestUri(uri);
#endif
            try
            {
                var result = await GetJsonFromUri<DiscoveredItems>(uri);
                return result;
            }
            catch (System.Net.WebException innerException)
            {
                throw new GuildWars2ApiException(string.Format(Exceptions.GetDiscoveredGameItemsError, uri), innerException);
            }
        }

        public async Task<IItemDetails> GetItemDetails(string language, int itemId)
        {
            var optionalParameters = new List<UriParameter>() { new UriParameter("lang", language) };
            var uri = _routeManager.Resolve(Gw2ApiWebMethods.ItemAndRecipeDatabaseAPI.ItemDetails, optionalParameters: optionalParameters, args: new object[] { itemId });
#if CRASH_TEST
            uri = GetCrashTestUri(uri);
#endif
            try
            {
                var result = await GetJsonFromUri<ItemDetails>(uri);
                return result;
            }
            catch (System.Net.WebException innerException)
            {
                throw new GuildWars2ApiException(string.Format(Exceptions.GetItemDetailsError, uri), innerException);
            }
        }

        public async Task<IDiscoveredRecipes> GetDiscoveredRecipes()
        {
            var uri = _routeManager.Resolve(Gw2ApiWebMethods.ItemAndRecipeDatabaseAPI.Recipes, EmptyUriParameters);
#if CRASH_TEST
            uri = GetCrashTestUri(uri);
#endif
            try
            {
                var result = await GetJsonFromUri<IDiscoveredRecipes>(uri);
                return result;
            }
            catch (System.Net.WebException innerException)
            {
                throw new GuildWars2ApiException(string.Format(Exceptions.GetDiscoveredRecipesError, uri), innerException);
            }
        }

        public async Task<IRecipeDetails> GetRecipeDetails(string language, int recipeId)
        {
            var optionalParameters = new List<UriParameter>() { new UriParameter("lang", language) };
            var uri = _routeManager.Resolve(Gw2ApiWebMethods.ItemAndRecipeDatabaseAPI.RecipeDetails, optionalParameters: optionalParameters, args: new object[] { recipeId });
#if CRASH_TEST
            uri = GetCrashTestUri(uri);
#endif
            try
            {
                var result = await GetJsonFromUri<RecipeDetails>(uri);
                return result;
            }
            catch (System.Net.WebException innerException)
            {
                throw new GuildWars2ApiException(string.Format(Exceptions.GetRecipeDetailsError, uri), innerException);
            }
        }
    }
}
