#pragma checksum "D:\Workspace\8BD\8BDASPNET\8BD\Views\Shared\Components\Sidebar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27a542c4cb4ab7a73e09ef8925708337c8208829"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Sidebar), @"mvc.1.0.view", @"/Views/Shared/Components/Sidebar.cshtml")]
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
#line 1 "D:\Workspace\8BD\8BDASPNET\8BD\Views\Shared\Components\Sidebar.cshtml"
using RestSharp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Workspace\8BD\8BDASPNET\8BD\Views\Shared\Components\Sidebar.cshtml"
using _8BD.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Workspace\8BD\8BDASPNET\8BD\Views\Shared\Components\Sidebar.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27a542c4cb4ab7a73e09ef8925708337c8208829", @"/Views/Shared/Components/Sidebar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b96a12b27c7900be26918d91671bad4a847a255e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Sidebar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<h1 class=""sidebar-header"">vizyondaki başlıklar </h1>
<div style='margin-bottom:10px; justify-content:center;' class='dropdown'>
    
    <button id='sol' style='margin-left:33%;' class='btn btn-sm eksilt btn-outline-secondary'><i class='fa fa-angle-left'></i></button>
    <button id='sidebar_button ' style='margin-left:1px; margin-right:1px; margin-bottom:0px; min-width:60px; height:31px;' role='button' type='button' class='btn btn-sm btn-default dropdown-toggle sidebarsayfalar btn-outline-secondary' data-toggle='dropdown' aria-haspopup='true' aria-expanded='false'>1  </button>
    <div id='dropdown-side' class='dropdown-menu ' aria-labelledby='dropdownMenuButton' style='min-width:10px;'>
        <z");
            BeginWriteAttribute("id", " id=\'", 870, "\'", 875, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\'dropdown-item pagination_link \' href=\'#\'>1</z>\r\n    </div><button id=\'sag\' class=\'btn btn-sm artir btn-outline-secondary\'><i  class=\'fa fa-angle-right\'></i></button>\r\n    </div>\r\n\r\n<br>\r\n\r\n");
#nullable restore
#line 19 "D:\Workspace\8BD\8BDASPNET\8BD\Views\Shared\Components\Sidebar.cshtml"
 foreach (var item in helper.getSubjects() as IOrderedEnumerable<_8BD.Models.Subject>)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"sidebar-entryheaders\"> <a");
            BeginWriteAttribute("href", " href=\"", 1203, "\"", 1264, 3);
#nullable restore
#line 21 "D:\Workspace\8BD\8BDASPNET\8BD\Views\Shared\Components\Sidebar.cshtml"
WriteAttributeValue("", 1210, Configuration["AppHost"], 1210, 25, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1235, "/Subject?search=", 1235, 16, true);
#nullable restore
#line 21 "D:\Workspace\8BD\8BDASPNET\8BD\Views\Shared\Components\Sidebar.cshtml"
WriteAttributeValue("", 1251, item.subject, 1251, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 21 "D:\Workspace\8BD\8BDASPNET\8BD\Views\Shared\Components\Sidebar.cshtml"
                                                                                                  Write(item.subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n");
#nullable restore
#line 22 "D:\Workspace\8BD\8BDASPNET\8BD\Views\Shared\Components\Sidebar.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SidebarHelper helper { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IConfiguration Configuration { get; private set; }
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
