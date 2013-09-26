using System;
using System.Collections.ObjectModel;
namespace ArenaNet.GuildWars2.Models
{
    public interface IRecipeDetails
    {
        Collection<string> Disciplines { get; set; }
        Collection<object> Flags { get; set; }
        Collection<IIngredient> Ingredients { get; set; }
        string MinRating { get; set; }
        string OutputItemCount { get; set; }
        string OutputItemId { get; set; }
        string RecipeId { get; set; }
        string TimeToCraftMs { get; set; }
        string type { get; set; }
    }
}
