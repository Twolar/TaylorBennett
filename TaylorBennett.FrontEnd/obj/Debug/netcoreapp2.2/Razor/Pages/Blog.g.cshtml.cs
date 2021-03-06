#pragma checksum "C:\dev\TaylorBennett\TaylorBennett.FrontEnd\Pages\Blog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ddaa4bbf0d7b5a190fc7b7efc0b93a988103584"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TaylorBennett.FrontEnd.Pages.Pages_Blog), @"mvc.1.0.razor-page", @"/Pages/Blog.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Blog.cshtml", typeof(TaylorBennett.FrontEnd.Pages.Pages_Blog), null)]
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
#line 1 "C:\dev\TaylorBennett\TaylorBennett.FrontEnd\Pages\_ViewImports.cshtml"
using TaylorBennett.FrontEnd;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ddaa4bbf0d7b5a190fc7b7efc0b93a988103584", @"/Pages/Blog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a5b74e033812da4e88ceabd1cfdce2e845ce217", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Blog : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Admin/NewBlogPost", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Admin/EditBlogPost", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default btn-xs"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\dev\TaylorBennett\TaylorBennett.FrontEnd\Pages\Blog.cshtml"
  
    ViewData["Title"] = "Blog";

#line default
#line hidden
            BeginContext(65, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\dev\TaylorBennett\TaylorBennett.FrontEnd\Pages\Blog.cshtml"
 if (Model.ShowMessage)
{

#line default
#line hidden
            BeginContext(95, 215, true);
            WriteLiteral("    <div class=\"alert alert-success alert-dismissible\" role=\"alert\">\r\n        <button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\"><span aria-hidden=\"true\">&times;</span>   </button>\r\n        ");
            EndContext();
            BeginContext(311, 13, false);
#line 11 "C:\dev\TaylorBennett\TaylorBennett.FrontEnd\Pages\Blog.cshtml"
   Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(324, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
#line 13 "C:\dev\TaylorBennett\TaylorBennett.FrontEnd\Pages\Blog.cshtml"
}

#line default
#line hidden
            BeginContext(341, 420, true);
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-3"">Blog</h1>
    <p>
        Welcome to my personal blog, here I mainly post a day summary of what I have learnt each day.
        Because I believe it helps me to consolidate any learnings from the day as it offers an opportunity
        to summarise and reflect on any learning right before sleeping.
    </p>
</div>
<div class=""row justify-content-center"">
");
            EndContext();
#line 24 "C:\dev\TaylorBennett\TaylorBennett.FrontEnd\Pages\Blog.cshtml"
     if (Model.IsAdmin)
    {

#line default
#line hidden
            BeginContext(793, 55, true);
            WriteLiteral("        <li class=\"list-inline-item p-3\">\r\n            ");
            EndContext();
            BeginContext(848, 103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ddaa4bbf0d7b5a190fc7b7efc0b93a9881035846541", async() => {
                BeginContext(934, 13, true);
                WriteLiteral("New Blog Post");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(951, 17, true);
            WriteLiteral("\r\n        </li>\r\n");
            EndContext();
#line 29 "C:\dev\TaylorBennett\TaylorBennett.FrontEnd\Pages\Blog.cshtml"
    }

#line default
#line hidden
            BeginContext(975, 54, true);
            WriteLiteral("</div>\r\n    <div class=\"row justify-content-center\">\r\n");
            EndContext();
#line 32 "C:\dev\TaylorBennett\TaylorBennett.FrontEnd\Pages\Blog.cshtml"
         foreach (var blogpost in Model.BlogPosts)
        {

#line default
#line hidden
            BeginContext(1092, 138, true);
            WriteLiteral("            <div class=\"w-100 p-3\">\r\n                <div class=\"card shadow session h-100\">\r\n                    <h5 class=\"card-header\">");
            EndContext();
            BeginContext(1231, 22, false);
#line 36 "C:\dev\TaylorBennett\TaylorBennett.FrontEnd\Pages\Blog.cshtml"
                                       Write(blogpost.BlogPostTitle);

#line default
#line hidden
            EndContext();
            BeginContext(1253, 135, true);
            WriteLiteral("</h5>\r\n                    <div class=\"card-body\">\r\n                        <div class=\"card-title\">\r\n                            <pre>");
            EndContext();
            BeginContext(1389, 21, false);
#line 39 "C:\dev\TaylorBennett\TaylorBennett.FrontEnd\Pages\Blog.cshtml"
                            Write(blogpost.BlogPostBody);

#line default
#line hidden
            EndContext();
            BeginContext(1410, 264, true);
            WriteLiteral(@"</pre>
                        </div>
                    </div>
                    <div class=""card-footer"">
                        <ul class=""list-inline mb-0"">
                            <li class=""list-inline-item"">
                                <a>");
            EndContext();
            BeginContext(1675, 15, false);
#line 45 "C:\dev\TaylorBennett\TaylorBennett.FrontEnd\Pages\Blog.cshtml"
                              Write(blogpost.Author);

#line default
#line hidden
            EndContext();
            BeginContext(1690, 135, true);
            WriteLiteral("</a>\r\n                            </li>\r\n                            <li class=\"list-inline-item\">\r\n                                <a>");
            EndContext();
            BeginContext(1826, 50, false);
#line 48 "C:\dev\TaylorBennett\TaylorBennett.FrontEnd\Pages\Blog.cshtml"
                              Write(blogpost.BlogPostDate.Date.ToString("dd MMM yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(1876, 41, true);
            WriteLiteral("</a>\r\n                            </li>\r\n");
            EndContext();
#line 50 "C:\dev\TaylorBennett\TaylorBennett.FrontEnd\Pages\Blog.cshtml"
                             if (Model.IsAdmin)
                            {

#line default
#line hidden
            BeginContext(1997, 99, true);
            WriteLiteral("                                <li class=\"list-inline-item\">\r\n                                    ");
            EndContext();
            BeginContext(2096, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ddaa4bbf0d7b5a190fc7b7efc0b93a98810358411598", async() => {
                BeginContext(2189, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 53 "C:\dev\TaylorBennett\TaylorBennett.FrontEnd\Pages\Blog.cshtml"
                                                                        WriteLiteral(blogpost.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2197, 41, true);
            WriteLiteral("\r\n                                </li>\r\n");
            EndContext();
#line 55 "C:\dev\TaylorBennett\TaylorBennett.FrontEnd\Pages\Blog.cshtml"
                            }

#line default
#line hidden
            BeginContext(2269, 103, true);
            WriteLiteral("                        </ul>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
            EndContext();
#line 60 "C:\dev\TaylorBennett\TaylorBennett.FrontEnd\Pages\Blog.cshtml"
        }

#line default
#line hidden
            BeginContext(2383, 12, true);
            WriteLiteral("    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BlogModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BlogModel>)PageContext?.ViewData;
        public BlogModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
