#pragma checksum "C:\Users\Kaan\Desktop\Telefon Rehberi\Demo_Product\Demo_Product\Views\Partials\Partial_Sidebar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "279567699617c573f0781fde182bb417cfc9407a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Partials_Partial_Sidebar), @"mvc.1.0.view", @"/Views/Partials/Partial_Sidebar.cshtml")]
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
#line 1 "C:\Users\Kaan\Desktop\Telefon Rehberi\Demo_Product\Demo_Product\Views\_ViewImports.cshtml"
using Demo_Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Kaan\Desktop\Telefon Rehberi\Demo_Product\Demo_Product\Views\_ViewImports.cshtml"
using Demo_Product.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"279567699617c573f0781fde182bb417cfc9407a", @"/Views/Partials/Partial_Sidebar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78cfb9a0ef0ec1d3d285195ab224403920d5ac14", @"/Views/_ViewImports.cshtml")]
    public class Views_Partials_Partial_Sidebar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!--SOLID'e uygunluk için Partial View'de Side Bar (sol menü) kısmımız burada-->
<div id=""layoutSidenav_nav"">
    <nav class=""sb-sidenav accordion sb-sidenav-dark"" id=""sidenavAccordion"">
        <div class=""sb-sidenav-menu"">
            <div class=""nav"">
                <div class=""sb-sidenav-menu-heading"">Menü</div>


                <a class=""nav-link"" href=""/Employee/Index/"">
                    <div class=""sb-nav-link-icon""><i class=""fa fa-user-circle""></i></div>
                    Rehber
                </a>

                <a class=""nav-link"" href=""/Job/Index/"">
                    <div class=""sb-nav-link-icon""><i class=""fa fa-signal""></i></div>
                    Departman
                </a>

                <a class=""nav-link"" href=""/Job/AddJob/"">
                    <div class=""sb-nav-link-icon""><i class=""fa fa-user-plus""></i></div>
                    Yeni Departman Girişi
                </a>

                <a class=""nav-link"" href=""/Category/Index/"">
                ");
            WriteLiteral(@"    <div class=""sb-nav-link-icon""><i class=""fas fa-table""></i></div>
                    Çağrılar
                </a>

                <a class=""nav-link"" href=""/Settings/Index/"">
                    <div class=""sb-nav-link-icon""><i class=""fa fa-lock""></i></div>
                    Parola
                </a>

            </div>
        </div>
    </nav>
</div>");
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
