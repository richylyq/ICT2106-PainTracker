#pragma checksum "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Entry\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "61b4e564bb7fee813c178b1f213c4b9d92381d69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Entry_Index), @"mvc.1.0.view", @"/Views/Entry/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Entry/Index.cshtml", typeof(AspNetCore.Views_Entry_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61b4e564bb7fee813c178b1f213c4b9d92381d69", @"/Views/Entry/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"413b5b8409aa6b8397b24276d425b7b7a248eca9", @"/Views/_ViewImports.cshtml")]
    public class Views_Entry_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ExploreCalifornia.Models.Entry>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("flaticon-upload"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Entry\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(95, 437, true);
            WriteLiteral(@"
<style>
    #PDwrapper {
        padding: 25px;
        margin:70px;
        width:75%;
        height:auto;
        
    }

    .flaticon-upload, .flaticon-upload:hover {
        
        text-decoration: none;
        font-size: 50px;
        margin-left: 70%;
    }

    .table {
        
        background-color:aquamarine;
    }

</style>

<div id=""PDwrapper"">
    <h1>Pain Diary</h1>

    <p>
        ");
            EndContext();
            BeginContext(532, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "61b4e564bb7fee813c178b1f213c4b9d92381d694747", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(583, 372, true);
            WriteLiteral(@"
    </p>
    <table class=""table"">
        <thead>
            <tr>
                <th>
                    Title
                </th>
                <th>
                    Creation Date
                </th>
                
                <th>
                    Actions
                </th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 52 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Entry\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
            BeginContext(1012, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1085, 40, false);
#line 56 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Entry\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.title));

#line default
#line hidden
            EndContext();
            BeginContext(1125, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1205, 47, false);
#line 59 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Entry\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.creationDate));

#line default
#line hidden
            EndContext();
            BeginContext(1252, 103, true);
            WriteLiteral("\r\n                    </td>\r\n                    \r\n                    <td>\r\n\r\n                        ");
            EndContext();
            BeginContext(1356, 58, false);
#line 64 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Entry\Index.cshtml"
                   Write(Html.ActionLink("View", "View", new { id = item.entryID }));

#line default
#line hidden
            EndContext();
            BeginContext(1414, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(1443, 58, false);
#line 65 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Entry\Index.cshtml"
                   Write(Html.ActionLink("Edit", "Edit", new { id = item.entryID }));

#line default
#line hidden
            EndContext();
            BeginContext(1501, 28, true);
            WriteLiteral(" |\r\n                        ");
            EndContext();
            BeginContext(1530, 62, false);
#line 66 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Entry\Index.cshtml"
                   Write(Html.ActionLink("Delete", "Delete", new { id = item.entryID }));

#line default
#line hidden
            EndContext();
            BeginContext(1592, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 69 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Entry\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1659, 40, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ExploreCalifornia.Models.Entry>> Html { get; private set; }
    }
}
#pragma warning restore 1591
