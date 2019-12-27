using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NePisirsem.Models
{
    public class MyViewModel
    {
        public List<SelectListItem> ingredientList { get; set; }
        public int recipeId { get; set; }
        public string recipeName { get; set; }
        public string recipeCategory { get; set; }
        public int userId { get; set; }



    }
}
