#pragma checksum "D:\Workspace\8BD\8BDASPNET\8BD\Views\Shared\Components\Sidebar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31add22e7a39e941b9483c7063109b020b61f56a"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"31add22e7a39e941b9483c7063109b020b61f56a", @"/Views/Shared/Components/Sidebar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b96a12b27c7900be26918d91671bad4a847a255e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Sidebar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1 class=\"sidebar-header\">vizyondaki başlıklar </h1>\r\n\r\n<br>\r\n\r\n");
#nullable restore
#line 11 "D:\Workspace\8BD\8BDASPNET\8BD\Views\Shared\Components\Sidebar.cshtml"
 foreach (var item in helper.getSubjects() as IOrderedEnumerable<_8BD.Models.Subject>)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"sidebar-entryheaders\"> <a");
            BeginWriteAttribute("href", " href=\"", 350, "\"", 411, 3);
#nullable restore
#line 13 "D:\Workspace\8BD\8BDASPNET\8BD\Views\Shared\Components\Sidebar.cshtml"
WriteAttributeValue("", 357, Configuration["AppHost"], 357, 25, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 382, "/Subject?search=", 382, 16, true);
#nullable restore
#line 13 "D:\Workspace\8BD\8BDASPNET\8BD\Views\Shared\Components\Sidebar.cshtml"
WriteAttributeValue("", 398, item.subject, 398, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> ");
#nullable restore
#line 13 "D:\Workspace\8BD\8BDASPNET\8BD\Views\Shared\Components\Sidebar.cshtml"
                                                                                                  Write(item.subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></p>\r\n");
#nullable restore
#line 14 "D:\Workspace\8BD\8BDASPNET\8BD\Views\Shared\Components\Sidebar.cshtml"
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
