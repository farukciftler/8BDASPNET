#pragma checksum "/home/loquat/Projects/8BDASPNET/8BD/Views/Subject/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "588982be2e2b41d1e1f3f94fbce4a0ecd60fd5f8"
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
#line 1 "/home/loquat/Projects/8BDASPNET/8BD/Views/_ViewImports.cshtml"
using _8BD;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/loquat/Projects/8BDASPNET/8BD/Views/_ViewImports.cshtml"
using _8BD.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/home/loquat/Projects/8BDASPNET/8BD/Views/Subject/Index.cshtml"
using _8BD.Helpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"588982be2e2b41d1e1f3f94fbce4a0ecd60fd5f8", @"/Views/Subject/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31e69a05e87b9cc0ee2aa199a19f09f8b79c4f33", @"/Views/_ViewImports.cshtml")]
    public class Views_Subject_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "/home/loquat/Projects/8BDASPNET/8BD/Views/Subject/Index.cshtml"
  
    ViewData["Title"] = @ViewBag.Subject;
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 9 "/home/loquat/Projects/8BDASPNET/8BD/Views/Subject/Index.cshtml"
 if (ViewBag.Count != 0 && ViewData["Entries"] != null)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4 class=\"subject-header\">");
#nullable restore
#line 12 "/home/loquat/Projects/8BDASPNET/8BD/Views/Subject/Index.cshtml"
                          Write(ViewBag.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n    <hr>\n");
#nullable restore
#line 16 "/home/loquat/Projects/8BDASPNET/8BD/Views/Subject/Index.cshtml"
     foreach (var item in (IEnumerable<Entry>)ViewData["Entries"])
    {
        
       
        var c = @_helper.GetUsername(item.authorId);
        

#line default
#line hidden
#nullable disable
            WriteLiteral("<p class=\"entry\"> ");
#nullable restore
#line 21 "/home/loquat/Projects/8BDASPNET/8BD/Views/Subject/Index.cshtml"
                     Write(item.entry);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        <div class=\"row d-flex flex-row-reverse\" style=\"margin-right:5px;\">\n            <p class=\"entry-date monospace\">");
#nullable restore
#line 23 "/home/loquat/Projects/8BDASPNET/8BD/Views/Subject/Index.cshtml"
                                       Write(item.createDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p> | <p class=\"monospace entry-author\">");
#nullable restore
#line 23 "/home/loquat/Projects/8BDASPNET/8BD/Views/Subject/Index.cshtml"
                                                                                                      if (c != null) { 

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "/home/loquat/Projects/8BDASPNET/8BD/Views/Subject/Index.cshtml"
                                                                                                                  Write(c);

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "/home/loquat/Projects/8BDASPNET/8BD/Views/Subject/Index.cshtml"
                                                                                                                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        </div>\n");
            WriteLiteral("        <hr class=\"entry-hr\">\n");
#nullable restore
#line 27 "/home/loquat/Projects/8BDASPNET/8BD/Views/Subject/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "/home/loquat/Projects/8BDASPNET/8BD/Views/Subject/Index.cshtml"
     
    if (ViewBag.Name != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "/home/loquat/Projects/8BDASPNET/8BD/Views/Subject/Index.cshtml"
   Write(await Html.PartialAsync("../Shared/DictComponents/EntryAdd"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "/home/loquat/Projects/8BDASPNET/8BD/Views/Subject/Index.cshtml"
                                                                     
    }else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br>\n       <div class=\"quote\">    \n           <h4 class=\"subject-header\">Tanım girebilmek için lütfen üye olunuz veya hesabınıza giriş yapınız.</h4>\n       </div>     \n");
#nullable restore
#line 37 "/home/loquat/Projects/8BDASPNET/8BD/Views/Subject/Index.cshtml"
    }
}
else
{
    if (ViewBag.Name != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("       <h4 class=\"subject-header\">");
#nullable restore
#line 43 "/home/loquat/Projects/8BDASPNET/8BD/Views/Subject/Index.cshtml"
                             Write(ViewBag.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n");
#nullable restore
#line 44 "/home/loquat/Projects/8BDASPNET/8BD/Views/Subject/Index.cshtml"
   Write(await Html.PartialAsync("../Shared/DictComponents/EntryAdd"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "/home/loquat/Projects/8BDASPNET/8BD/Views/Subject/Index.cshtml"
                                                                     
    }
    else if (ViewData["Entries"] != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <h4 class=\"subject-header\">");
#nullable restore
#line 48 "/home/loquat/Projects/8BDASPNET/8BD/Views/Subject/Index.cshtml"
                            Write(ViewBag.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n      <br>\n        <h4 class=\"monospace\">Böyle bir başlık bulunmamaktadır.</h4>\n        <h4 class=\"monospace\">Başlık açmak için yazar olmanız gerekiyor. Lütfen üye girişi yapınız.</h4>\n");
#nullable restore
#line 52 "/home/loquat/Projects/8BDASPNET/8BD/Views/Subject/Index.cshtml"
    }
}

#line default
#line hidden
#nullable disable
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
