#pragma checksum "F:\ITI SD Intake 41\ASP.Net MVC\Asp Core Real Estate Project\FinalMVC\AspCoreProject\RealEstate\Views\Properties\AllProperties.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "870fbb37dd142f83d0e0da6413b91f3a27027f6f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Properties_AllProperties), @"mvc.1.0.view", @"/Views/Properties/AllProperties.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"870fbb37dd142f83d0e0da6413b91f3a27027f6f", @"/Views/Properties/AllProperties.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67ab996ee09aab1f1c7c6aa4034f242972cdca05", @"/Views/_ViewImports.cshtml")]
    public class Views_Properties_AllProperties : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RealEstate.Models.Property>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-whp"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Properties", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\ITI SD Intake 41\ASP.Net MVC\Asp Core Real Estate Project\FinalMVC\AspCoreProject\RealEstate\Views\Properties\AllProperties.cshtml"
  
    ViewData["Title"] = "My Properties";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-lg-4 col-xl-4 mb10 m-3"" >
    <div class=""breadcrumb_content style2 mb30-991"">
        <h2 class=""breadcrumb_title"">All Properties</h2>
        <p>We are glad to see you again!</p>
    </div>
</div>

<div class=""col-lg-12"">
    <div class=""my_dashboard_review mb40"">
        <div class=""property_table"">
            <div class=""table-responsive mt0"">
                <table class=""table"">
                    <thead class=""thead-light"">
                        <tr>
                            <th scope=""col"">Listing Title</th>
                            <th scope=""col"">Date published</th>
                            <th scope=""col"">Status</th>
                            <th scope=""col"">View</th>
                            <th scope=""col"">Action</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 29 "F:\ITI SD Intake 41\ASP.Net MVC\Asp Core Real Estate Project\FinalMVC\AspCoreProject\RealEstate\Views\Properties\AllProperties.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <th scope=\"row\">\r\n                                <div class=\"feat_property list favorite_page style2\">\r\n                                    <div class=\"thumb\">\r\n");
#nullable restore
#line 35 "F:\ITI SD Intake 41\ASP.Net MVC\Asp Core Real Estate Project\FinalMVC\AspCoreProject\RealEstate\Views\Properties\AllProperties.cshtml"
                                         foreach (var image in ViewBag.Images)
                                        {
                                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "F:\ITI SD Intake 41\ASP.Net MVC\Asp Core Real Estate Project\FinalMVC\AspCoreProject\RealEstate\Views\Properties\AllProperties.cshtml"
                                             if (item.PropertyID == image.PropertyID)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "870fbb37dd142f83d0e0da6413b91f3a27027f6f8065", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1617, "~/images/property/", 1617, 18, true);
