using Microsoft.AspNetCore.Mvc.Rendering;

namespace RecipeApp.Models
{
    public class DishTypeViewModel
    {
        public List<Recipe>? Recipes { get; set; }
        public SelectList? DishTypes { get; set; }
        public string? DishType { get; set; }
        public string? SearchString { get; set; }
    }
}
