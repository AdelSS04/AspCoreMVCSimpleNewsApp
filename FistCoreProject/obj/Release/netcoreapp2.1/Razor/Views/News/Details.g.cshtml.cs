#pragma checksum "C:\Users\adela\source\repos\FistCoreProject\FistCoreProject\Views\News\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f63fffe3c84a7d53e2af1ea90d8e956f3bdefaf4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_Details), @"mvc.1.0.view", @"/Views/News/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/News/Details.cshtml", typeof(AspNetCore.Views_News_Details))]
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
#line 1 "C:\Users\adela\source\repos\FistCoreProject\FistCoreProject\Views\_ViewImports.cshtml"
using FistCoreProject;

#line default
#line hidden
#line 2 "C:\Users\adela\source\repos\FistCoreProject\FistCoreProject\Views\_ViewImports.cshtml"
using FistCoreProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f63fffe3c84a7d53e2af1ea90d8e956f3bdefaf4", @"/Views/News/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46ca25a55ebbed4e80d3e17f7a8f07b6d6403ce9", @"/Views/_ViewImports.cshtml")]
    public class Views_News_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FistCoreProject.Models.News>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(36, 173, true);
            WriteLiteral("\r\n\r\n<div class=\"container\" style=\"margin-top:30px;margin-bottom:30px;\">\r\n\t<h2>Details News</h2>\r\n\r\n\t<div>\r\n\t\t<h4></h4>\r\n\t\t<hr />\r\n\t\t<dl class=\"dl-horizontal\">\r\n\t\t\t<dt>\r\n\t\t\t\t");
            EndContext();
            BeginContext(210, 41, false);
#line 12 "C:\Users\adela\source\repos\FistCoreProject\FistCoreProject\Views\News\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(251, 25, true);
            WriteLiteral("\r\n\t\t\t</dt>\r\n\t\t\t<dd>\r\n\t\t\t\t");
            EndContext();
            BeginContext(277, 37, false);
#line 15 "C:\Users\adela\source\repos\FistCoreProject\FistCoreProject\Views\News\Details.cshtml"
           Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(314, 25, true);
            WriteLiteral("\r\n\t\t\t</dd>\r\n\t\t\t<dt>\r\n\t\t\t\t");
            EndContext();
            BeginContext(340, 40, false);
#line 18 "C:\Users\adela\source\repos\FistCoreProject\FistCoreProject\Views\News\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(380, 25, true);
            WriteLiteral("\r\n\t\t\t</dt>\r\n\t\t\t<dd>\r\n\t\t\t\t");
            EndContext();
            BeginContext(406, 36, false);
#line 21 "C:\Users\adela\source\repos\FistCoreProject\FistCoreProject\Views\News\Details.cshtml"
           Write(Html.DisplayFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(442, 25, true);
            WriteLiteral("\r\n\t\t\t</dd>\r\n\t\t\t<dt>\r\n\t\t\t\t");
            EndContext();
            BeginContext(468, 41, false);
#line 24 "C:\Users\adela\source\repos\FistCoreProject\FistCoreProject\Views\News\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
            EndContext();
            BeginContext(509, 25, true);
            WriteLiteral("\r\n\t\t\t</dt>\r\n\t\t\t<dd>\r\n\t\t\t\t");
            EndContext();
            BeginContext(535, 37, false);
#line 27 "C:\Users\adela\source\repos\FistCoreProject\FistCoreProject\Views\News\Details.cshtml"
           Write(Html.DisplayFor(model => model.Image));

#line default
#line hidden
            EndContext();
            BeginContext(572, 25, true);
            WriteLiteral("\r\n\t\t\t</dd>\r\n\t\t\t<dt>\r\n\t\t\t\t");
            EndContext();
            BeginContext(598, 41, false);
#line 30 "C:\Users\adela\source\repos\FistCoreProject\FistCoreProject\Views\News\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Topic));

#line default
#line hidden
            EndContext();
            BeginContext(639, 25, true);
            WriteLiteral("\r\n\t\t\t</dt>\r\n\t\t\t<dd>\r\n\t\t\t\t");
            EndContext();
            BeginContext(665, 37, false);
#line 33 "C:\Users\adela\source\repos\FistCoreProject\FistCoreProject\Views\News\Details.cshtml"
           Write(Html.DisplayFor(model => model.Topic));

#line default
#line hidden
            EndContext();
            BeginContext(702, 25, true);
            WriteLiteral("\r\n\t\t\t</dd>\r\n\t\t\t<dt>\r\n\t\t\t\t");
            EndContext();
            BeginContext(728, 44, false);
#line 36 "C:\Users\adela\source\repos\FistCoreProject\FistCoreProject\Views\News\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
            EndContext();
            BeginContext(772, 25, true);
            WriteLiteral("\r\n\t\t\t</dt>\r\n\t\t\t<dd>\r\n\t\t\t\t");
            EndContext();
            BeginContext(798, 43, false);
#line 39 "C:\Users\adela\source\repos\FistCoreProject\FistCoreProject\Views\News\Details.cshtml"
           Write(Html.DisplayFor(model => model.Category.Id));

#line default
#line hidden
            EndContext();
            BeginContext(841, 40, true);
            WriteLiteral("\r\n\t\t\t</dd>\r\n\t\t</dl>\r\n\t</div>\r\n\t<div>\r\n\t\t");
            EndContext();
            BeginContext(881, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8dd6790b40794509b45917a41988cd8f", async() => {
                BeginContext(951, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 44 "C:\Users\adela\source\repos\FistCoreProject\FistCoreProject\Views\News\Details.cshtml"
                                                       WriteLiteral(Model.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(959, 6, true);
            WriteLiteral(" |\r\n\t\t");
            EndContext();
            BeginContext(965, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e266090b751d4a35bd6247118b43e85c", async() => {
                BeginContext(1007, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1023, 19, true);
            WriteLiteral("\r\n\t</div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FistCoreProject.Models.News> Html { get; private set; }
    }
}
#pragma warning restore 1591
