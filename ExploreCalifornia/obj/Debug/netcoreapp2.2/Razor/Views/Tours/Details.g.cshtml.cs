#pragma checksum "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Tours\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5be50af8c5f66091ce661ab68d7f724f5f92c37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tours_Details), @"mvc.1.0.view", @"/Views/Tours/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tours/Details.cshtml", typeof(AspNetCore.Views_Tours_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5be50af8c5f66091ce661ab68d7f724f5f92c37", @"/Views/Tours/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"413b5b8409aa6b8397b24276d425b7b7a248eca9", @"/Views/_ViewImports.cshtml")]
    public class Views_Tours_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExploreCalifornia.Models.Tour>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Tours\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(83, 5112, true);
            WriteLiteral(@"
<!-- BEGIN: Subheader -->
<div class=""m-subheader "">
    <div class=""d-flex align-items-center"">
        <div class=""mr-auto"">
            <h3 class=""m-subheader__title m-subheader__title--separator"">Details</h3>
            <ul class=""m-subheader__breadcrumbs m-nav m-nav--inline"">
                <li class=""m-nav__item m-nav__item--home"">
                    <a href=""#"" class=""m-nav__link m-nav__link--icon"">
                        <i class=""m-nav__link-icon la la-home""></i>
                    </a>
                </li>
                <li class=""m-nav__separator"">-</li>
                <li class=""m-nav__item"">
                    <a href="""" class=""m-nav__link"">
                        <span class=""m-nav__link-text"">Portlets</span>
                    </a>
                </li>
                <li class=""m-nav__separator"">-</li>
                <li class=""m-nav__item"">
                    <a href="""" class=""m-nav__link"">
                        <span class=""m-nav__link-text"">Advanced Po");
            WriteLiteral(@"rtlets</span>
                    </a>
                </li>
            </ul>
        </div>
        <div>
            <div class=""m-dropdown m-dropdown--inline m-dropdown--arrow m-dropdown--align-right m-dropdown--align-push"" m-dropdown-toggle=""hover"" aria-expanded=""true"">
                <a href=""#"" class=""m-portlet__nav-link btn btn-lg btn-secondary  m-btn m-btn--outline-2x m-btn--air m-btn--icon m-btn--icon-only m-btn--pill  m-dropdown__toggle"">
                    <i class=""la la-plus m--hide""></i>
                    <i class=""la la-ellipsis-h""></i>
                </a>
                <div class=""m-dropdown__wrapper"">
                    <span class=""m-dropdown__arrow m-dropdown__arrow--right m-dropdown__arrow--adjust""></span>
                    <div class=""m-dropdown__inner"">
                        <div class=""m-dropdown__body"">
                            <div class=""m-dropdown__content"">
                                <ul class=""m-nav"">
                                    <li cl");
            WriteLiteral(@"ass=""m-nav__section m-nav__section--first m--hide"">
                                        <span class=""m-nav__section-text"">Quick Actions</span>
                                    </li>
                                    <li class=""m-nav__item"">
                                        <a href="""" class=""m-nav__link"">
                                            <i class=""m-nav__link-icon flaticon-share""></i>
                                            <span class=""m-nav__link-text"">Activity</span>
                                        </a>
                                    </li>
                                    <li class=""m-nav__item"">
                                        <a href="""" class=""m-nav__link"">
                                            <i class=""m-nav__link-icon flaticon-chat-1""></i>
                                            <span class=""m-nav__link-text"">Messages</span>
                                        </a>
                                    </li>
             ");
            WriteLiteral(@"                       <li class=""m-nav__item"">
                                        <a href="""" class=""m-nav__link"">
                                            <i class=""m-nav__link-icon flaticon-info""></i>
                                            <span class=""m-nav__link-text"">FAQ</span>
                                        </a>
                                    </li>
                                    <li class=""m-nav__item"">
                                        <a href="""" class=""m-nav__link"">
                                            <i class=""m-nav__link-icon flaticon-lifebuoy""></i>
                                            <span class=""m-nav__link-text"">Support</span>
                                        </a>
                                    </li>
                                    <li class=""m-nav__separator m-nav__separator--fit"">
                                    </li>
                                    <li class=""m-nav__item"">
                             ");
            WriteLiteral(@"           <a href=""#"" class=""btn btn-outline-danger m-btn m-btn--pill m-btn--wide btn-sm"">Submit</a>
                                    </li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- END: Subheader -->
<div class=""m-content"">
    <div class=""row"">
        <div class=""col-lg-12"">
            <!--begin::Portlet-->
            <div class=""m-portlet m-portlet--info m-portlet--head-solid-bg"">
                <div class=""m-portlet__head"">
                    <div class=""m-portlet__head-caption"">
                        <div class=""m-portlet__head-title"">
                            <span class=""m-portlet__head-icon"">
                                <i class=""flaticon-placeholder-2""></i>
                            </span>
                            <h3 class=""m-portlet__head-text"">
                                ");
            EndContext();
            BeginContext(5196, 36, false);
#line 98 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Tours\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(5232, 5053, true);
            WriteLiteral(@" Details
                            </h3>
                        </div>
                    </div>
                    <div class=""m-portlet__head-tools"">
                        <ul class=""m-portlet__nav"">
                            <li class=""m-portlet__nav-item"">
                                <a href="""" class=""m-portlet__nav-link m-portlet__nav-link--icon""><i class=""la la-close""></i></a>
                            </li>
                            <li class=""m-portlet__nav-item"">
                                <a href="""" class=""m-portlet__nav-link m-portlet__nav-link--icon""><i class=""la la-refresh""></i></a>
                            </li>
                            <li class=""m-portlet__nav-item"">
                                <a href="""" class=""m-portlet__nav-link m-portlet__nav-link--icon""><i class=""la la-angle-down""></i></a>
                            </li>
                            <li class=""m-portlet__nav-item m-dropdown m-dropdown--inline m-dropdown--arrow m-dropdown--al");
            WriteLiteral(@"ign-right m-dropdown--align-push"" m-dropdown-toggle=""hover"">
                                <a href=""#"" class=""m-portlet__nav-link m-portlet__nav-link--icon m-dropdown__toggle"">
                                    <i class=""la la-ellipsis-v""></i>
                                </a>
                                <div class=""m-dropdown__wrapper"">
                                    <span class=""m-dropdown__arrow m-dropdown__arrow--right m-dropdown__arrow--adjust""></span>
                                    <div class=""m-dropdown__inner"">
                                        <div class=""m-dropdown__body"">
                                            <div class=""m-dropdown__content"">
                                                <ul class=""m-nav"">
                                                    <li class=""m-nav__section m-nav__section--first"">
                                                        <span class=""m-nav__section-text"">Quick Actions</span>
                                     ");
            WriteLiteral(@"               </li>
                                                    <li class=""m-nav__item"">
                                                        <a href="""" class=""m-nav__link"">
                                                            <i class=""m-nav__link-icon flaticon-share""></i>
                                                            <span class=""m-nav__link-text"">Activity</span>
                                                        </a>
                                                    </li>
                                                    <li class=""m-nav__item"">
                                                        <a href="""" class=""m-nav__link"">
                                                            <i class=""m-nav__link-icon flaticon-chat-1""></i>
                                                            <span class=""m-nav__link-text"">Messages</span>
                                                        </a>
                                                  ");
            WriteLiteral(@"  </li>
                                                    <li class=""m-nav__item"">
                                                        <a href="""" class=""m-nav__link"">
                                                            <i class=""m-nav__link-icon flaticon-info""></i>
                                                            <span class=""m-nav__link-text"">FAQ</span>
                                                        </a>
                                                    </li>
                                                    <li class=""m-nav__item"">
                                                        <a href="""" class=""m-nav__link"">
                                                            <i class=""m-nav__link-icon flaticon-lifebuoy""></i>
                                                            <span class=""m-nav__link-text"">Support</span>
                                                        </a>
                                                    </li>
         ");
            WriteLiteral(@"                                           <li class=""m-nav__separator m-nav__separator--fit"">
                                                    </li>
                                                    <li class=""m-nav__item"">
                                                        <a href=""#"" class=""btn btn-outline-danger m-btn m-btn--pill m-btn--wide btn-sm"">Cancel</a>
                                                    </li>
                                                </ul>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </li>
                        </ul>
                    </div>
                </div>
                <div class=""m-portlet__body"">
                    <dl class=""row"">
                        <dt class=""col-sm-2"">
                            ");
            EndContext();
            BeginContext(10286, 40, false);
#line 167 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Tours\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(10326, 109, true);
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
            EndContext();
            BeginContext(10436, 36, false);
#line 170 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Tours\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(10472, 108, true);
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            ");
            EndContext();
            BeginContext(10581, 47, false);
#line 173 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Tours\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(10628, 109, true);
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
            EndContext();
            BeginContext(10738, 43, false);
#line 176 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Tours\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(10781, 108, true);
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            ");
            EndContext();
            BeginContext(10890, 42, false);
#line 179 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Tours\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.Length));

#line default
#line hidden
            EndContext();
            BeginContext(10932, 109, true);
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
            EndContext();
            BeginContext(11042, 38, false);
#line 182 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Tours\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Length));

#line default
#line hidden
            EndContext();
            BeginContext(11080, 108, true);
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            ");
            EndContext();
            BeginContext(11189, 41, false);
#line 185 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Tours\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(11230, 109, true);
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
            EndContext();
            BeginContext(11340, 37, false);
#line 188 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Tours\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(11377, 108, true);
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            ");
            EndContext();
            BeginContext(11486, 42, false);
#line 191 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Tours\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.Rating));

#line default
#line hidden
            EndContext();
            BeginContext(11528, 109, true);
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
            EndContext();
            BeginContext(11638, 38, false);
#line 194 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Tours\Details.cshtml"
                       Write(Html.DisplayFor(model => model.Rating));

#line default
#line hidden
            EndContext();
            BeginContext(11676, 108, true);
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            ");
            EndContext();
            BeginContext(11785, 49, false);
#line 197 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Tours\Details.cshtml"
                       Write(Html.DisplayNameFor(model => model.IncludesMeals));

#line default
#line hidden
            EndContext();
            BeginContext(11834, 109, true);
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
            EndContext();
            BeginContext(11944, 45, false);
#line 200 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Tours\Details.cshtml"
                       Write(Html.DisplayFor(model => model.IncludesMeals));

#line default
#line hidden
            EndContext();
            BeginContext(11989, 151, true);
            WriteLiteral("\r\n                        </dd>\r\n                    </dl>\r\n                </div>\r\n                <div class=\"m-portlet__foot\">\r\n                    ");
            EndContext();
            BeginContext(12140, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5be50af8c5f66091ce661ab68d7f724f5f92c3722490", async() => {
                BeginContext(12210, 4, true);
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
#line 205 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Tours\Details.cshtml"
                                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(12218, 55, true);
            WriteLiteral("\r\n                    <span class=\"m--margin-left-10\"> ");
            EndContext();
            BeginContext(12273, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b5be50af8c5f66091ce661ab68d7f724f5f92c3725008", async() => {
                BeginContext(12319, 12, true);
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
            BeginContext(12335, 122, true);
            WriteLiteral("</span>\r\n                </div>\r\n            </div>\r\n            <!--end::Portlet-->\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExploreCalifornia.Models.Tour> Html { get; private set; }
    }
}
#pragma warning restore 1591
