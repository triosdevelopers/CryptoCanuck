#pragma checksum "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56bbace04e616fa4d1539f9da145f54121149223"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CryptoCanuck.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace CryptoCanuck.Pages
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
#line 1 "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\_ViewImports.cshtml"
using CryptoCanuck;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56bbace04e616fa4d1539f9da145f54121149223", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"097a38565dd8019f717a368105feab2ed909e2d0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Prices", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
</div>

<div id= ""graphCoinTable"">
    <table class=""table table-hover"">
        <thead>
            <tr>
                <th scope=""col"">#</th>
                <th scope=""col"">Coin</th>
                <th scope=""col"">Price</th>
                <th scope=""col"">Total Vol/24H</th>
                <th scope=""col"">Market Cap.</th>
                <th scope=""col"">% in 24h </th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 25 "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\Index.cshtml"
             for(int i = 0; i < @Model.top24Data.Count; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th scope=\"row\">");
#nullable restore
#line 28 "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\Index.cshtml"
                                Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td> \r\n                        <a class=\"graphLink\"");
            BeginWriteAttribute("href", " href=\"", 916, "\"", 967, 2);
            WriteAttributeValue("", 923, "/CoinGraph?coin=", 923, 16, true);
#nullable restore
#line 30 "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\Index.cshtml"
WriteAttributeValue("", 939, Model.top24CoinInfo[i].Name, 939, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 1003, "\"", 1080, 3);
            WriteAttributeValue("", 1009, "https://www.cryptocompare.com/", 1009, 30, true);
#nullable restore
#line 31 "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\Index.cshtml"
WriteAttributeValue("", 1039, Model.top24CoinInfo[i].ImageUrl, 1039, 32, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1071, "?width=25", 1071, 9, true);
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 31 "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\Index.cshtml"
                                                                                                           Write(Model.top24CoinInfo[i].FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </a>\r\n                    </td>                            \r\n                \r\n                    <td>\r\n                        <a class=\"graphLink\"");
            BeginWriteAttribute("href", " href=\"", 1290, "\"", 1341, 2);
            WriteAttributeValue("", 1297, "/CoinGraph?coin=", 1297, 16, true);
#nullable restore
#line 36 "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\Index.cshtml"
WriteAttributeValue("", 1313, Model.top24CoinInfo[i].Name, 1313, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
#nullable restore
#line 37 "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\Index.cshtml"
                       Write(Model.top24Data[i].PRICE);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </a>\r\n                    </td>\r\n                \r\n                    <td>\r\n                        <a class=\"graphLink\"");
            BeginWriteAttribute("href", " href=\"", 1545, "\"", 1596, 2);
            WriteAttributeValue("", 1552, "/CoinGraph?coin=", 1552, 16, true);
#nullable restore
#line 42 "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\Index.cshtml"
WriteAttributeValue("", 1568, Model.top24CoinInfo[i].Name, 1568, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
#nullable restore
#line 43 "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\Index.cshtml"
                       Write(Model.top24Data[i].TOTALVOLUME24HTO);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </a>\r\n                    </td>\r\n\r\n                    <td>\r\n                        <a class=\"graphLink\"");
            BeginWriteAttribute("href", " href=\"", 1795, "\"", 1846, 2);
            WriteAttributeValue("", 1802, "/CoinGraph?coin=", 1802, 16, true);
#nullable restore
#line 48 "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\Index.cshtml"
WriteAttributeValue("", 1818, Model.top24CoinInfo[i].Name, 1818, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
#nullable restore
#line 49 "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\Index.cshtml"
                       Write(Model.top24Data[i].MKTCAP);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </a>\r\n                    </td>\r\n                            \r\n                    <td>\r\n                        <a class=\"graphLink\"");
            BeginWriteAttribute("href", " href=\"", 2063, "\"", 2114, 2);
            WriteAttributeValue("", 2070, "/CoinGraph?coin=", 2070, 16, true);
#nullable restore
#line 54 "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\Index.cshtml"
WriteAttributeValue("", 2086, Model.top24CoinInfo[i].Name, 2086, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
#nullable restore
#line 55 "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\Index.cshtml"
                       Write(Model.top24Data[i].CHANGEPCT24HOUR);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </a>\r\n                    </td>                  \r\n                </tr>\r\n");
#nullable restore
#line 59 "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n<div id=\"converter\">\r\n    <div id=\"converterForm\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56bbace04e616fa4d1539f9da145f5412114922310363", async() => {
                WriteLiteral("\r\n        <label for=\"crypto\">Currency converter:</label>\r\n\r\n        <select name=\"symbol\">\r\n");
#nullable restore
#line 70 "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\Index.cshtml"
             for(int i = 0; i < Model.top24Data.Count; i++){

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56bbace04e616fa4d1539f9da145f5412114922310976", async() => {
#nullable restore
#line 71 "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\Index.cshtml"
                                                                                            Write(Model.top24CoinInfo[i].FullName);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "name", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 71 "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\Index.cshtml"
AddHtmlAttributeValue("", 2629, Model.top24CoinInfo[i].Name, 2629, 28, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 71 "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\Index.cshtml"
                                                       WriteLiteral(Model.top24CoinInfo[i].Name);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 72 "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </select>\r\n        <input type=\"number\" name=\"amount\">\r\n        <button class=\"btn btn-default\">Enter</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
    
    <div id=""converterTable"">
        <table class=""table table-hover"">
        <thead>
            <tr>
                <th>Currency</th>
                <th>CAD</th>
                <th>USD</th>
                <th>JPY</th>
                <th>EUR</th>
            </tr>
        </thead>
        <tbody>
        <tr>
            <td></td>
            <td>$");
#nullable restore
#line 93 "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\Index.cshtml"
            Write(Model.prices.CAD);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>$");
#nullable restore
#line 94 "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\Index.cshtml"
            Write(Model.prices.USD);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>¥");
#nullable restore
#line 95 "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\Index.cshtml"
            Write(Model.prices.JPY);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>€");
#nullable restore
#line 96 "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\Index.cshtml"
            Write(Model.prices.EUR);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        </tbody>\r\n    </table>\r\n    </div>  \r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
