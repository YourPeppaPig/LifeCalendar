#pragma checksum "C:\Users\AavMa\source\repos\LCNew — копия\LCNew\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd5d655964bd52fab550baf83c1bda9f5ef5bd81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\AavMa\source\repos\LCNew — копия\LCNew\Views\_ViewImports.cshtml"
using LCNew;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\AavMa\source\repos\LCNew — копия\LCNew\Views\_ViewImports.cshtml"
using LCNew.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd5d655964bd52fab550baf83c1bda9f5ef5bd81", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2905021d009b96254d1a2c4eef247a42b92515bd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("eventForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div id=""calendar-wrapper"">
    <div id='calendar'></div>
</div>

<div class=""modal fade"" id=""eventModal"" role=""dialog"" aria-labelledby=""eventModalLabel"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h4 class=""modal-title"" id=""eventModalLabel"">Event</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close""><span aria-hidden=""true"">&times;</span></button>
            </div>
            <div class=""modal-body"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dd5d655964bd52fab550baf83c1bda9f5ef5bd814134", async() => {
                WriteLiteral("\r\n                    <div class=\"form-group row\">\r\n                        <label");
                BeginWriteAttribute("for", " for=\"", 677, "\"", 683, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""col-sm-3 col-form-label"">Title</label>
                        <div class=""col-sm-9"">
                            <input type=""text"" class=""form-control"" id=""EventTitle"">
                        </div>
                    </div>
                    <div class=""form-group row"">
                        <label");
                BeginWriteAttribute("for", " for=\"", 1006, "\"", 1012, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""col-sm-3 col-form-label"">Start Time</label>
                        <div class=""col-sm-9"">
                            <input type=""text"" class=""form-control"" id=""StartTime"">
                        </div>
                    </div>
                    <div class=""form-group row"">
                        <label");
                BeginWriteAttribute("for", " for=\"", 1339, "\"", 1345, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""col-sm-3 col-form-label"">End Time</label>
                        <div class=""col-sm-9"">
                            <input type=""text"" class=""form-control"" id=""EndTime"">
                        </div>
                    </div>
                    <div class=""form-group row"">
                        <label");
                BeginWriteAttribute("for", " for=\"", 1668, "\"", 1674, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""col-sm-3 col-form-label"">Description</label>
                        <div class=""col-sm-9"">
                            <textarea class=""form-control"" id=""Description"" rows=""5""></textarea>
                        </div>
                    </div>
                    <div class=""form-group row"">
                        <div class=""col-sm-3 offset-sm-9"">
                            <label><input type=""checkbox"" id=""AllDay"" /> All Day</label>
                        </div>
                    </div>
                    <input type=""hidden"" id=""isNewEvent"" />
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">  
                <button type=""button"" class=""btn btn-danger"" id=""deleteEvent"">Delete</button>
                <div>
                    <button type=""button"" class=""btn btn-default"" data-dismiss=""modal"">Close</button>
                    <button type=""button"" class=""btn btn-primary"" id=""eventModalSave"">Save Changes</button>
                </div>
            </div>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
