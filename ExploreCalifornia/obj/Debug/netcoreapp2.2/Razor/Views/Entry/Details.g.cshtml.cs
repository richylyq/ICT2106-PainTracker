#pragma checksum "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Entry\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e95e052cb9a42d52f278c3806504d6f8040e3e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Entry_Details), @"mvc.1.0.view", @"/Views/Entry/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Entry/Details.cshtml", typeof(AspNetCore.Views_Entry_Details))]
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
#line 1 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\_ViewImports.cshtml"
using ExploreCalifornia;

#line default
#line hidden
#line 2 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\_ViewImports.cshtml"
using ExploreCalifornia.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e95e052cb9a42d52f278c3806504d6f8040e3e8", @"/Views/Entry/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"413b5b8409aa6b8397b24276d425b7b7a248eca9", @"/Views/_ViewImports.cshtml")]
    public class Views_Entry_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExploreCalifornia.Models.Entry>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Entry\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(84, 334, true);
            WriteLiteral(@"
<style>
    #PDwrapper {
        padding: 25px;
        margin: 70px;
        width: 75%;
        height: auto;
    }
</style>


<div id=""PDwrapper"">
    <h1>Confirm Pain Diary Details</h1>

    <div>
        <h4>Entry</h4>
        <hr />
        <dl class=""row"">
            <dt class=""col-sm-2"">
                ");
            EndContext();
            BeginContext(419, 43, false);
#line 25 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Entry\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.entryID));

#line default
#line hidden
            EndContext();
            BeginContext(462, 73, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(536, 39, false);
#line 28 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Entry\Details.cshtml"
           Write(Html.DisplayFor(model => model.entryID));

#line default
#line hidden
            EndContext();
            BeginContext(575, 72, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(648, 48, false);
#line 31 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Entry\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.creationDate));

#line default
#line hidden
            EndContext();
            BeginContext(696, 73, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(770, 44, false);
#line 34 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Entry\Details.cshtml"
           Write(Html.DisplayFor(model => model.creationDate));

#line default
#line hidden
            EndContext();
            BeginContext(814, 72, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(887, 41, false);
#line 37 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Entry\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.title));

#line default
#line hidden
            EndContext();
            BeginContext(928, 73, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(1002, 37, false);
#line 40 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Entry\Details.cshtml"
           Write(Html.DisplayFor(model => model.title));

#line default
#line hidden
            EndContext();
            BeginContext(1039, 72, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(1112, 47, false);
#line 43 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Entry\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.description));

#line default
#line hidden
            EndContext();
            BeginContext(1159, 73, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(1233, 43, false);
#line 46 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Entry\Details.cshtml"
           Write(Html.DisplayFor(model => model.description));

#line default
#line hidden
            EndContext();
            BeginContext(1276, 72, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(1349, 47, false);
#line 49 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Entry\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.logDateTime));

#line default
#line hidden
            EndContext();
            BeginContext(1396, 73, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(1470, 43, false);
#line 52 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Entry\Details.cshtml"
           Write(Html.DisplayFor(model => model.logDateTime));

#line default
#line hidden
            EndContext();
            BeginContext(1513, 72, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(1586, 44, false);
#line 55 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Entry\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.painArea));

#line default
#line hidden
            EndContext();
            BeginContext(1630, 73, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(1704, 40, false);
#line 58 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Entry\Details.cshtml"
           Write(Html.DisplayFor(model => model.painArea));

#line default
#line hidden
            EndContext();
            BeginContext(1744, 72, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(1817, 44, false);
#line 61 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Entry\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.logNotes));

#line default
#line hidden
            EndContext();
            BeginContext(1861, 73, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(1935, 40, false);
#line 64 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Entry\Details.cshtml"
           Write(Html.DisplayFor(model => model.logNotes));

#line default
#line hidden
            EndContext();
            BeginContext(1975, 72, true);
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
            EndContext();
            BeginContext(2048, 43, false);
#line 67 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Entry\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.logType));

#line default
#line hidden
            EndContext();
            BeginContext(2091, 73, true);
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
            EndContext();
            BeginContext(2165, 39, false);
#line 70 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Entry\Details.cshtml"
           Write(Html.DisplayFor(model => model.logType));

#line default
#line hidden
            EndContext();
            BeginContext(2204, 67, true);
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n    <div>\r\n        ");
            EndContext();
            BeginContext(2272, 68, false);
#line 75 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Entry\Details.cshtml"
   Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(2340, 12, true);
            WriteLiteral(" |\r\n        ");
            EndContext();
            BeginContext(2352, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e95e052cb9a42d52f278c3806504d6f8040e3e812432", async() => {
                BeginContext(2374, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2390, 20, true);
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExploreCalifornia.Models.Entry> Html { get; private set; }
    }
}
#pragma warning restore 1591
