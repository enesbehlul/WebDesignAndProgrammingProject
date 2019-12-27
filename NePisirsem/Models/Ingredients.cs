using System;
using System.Collections.Generic;

namespace NePisirsem.Models
{
    public partial class Ingredients
    {
        public Ingredients()
        {
            IngredientRecipeJoint = new HashSet<IngredientRecipeJoint>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<IngredientRecipeJoint> IngredientRecipeJoint { get; set; }
    }
}
