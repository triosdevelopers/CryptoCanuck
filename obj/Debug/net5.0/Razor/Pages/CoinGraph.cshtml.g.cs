#pragma checksum "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\CoinGraph.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6c82512babcf313b05c0fd664f9d0df65c1400e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CryptoCanuck.Pages.Pages_CoinGraph), @"mvc.1.0.razor-page", @"/Pages/CoinGraph.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6c82512babcf313b05c0fd664f9d0df65c1400e", @"/Pages/CoinGraph.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"097a38565dd8019f717a368105feab2ed909e2d0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_CoinGraph : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\CoinGraph.cshtml"
  
    ViewData["Title"] = "Coin Graph";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script type=\"text/javascript\">\r\n    var variable = \"");
#nullable restore
#line 8 "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\CoinGraph.cshtml"
               Write(Model.origString);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n    var coinName = \"");
#nullable restore
#line 9 "E:\C#\TeamAPI\CryptoCanuck\CryptoCanuck\Pages\CoinGraph.cshtml"
               Write(Model.coinName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n</script>\r\n\r\n<div id=\"graphContainer\"></div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoinGraphModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CoinGraphModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CoinGraphModel>)PageContext?.ViewData;
        public CoinGraphModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591