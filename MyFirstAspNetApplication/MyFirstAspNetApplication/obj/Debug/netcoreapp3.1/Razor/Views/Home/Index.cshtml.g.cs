#pragma checksum "C:\Users\Petko Pedev\source\CSharpWebRepo\MyFirstAspNetApplication\MyFirstAspNetApplication\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f034fb82acdcb96bfa1369a55c2d0852cab84c1"
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
#line 1 "C:\Users\Petko Pedev\source\CSharpWebRepo\MyFirstAspNetApplication\MyFirstAspNetApplication\Views\_ViewImports.cshtml"
using MyFirstAspNetApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Petko Pedev\source\CSharpWebRepo\MyFirstAspNetApplication\MyFirstAspNetApplication\Views\_ViewImports.cshtml"
using MyFirstAspNetApplication.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Petko Pedev\source\CSharpWebRepo\MyFirstAspNetApplication\MyFirstAspNetApplication\Views\Home\Index.cshtml"
using MyFirstAspNetApplication.ViewModels.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Petko Pedev\source\CSharpWebRepo\MyFirstAspNetApplication\MyFirstAspNetApplication\Views\Home\Index.cshtml"
using MyFirstAspNetApplication.Service;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f034fb82acdcb96bfa1369a55c2d0852cab84c1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7e611ec85430ee11de6fa6dda348c8bfe153a58", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IndexViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "C:\Users\Petko Pedev\source\CSharpWebRepo\MyFirstAspNetApplication\MyFirstAspNetApplication\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    this.Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome ");
#nullable restore
#line 12 "C:\Users\Petko Pedev\source\CSharpWebRepo\MyFirstAspNetApplication\MyFirstAspNetApplication\Views\Home\Index.cshtml"
                             Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    <h2>");
#nullable restore
#line 13 "C:\Users\Petko Pedev\source\CSharpWebRepo\MyFirstAspNetApplication\MyFirstAspNetApplication\Views\Home\Index.cshtml"
   Write(this.Configuration["HelloMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <h2>Instances: ");
#nullable restore
#line 14 "C:\Users\Petko Pedev\source\CSharpWebRepo\MyFirstAspNetApplication\MyFirstAspNetApplication\Views\Home\Index.cshtml"
              Write(InstanceCounter.Instances);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <h2>It is ");
#nullable restore
#line 15 "C:\Users\Petko Pedev\source\CSharpWebRepo\MyFirstAspNetApplication\MyFirstAspNetApplication\Views\Home\Index.cshtml"
         Write(Model.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(" year.</h2>\r\n    <p>");
#nullable restore
#line 16 "C:\Users\Petko Pedev\source\CSharpWebRepo\MyFirstAspNetApplication\MyFirstAspNetApplication\Views\Home\Index.cshtml"
  Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>We have ");
#nullable restore
#line 17 "C:\Users\Petko Pedev\source\CSharpWebRepo\MyFirstAspNetApplication\MyFirstAspNetApplication\Views\Home\Index.cshtml"
          Write(Model.UsersCount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" users.</p>\r\n    <p>Processor count: ");
#nullable restore
#line 18 "C:\Users\Petko Pedev\source\CSharpWebRepo\MyFirstAspNetApplication\MyFirstAspNetApplication\Views\Home\Index.cshtml"
                   Write(Model.ProcessorCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Time: ");
#nullable restore
#line 19 "C:\Users\Petko Pedev\source\CSharpWebRepo\MyFirstAspNetApplication\MyFirstAspNetApplication\Views\Home\Index.cshtml"
        Write(DateTime.Now);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>Id: ");
#nullable restore
#line 20 "C:\Users\Petko Pedev\source\CSharpWebRepo\MyFirstAspNetApplication\MyFirstAspNetApplication\Views\Home\Index.cshtml"
      Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n\r\n\r\n");
            DefineSection("Links", async() => {
                WriteLiteral("\r\n    <li class=\"nav-item\">\r\n        <a class=\"nav-link text-dark\" href=\"https://google.com\">Google</a>\r\n    </li>\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IInstanceCounter InstanceCounter { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.Extensions.Configuration.IConfiguration Configuration { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
