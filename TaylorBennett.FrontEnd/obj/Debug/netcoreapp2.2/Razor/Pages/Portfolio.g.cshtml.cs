#pragma checksum "C:\Dev\TaylorBennett\TaylorBennett.FrontEnd\Pages\Portfolio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0831c9131f8abeac729a00300f7e224e76bb42aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TaylorBennett.FrontEnd.Pages.Pages_Portfolio), @"mvc.1.0.razor-page", @"/Pages/Portfolio.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Portfolio.cshtml", typeof(TaylorBennett.FrontEnd.Pages.Pages_Portfolio), null)]
namespace TaylorBennett.FrontEnd.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Dev\TaylorBennett\TaylorBennett.FrontEnd\Pages\_ViewImports.cshtml"
using TaylorBennett.FrontEnd;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0831c9131f8abeac729a00300f7e224e76bb42aa", @"/Pages/Portfolio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a5b74e033812da4e88ceabd1cfdce2e845ce217", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Portfolio : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Dev\TaylorBennett\TaylorBennett.FrontEnd\Pages\Portfolio.cshtml"
  
    ViewData["Title"] = "Portfolio";

#line default
#line hidden
            BeginContext(75, 168, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Portfolio</h1>\r\n    <a href=\"https://github.com/twolar\" target=\"_blank\">Click here to see my Github</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PortfolioModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PortfolioModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PortfolioModel>)PageContext?.ViewData;
        public PortfolioModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591