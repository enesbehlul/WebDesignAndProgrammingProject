using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NePisirsem.Models
{
    public class MyRecipeViewModel
    {
        public Recipes MyRecipe { get; set; }
        public List<Ingredients> MyIngredients { get; set; }
    }
}
