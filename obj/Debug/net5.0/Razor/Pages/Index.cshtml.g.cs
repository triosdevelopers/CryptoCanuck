#pragma checksum "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01a3b1ce8f79e77d2e6d55722832152d157d5203"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"01a3b1ce8f79e77d2e6d55722832152d157d5203", @"/Pages/Index.cshtml")]
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
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4 welcome\">Welcome to Crypto Canuck</h1>\r\n</div>\r\n\r\n<a href=\"/CoinGraph?coin=BTCWeekly\"> Test Code for Allaura</a>\r\n\r\n<div id=\"converter\">\r\n    <div id=\"converterForm\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01a3b1ce8f79e77d2e6d55722832152d157d52034156", async() => {
                WriteLiteral("\r\n        <label for=\"crypto\">Currency converter:</label>\r\n\r\n        <select name=\"symbol\">\r\n");
#nullable restore
#line 19 "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\Index.cshtml"
             for(int i = 0; i < Model.top24Data.Count; i++){

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "01a3b1ce8f79e77d2e6d55722832152d157d52034768", async() => {
#nullable restore
#line 20 "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\Index.cshtml"
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
#line 20 "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\Index.cshtml"
AddHtmlAttributeValue("", 532, Model.top24CoinInfo[i].Name, 532, 28, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 20 "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\Index.cshtml"
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
#line 21 "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\Index.cshtml"
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
            <td>");
#nullable restore
#line 41 "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\Index.cshtml"
           Write(Model.amount);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 41 "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\Index.cshtml"
                         Write(Model.symbol);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>$");
#nullable restore
#line 42 "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\Index.cshtml"
            Write(Model.prices.CAD);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>$");
#nullable restore
#line 43 "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\Index.cshtml"
            Write(Model.prices.USD);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>¥");
#nullable restore
#line 44 "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\Index.cshtml"
            Write(Model.prices.JPY);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>€");
#nullable restore
#line 45 "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\Index.cshtml"
            Write(Model.prices.EUR);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
        </tr>
        </tbody>
    </table>
    </div>  
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
#line 65 "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\Index.cshtml"
             for(int i = 0; i < @Model.top24Data.Count; i++)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th scope=\"row\">");
#nullable restore
#line 68 "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\Index.cshtml"
                                Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td> \r\n                        <a class=\"graphLink\"");
            BeginWriteAttribute("href", " href=\"", 2081, "\"", 2132, 2);
            WriteAttributeValue("", 2088, "/CoinGraph?coin=", 2088, 16, true);
#nullable restore
#line 70 "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\Index.cshtml"
WriteAttributeValue("", 2104, Model.top24CoinInfo[i].Name, 2104, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 2168, "\"", 2245, 3);
            WriteAttributeValue("", 2174, "https://www.cryptocompare.com/", 2174, 30, true);
#nullable restore
#line 71 "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\Index.cshtml"
WriteAttributeValue("", 2204, Model.top24CoinInfo[i].ImageUrl, 2204, 32, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2236, "?width=25", 2236, 9, true);
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 71 "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\Index.cshtml"
                                                                                                           Write(Model.top24CoinInfo[i].FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </a>\r\n                    </td>                            \r\n                \r\n                    <td>\r\n                        <a class=\"graphLink\"");
            BeginWriteAttribute("href", " href=\"", 2455, "\"", 2506, 2);
            WriteAttributeValue("", 2462, "/CoinGraph?coin=", 2462, 16, true);
#nullable restore
#line 76 "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\Index.cshtml"
WriteAttributeValue("", 2478, Model.top24CoinInfo[i].Name, 2478, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
#nullable restore
#line 77 "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\Index.cshtml"
                       Write(Model.top24Data[i].PRICE);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </a>\r\n                    </td>\r\n                \r\n                    <td>\r\n                        <a class=\"graphLink\"");
            BeginWriteAttribute("href", " href=\"", 2710, "\"", 2761, 2);
            WriteAttributeValue("", 2717, "/CoinGraph?coin=", 2717, 16, true);
#nullable restore
#line 82 "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\Index.cshtml"
WriteAttributeValue("", 2733, Model.top24CoinInfo[i].Name, 2733, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
#nullable restore
#line 83 "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\Index.cshtml"
                       Write(Model.top24Data[i].TOTALVOLUME24HTO);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </a>\r\n                    </td>\r\n\r\n                    <td>\r\n                        <a class=\"graphLink\"");
            BeginWriteAttribute("href", " href=\"", 2960, "\"", 3011, 2);
            WriteAttributeValue("", 2967, "/CoinGraph?coin=", 2967, 16, true);
#nullable restore
#line 88 "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\Index.cshtml"
WriteAttributeValue("", 2983, Model.top24CoinInfo[i].Name, 2983, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
#nullable restore
#line 89 "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\Index.cshtml"
                       Write(Model.top24Data[i].MKTCAP);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </a>\r\n                    </td>\r\n                            \r\n                    <td>\r\n                        <a class=\"graphLink\"");
            BeginWriteAttribute("href", " href=\"", 3228, "\"", 3279, 2);
            WriteAttributeValue("", 3235, "/CoinGraph?coin=", 3235, 16, true);
#nullable restore
#line 94 "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\Index.cshtml"
WriteAttributeValue("", 3251, Model.top24CoinInfo[i].Name, 3251, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            ");
#nullable restore
#line 95 "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\Index.cshtml"
                       Write(Model.top24Data[i].CHANGEPCT24HOUR);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </a>\r\n                    </td>                  \r\n                </tr>\r\n");
#nullable restore
#line 99 "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
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