#nullable restore
#line 39 "F:\ITI SD Intake 41\ASP.Net MVC\Asp Core Real Estate Project\FinalMVC\AspCoreProject\RealEstate\Views\Properties\AllProperties.cshtml"
AddHtmlAttributeValue("", 1635, image.ImgData, 1635, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 39 "F:\ITI SD Intake 41\ASP.Net MVC\Asp Core Real Estate Project\FinalMVC\AspCoreProject\RealEstate\Views\Properties\AllProperties.cshtml"
AddHtmlAttributeValue("", 1656, image.ImgData, 1656, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 40 "F:\ITI SD Intake 41\ASP.Net MVC\Asp Core Real Estate Project\FinalMVC\AspCoreProject\RealEstate\Views\Properties\AllProperties.cshtml"
                                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "F:\ITI SD Intake 41\ASP.Net MVC\Asp Core Real Estate Project\FinalMVC\AspCoreProject\RealEstate\Views\Properties\AllProperties.cshtml"
                                             
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <div class=""thmb_cntnt"">
                                                <ul class=""tag mb0"">
                                                    <li class=""list-inline-item dn""></li>
                                                    <li class=""list-inline-item"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "870fbb37dd142f83d0e0da6413b91f3a27027f6f11129", async() => {
#nullable restore
#line 45 "F:\ITI SD Intake 41\ASP.Net MVC\Asp Core Real Estate Project\FinalMVC\AspCoreProject\RealEstate\Views\Properties\AllProperties.cshtml"
                                                                                                                                                                Write(item.PropertyType);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "F:\ITI SD Intake 41\ASP.Net MVC\Asp Core Real Estate Project\FinalMVC\AspCoreProject\RealEstate\Views\Properties\AllProperties.cshtml"
                                                                                                           WriteLiteral(item.PropertyID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</li>
                                                </ul>
                                            </div>
                                        </div>
                                    <div class=""details"">
                                        <div class=""tc_content"">
                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "870fbb37dd142f83d0e0da6413b91f3a27027f6f14308", async() => {
                WriteLiteral("<h4>");
#nullable restore
#line 51 "F:\ITI SD Intake 41\ASP.Net MVC\Asp Core Real Estate Project\FinalMVC\AspCoreProject\RealEstate\Views\Properties\AllProperties.cshtml"
                                                                                                                               Write(item.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "F:\ITI SD Intake 41\ASP.Net MVC\Asp Core Real Estate Project\FinalMVC\AspCoreProject\RealEstate\Views\Properties\AllProperties.cshtml"
                                                                      WriteLiteral(item.PropertyID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                            <p><span class=\"flaticon-placeholder\"></span> ");
#nullable restore
#line 52 "F:\ITI SD Intake 41\ASP.Net MVC\Asp Core Real Estate Project\FinalMVC\AspCoreProject\RealEstate\Views\Properties\AllProperties.cshtml"
                                                                                     Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                            <a class=\"fp_price text-thm\" href=\"#\">");
#nullable restore
#line 53 "F:\ITI SD Intake 41\ASP.Net MVC\Asp Core Real Estate Project\FinalMVC\AspCoreProject\RealEstate\Views\Properties\AllProperties.cshtml"
                                                                             Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </th>\r\n                            <td>");
#nullable restore
#line 58 "F:\ITI SD Intake 41\ASP.Net MVC\Asp Core Real Estate Project\FinalMVC\AspCoreProject\RealEstate\Views\Properties\AllProperties.cshtml"
                           Write(item.YearBuilt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 59 "F:\ITI SD Intake 41\ASP.Net MVC\Asp Core Real Estate Project\FinalMVC\AspCoreProject\RealEstate\Views\Properties\AllProperties.cshtml"
                             if (@item.PropertyStatus.ToString() == "ForSale")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td><span class=\"status_tag btn btn-danger\">");
#nullable restore
#line 61 "F:\ITI SD Intake 41\ASP.Net MVC\Asp Core Real Estate Project\FinalMVC\AspCoreProject\RealEstate\Views\Properties\AllProperties.cshtml"
                                                                       Write(item.PropertyStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n");
#nullable restore
#line 62 "F:\ITI SD Intake 41\ASP.Net MVC\Asp Core Real Estate Project\FinalMVC\AspCoreProject\RealEstate\Views\Properties\AllProperties.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "F:\ITI SD Intake 41\ASP.Net MVC\Asp Core Real Estate Project\FinalMVC\AspCoreProject\RealEstate\Views\Properties\AllProperties.cshtml"
                             if (@item.PropertyStatus.ToString() == "ForRent")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td><span class=\"status_tag btn btn-success\">");
#nullable restore
#line 65 "F:\ITI SD Intake 41\ASP.Net MVC\Asp Core Real Estate Project\FinalMVC\AspCoreProject\RealEstate\Views\Properties\AllProperties.cshtml"
                                                                        Write(item.PropertyStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n");
#nullable restore
#line 66 "F:\ITI SD Intake 41\ASP.Net MVC\Asp Core Real Estate Project\FinalMVC\AspCoreProject\RealEstate\Views\Properties\AllProperties.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "F:\ITI SD Intake 41\ASP.Net MVC\Asp Core Real Estate Project\FinalMVC\AspCoreProject\RealEstate\Views\Properties\AllProperties.cshtml"
                             if (@item.PropertyStatus.ToString() == "Saled")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td><span class=\"status_tag btn btn-info\">");
#nullable restore
#line 69 "F:\ITI SD Intake 41\ASP.Net MVC\Asp Core Real Estate Project\FinalMVC\AspCoreProject\RealEstate\Views\Properties\AllProperties.cshtml"
                                                                     Write(item.PropertyStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n");
#nullable restore
#line 70 "F:\ITI SD Intake 41\ASP.Net MVC\Asp Core Real Estate Project\FinalMVC\AspCoreProject\RealEstate\Views\Properties\AllProperties.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "F:\ITI SD Intake 41\ASP.Net MVC\Asp Core Real Estate Project\FinalMVC\AspCoreProject\RealEstate\Views\Properties\AllProperties.cshtml"
                             if (@item.PropertyStatus.ToString() == "Rented")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td><span class=\"status_tag btn btn-warning\">");
#nullable restore
#line 73 "F:\ITI SD Intake 41\ASP.Net MVC\Asp Core Real Estate Project\FinalMVC\AspCoreProject\RealEstate\Views\Properties\AllProperties.cshtml"
                                                                        Write(item.PropertyStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n");
#nullable restore
#line 74 "F:\ITI SD Intake 41\ASP.Net MVC\Asp Core Real Estate Project\FinalMVC\AspCoreProject\RealEstate\Views\Properties\AllProperties.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>");
#nullable restore
#line 75 "F:\ITI SD Intake 41\ASP.Net MVC\Asp Core Real Estate Project\FinalMVC\AspCoreProject\RealEstate\Views\Properties\AllProperties.cshtml"
                           Write(item.AreaSize);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                <ul class=\"view_edit_delete_list mb0\">\r\n                                    <li class=\"list-inline-item\" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Edit\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "870fbb37dd142f83d0e0da6413b91f3a27027f6f23338", async() => {
                WriteLiteral("<span class=\"flaticon-edit\"></span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "F:\ITI SD Intake 41\ASP.Net MVC\Asp Core Real Estate Project\FinalMVC\AspCoreProject\RealEstate\Views\Properties\AllProperties.cshtml"
                                                                                                                                                                            WriteLiteral(item.PropertyID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                                    <li class=\"list-inline-item\" data-toggle=\"tooltip\" data-placement=\"top\" title=\"Delete\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "870fbb37dd142f83d0e0da6413b91f3a27027f6f26056", async() => {
                WriteLiteral("<span class=\"flaticon-garbage\"></span>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 79 "F:\ITI SD Intake 41\ASP.Net MVC\Asp Core Real Estate Project\FinalMVC\AspCoreProject\RealEstate\Views\Properties\AllProperties.cshtml"
                                                                                                                                                                                WriteLiteral(item.PropertyID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n                                </ul>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 83 "F:\ITI SD Intake 41\ASP.Net MVC\Asp Core Real Estate Project\FinalMVC\AspCoreProject\RealEstate\Views\Properties\AllProperties.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                </table>\r\n            </div>\r\n");
            WriteLiteral(@"            <div class=""mbp_pagination"">
                <ul class=""page_navigation"">
                    <li class=""page-item disabled"">
                        <a class=""page-link"" href=""#"" tabindex=""-1"" aria-disabled=""true""> <span class=""flaticon-left-arrow""></span> Prev</a>
                    </li>
                    <li class=""page-item""><a class=""page-link"" href=""#"">1</a></li>
                    <li class=""page-item active"" aria-current=""page"">
                        <a class=""page-link"" href=""#"">2 <span class=""sr-only"">(current)</span></a>
                    </li>
                    <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
                    <li class=""page-item""><a class=""page-link"" href=""#"">...</a></li>
                    <li class=""page-item""><a class=""page-link"" href=""#"">29</a></li>
                    <li class=""page-item"">
                        <a class=""page-link"" href=""#""><span class=""flaticon-right-arrow""></span></a>
                    </li>
    ");
            WriteLiteral("            </ul>\r\n            </div>\r\n");
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RealEstate.Models.Property>> Html { get; private set; }
    }
}
#pragma warning restore 1591