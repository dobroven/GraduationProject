#pragma checksum "C:\Папка временного пользователя\Учёба\AspNetCoreApp - копия\AspNetCoreApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72fd39e8666ce99f497dba9516323e121b4b4939"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72fd39e8666ce99f497dba9516323e121b4b4939", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd51982e6ec86b09a61ba7774f06c6bd81fcc7ec", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 33, true);
            WriteLiteral("\r\n\r\n<div class=\"row mt-5 mb-2\">\r\n");
            EndContext();
#line 5 "C:\Папка временного пользователя\Учёба\AspNetCoreApp - копия\AspNetCoreApp\Views\Home\Index.cshtml"
      
        foreach (Dish dish in Model.AvailableDishes)
        {
            

#line default
#line hidden
            BeginContext(141, 31, false);
#line 8 "C:\Папка временного пользователя\Учёба\AspNetCoreApp - копия\AspNetCoreApp\Views\Home\Index.cshtml"
       Write(Html.Partial("AllDishes", dish));

#line default
#line hidden
            EndContext();
#line 8 "C:\Папка временного пользователя\Учёба\AspNetCoreApp - копия\AspNetCoreApp\Views\Home\Index.cshtml"
                                            
        }
    

#line default
#line hidden
            BeginContext(192, 12, true);
            WriteLiteral("</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
