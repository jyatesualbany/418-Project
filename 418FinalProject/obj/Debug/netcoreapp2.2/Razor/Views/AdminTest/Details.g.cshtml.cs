<<<<<<< HEAD
#pragma checksum "/Users/akeemshane/Documents/Documents - Akeem’s MacBook Pro/VisualStudio/418-Project/418FinalProject/Views/AdminTest/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81aca608a760cbe726fb6c65c761caf58e2d67f6"
=======
#pragma checksum "/Users/julienunez/Downloads/Archive/418FinalProject/Views/AdminTest/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81aca608a760cbe726fb6c65c761caf58e2d67f6"
>>>>>>> Julie
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminTest_Details), @"mvc.1.0.view", @"/Views/AdminTest/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdminTest/Details.cshtml", typeof(AspNetCore.Views_AdminTest_Details))]
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
<<<<<<< HEAD
#line 1 "/Users/akeemshane/Documents/Documents - Akeem’s MacBook Pro/VisualStudio/418-Project/418FinalProject/Views/_ViewImports.cshtml"
=======
#line 1 "/Users/julienunez/Downloads/Archive/418FinalProject/Views/_ViewImports.cshtml"
>>>>>>> Julie
using _418FinalProject;

#line default
#line hidden
<<<<<<< HEAD
#line 5 "/Users/akeemshane/Documents/Documents - Akeem’s MacBook Pro/VisualStudio/418-Project/418FinalProject/Views/AdminTest/Details.cshtml"
=======
#line 5 "/Users/julienunez/Downloads/Archive/418FinalProject/Views/AdminTest/Details.cshtml"
>>>>>>> Julie
using _418FinalProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81aca608a760cbe726fb6c65c761caf58e2d67f6", @"/Views/AdminTest/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"721d5ce7967c8a32a9a4be2e1dc36f2f03d72a1a", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminTest_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Test>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditQuestion", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteQuestion", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
<<<<<<< HEAD
#line 1 "/Users/akeemshane/Documents/Documents - Akeem’s MacBook Pro/VisualStudio/418-Project/418FinalProject/Views/AdminTest/Details.cshtml"
=======
#line 1 "/Users/julienunez/Downloads/Archive/418FinalProject/Views/AdminTest/Details.cshtml"
>>>>>>> Julie
  
    ViewData["Title"] = "Test Details";
    string q_id = ViewData["Debugging"] as String;

#line default
#line hidden
            BeginContext(147, 126, true);
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Test </h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(274, 42, false);
<<<<<<< HEAD
#line 15 "/Users/akeemshane/Documents/Documents - Akeem’s MacBook Pro/VisualStudio/418-Project/418FinalProject/Views/AdminTest/Details.cshtml"
=======
#line 15 "/Users/julienunez/Downloads/Archive/418FinalProject/Views/AdminTest/Details.cshtml"
>>>>>>> Julie
       Write(Html.DisplayNameFor(model => model.TestID));

