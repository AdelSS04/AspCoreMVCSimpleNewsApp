#pragma checksum "C:\Users\adela\source\repos\FistCoreProject\FistCoreProject\Views\News\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "952b257baf1ebe27867d95e62bd167bf6b4897a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_Delete), @"mvc.1.0.view", @"/Views/News/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/News/Delete.cshtml", typeof(AspNetCore.Views_News_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"952b257baf1ebe27867d95e62bd167bf6b4897a0", @"/Views/News/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46ca25a55ebbed4e80d3e17f7a8f07b6d6403ce9", @"/Views/_ViewImports.cshtml")]
    public class Views_News_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FistCoreProject.Models.News>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 220, true);
            WriteLiteral("\r\n<div class=\"container\" style=\"margin-top:30px;margin-bottom:30px;\">\r\n\r\n\t<h2>Delete</h2>\r\n\r\n\t<h3>Are you sure you want to delete this?</h3>\r\n\t<div>\r\n\t\t<h4>News</h4>\r\n\t\t<hr />\r\n\t\t<dl class=\"dl-horizontal\">\r\n\t\t\t<dt>\r\n\t\t\t\t");
            EndContext();
            BeginContext(257, 41, false);
#line 13 "C:\Users\adela\source\repos\FistCoreProject\FistCoreProject\Views\News\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(298, 25, true);
            WriteLiteral("\r\n\t\t\t</dt>\r\n\t\t\t<dd>\r\n\t\t\t\t");
            EndContext();
            BeginContext(324, 37, false);
#line 16 "C:\Users\adela\source\repos\FistCoreProject\FistCoreProject\Views\News\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(361, 25, true);
            WriteLiteral("\r\n\t\t\t</dd>\r\n\t\t\t<dt>\r\n\t\t\t\t");
            EndContext();
            BeginContext(387, 40, false);
#line 19 "C:\Users\adela\source\repos\FistCoreProject\FistCoreProject\Views\News\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(427, 25, true);
            WriteLiteral("\r\n\t\t\t</dt>\r\n\t\t\t<dd>\r\n\t\t\t\t");
            EndContext();
            BeginContext(453, 36, false);
#line 22 "C:\Users\adela\source\repos\FistCoreProject\FistCoreProject\Views\News\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(489, 25, true);
            WriteLiteral("\r\n\t\t\t</dd>\r\n\t\t\t<dt>\r\n\t\t\t\t");
            EndContext();
            BeginContext(515, 41, false);
#line 25 "C:\Users\adela\source\repos\FistCoreProject\FistCoreProject\Views\News\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
            EndContext();
            BeginContext(556, 25, true);
            WriteLiteral("\r\n\t\t\t</dt>\r\n\t\t\t<dd>\r\n\t\t\t\t");
            EndContext();
            BeginContext(582, 37, false);
#line 28 "C:\Users\adela\source\repos\FistCoreProject\FistCoreProject\Views\News\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Image));

#line default
#line hidden
            EndContext();
            BeginContext(619, 25, true);
            WriteLiteral("\r\n\t\t\t</dd>\r\n\t\t\t<dt>\r\n\t\t\t\t");
            EndContext();
            BeginContext(645, 41, false);
#line 31 "C:\Users\adela\source\repos\FistCoreProject\FistCoreProject\Views\News\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Topic));

#line default
#line hidden
            EndContext();
            BeginContext(686, 25, true);
            WriteLiteral("\r\n\t\t\t</dt>\r\n\t\t\t<dd>\r\n\t\t\t\t");
            EndContext();
            BeginContext(712, 37, false);
#line 34 "C:\Users\adela\source\repos\FistCoreProject\FistCoreProject\Views\News\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Topic));

#line default
#line hidden
            EndContext();
            BeginContext(749, 25, true);
            WriteLiteral("\r\n\t\t\t</dd>\r\n\t\t\t<dt>\r\n\t\t\t\t");
            EndContext();
            BeginContext(775, 44, false);
#line 37 "C:\Users\adela\source\repos\FistCoreProject\FistCoreProject\Views\News\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
            EndContext();
            BeginContext(819, 25, true);
            WriteLiteral("\r\n\t\t\t</dt>\r\n\t\t\t<dd>\r\n\t\t\t\t");
            EndContext();
            BeginContext(845, 43, false);
#line 40 "C:\Users\adela\source\repos\FistCoreProject\FistCoreProject\Views\News\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Category.Id));

#line default
#line hidden
            EndContext();
            BeginContext(888, 25, true);
            WriteLiteral("\r\n\t\t\t</dd>\r\n\t\t</dl>\r\n\r\n\t\t");
            EndContext();
            BeginContext(913, 210, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56423e8f95ab45e3bedefc4db9466d88", async() => {
                BeginContext(939, 5, true);
                WriteLiteral("\r\n\t\t\t");
                EndContext();
                BeginContext(944, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9397c885907747ad8bbe2235323c6b40", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 45 "C:\Users\adela\source\repos\FistCoreProject\FistCoreProject\Views\News\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(980, 73, true);
                WriteLiteral("\r\n\t\t\t<input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n\t\t\t");
                EndContext();
                BeginContext(1053, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0d2b5c3b2cd462fbce2920c577dcfe9", async() => {
                    BeginContext(1096, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
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
                BeginContext(1112, 4, true);
                WriteLiteral("\r\n\t\t");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1123, 19, true);
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
