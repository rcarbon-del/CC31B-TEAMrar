using System.Collections.Generic;
using System.Linq;
using Engine.Models;
namespace Engine.Factories
{
    public static class RecipeFactory
    {
        private static readonly List<Recipe> _recipes = new List<Recipe>();
        static RecipeFactory()
        {
            Recipe sugarCubes = new Recipe(1, "Sugar Cubes");
            sugarCubes.AddIngredient(3001, 1);
            sugarCubes.AddIngredient(3002, 1);

            sugarCubes.AddOutputItem(2001, 1);
            _recipes.Add(sugarCubes);

            Recipe specialButter = new Recipe(2, "Mayor's Special Butter");
            specialButter.AddIngredient(81, 10);
            specialButter.AddIngredient(67, 5);
            specialButter.AddIngredient(69, 1);

            specialButter.AddOutputItem(75, 2);
            _recipes.Add(specialButter);

        }
        public static Recipe RecipeByID(int id)
        {
            return _recipes.FirstOrDefault(x => x.ID == id);
        }
    }
}