#line default
#line hidden
            EndContext();
            BeginContext(316, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(378, 38, false);
<<<<<<< HEAD
#line 18 "/Users/akeemshane/Documents/Documents - Akeem’s MacBook Pro/VisualStudio/418-Project/418FinalProject/Views/AdminTest/Details.cshtml"
=======
#line 18 "/Users/julienunez/Downloads/Archive/418FinalProject/Views/AdminTest/Details.cshtml"
>>>>>>> Julie
       Write(Html.DisplayFor(model => model.TestID));

#line default
#line hidden
            EndContext();
            BeginContext(416, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(477, 45, false);
<<<<<<< HEAD
#line 21 "/Users/akeemshane/Documents/Documents - Akeem’s MacBook Pro/VisualStudio/418-Project/418FinalProject/Views/AdminTest/Details.cshtml"
=======
#line 21 "/Users/julienunez/Downloads/Archive/418FinalProject/Views/AdminTest/Details.cshtml"
>>>>>>> Julie
       Write(Html.DisplayNameFor(model => model.TestTitle));

#line default
#line hidden
            EndContext();
            BeginContext(522, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(584, 41, false);
<<<<<<< HEAD
#line 24 "/Users/akeemshane/Documents/Documents - Akeem’s MacBook Pro/VisualStudio/418-Project/418FinalProject/Views/AdminTest/Details.cshtml"
=======
#line 24 "/Users/julienunez/Downloads/Archive/418FinalProject/Views/AdminTest/Details.cshtml"
>>>>>>> Julie
       Write(Html.DisplayFor(model => model.TestTitle));

#line default
#line hidden
            EndContext();
            BeginContext(625, 120, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(746, 68, false);
<<<<<<< HEAD
#line 32 "/Users/akeemshane/Documents/Documents - Akeem’s MacBook Pro/VisualStudio/418-Project/418FinalProject/Views/AdminTest/Details.cshtml"
=======
#line 32 "/Users/julienunez/Downloads/Archive/418FinalProject/Views/AdminTest/Details.cshtml"
>>>>>>> Julie
           Write(Html.DisplayNameFor(q => Model.SelectQuestions.First().QuestionText));

#line default
#line hidden
            EndContext();
            BeginContext(814, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(870, 64, false);
<<<<<<< HEAD
#line 35 "/Users/akeemshane/Documents/Documents - Akeem’s MacBook Pro/VisualStudio/418-Project/418FinalProject/Views/AdminTest/Details.cshtml"
=======
#line 35 "/Users/julienunez/Downloads/Archive/418FinalProject/Views/AdminTest/Details.cshtml"
>>>>>>> Julie
           Write(Html.DisplayNameFor(q => Model.SelectQuestions.First().Category));

#line default
#line hidden
            EndContext();
            BeginContext(934, 63, true);
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
<<<<<<< HEAD
#line 40 "/Users/akeemshane/Documents/Documents - Akeem’s MacBook Pro/VisualStudio/418-Project/418FinalProject/Views/AdminTest/Details.cshtml"
=======
#line 40 "/Users/julienunez/Downloads/Archive/418FinalProject/Views/AdminTest/Details.cshtml"
>>>>>>> Julie
         foreach (var item in Model.SelectQuestions)
        {

#line default
#line hidden
            BeginContext(1062, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1123, 39, false);
<<<<<<< HEAD
#line 44 "/Users/akeemshane/Documents/Documents - Akeem’s MacBook Pro/VisualStudio/418-Project/418FinalProject/Views/AdminTest/Details.cshtml"
=======
#line 44 "/Users/julienunez/Downloads/Archive/418FinalProject/Views/AdminTest/Details.cshtml"
>>>>>>> Julie
               Write(Html.DisplayFor(q => item.QuestionText));

#line default
#line hidden
            EndContext();
            BeginContext(1162, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1230, 35, false);
<<<<<<< HEAD
#line 47 "/Users/akeemshane/Documents/Documents - Akeem’s MacBook Pro/VisualStudio/418-Project/418FinalProject/Views/AdminTest/Details.cshtml"
=======
#line 47 "/Users/julienunez/Downloads/Archive/418FinalProject/Views/AdminTest/Details.cshtml"
>>>>>>> Julie
               Write(Html.DisplayFor(q => item.Category));

#line default
#line hidden
            EndContext();
            BeginContext(1265, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
<<<<<<< HEAD
#line 50 "/Users/akeemshane/Documents/Documents - Akeem’s MacBook Pro/VisualStudio/418-Project/418FinalProject/Views/AdminTest/Details.cshtml"
=======
#line 50 "/Users/julienunez/Downloads/Archive/418FinalProject/Views/AdminTest/Details.cshtml"
>>>>>>> Julie
        }

#line default
#line hidden
            BeginContext(1320, 27, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n<p>");
            EndContext();
            BeginContext(1348, 4, false);
<<<<<<< HEAD
#line 53 "/Users/akeemshane/Documents/Documents - Akeem’s MacBook Pro/VisualStudio/418-Project/418FinalProject/Views/AdminTest/Details.cshtml"
=======
#line 53 "/Users/julienunez/Downloads/Archive/418FinalProject/Views/AdminTest/Details.cshtml"
>>>>>>> Julie
Write(q_id);

#line default
#line hidden
            EndContext();
            BeginContext(1352, 17, true);
            WriteLiteral("</p>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1369, 66, false);
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81aca608a760cbe726fb6c65c761caf58e2d67f69540", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81aca608a760cbe726fb6c65c761caf58e2d67f68805", async() => {
>>>>>>> Julie
                BeginContext(1427, 4, true);
                WriteLiteral("Edit");
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
<<<<<<< HEAD
#line 55 "/Users/akeemshane/Documents/Documents - Akeem’s MacBook Pro/VisualStudio/418-Project/418FinalProject/Views/AdminTest/Details.cshtml"
=======
#line 55 "/Users/julienunez/Downloads/Archive/418FinalProject/Views/AdminTest/Details.cshtml"
>>>>>>> Julie
                                   WriteLiteral(Model.TestID);

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
            BeginContext(1435, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1443, 70, false);
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81aca608a760cbe726fb6c65c761caf58e2d67f611890", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81aca608a760cbe726fb6c65c761caf58e2d67f611106", async() => {
>>>>>>> Julie
                BeginContext(1503, 6, true);
                WriteLiteral("Delete");
                EndContext();
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
<<<<<<< HEAD
#line 56 "/Users/akeemshane/Documents/Documents - Akeem’s MacBook Pro/VisualStudio/418-Project/418FinalProject/Views/AdminTest/Details.cshtml"
=======
#line 56 "/Users/julienunez/Downloads/Archive/418FinalProject/Views/AdminTest/Details.cshtml"
>>>>>>> Julie
                                     WriteLiteral(Model.TestID);

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
            BeginContext(1513, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1521, 38, false);
<<<<<<< HEAD
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81aca608a760cbe726fb6c65c761caf58e2d67f614245", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81aca608a760cbe726fb6c65c761caf58e2d67f613412", async() => {
>>>>>>> Julie
                BeginContext(1543, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1559, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Test> Html { get; private set; }
    }
}
#pragma warning restore 1591