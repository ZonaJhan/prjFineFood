#pragma checksum "C:\Zona\try\prjFineFoodCore\Views\PSearchPocketList\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70d6c24d3bb188cf3ce53046ef90d5499a2b51e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PSearchPocketList_Search), @"mvc.1.0.view", @"/Views/PSearchPocketList/Search.cshtml")]
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
#line 1 "C:\Zona\try\prjFineFoodCore\Views\_ViewImports.cshtml"
using prjFineFoodCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Zona\try\prjFineFoodCore\Views\_ViewImports.cshtml"
using prjFineFoodCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70d6c24d3bb188cf3ce53046ef90d5499a2b51e0", @"/Views/PSearchPocketList/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff203aa6c9dd9399a1b91ce2aea0f7a81a6be712", @"/Views/_ViewImports.cshtml")]
    public class Views_PSearchPocketList_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<prjFineFoodCore.Models.PocketList>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Zona\try\prjFineFoodCore\Views\PSearchPocketList\Search.cshtml"
  
    ViewData["Title"] = "Search";
    Layout = "_LayoutPockSearch";

#line default
#line hidden
#nullable disable
            DefineSection("CSS", async() => {
                WriteLiteral(@"
    <style>
        .outside {
            border: 1px solid black;
            height: 270px;
            border-radius: 30px;
            margin: 20px;
        }

        .imgdv {
            border: 1px solid black;
            border-radius: 30px;
            margin: 10px;
            height: 250px;
            width: 450px;
            float: left;
        }

        .detaildiv {
            margin: 30px;
        }

        .hr {
            width: 500px;
        }
    </style>
");
            }
            );
            WriteLiteral("\r\n");
            WriteLiteral("<div class=\"container\">\r\n    <main>\r\n");
            WriteLiteral("        <h1>Search</h1>\r\n        <h1>????????????</h1>\r\n");
#nullable restore
#line 93 "C:\Zona\try\prjFineFoodCore\Views\PSearchPocketList\Search.cshtml"
         for (int i = 1; i < 8; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"outside\">\r\n        <div class=\"imgdv\">\r\n            <img src=\"#\" />\r\n        </div>\r\n        <div>\r\n            <p class=\"detaildiv\">????????????: a+");
#nullable restore
#line 100 "C:\Zona\try\prjFineFoodCore\Views\PSearchPocketList\Search.cshtml"
                                    Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        <div>\r\n            <p class=\"detaildiv\">??????: a+");
#nullable restore
#line 103 "C:\Zona\try\prjFineFoodCore\Views\PSearchPocketList\Search.cshtml"
                                  Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        <div>\r\n            <p class=\"detaildiv\">??????: a+");
#nullable restore
#line 106 "C:\Zona\try\prjFineFoodCore\Views\PSearchPocketList\Search.cshtml"
                                  Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        <div>\r\n            <p class=\"detaildiv\">????????????: a+");
#nullable restore
#line 109 "C:\Zona\try\prjFineFoodCore\Views\PSearchPocketList\Search.cshtml"
                                    Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n    </div>\r\n            <hr />\r\n");
#nullable restore
#line 113 "C:\Zona\try\prjFineFoodCore\Views\PSearchPocketList\Search.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </main>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<prjFineFoodCore.Models.PocketList>> Html { get; private set; }
    }
}
#pragma warning restore 1591
