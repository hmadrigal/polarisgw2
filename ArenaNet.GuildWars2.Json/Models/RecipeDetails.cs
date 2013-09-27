using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;


namespace ArenaNet.GuildWars2.Models
{
    public class RecipeDetails : IRecipeDetails
    {
        [JsonProperty("recipe_id")]
        public string RecipeId { get; set; }
        public string type { get; set; }
        [JsonProperty("output_item_id")]
        public string OutputItemId { get; set; }
        [JsonProperty("output_item_count")]
        public string OutputItemCount { get; set; }
        [JsonProperty("min_rating")]
        public string MinRating { get; set; }
        [JsonProperty("time_to_craft_ms")]
        public string TimeToCraftMs { get; set; }
        public Collection<string> Disciplines { get; set; }
        public Collection<object> Flags { get; set; }
        [JsonConverter(typeof(GenericJsonConverter<IIngredient, Ingredient>))]
        public Collection<IIngredient> Ingredients { get; set; }
    }
}
