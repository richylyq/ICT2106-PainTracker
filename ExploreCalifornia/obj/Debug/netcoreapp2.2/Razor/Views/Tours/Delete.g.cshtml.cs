#pragma checksum "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Tours\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54155fce682fc0e6b063426c2a942fd2eae0ecad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tours_Delete), @"mvc.1.0.view", @"/Views/Tours/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tours/Delete.cshtml", typeof(AspNetCore.Views_Tours_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54155fce682fc0e6b063426c2a942fd2eae0ecad", @"/Views/Tours/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"413b5b8409aa6b8397b24276d425b7b7a248eca9", @"/Views/_ViewImports.cshtml")]
    public class Views_Tours_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExploreCalifornia.Models.Tour>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-default"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Tours\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(82, 10195, true);
            WriteLiteral(@"
<!-- BEGIN: Subheader -->
<div class=""m-subheader "">
    <div class=""d-flex align-items-center"">
        <div class=""mr-auto"">
            <h3 class=""m-subheader__title m-subheader__title--separator"">Delete</h3>
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
                        <span class=""m-nav__link-text"">Advanced Por");
            WriteLiteral(@"tlets</span>
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
                                    <li cla");
            WriteLiteral(@"ss=""m-nav__section m-nav__section--first m--hide"">
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
            WriteLiteral(@"                      <li class=""m-nav__item"">
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
            WriteLiteral(@"          <a href=""#"" class=""btn btn-outline-danger m-btn m-btn--pill m-btn--wide btn-sm"">Submit</a>
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
            <div class=""m-portlet m-portlet--danger m-portlet--head-solid-bg"">
                <div class=""m-portlet__head"">
                    <div class=""m-portlet__head-caption"">
                        <div class=""m-portlet__head-title"">
                            <span class=""m-portlet__head-icon"">
                                <i class=""flaticon-placeholder-2""></i>
                            </span>
                            <h3 class=""m-portlet__head-text"">
                                Are you");
            WriteLiteral(@" sure you want to delete this?
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
                            <li class=""m-portlet__nav-item m-dropdown m-dropdown--inline m-dropdown");
            WriteLiteral(@"--arrow m-dropdown--align-right m-dropdown--align-push"" m-dropdown-toggle=""hover"">
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
            WriteLiteral(@"                                     </li>
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
            WriteLiteral(@"                        </li>
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
                                              ");
            WriteLiteral(@"      </li>
                                                    <li class=""m-nav__separator m-nav__separator--fit"">
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
            BeginContext(10278, 40, false);
#line 167 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Tours\Delete.cshtml"
                       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(10318, 109, true);
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
            EndContext();
            BeginContext(10428, 36, false);
#line 170 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Tours\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(10464, 108, true);
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            ");
            EndContext();
            BeginContext(10573, 47, false);
#line 173 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Tours\Delete.cshtml"
                       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(10620, 109, true);
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
            EndContext();
            BeginContext(10730, 43, false);
#line 176 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Tours\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(10773, 108, true);
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            ");
            EndContext();
            BeginContext(10882, 42, false);
#line 179 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Tours\Delete.cshtml"
                       Write(Html.DisplayNameFor(model => model.Length));

#line default
#line hidden
            EndContext();
            BeginContext(10924, 109, true);
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
            EndContext();
            BeginContext(11034, 38, false);
#line 182 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Tours\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.Length));

#line default
#line hidden
            EndContext();
            BeginContext(11072, 108, true);
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            ");
            EndContext();
            BeginContext(11181, 41, false);
#line 185 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Tours\Delete.cshtml"
                       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(11222, 109, true);
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
            EndContext();
            BeginContext(11332, 37, false);
#line 188 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Tours\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(11369, 108, true);
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            ");
            EndContext();
            BeginContext(11478, 42, false);
#line 191 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Tours\Delete.cshtml"
                       Write(Html.DisplayNameFor(model => model.Rating));

#line default
#line hidden
            EndContext();
            BeginContext(11520, 109, true);
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
            EndContext();
            BeginContext(11630, 38, false);
#line 194 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Tours\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.Rating));

#line default
#line hidden
            EndContext();
            BeginContext(11668, 108, true);
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            ");
            EndContext();
            BeginContext(11777, 49, false);
#line 197 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Tours\Delete.cshtml"
                       Write(Html.DisplayNameFor(model => model.IncludesMeals));

#line default
#line hidden
            EndContext();
            BeginContext(11826, 109, true);
            WriteLiteral("\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
            EndContext();
            BeginContext(11936, 45, false);
#line 200 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Tours\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.IncludesMeals));

#line default
#line hidden
            EndContext();
            BeginContext(11981, 151, true);
            WriteLiteral("\r\n                        </dd>\r\n                    </dl>\r\n                </div>\r\n                <div class=\"m-portlet__foot\">\r\n                    ");
            EndContext();
            BeginContext(12132, 332, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54155fce682fc0e6b063426c2a942fd2eae0ecad22473", async() => {
                BeginContext(12158, 26, true);
                WriteLiteral("\r\n                        ");
                EndContext();
                BeginContext(12184, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "54155fce682fc0e6b063426c2a942fd2eae0ecad22884", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 206 "C:\Users\yuqua\Desktop\SIT\Y2\Trimester2\ICT2106\PROJECTS\ICT2106-PainTracker\ExploreCalifornia\Views\Tours\Delete.cshtml"
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
                BeginContext(12220, 146, true);
                WriteLiteral("\r\n                        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" />\r\n                        <span class=\"m--margin-left-10\"> ");
                EndContext();
                BeginContext(12366, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54155fce682fc0e6b063426c2a942fd2eae0ecad24901", async() => {
                    BeginContext(12412, 12, true);
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
                BeginContext(12428, 29, true);
                WriteLiteral("</span>\r\n                    ");
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
            BeginContext(12464, 115, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <!--end::Portlet-->\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
