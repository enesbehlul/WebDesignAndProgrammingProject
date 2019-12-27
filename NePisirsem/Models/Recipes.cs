using System;
using System.Collections.Generic;

namespace NePisirsem.Models
{
    public partial class Recipes
    {
        public Recipes()
        {
            IngredientRecipeJoint = new HashSet<IngredientRecipeJoint>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? Userid { get; set; }
        public string Category { get; set; }

        public virtual Users User { get; set; }
        public virtual ICollection<IngredientRecipeJoint> IngredientRecipeJoint { get; set; }
    }
}
