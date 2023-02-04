namespace RecipeApp.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Ingridients { get; set; }
        public string Instruction { get; set; }
        public string DishType { get; set; } = "Other";
        public bool IsVegan { get; set; } = false;

    }
}
