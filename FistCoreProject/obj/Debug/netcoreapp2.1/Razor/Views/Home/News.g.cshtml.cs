#pragma checksum "C:\Users\adela\source\repos\FistCoreProject\FistCoreProject\Views\Home\News.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "358baa78e125eecae83eaa7315b2d40ebbedb2a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_News), @"mvc.1.0.view", @"/Views/Home/News.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/News.cshtml", typeof(AspNetCore.Views_Home_News))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"358baa78e125eecae83eaa7315b2d40ebbedb2a2", @"/Views/Home/News.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46ca25a55ebbed4e80d3e17f7a8f07b6d6403ce9", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_News : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<News>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/img/about.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:300px;height:300px;border-radius:50%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(19, 142, true);
            WriteLiteral("<section id=\"about\" class=\"about\">\r\n\t<div class=\"container aos-init aos-animate\" data-aos=\"fade-up\">\r\n\r\n\t\t<div class=\"section-title\">\r\n\t\t\t<h2>");
            EndContext();
            BeginContext(162, 11, false);
#line 6 "C:\Users\adela\source\repos\FistCoreProject\FistCoreProject\Views\Home\News.cshtml"
           Write(ViewBag.cat);

#line default
#line hidden
            EndContext();
            BeginContext(173, 32, true);
            WriteLiteral("</h2>\r\n\t\t\t \t</div>\r\n\t\t<center>\r\n");
            EndContext();
#line 9 "C:\Users\adela\source\repos\FistCoreProject\FistCoreProject\Views\Home\News.cshtml"
             foreach (var item in Model)
			{

#line default
#line hidden
            BeginContext(242, 76, true);
            WriteLiteral("<div class=\"row\" style=\"margin:30px\">\r\n\r\n\r\n\t\t\t\t\t<div class=\"col-12\">\r\n\t\t\t\t\t\t");
            EndContext();
            BeginContext(318, 110, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9c95b12bf73249abbabd9f93d7058856", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(428, 55, true);
            WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"col-sm-12\">\r\n\t\t\t\t\t\t<h3>");
            EndContext();
            BeginContext(484, 10, false);
#line 17 "C:\Users\adela\source\repos\FistCoreProject\FistCoreProject\Views\Home\News.cshtml"
                       Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(494, 17, true);
            WriteLiteral("</h3>\r\n\t\t\t\t\t\t<h4>");
            EndContext();
            BeginContext(512, 9, false);
#line 18 "C:\Users\adela\source\repos\FistCoreProject\FistCoreProject\Views\Home\News.cshtml"
                       Write(item.Date);

#line default
#line hidden
            EndContext();
            BeginContext(521, 47, true);
            WriteLiteral("</h4>\r\n\r\n\t\t\t\t\t\t<p class=\"font-italic\">\r\n\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(569, 10, false);
#line 21 "C:\Users\adela\source\repos\FistCoreProject\FistCoreProject\Views\Home\News.cshtml"
                       Write(item.Topic);

#line default
#line hidden
            EndContext();
            BeginContext(579, 70, true);
            WriteLiteral("\r\n\t\t\t\t\t\t</p>\r\n\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t\t<a class=\"btn btn-danger\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 649, "\"", 681, 2);
            WriteAttributeValue("", 656, "/Home/DeleteNews/", 656, 17, true);
#line 26 "C:\Users\adela\source\repos\FistCoreProject\FistCoreProject\Views\Home\News.cshtml"
WriteAttributeValue("", 673, item.Id, 673, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(682, 13, true);
            WriteLiteral(">Delete</a>\r\n");
            EndContext();
            BeginContext(697, 10, true);
            WriteLiteral("\t\t\t\t<hr />");
            EndContext();
#line 28 "C:\Users\adela\source\repos\FistCoreProject\FistCoreProject\Views\Home\News.cshtml"
                      }

#line default
#line hidden
            BeginContext(710, 32, true);
            WriteLiteral("\t\t</center>\r\n\t</div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<News>> Html { get; private set; }
    }
}
#pragma warning restore 1591
