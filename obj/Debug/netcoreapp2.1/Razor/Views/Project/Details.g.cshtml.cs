#pragma checksum "C:\Users\mara\Documents\CIDM3312\FinalProject\Views\Project\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57e5f1ba4ef766b4f0c91d1830158ea9b7faadb7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_Details), @"mvc.1.0.view", @"/Views/Project/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Project/Details.cshtml", typeof(AspNetCore.Views_Project_Details))]
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
#line 1 "C:\Users\mara\Documents\CIDM3312\FinalProject\Views\_ViewImports.cshtml"
using CIDM3312Project;

#line default
#line hidden
#line 2 "C:\Users\mara\Documents\CIDM3312\FinalProject\Views\_ViewImports.cshtml"
using CIDM3312Project.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57e5f1ba4ef766b4f0c91d1830158ea9b7faadb7", @"/Views/Project/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c109b9f610862e78bb16576aca582a489d9ee643", @"/Views/_ViewImports.cshtml")]
    public class Views_Project_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CIDM3312Project.Models.Project>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(39, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\mara\Documents\CIDM3312\FinalProject\Views\Project\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(84, 145, true);
            WriteLiteral("\r\n<h2 class=\"text-white\">Project Details</h2>\r\n\r\n<div>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt class=\"text-white\">\r\n            ");
            EndContext();
            BeginContext(230, 47, false);
#line 13 "C:\Users\mara\Documents\CIDM3312\FinalProject\Views\Project\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ProjectName));

#line default
#line hidden
            EndContext();
            BeginContext(277, 62, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"text-white\">\r\n            ");
            EndContext();
            BeginContext(340, 43, false);
#line 16 "C:\Users\mara\Documents\CIDM3312\FinalProject\Views\Project\Details.cshtml"
       Write(Html.DisplayFor(model => model.ProjectName));

#line default
#line hidden
            EndContext();
            BeginContext(383, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"text-white\">\r\n            ");
            EndContext();
            BeginContext(446, 50, false);
#line 19 "C:\Users\mara\Documents\CIDM3312\FinalProject\Views\Project\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.EstimatedHours));

#line default
#line hidden
            EndContext();
            BeginContext(496, 62, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"text-white\">\r\n            ");
            EndContext();
            BeginContext(559, 46, false);
#line 22 "C:\Users\mara\Documents\CIDM3312\FinalProject\Views\Project\Details.cshtml"
       Write(Html.DisplayFor(model => model.EstimatedHours));

#line default
#line hidden
            EndContext();
            BeginContext(605, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"text-white\">\r\n            ");
            EndContext();
            BeginContext(668, 44, false);
#line 25 "C:\Users\mara\Documents\CIDM3312\FinalProject\Views\Project\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Deadline));

#line default
#line hidden
            EndContext();
            BeginContext(712, 62, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"text-white\">\r\n            ");
            EndContext();
            BeginContext(775, 40, false);
#line 28 "C:\Users\mara\Documents\CIDM3312\FinalProject\Views\Project\Details.cshtml"
       Write(Html.DisplayFor(model => model.Deadline));

#line default
#line hidden
            EndContext();
            BeginContext(815, 66, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div class=\"text-white\">\r\n    ");
            EndContext();
            BeginContext(881, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3a6d599d2fa4b399f30180534e02fa7", async() => {
                BeginContext(955, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 33 "C:\Users\mara\Documents\CIDM3312\FinalProject\Views\Project\Details.cshtml"
                                                WriteLiteral(Model.ProjectID);

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
            BeginContext(963, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(971, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b3dd315abab0435791378ed6516108ac", async() => {
                BeginContext(1014, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
            BeginContext(1030, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CIDM3312Project.Models.Project> Html { get; private set; }
    }
}
#pragma warning restore 1591
