#pragma checksum "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cdae38bbd0ff9c20b91a2f0a47d23849712c7ee"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cdae38bbd0ff9c20b91a2f0a47d23849712c7ee", @"/Views/Subject/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b96a12b27c7900be26918d91671bad4a847a255e", @"/Views/_ViewImports.cshtml")]
    public class Views_Subject_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 7 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
  
    ViewData["Title"] = @ViewBag.Subject;
    Layout = "~/Views/Shared/_Layout2.cshtml";

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
            BeginWriteAttribute("href", " href=\"", 653, "\"", 705, 4);
            WriteAttributeValue("", 660, "/subject?search=", 660, 16, true);
#nullable restore
#line 23 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
WriteAttributeValue("", 676, ViewBag.Subject, 676, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 692, "&pageIndex=", 692, 11, true);
#nullable restore
#line 23 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
WriteAttributeValue("", 703, b, 703, 2, false);

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
            BeginWriteAttribute("id", " id=\'", 1397, "\'", 1402, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\'dropdown-item pagination_link \'");
            BeginWriteAttribute("href", " href=\'", 1442, "\'", 1494, 4);
            WriteAttributeValue("", 1449, "/subject?search=", 1449, 16, true);
#nullable restore
#line 32 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
WriteAttributeValue("", 1465, ViewBag.Subject, 1465, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1481, "&pageIndex=", 1481, 11, true);
#nullable restore
#line 32 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
WriteAttributeValue("", 1492, i, 1492, 2, false);

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
            BeginWriteAttribute("href", " href=\"", 1752, "\"", 1804, 4);
            WriteAttributeValue("", 1759, "/subject?search=", 1759, 16, true);
#nullable restore
#line 43 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
WriteAttributeValue("", 1775, ViewBag.Subject, 1775, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1791, "&pageIndex=", 1791, 11, true);
#nullable restore
#line 43 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
WriteAttributeValue("", 1802, a, 1802, 2, false);

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
            BeginWriteAttribute("href", " href=\"", 2281, "\"", 2319, 2);
            WriteAttributeValue("", 2288, "/subjectedit/", 2288, 13, true);
#nullable restore
#line 57 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
WriteAttributeValue("", 2301, ViewBag.SubjectId, 2301, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"far fa-edit \"></i></a>\r\n        <a class=\"modbut\"");
            BeginWriteAttribute("href", " href=\"", 2380, "\"", 2420, 2);
            WriteAttributeValue("", 2387, "/subjectdelete/", 2387, 15, true);
#nullable restore
#line 58 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
WriteAttributeValue("", 2402, ViewBag.SubjectId, 2402, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"far fa-trash-alt \"></i></a>\r\n        <a class=\"modbut\"");
            BeginWriteAttribute("href", " href=\"", 2486, "\"", 2524, 2);
            WriteAttributeValue("", 2493, "/subjecthide/", 2493, 13, true);
#nullable restore
#line 59 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
WriteAttributeValue("", 2506, ViewBag.SubjectId, 2506, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"far fa-eye-slash \"></i></a>\r\n    </div>\r\n");
#nullable restore
#line 64 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
     foreach (var item in (IEnumerable<Entry>)ViewData["Entries"])
    {


        var c = @_helper.GetUsername(item.authorId);
        

#line default
#line hidden
#nullable disable
            WriteLiteral("<a style=\"float:right; font-size:12px;\" class=\"monospace\"");
            BeginWriteAttribute("href", " href=\"", 2781, "\"", 2820, 4);
            WriteAttributeValue("", 2788, "/entry/", 2788, 7, true);
#nullable restore
#line 69 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
WriteAttributeValue("", 2795, ViewBag.Subject, 2795, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2811, "/", 2811, 1, true);
#nullable restore
#line 69 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
WriteAttributeValue("", 2812, item.id, 2812, 8, false);

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
            BeginWriteAttribute("href", " href=\"", 3056, "\"", 3095, 4);
            WriteAttributeValue("", 3063, "/entry/", 3063, 7, true);
#nullable restore
#line 73 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
WriteAttributeValue("", 3070, ViewBag.Subject, 3070, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3086, "/", 3086, 1, true);
#nullable restore
#line 73 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
WriteAttributeValue("", 3087, item.id, 3087, 8, false);

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
            BeginWriteAttribute("href", " href=\"", 3410, "\"", 3436, 2);
            WriteAttributeValue("", 3417, "/entryedit/", 3417, 11, true);
#nullable restore
#line 79 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
WriteAttributeValue("", 3428, item.id, 3428, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"far fa-edit \"></i></a>\r\n            <a class=\"modbut\"");
            BeginWriteAttribute("href", " href=\"", 3501, "\"", 3529, 2);
            WriteAttributeValue("", 3508, "/entrydelete/", 3508, 13, true);
#nullable restore
#line 80 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
WriteAttributeValue("", 3521, item.id, 3521, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"far fa-trash-alt \"></i></a>\r\n            <a class=\"modbut\"");
            BeginWriteAttribute("href", " href=\"", 3599, "\"", 3629, 2);
            WriteAttributeValue("", 3606, "/entrytransfer/", 3606, 15, true);
#nullable restore
#line 81 "C:\Users\abdul\Documents\Projects\8BDASPNET\8BD\Views\Subject\Index.cshtml"
WriteAttributeValue("", 3621, item.id, 3621, 8, false);

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
