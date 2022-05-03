#pragma checksum "C:\Zona\try\prjFineFoodCore\Views\PPockstListCollection\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "279fa50e91ab25f73078412f263288c2317892c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PPockstListCollection_List), @"mvc.1.0.view", @"/Views/PPockstListCollection/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"279fa50e91ab25f73078412f263288c2317892c0", @"/Views/PPockstListCollection/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff203aa6c9dd9399a1b91ce2aea0f7a81a6be712", @"/Views/_ViewImports.cshtml")]
    public class Views_PPockstListCollection_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<prjFineFoodCore.Models.PocketListAction>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Zona\try\prjFineFoodCore\Views\PPockstListCollection\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
#nullable disable
            DefineSection("CSS", async() => {
                WriteLiteral(@"
    <style>
        /*   * {
            margin: 0;
            padding: 0;
            box-sizing: border-box;
            text-decoration: none;
            transition: 0.8s;
        }

        body {
            font-family: ""Montserrat"";
            background-color: #b8b6b6;
            color: #fdfdfd;
        }*/

        .card {
            width: 300px;
            height: 350px;
            margin: 50px;
            background-color: #ffffff;
            box-shadow: 0 10px 90px #00000024;
            text-align: center;
            font-size: 20px;
            border-radius: 15px;
            float: left;
        }

            .card .card-header {
                background-color: #888888;
                position: relative;
                height: 250px;
                border-top-left-radius: 15px;
                border-top-right-radius: 15px;
            }

                .card .card-header .profile-img {
                    width: 130px;
                 ");
                WriteLiteral(@"   height: 130px;
                    border-radius: 1000px;
                    position: absolute;
                    left: 50%;
                    transform: translate(-50%,-50%);
                    border: 8px solid #AAAAAA;
                    box-shadow: 0 0 20px #00000033;
                }

                    .card .card-header .profile-img:hover {
                        font-size: 30px;
                        width: 150px;
                        height: 150px;
                        border: 8px solid #DDDDDD;
                        transition: 0.8s;
                    }

            .card .card-body {
                padding: 10px 40px;
            }

                .card .card-body.name {
                    margin-top: 30px;
                    font-size: 22px;
                    font-weight: bold;
                    color: #AAAAAA;
                }

                    .card .card-body .name:hover {
                        margin-top: 30px;
             ");
                WriteLiteral(@"           font-size: 24px;
                        color: #666666;
                        transition: 0.8s;
                    }

                .card .card-body .mail {
                    font-size: 14px;
                    color: #c2bdbd;
                }

                    .card .card-body .mail:hover {
                        font-size: 16px;
                        color: #ffffff;
                        transition: 0.8s;
                    }

                .card .card-body .job {
                    margin-top: 10px;
                    font-size: 14px;
                }

            .card .social-link {
                display: flex;
                justify-content: center;
                align-items: center;
                margin-top: 30px;
            }

                .card .social-link .social-icon {
                    display: inline-flex;
                    align-items: center;
                    justify-content: center;
                    height");
                WriteLiteral(@": 40px;
                    width: 40px;
                    background-color: #888888;
                    color: #ffffff;
                    font-size: 20px;
                    border-radius: 100%;
                    text-decoration: none;
                    margin: 0 13px 30px 0;
                }

                    .card .social-link .social-icon:last-child {
                        margin-right: 0;
                    }

                    .card .social-link .social-icon:hover {
                        background-color: #DDDDDD;
                        height: 60px;
                        width: 60px;
                        text-decoration: none;
                        transition: 0.8s;
                    }

            .card .card-footer {
                width: 300px;
                background-color: #888888;
                border-bottom-left-radius: 15px;
                border-bottom-right-radius: 15px;
                padding: 20px 0 20px 0;
            }

");
                WriteLiteral("                .card .card-footer .count {\r\n                    font-size: 14px;\r\n                }\r\n\r\n        .clearFloat {\r\n            clear: both;\r\n        }\r\n    </style>\r\n\r\n");
            }
            );
            WriteLiteral("\r\n");
            WriteLiteral(@"

<div class=""container"">
    <main>
        <h1>我的收藏口袋名單</h1>
        <button class=""btn btn-outline-dark bi bi-search h-100"" type=""button"" id=""btnSearch"" style=""margin:5px"">
            搜尋
        </button>
        <br />
        <br />
        <br />
        <br />
        <br />
");
#nullable restore
#line 208 "C:\Zona\try\prjFineFoodCore\Views\PPockstListCollection\List.cshtml"
          int count = 0;
            foreach (var item in Model)
            {
                count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card\">\r\n                    <div class=\"card-header\">\r\n                        <h5 class=\"profile-img\">建立者: 郭 ");
#nullable restore
#line 214 "C:\Zona\try\prjFineFoodCore\Views\PPockstListCollection\List.cshtml"
                                                  Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n");
            WriteLiteral("                    </div>\r\n\r\n                    <div class=\"card-body\">\r\n                        <p class=\"name\">\r\n");
            WriteLiteral("                            收藏的郭 ");
#nullable restore
#line 221 "C:\Zona\try\prjFineFoodCore\Views\PPockstListCollection\List.cshtml"
                            Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n");
            WriteLiteral("                    </div>\r\n\r\n                    <div class=\"social-link\">\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("                        ");
#nullable restore
#line 239 "C:\Zona\try\prjFineFoodCore\Views\PPockstListCollection\List.cshtml"
                   Write(Html.ActionLink("", "Edit", new { id = item.PocketListId }, new { @class = "btn btn-outline-dark btn btn-outline-dark social-icon bi bi-heart-fill" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                        ");
#nullable restore
#line 241 "C:\Zona\try\prjFineFoodCore\Views\PPockstListCollection\List.cshtml"
                   Write(Html.ActionLink("", "Detail", new { id = item.PocketListId }, new { @class = "btn btn-outline-dark btn btn-outline-dark social-icon bi bi-list-check" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                    </div>\r\n\r\n                    <div class=\"card-footer\">\r\n                        <p class=\"count\"></p>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 250 "C:\Zona\try\prjFineFoodCore\Views\PPockstListCollection\List.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"clearFloat\"></div>\r\n");
            WriteLiteral("    </main>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        const btnSearch = document.querySelector(\"#btnSearch\");\r\n        btnSearch.addEventListener(\"click\", () => {\r\n            location.href = \"/PSearchPocketList/Search\";\r\n        })\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<prjFineFoodCore.Models.PocketListAction>> Html { get; private set; }
    }
}
#pragma warning restore 1591