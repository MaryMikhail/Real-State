#pragma checksum "F:\ITI SD Intake 41\ASP.Net MVC\Asp Core Real Estate Project\FinalMVC\AspCoreProject\RealEstate\Views\Error\AppError.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79d28d885c39beb409c7a200b2047f73626bba45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Error_AppError), @"mvc.1.0.view", @"/Views/Error/AppError.cshtml")]
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
#line 1 "F:\ITI SD Intake 41\ASP.Net MVC\Asp Core Real Estate Project\FinalMVC\AspCoreProject\RealEstate\Views\_ViewImports.cshtml"
using RealEstate;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\ITI SD Intake 41\ASP.Net MVC\Asp Core Real Estate Project\FinalMVC\AspCoreProject\RealEstate\Views\_ViewImports.cshtml"
using RealEstate.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\ITI SD Intake 41\ASP.Net MVC\Asp Core Real Estate Project\FinalMVC\AspCoreProject\RealEstate\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\ITI SD Intake 41\ASP.Net MVC\Asp Core Real Estate Project\FinalMVC\AspCoreProject\RealEstate\Views\_ViewImports.cshtml"
using RealEstate.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79d28d885c39beb409c7a200b2047f73626bba45", @"/Views/Error/AppError.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67ab996ee09aab1f1c7c6aa4034f242972cdca05", @"/Views/_ViewImports.cshtml")]
    public class Views_Error_AppError : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "F:\ITI SD Intake 41\ASP.Net MVC\Asp Core Real Estate Project\FinalMVC\AspCoreProject\RealEstate\Views\Error\AppError.cshtml"
  
    ViewData["Title"] = "ServerError";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "F:\ITI SD Intake 41\ASP.Net MVC\Asp Core Real Estate Project\FinalMVC\AspCoreProject\RealEstate\Views\Error\AppError.cshtml"
  
    ViewBag.Title = "Error occurred";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>We have a problem</h1>\r\n\r\n<p>Sorry, an error occurred while executing your request.</p>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<RealEstateUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<RealEstateUser> SignInManager { get; private set; }
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
