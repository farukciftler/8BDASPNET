#pragma checksum "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f8e0a41357a727e15751968746c013eaaf361ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Subject_Index), @"mvc.1.0.view", @"/Views/Subject/Index.cshtml")]
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
#line 1 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\_ViewImports.cshtml"
using _8BD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\_ViewImports.cshtml"
using _8BD.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
using _8BD.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f8e0a41357a727e15751968746c013eaaf361ad", @"/Views/Subject/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b96a12b27c7900be26918d91671bad4a847a255e", @"/Views/_ViewImports.cshtml")]
    public class Views_Subject_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 7 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
  
    ViewData["Title"] = @ViewBag.Subject;
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div style=\'float:right; margin-bottom:auto; margin-right:5px;\' class=\'dropdown\'>\r\n\r\n");
#nullable restore
#line 12 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
      
        var a = ViewBag.pageIndex + 1;
        var b = ViewBag.pageIndex - 1;
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 17 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
     if (@b < 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <button id=\'sol\' class=\'btn btn-sm eksilt btn-outline-secondary\'><i class=\'fa fa-angle-left\'></i></button>\r\n");
#nullable restore
#line 20 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\"", 652, "\"", 704, 4);
            WriteAttributeValue("", 659, "/subject?search=", 659, 16, true);
#nullable restore
#line 23 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
WriteAttributeValue("", 675, ViewBag.Subject, 675, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 691, "&pageIndex=", 691, 11, true);
#nullable restore
#line 23 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
WriteAttributeValue("", 702, b, 702, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> <button id=\'sol\' class=\'btn btn-sm eksilt btn-outline-secondary\'><i class=\'fa fa-angle-left\'></i></button></a>\r\n");
#nullable restore
#line 24 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <button id='sidebar_button ' style='margin-left:1px; margin-right:1px; margin-bottom:0px; min-width:60px; height:31px;' role='button' type='button' class='btn btn-sm btn-default dropdown-toggle sidebarsayfalar btn-outline-secondary' data-toggle='dropdown' aria-haspopup='true' aria-expanded='false'>");
#nullable restore
#line 26 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
                                                                                                                                                                                                                                                                                                          Write(a);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </button>\r\n    <div id=\'dropdown-side\' class=\'dropdown-menu \' aria-labelledby=\'dropdownMenuButton\' style=\'min-width:10px;\'>\r\n\r\n");
#nullable restore
#line 29 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
         for (int i = 0; i < @_pagination.getPageNumber(ViewBag.SubjectId); i++)
        {
            var c = i +1;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a");
            BeginWriteAttribute("id", " id=\'", 1396, "\'", 1401, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\'dropdown-item pagination_link \'");
            BeginWriteAttribute("href", " href=\'", 1441, "\'", 1493, 4);
            WriteAttributeValue("", 1448, "/subject?search=", 1448, 16, true);
#nullable restore
#line 32 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
WriteAttributeValue("", 1464, ViewBag.Subject, 1464, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1480, "&pageIndex=", 1480, 11, true);
#nullable restore
#line 32 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
WriteAttributeValue("", 1491, i, 1491, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 32 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
                                                                                                            Write(c);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 33 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n");
#nullable restore
#line 37 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
     if (@a == @_pagination.getPageNumber(ViewBag.SubjectId))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <button id=\'sol\' class=\'btn btn-sm eksilt btn-outline-secondary\'><i class=\'fa fa-angle-right\'></i></button>\r\n");
#nullable restore
#line 40 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\"", 1751, "\"", 1803, 4);
            WriteAttributeValue("", 1758, "/subject?search=", 1758, 16, true);
#nullable restore
#line 43 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
WriteAttributeValue("", 1774, ViewBag.Subject, 1774, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1790, "&pageIndex=", 1790, 11, true);
#nullable restore
#line 43 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
WriteAttributeValue("", 1801, a, 1801, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><button id=\'sag\' class=\'btn btn-sm artir btn-outline-secondary\'><i class=\'fa fa-angle-right\'></i></button></a>\r\n");
#nullable restore
#line 44 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n<br />\r\n\r\n<h4 class=\"subject-header\"><b>");
#nullable restore
#line 49 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
                         Write(ViewBag.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("  </b></h4>\r\n");
#nullable restore
#line 50 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
 if (ViewBag.Count != 0 && ViewData["Entries"] != null)
{



#line default
#line hidden
#nullable disable
            WriteLiteral("    <hr>\r\n    <div class=\"row\" style=\"margin-left:4px; margin-top:-18px;\">\r\n        <a class=\"modbut\" onclick=\"CopyLink();\" title=\"Linki kopyala\" href=\"#\"><i class=\"fas fa-link\"></i></a>\r\n        <a class=\"modbut\"");
            BeginWriteAttribute("href", " href=\"", 2280, "\"", 2318, 2);
            WriteAttributeValue("", 2287, "/subjectedit/", 2287, 13, true);
#nullable restore
#line 57 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
WriteAttributeValue("", 2300, ViewBag.SubjectId, 2300, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"far fa-edit \"></i></a>\r\n        <a class=\"modbut\"");
            BeginWriteAttribute("href", " href=\"", 2379, "\"", 2419, 2);
            WriteAttributeValue("", 2386, "/subjectdelete/", 2386, 15, true);
#nullable restore
#line 58 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
WriteAttributeValue("", 2401, ViewBag.SubjectId, 2401, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"far fa-trash-alt \"></i></a>\r\n        <!-- <a class=\"modbut\" href=\"/subjecthide/");
#nullable restore
#line 59 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
                                             Write(ViewBag.SubjectId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><i class=\"far fa-eye-slash \"></i></a>-->\r\n    </div>\r\n");
#nullable restore
#line 64 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
     foreach (var item in (IEnumerable<Entry>)ViewData["Entries"])
    {


        var c = @_helper.GetUsername(item.authorId);
        

#line default
#line hidden
#nullable disable
            WriteLiteral("<a style=\"float:right; font-size:12px;\" class=\"monospace\"");
            BeginWriteAttribute("href", " href=\"", 2788, "\"", 2827, 4);
            WriteAttributeValue("", 2795, "/entry/", 2795, 7, true);
#nullable restore
#line 69 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
WriteAttributeValue("", 2802, ViewBag.Subject, 2802, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2818, "/", 2818, 1, true);
#nullable restore
#line 69 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
WriteAttributeValue("", 2819, item.id, 2819, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">#");
#nullable restore
#line 69 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
                                                                                                      Write(item.id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n        <br />\r\n        <p class=\"entry\">");
#nullable restore
#line 71 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
                    Write(Html.Raw(_regex.PregReplace(@item.entry, _regex.patterns, _regex.replacements)));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <div class=\"row d-flex flex-row-reverse\" style=\"margin-right:5px;\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 3063, "\"", 3102, 4);
            WriteAttributeValue("", 3070, "/entry/", 3070, 7, true);
#nullable restore
#line 73 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
WriteAttributeValue("", 3077, ViewBag.Subject, 3077, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3093, "/", 3093, 1, true);
#nullable restore
#line 73 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
WriteAttributeValue("", 3094, item.id, 3094, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><p class=\"entry-date monospace\">");
#nullable restore
#line 73 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
                                                                                  Write(item.createDate.ToString("MM.dd.yyyy H:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p></a> | <p class=\"monospace entry-author\">\r\n");
#nullable restore
#line 74 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
                 if (c != null)
                {

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
            Write(c);

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
                   }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </p>\r\n        </div>\r\n        <div class=\"row\" style=\"margin-left:4px; margin-bottom:-8px;\">\r\n            <a class=\"modbut\"");
            BeginWriteAttribute("href", " href=\"", 3417, "\"", 3443, 2);
            WriteAttributeValue("", 3424, "/entryedit/", 3424, 11, true);
#nullable restore
#line 79 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
WriteAttributeValue("", 3435, item.id, 3435, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"far fa-edit \"></i></a>\r\n            <a class=\"modbut\"");
            BeginWriteAttribute("href", " href=\"", 3508, "\"", 3536, 2);
            WriteAttributeValue("", 3515, "/entrydelete/", 3515, 13, true);
#nullable restore
#line 80 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
WriteAttributeValue("", 3528, item.id, 3528, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"far fa-trash-alt \"></i></a>\r\n            <a class=\"modbut\"");
            BeginWriteAttribute("href", " href=\"", 3606, "\"", 3636, 2);
            WriteAttributeValue("", 3613, "/entrytransfer/", 3613, 15, true);
#nullable restore
#line 81 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
WriteAttributeValue("", 3628, item.id, 3628, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-exchange-alt \"></i></a>\r\n        </div>\r\n");
            WriteLiteral("        <br />\r\n        <hr class=\"entry-hr\">\r\n");
#nullable restore
#line 87 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
     
    if (ViewBag.Name != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
   Write(await Html.PartialAsync("../Shared/DictComponents/EntryAdd"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 90 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
                                                                     
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br>\r\n        <div class=\"quote\">\r\n            <h4 class=\"subject-header\">Tanım girebilmek için lütfen üye olunuz veya hesabınıza giriş yapınız.</h4>\r\n        </div>\r\n");
#nullable restore
#line 98 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
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
#line 105 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
   Write(await Html.PartialAsync("../Shared/DictComponents/EntryAdd"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 105 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
                                                                     
    }
    else if (ViewData["Entries"] != null)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <br>\r\n        <h4 class=\"monospace\">Böyle bir başlık bulunmamaktadır.</h4>\r\n        <h4 class=\"monospace\">Başlık açmak için yazar olmanız gerekiyor. Lütfen üye girişi yapınız.</h4>\r\n");
#nullable restore
#line 113 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
    }
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script>
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
        public PaginationHelper _pagination { get; private set; }
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
