#pragma checksum "D:\Workspace\8BD\8BDASPNET\8BD\Views\Shared\DictComponents\EntryAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3f20662670d145b59cf6ce11241a51e5aeaa1a01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_DictComponents_EntryAdd), @"mvc.1.0.view", @"/Views/Shared/DictComponents/EntryAdd.cshtml")]
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
#line 1 "D:\Workspace\8BD\8BDASPNET\8BD\Views\_ViewImports.cshtml"
using _8BD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Workspace\8BD\8BDASPNET\8BD\Views\_ViewImports.cshtml"
using _8BD.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Workspace\8BD\8BDASPNET\8BD\Views\Shared\DictComponents\EntryAdd.cshtml"
using _8BD.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3f20662670d145b59cf6ce11241a51e5aeaa1a01", @"/Views/Shared/DictComponents/EntryAdd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b96a12b27c7900be26918d91671bad4a847a255e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_DictComponents_EntryAdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Entry", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Addentry", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f20662670d145b59cf6ce11241a51e5aeaa1a014648", async() => {
                WriteLiteral("\r\n\r\n\r\n\r\n    <input type=\"text\" name=\"subject\"");
                BeginWriteAttribute("value", " value=\"", 172, "\"", 196, 1);
#nullable restore
#line 8 "D:\Workspace\8BD\8BDASPNET\8BD\Views\Shared\DictComponents\EntryAdd.cshtml"
WriteAttributeValue("", 180, ViewBag.Subject, 180, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("placeholder", " placeholder=\"", 197, "\"", 211, 0);
                EndWriteAttribute();
                WriteLiteral(" style=\"width: 100%;\" hidden>\r\n    <input type=\"text\" name=\"subjectId\"");
                BeginWriteAttribute("value", " value=\"", 282, "\"", 334, 1);
#nullable restore
#line 9 "D:\Workspace\8BD\8BDASPNET\8BD\Views\Shared\DictComponents\EntryAdd.cshtml"
WriteAttributeValue("", 290, _helper.GetSubjectIdByName(ViewBag.Subject), 290, 44, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" hidden />\r\n    <br><br>\r\n\r\n    <label");
                BeginWriteAttribute("for", " for=\"", 373, "\"", 379, 0);
                EndWriteAttribute();
                BeginWriteAttribute("style", " style=\"", 380, "\"", 388, 0);
                EndWriteAttribute();
                WriteLiteral(">Tanım: </label>\r\n\r\n    <textarea type=\"text\" name=\"entry\" id=\"girdi-area\"");
                BeginWriteAttribute("value", " value=\"", 463, "\"", 471, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""md-textarea form-control"" rows=""3"" required></textarea>



    <button id=""girdi-area2"" type=""button"" class=""btn btn-dark"" style=""margin-top: 10px; margin-right: 2px;  float: left"" onclick=""foo()"">b</button>
    <button type=""button"" class=""btn btn-dark"" style=""margin-top: 10px; margin-right: 2px; float: left"">i</button>
    <button type=""button"" class=""btn btn-dark"" style=""margin-top: 10px; margin-right: 2px;  float: left"">bkz</button>
    <button type=""button"" class=""btn btn-dark"" style=""margin-top: 10px; margin-right: 2px;  float: left"">gbkz</button>
    <button type=""button"" class=""btn btn-dark"" style=""margin-top: 10px; margin-right: 2px;  float: left"">*</button>
    <button type=""button"" class=""btn btn-dark"" style=""margin-top: 10px; margin-right: 2px;  float: left"">alıntı</button>
    <button type=""button"" class=""btn btn-dark"" style=""margin-top: 10px; margin-right: 2px;  float: left"">link</button>
    <button type=""submit"" class=""btn btn-dark"" style=""margin-top: 10px;  float: right;"">G");
                WriteLiteral("önder</button>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<script>\r\n\r\n    function foo()\r\n    {\r\n    let sel = window.getSelection(); \r\n\r\n    sel.modify(\'extend\', \'forward\', select.value);\r\n    alert(sel);\r\n    var selRange = sel.getRangeAt(0);\r\n    // do stuff with the range\r\n    }\r\n</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public HttpHelper _helper { get; private set; }
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
