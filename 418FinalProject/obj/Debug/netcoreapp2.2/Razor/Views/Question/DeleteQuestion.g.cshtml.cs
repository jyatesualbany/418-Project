#pragma checksum "C:\Users\wdick\Desktop\418-Project\418FinalProject\Views\Question\DeleteQuestion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "948789c6655de468c2272907a045382ab954f38a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Question_DeleteQuestion), @"mvc.1.0.view", @"/Views/Question/DeleteQuestion.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Question/DeleteQuestion.cshtml", typeof(AspNetCore.Views_Question_DeleteQuestion))]
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
#line 1 "C:\Users\wdick\Desktop\418-Project\418FinalProject\Views\_ViewImports.cshtml"
using _418FinalProject;

#line default
#line hidden
#line 9 "C:\Users\wdick\Desktop\418-Project\418FinalProject\Views\Question\DeleteQuestion.cshtml"
using _418FinalProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"948789c6655de468c2272907a045382ab954f38a", @"/Views/Question/DeleteQuestion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"721d5ce7967c8a32a9a4be2e1dc36f2f03d72a1a", @"/Views/_ViewImports.cshtml")]
    public class Views_Question_DeleteQuestion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Question>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditQuestion", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(121, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(130, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(160, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(213, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 12 "C:\Users\wdick\Desktop\418-Project\418FinalProject\Views\Question\DeleteQuestion.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(257, 201, true);
            WriteLiteral("\r\n<h1>Are you sure you would like to delete the following question and all its data?</h1>\r\n\r\n<div>\r\n    <h4>Questions</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(459, 46, false);
#line 23 "C:\Users\wdick\Desktop\418-Project\418FinalProject\Views\Question\DeleteQuestion.cshtml"
       Write(Html.DisplayNameFor(model => model.QuestionID));

#line default
#line hidden
            EndContext();
            BeginContext(505, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(567, 42, false);
#line 26 "C:\Users\wdick\Desktop\418-Project\418FinalProject\Views\Question\DeleteQuestion.cshtml"
       Write(Html.DisplayFor(model => model.QuestionID));

#line default
#line hidden
            EndContext();
            BeginContext(609, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(670, 48, false);
#line 29 "C:\Users\wdick\Desktop\418-Project\418FinalProject\Views\Question\DeleteQuestion.cshtml"
       Write(Html.DisplayNameFor(model => model.QuestionText));

#line default
#line hidden
            EndContext();
            BeginContext(718, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(780, 44, false);
#line 32 "C:\Users\wdick\Desktop\418-Project\418FinalProject\Views\Question\DeleteQuestion.cshtml"
       Write(Html.DisplayFor(model => model.QuestionText));

#line default
#line hidden
            EndContext();
            BeginContext(824, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(885, 47, false);
#line 35 "C:\Users\wdick\Desktop\418-Project\418FinalProject\Views\Question\DeleteQuestion.cshtml"
       Write(Html.DisplayNameFor(model => model.Answer1Text));

#line default
#line hidden
            EndContext();
            BeginContext(932, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(994, 43, false);
#line 38 "C:\Users\wdick\Desktop\418-Project\418FinalProject\Views\Question\DeleteQuestion.cshtml"
       Write(Html.DisplayFor(model => model.Answer1Text));

#line default
#line hidden
            EndContext();
            BeginContext(1037, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1098, 47, false);
#line 41 "C:\Users\wdick\Desktop\418-Project\418FinalProject\Views\Question\DeleteQuestion.cshtml"
       Write(Html.DisplayNameFor(model => model.Answer2Text));

#line default
#line hidden
            EndContext();
            BeginContext(1145, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1207, 43, false);
#line 44 "C:\Users\wdick\Desktop\418-Project\418FinalProject\Views\Question\DeleteQuestion.cshtml"
       Write(Html.DisplayFor(model => model.Answer2Text));

#line default
#line hidden
            EndContext();
            BeginContext(1250, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1311, 47, false);
#line 47 "C:\Users\wdick\Desktop\418-Project\418FinalProject\Views\Question\DeleteQuestion.cshtml"
       Write(Html.DisplayNameFor(model => model.Answer3Text));

#line default
#line hidden
            EndContext();
            BeginContext(1358, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1420, 43, false);
#line 50 "C:\Users\wdick\Desktop\418-Project\418FinalProject\Views\Question\DeleteQuestion.cshtml"
       Write(Html.DisplayFor(model => model.Answer3Text));

#line default
#line hidden
            EndContext();
            BeginContext(1463, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1524, 47, false);
#line 53 "C:\Users\wdick\Desktop\418-Project\418FinalProject\Views\Question\DeleteQuestion.cshtml"
       Write(Html.DisplayNameFor(model => model.Answer4Text));

#line default
#line hidden
            EndContext();
            BeginContext(1571, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1633, 43, false);
#line 56 "C:\Users\wdick\Desktop\418-Project\418FinalProject\Views\Question\DeleteQuestion.cshtml"
       Write(Html.DisplayFor(model => model.Answer4Text));

#line default
#line hidden
            EndContext();
            BeginContext(1676, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1737, 44, false);
#line 59 "C:\Users\wdick\Desktop\418-Project\418FinalProject\Views\Question\DeleteQuestion.cshtml"
       Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
            EndContext();
            BeginContext(1781, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1843, 40, false);
#line 62 "C:\Users\wdick\Desktop\418-Project\418FinalProject\Views\Question\DeleteQuestion.cshtml"
       Write(Html.DisplayFor(model => model.Category));

#line default
#line hidden
            EndContext();
            BeginContext(1883, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1944, 41, false);
#line 65 "C:\Users\wdick\Desktop\418-Project\418FinalProject\Views\Question\DeleteQuestion.cshtml"
       Write(Html.DisplayNameFor(model => model.Image));

#line default
#line hidden
            EndContext();
            BeginContext(1985, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2047, 37, false);
#line 68 "C:\Users\wdick\Desktop\418-Project\418FinalProject\Views\Question\DeleteQuestion.cshtml"
       Write(Html.DisplayFor(model => model.Image));

#line default
#line hidden
            EndContext();
            BeginContext(2084, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2131, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "948789c6655de468c2272907a045382ab954f38a11579", async() => {
                BeginContext(2193, 4, true);
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
#line 73 "C:\Users\wdick\Desktop\418-Project\418FinalProject\Views\Question\DeleteQuestion.cshtml"
                                   WriteLiteral(Model.QuestionID);

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
            BeginContext(2201, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(2209, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "948789c6655de468c2272907a045382ab954f38a13925", async() => {
                BeginContext(2231, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2247, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Question> Html { get; private set; }
    }
}
#pragma warning restore 1591
