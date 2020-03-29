#pragma checksum "D:\Workspace\8BD\8BDASPNET\8BD\Views\Subject\SingleEntry.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3602790cecb093d520b06c38b7dc15dacdb1a086"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Subject_SingleEntry), @"mvc.1.0.view", @"/Views/Subject/SingleEntry.cshtml")]
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
#line 1 "D:\Workspace\8BD\8BDASPNET\8BD\Views\Subject\SingleEntry.cshtml"
using _8BD.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Workspace\8BD\8BDASPNET\8BD\Views\Subject\SingleEntry.cshtml"
using _8BD.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Workspace\8BD\8BDASPNET\8BD\Views\Subject\SingleEntry.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3602790cecb093d520b06c38b7dc15dacdb1a086", @"/Views/Subject/SingleEntry.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b96a12b27c7900be26918d91671bad4a847a255e", @"/Views/_ViewImports.cshtml")]
    public class Views_Subject_SingleEntry : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 7 "D:\Workspace\8BD\8BDASPNET\8BD\Views\Subject\SingleEntry.cshtml"
  
    ViewData["Title"] = @ViewBag.Subject;
    Layout = "~/Views/Shared/_Layout.cshtml";
    var entry = ViewData["Entry"] as Entry;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h4 class=\"subject-header\"><b>");
