#pragma checksum "C:\Users\Petko Pedev\source\CSharpWebRepo\MoiteRecepti\Web\MoiteRecepti.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20979c84c0aa700f096548b73afdbbdf8793fb73"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Petko Pedev\source\CSharpWebRepo\MoiteRecepti\Web\MoiteRecepti.Web\Views\_ViewImports.cshtml"
using MoiteRecepti.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Petko Pedev\source\CSharpWebRepo\MoiteRecepti\Web\MoiteRecepti.Web\Views\_ViewImports.cshtml"
using MoiteRecepti.Web.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Petko Pedev\source\CSharpWebRepo\MoiteRecepti\Web\MoiteRecepti.Web\Views\Home\Index.cshtml"
using MoiteRecepti.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20979c84c0aa700f096548b73afdbbdf8793fb73", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36ef38b988ad2621a530e0e16b6e933fb12ea6fc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MoiteRecepti.Web.ViewModels.Home.IndexViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Petko Pedev\source\CSharpWebRepo\MoiteRecepti\Web\MoiteRecepti.Web\Views\Home\Index.cshtml"
  
    this.ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome to ");
#nullable restore
#line 8 "C:\Users\Petko Pedev\source\CSharpWebRepo\MoiteRecepti\Web\MoiteRecepti.Web\Views\Home\Index.cshtml"
                                Write(GlobalConstants.SystemName);

#line default
#line hidden
#nullable disable
            WriteLiteral("!</h1>\r\n    <div class=\"col-md-4 offset-md-4\">\r\n        <p>We have:</p>\r\n        <ul class=\"list-group\">\r\n            <li class=\"list-group-item bg-info\">Recipes: ");
#nullable restore
#line 12 "C:\Users\Petko Pedev\source\CSharpWebRepo\MoiteRecepti\Web\MoiteRecepti.Web\Views\Home\Index.cshtml"
                                                    Write(Model.RecipesCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li class=\"list-group-item bg-light\">Categories: ");
#nullable restore
#line 13 "C:\Users\Petko Pedev\source\CSharpWebRepo\MoiteRecepti\Web\MoiteRecepti.Web\Views\Home\Index.cshtml"
                                                        Write(Model.CategoriesCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li class=\"list-group-item bg-info\">Images: ");
#nullable restore
#line 14 "C:\Users\Petko Pedev\source\CSharpWebRepo\MoiteRecepti\Web\MoiteRecepti.Web\Views\Home\Index.cshtml"
                                                   Write(Model.ImagesCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li class=\"list-group-item bg-light\">Ingredients: ");
#nullable restore
#line 15 "C:\Users\Petko Pedev\source\CSharpWebRepo\MoiteRecepti\Web\MoiteRecepti.Web\Views\Home\Index.cshtml"
                                                         Write(Model.IngredientsCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        </ul>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MoiteRecepti.Web.ViewModels.Home.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
