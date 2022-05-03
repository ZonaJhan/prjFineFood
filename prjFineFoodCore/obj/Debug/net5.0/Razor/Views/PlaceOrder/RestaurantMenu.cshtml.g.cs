#pragma checksum "C:\Zona\try\prjFineFoodCore\Views\PlaceOrder\RestaurantMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28b334d27599c72a4c33e28e732a9729be7abec3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PlaceOrder_RestaurantMenu), @"mvc.1.0.view", @"/Views/PlaceOrder/RestaurantMenu.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28b334d27599c72a4c33e28e732a9729be7abec3", @"/Views/PlaceOrder/RestaurantMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff203aa6c9dd9399a1b91ce2aea0f7a81a6be712", @"/Views/_ViewImports.cshtml")]
    public class Views_PlaceOrder_RestaurantMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<prjFineFoodCore.ViewModel.CFoodViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("..."), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Zona\try\prjFineFoodCore\Views\PlaceOrder\RestaurantMenu.cshtml"
  
    ViewBag.Title = "菜單";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n\r\n        function ShowMessage() {\r\n            toastr[\"success\"](\"商品已加入購物車！\");\r\n        }\r\n\r\n        $(\"divAdd\").click(ShowMessage());\r\n\r\n    </script>\r\n");
            }
            );
            WriteLiteral(@"
<div class=""container"">
    <main>
        <div class=""container"" style=""margin-top:40px"">
            <div class=""row"">
                <div class=""col-5"">
                    <p></p>
                    <p></p>
                    <img class=""pl-5""");
            BeginWriteAttribute("src", " src=\"", 549, "\"", 555, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n                    <div class=\"col-8\">\r\n                        <h3>");
#nullable restore
#line 28 "C:\Zona\try\prjFineFoodCore\Views\PlaceOrder\RestaurantMenu.cshtml"
                       Write(ViewBag.RestaurantName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <p>地址：");
#nullable restore
#line 29 "C:\Zona\try\prjFineFoodCore\Views\PlaceOrder\RestaurantMenu.cshtml"
                         Write(ViewBag.RestaurantAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral(";</p>\r\n                        <p>電話：");
#nullable restore
#line 30 "C:\Zona\try\prjFineFoodCore\Views\PlaceOrder\RestaurantMenu.cshtml"
                         Write(ViewBag.RestaurantPhone);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    </div>
                </div>
            </div>
        </div>

        <section class=""py-5"">
            <div class=""container px-4 px-lg-5 mt-5"">
                <div class=""row gx-4 gx-lg-5 row-cols-2 row-cols-md-3 row-cols-xl-4 justify-content-center"">
");
#nullable restore
#line 39 "C:\Zona\try\prjFineFoodCore\Views\PlaceOrder\RestaurantMenu.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"col mb-5\">\r\n                            <div class=\"card h-100\">\r\n                                <!-- Food image-->\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "28b334d27599c72a4c33e28e732a9729be7abec36414", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1360, "~/Images/Foods/", 1360, 15, true);
#nullable restore
#line 44 "C:\Zona\try\prjFineFoodCore\Views\PlaceOrder\RestaurantMenu.cshtml"
AddHtmlAttributeValue("", 1375, item.Photo, 1375, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral(@"                                <!-- Product details-->
                                <div class=""card-body p-4"">
                                    <div class=""text-center"">
                                        <!-- Food name-->
                                        <h5 class=""fw-bolder"">");
#nullable restore
#line 50 "C:\Zona\try\prjFineFoodCore\Views\PlaceOrder\RestaurantMenu.cshtml"
                                                         Write(item.FoodName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                        <!-- Food price-->\r\n                                        $");
#nullable restore
#line 52 "C:\Zona\try\prjFineFoodCore\Views\PlaceOrder\RestaurantMenu.cshtml"
                                    Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </div>
                                </div>
                                <!-- Food actions-->
                                <div class=""card-footer p-4 pt-0 border-top-0 bg-transparent"">
                                    <div class=""text-center"">");
#nullable restore
#line 57 "C:\Zona\try\prjFineFoodCore\Views\PlaceOrder\RestaurantMenu.cshtml"
                                                        Write(Html.ActionLink("加入購物車", "AddToCart", new { id = item.FoodId }, new { id = "divAdd", @class = "btn btn-outline-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 61 "C:\Zona\try\prjFineFoodCore\Views\PlaceOrder\RestaurantMenu.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </section>\r\n\r\n        <hr />\r\n        <p></p>\r\n");
            WriteLiteral("    </main>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<prjFineFoodCore.ViewModel.CFoodViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
