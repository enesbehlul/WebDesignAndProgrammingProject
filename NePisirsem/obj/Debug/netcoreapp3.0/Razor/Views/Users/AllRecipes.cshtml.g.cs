#pragma checksum "C:\Users\behlul\source\repos\NePisirsem\NePisirsem\Views\Users\AllRecipes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f408636971ff51b9eae967c5c9bb685db36b939"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_AllRecipes), @"mvc.1.0.view", @"/Views/Users/AllRecipes.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\behlul\source\repos\NePisirsem\NePisirsem\Views\_ViewImports.cshtml"
using NePisirsem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\behlul\source\repos\NePisirsem\NePisirsem\Views\_ViewImports.cshtml"
using NePisirsem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f408636971ff51b9eae967c5c9bb685db36b939", @"/Views/Users/AllRecipes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a73fcdea4b2357fa8d702db023a1e5dd407f64bd", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_AllRecipes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<NePisirsem.Models.MyRecipeViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 7 "C:\Users\behlul\source\repos\NePisirsem\NePisirsem\Views\Users\AllRecipes.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <h1>");
#nullable restore
#line 10 "C:\Users\behlul\source\repos\NePisirsem\NePisirsem\Views\Users\AllRecipes.cshtml"
       Write(item.MyRecipe.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 11 "C:\Users\behlul\source\repos\NePisirsem\NePisirsem\Views\Users\AllRecipes.cshtml"
         foreach (var ingr in @item.MyIngredients)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h2>");
#nullable restore
#line 13 "C:\Users\behlul\source\repos\NePisirsem\NePisirsem\Views\Users\AllRecipes.cshtml"
           Write(ingr.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n");
#nullable restore
#line 14 "C:\Users\behlul\source\repos\NePisirsem\NePisirsem\Views\Users\AllRecipes.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <hr />\r\n    </div>\r\n");
#nullable restore
#line 17 "C:\Users\behlul\source\repos\NePisirsem\NePisirsem\Views\Users\AllRecipes.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<NePisirsem.Models.MyRecipeViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
