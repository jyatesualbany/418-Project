#pragma checksum "/Users/julienunez/Downloads/Archive/418FinalProject/Views/UserGrades/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b207ebe50387c1763e90358a790e401115b2b2ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserGrades_Index), @"mvc.1.0.view", @"/Views/UserGrades/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UserGrades/Index.cshtml", typeof(AspNetCore.Views_UserGrades_Index))]
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
#line 1 "/Users/julienunez/Downloads/Archive/418FinalProject/Views/_ViewImports.cshtml"
using _418FinalProject;

#line default
#line hidden
#line 2 "/Users/julienunez/Downloads/Archive/418FinalProject/Views/_ViewImports.cshtml"
using _418FinalProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b207ebe50387c1763e90358a790e401115b2b2ec", @"/Views/UserGrades/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"721d5ce7967c8a32a9a4be2e1dc36f2f03d72a1a", @"/Views/_ViewImports.cshtml")]
    public class Views_UserGrades_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<_418FinalProject.Models.UserGrades>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(55, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/julienunez/Downloads/Archive/418FinalProject/Views/UserGrades/Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(94, 205, true);
            WriteLiteral("\n<h1>User Grades</h1>\n\n\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                User ID\n            </th>\n            <th>\n                Test ID\n            </th>\n            <th>");
            EndContext();
            BeginContext(300, 41, false);
#line 19 "/Users/julienunez/Downloads/Archive/418FinalProject/Views/UserGrades/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Grade));

#line default
#line hidden
            EndContext();
            BeginContext(341, 45, true);
            WriteLiteral("</th>\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 23 "/Users/julienunez/Downloads/Archive/418FinalProject/Views/UserGrades/Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(417, 46, true);
            WriteLiteral("        <tr>\n            <td>\n                ");
            EndContext();
            BeginContext(464, 46, false);
#line 26 "/Users/julienunez/Downloads/Archive/418FinalProject/Views/UserGrades/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.UserRefName));

#line default
#line hidden
            EndContext();
            BeginContext(510, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(563, 44, false);
#line 29 "/Users/julienunez/Downloads/Archive/418FinalProject/Views/UserGrades/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TestRefID));

#line default
#line hidden
            EndContext();
            BeginContext(607, 52, true);
            WriteLiteral("\n            </td>\n            <td>\n                ");
            EndContext();
            BeginContext(660, 40, false);
#line 32 "/Users/julienunez/Downloads/Archive/418FinalProject/Views/UserGrades/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Grade));

#line default
#line hidden
            EndContext();
            BeginContext(700, 68, true);
            WriteLiteral("\n            </td>\n            <td>\n               \n                ");
            EndContext();
            BeginContext(768, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b207ebe50387c1763e90358a790e401115b2b2ec5895", async() => {
                BeginContext(825, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 36 "/Users/julienunez/Downloads/Archive/418FinalProject/Views/UserGrades/Index.cshtml"
                                          WriteLiteral(item.UserRefName);

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
            BeginContext(836, 50, true);
            WriteLiteral("\n                \n            </td>\n        </tr>\n");
            EndContext();
#line 40 "/Users/julienunez/Downloads/Archive/418FinalProject/Views/UserGrades/Index.cshtml"
}

#line default
#line hidden
            BeginContext(888, 21, true);
            WriteLiteral("    </tbody>\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<_418FinalProject.Models.UserGrades>> Html { get; private set; }
    }
}
#pragma warning restore 1591
