using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NePisirsem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NePisirsem.Controllers
{
    public class UsersController : Controller
    {
        private readonly UserDBContext _context;
        public static int user_id;

        public UsersController(UserDBContext context)
        {
            _context = context;
        }

        // GET: /<controller>/
        public IActionResult Index(string uname)
        {
            var user = _context.Users.FirstOrDefault(u => u.Username == uname);
            return View(user);
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string uname, string psw)
        {
            //var users = _context.Users.FirstOrDefault(u => u.Username.StartsWith(user.Username) && u.Password.StartsWith(user.Password));
            var list = _context.Users.ToList();
            
            foreach (var item in list)
            {
                if (item.Username.StartsWith(uname) && item.Password.StartsWith(psw)){
                    user_id = item.Id;
                    return RedirectToAction("Index", new {@uname = uname});
                }
            }
            return RedirectToAction(nameof(Login));
        }

        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Signup([Bind("Id,Name,Username,Password")] Users user)
        {
            if (ModelState.IsValid)
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Login));
            }
            return NotFound();
        }

        public async Task<IActionResult> MyRecipes(int? id)
        {
            var myRecipeIngredientsJoinList = new List<MyRecipeViewModel>();

            if (id == null)
            {
                return NotFound();
            }
            var myRecipes = _context.Recipes
                        .Where(r => r.Userid == id).ToList();


            foreach (var item in myRecipes)
            {
                var recipeIngredients = (from i in _context.Ingredients
                                         join irj in _context.IngredientRecipeJoint
                                         on i.Id equals irj.IngredientId
                                         where irj.RecipeId == item.Id
                                         select i).ToList();
                var model = new MyRecipeViewModel();
                model.MyRecipe = item;
                model.MyIngredients = recipeIngredients;
                myRecipeIngredientsJoinList.Add(model);

            } 
            

            return View(myRecipeIngredientsJoinList);
        }

        public async Task<IActionResult> AddRecipe()
        {
            var recipes = new List<SelectListItem>();
            foreach (var item in _context.Ingredients.ToList())
            {
                recipes.Add(new SelectListItem
                {
                    Text = item.Name,
                    Value = item.Id.ToString()
                });
            }
            ViewBag.ingredients = recipes;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddRecipe(MyViewModel myViewModel)
        {
            var recipeJointList = _context.IngredientRecipeJoint.ToList();
            int lastIndex = recipeJointList.Last().Id;

            Recipes recipe = new Recipes();
            recipe.Userid = user_id;
            recipe.Name = myViewModel.recipeName;
            recipe.Category = myViewModel.recipeCategory;
            recipe.Id = myViewModel.recipeId;

            if (ModelState.IsValid)
            {
                _context.Add(recipe);
                await _context.SaveChangesAsync();
            }
            if (myViewModel.ingredientList == null)
            {
                return NotFound();
            }
            foreach (var item in myViewModel.ingredientList)
            {
                Console.WriteLine(item.Text);
                IngredientRecipeJoint irj = new IngredientRecipeJoint();
                irj.Id = ++lastIndex;
                irj.IngredientId = int.Parse(item.Value);
                irj.RecipeId = recipe.Id;
                _context.Add(irj);
                await _context.SaveChangesAsync();
            }
            return View();
        }

        public async Task<IActionResult> AllRecipes()
        {
            var myRecipeIngredientsJoinList = new List<MyRecipeViewModel>();

            var myRecipes = _context.Recipes.ToList();


            foreach (var item in myRecipes)
            {
                var recipeIngredients = (from i in _context.Ingredients
                                         join irj in _context.IngredientRecipeJoint
                                         on i.Id equals irj.IngredientId
                                         where irj.RecipeId == item.Id
                                         select i).ToList();
                var model = new MyRecipeViewModel();
                model.MyRecipe = item;
                model.MyIngredients = recipeIngredients;
                myRecipeIngredientsJoinList.Add(model);

            }


            return View(myRecipeIngredientsJoinList);
        }

    }
}