#nullable restore
#line 13 "D:\Workspace\8BD\8BDASPNET\8BD\Views\Subject\SingleEntry.cshtml"
                         Write(ViewBag.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </b></h4>\r\n");
#nullable restore
#line 14 "D:\Workspace\8BD\8BDASPNET\8BD\Views\Subject\SingleEntry.cshtml"
 if (ViewData["Entry"] != null)
{


#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <hr>
    <div class=""row"" style=""margin-left:4px; margin-top:-18px;"">
        <a class=""modbut"" onclick=""CopyLink();"" title=""Linki kopyala"" href=""#""><i class=""fas fa-link""></i></a>
        <a class=""modbut"" href=""subjectedit""><i class=""far fa-edit ""></i></a>
        <a class=""modbut"" href=""#""><i class=""far fa-trash-alt ""></i></a>
        <a class=""modbut"" href=""#""><i class=""far fa-folder-open ""></i></a>
        <a class=""modbut"" href=""#""><i class=""fas fa-exchange-alt ""></i></a>
        <a class=""modbut"" href=""#""><i class=""far fa-eye-slash ""></i></a>
    </div>
    <br />
    <a href=""#""><li class=""list-group-item"" style=""text-align:center"">daha önceki tanımlar</li></a>
    <br />
    <hr />
");
#nullable restore
#line 30 "D:\Workspace\8BD\8BDASPNET\8BD\Views\Subject\SingleEntry.cshtml"
    var c = @_helper.GetUsername(entry.authorId);
    

#line default
#line hidden
#nullable disable
            WriteLiteral("<a style=\"float:right; font-size:12px;\" class=\"monospace\"");
            BeginWriteAttribute("href", " href=\"", 1252, "\"", 1292, 4);
            WriteAttributeValue("", 1259, "/entry/", 1259, 7, true);
#nullable restore
#line 31 "D:\Workspace\8BD\8BDASPNET\8BD\Views\Subject\SingleEntry.cshtml"
WriteAttributeValue("", 1266, ViewBag.Subject, 1266, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1282, "/", 1282, 1, true);
#nullable restore
#line 31 "D:\Workspace\8BD\8BDASPNET\8BD\Views\Subject\SingleEntry.cshtml"
WriteAttributeValue("", 1283, entry.id, 1283, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">#");
#nullable restore
#line 31 "D:\Workspace\8BD\8BDASPNET\8BD\Views\Subject\SingleEntry.cshtml"
                                                                                                   Write(entry.id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n    <br />\r\n    <p class=\"entry\">");
#nullable restore
#line 33 "D:\Workspace\8BD\8BDASPNET\8BD\Views\Subject\SingleEntry.cshtml"
                Write(Html.Raw(_regex.PregReplace(entry.entry, _regex.patterns, _regex.replacements)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <div class=\"row d-flex flex-row-reverse\" style=\"margin-right:5px;\">\r\n        <a");
            BeginWriteAttribute("href", " href=\"", 1513, "\"", 1553, 4);
            WriteAttributeValue("", 1520, "/entry/", 1520, 7, true);
#nullable restore
#line 35 "D:\Workspace\8BD\8BDASPNET\8BD\Views\Subject\SingleEntry.cshtml"
WriteAttributeValue("", 1527, ViewBag.Subject, 1527, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1543, "/", 1543, 1, true);
#nullable restore
#line 35 "D:\Workspace\8BD\8BDASPNET\8BD\Views\Subject\SingleEntry.cshtml"
WriteAttributeValue("", 1544, entry.id, 1544, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><p class=\"entry-date monospace\">");
#nullable restore
#line 35 "D:\Workspace\8BD\8BDASPNET\8BD\Views\Subject\SingleEntry.cshtml"
                                                                               Write(entry.createDate.ToString("MM.dd.yyyy H:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></a> | <p class=\"monospace entry-author\">\r\n");
#nullable restore
#line 36 "D:\Workspace\8BD\8BDASPNET\8BD\Views\Subject\SingleEntry.cshtml"
             if (c != null)
            {

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "D:\Workspace\8BD\8BDASPNET\8BD\Views\Subject\SingleEntry.cshtml"
        Write(c);

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "D:\Workspace\8BD\8BDASPNET\8BD\Views\Subject\SingleEntry.cshtml"
               }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </p>\r\n    </div>\r\n    <div class=\"row\" style=\"margin-left:4px; margin-bottom:-8px;\">\r\n        <a class=\"modbut\" href=\"/entryedit\"><i class=\"far fa-edit \"></i></a>\r\n        <a class=\"modbut\"");
            BeginWriteAttribute("href", " href=\"", 1923, "\"", 1930, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""far fa-trash-alt ""></i></a>
        <a class=""modbut"" href=""#""><i class=""far fa-folder-open ""></i></a>
        <a class=""modbut"" href=""#""><i class=""far fa-envelope ""></i></a>
        <a class=""modbut"" href=""/entrytransfer""><i class=""fas fa-exchange-alt ""></i></a>
        <a class=""modbut"" href=""#""><i class=""far fa-eye-slash ""></i></a>
    </div>
    <br />
");
            WriteLiteral("    <hr class=\"entry-hr\">\r\n    <a href=\"#\"><li class=\"list-group-item\" style=\"text-align:center\">daha sonraki tanımlar</li></a>\r\n");
#nullable restore
#line 52 "D:\Workspace\8BD\8BDASPNET\8BD\Views\Subject\SingleEntry.cshtml"

    if (ViewBag.Name != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "D:\Workspace\8BD\8BDASPNET\8BD\Views\Subject\SingleEntry.cshtml"
   Write(await Html.PartialAsync("../Shared/DictComponents/EntryAdd"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "D:\Workspace\8BD\8BDASPNET\8BD\Views\Subject\SingleEntry.cshtml"
                                                                     
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br>\r\n        <div class=\"quote\">\r\n            <h4 class=\"subject-header\">Tanım girebilmek için lütfen üye olunuz veya hesabınıza giriş yapınız.</h4>\r\n        </div>\r\n");
#nullable restore
#line 63 "D:\Workspace\8BD\8BDASPNET\8BD\Views\Subject\SingleEntry.cshtml"
    }
}
else
{
    if (ViewBag.Name != null)
    {

        

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "D:\Workspace\8BD\8BDASPNET\8BD\Views\Subject\SingleEntry.cshtml"
   Write(await Html.PartialAsync("../Shared/DictComponents/EntryAdd"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "D:\Workspace\8BD\8BDASPNET\8BD\Views\Subject\SingleEntry.cshtml"
                                                                     
    }
    else if (ViewData["Entry"] != null)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <br>\r\n        <h4 class=\"monospace\">Böyle bir tanom bulunmamaktadır.</h4>\r\n        <h4 class=\"monospace\">Tanım yazmak için yazar olmanız gerekiyor. Lütfen üye girişi yapınız.</h4>\r\n");
#nullable restore
#line 78 "D:\Workspace\8BD\8BDASPNET\8BD\Views\Subject\SingleEntry.cshtml"
    }







}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script>
    function CopyLink() {
        var dummy = document.createElement('input'),
            text = window.location.href;

        document.body.appendChild(dummy);
        dummy.value = text;
        dummy.select();
        document.execCommand('copy');
        document.body.removeChild(dummy);
        alert(""Link Kopyalandı!"");

    }
</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IConfiguration Configuration { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public RegexHelper _regex { get; private set; }
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
