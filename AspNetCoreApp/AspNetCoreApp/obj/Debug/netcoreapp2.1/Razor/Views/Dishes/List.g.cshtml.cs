#pragma checksum "C:\Папка временного пользователя\Учёба\AspNetCoreApp - копия\AspNetCoreApp\Views\Dishes\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec72893ac73f9624bd6a4cc3657788c47434a2e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dishes_List), @"mvc.1.0.view", @"/Views/Dishes/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Dishes/List.cshtml", typeof(AspNetCore.Views_Dishes_List))]
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
#line 1 "C:\Папка временного пользователя\Учёба\AspNetCoreApp - копия\AspNetCoreApp\Views\_ViewImports.cshtml"
using AspNetCoreApp.ViewModels;

#line default
#line hidden
#line 2 "C:\Папка временного пользователя\Учёба\AspNetCoreApp - копия\AspNetCoreApp\Views\_ViewImports.cshtml"
using AspNetCoreApp.Data.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec72893ac73f9624bd6a4cc3657788c47434a2e8", @"/Views/Dishes/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd51982e6ec86b09a61ba7774f06c6bd81fcc7ec", @"/Views/_ViewImports.cshtml")]
    public class Views_Dishes_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 6, true);
            WriteLiteral("\r\n<h3>");
            EndContext();
            BeginContext(7, 21, false);
#line 2 "C:\Папка временного пользователя\Учёба\AspNetCoreApp - копия\AspNetCoreApp\Views\Dishes\List.cshtml"
Write(Model.CurrentCategory);

#line default
#line hidden
            EndContext();
            BeginContext(28, 36, true);
            WriteLiteral("</h3>\r\n<div class=\"row mt-5 mb-2\">\r\n");
            EndContext();
#line 4 "C:\Папка временного пользователя\Учёба\AspNetCoreApp - копия\AspNetCoreApp\Views\Dishes\List.cshtml"
      
        foreach (Dish dish in Model.AllDishes)
        {
            

#line default
#line hidden
            BeginContext(144, 31, false);
#line 7 "C:\Папка временного пользователя\Учёба\AspNetCoreApp - копия\AspNetCoreApp\Views\Dishes\List.cshtml"
       Write(Html.Partial("AllDishes", dish));

#line default
#line hidden
            EndContext();
#line 7 "C:\Папка временного пользователя\Учёба\AspNetCoreApp - копия\AspNetCoreApp\Views\Dishes\List.cshtml"
                                            
        }
    

#line default
#line hidden
            BeginContext(195, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
