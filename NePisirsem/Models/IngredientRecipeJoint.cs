using System;
using System.Collections.Generic;

namespace NePisirsem.Models
{
    public partial class IngredientRecipeJoint
    {
        public int Id { get; set; }
        public int? IngredientId { get; set; }
        public int? RecipeId { get; set; }
        public string Amount { get; set; }

        public virtual Ingredients Ingredient { get; set; }
        public virtual Recipes Recipe { get; set; }
    }
}
