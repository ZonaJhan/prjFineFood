#pragma checksum "C:\Zona\try\prjFineFoodCore\Views\Order\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05ed7bd90dddcdd0e31b492e9523803b7c511599"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Checkout), @"mvc.1.0.view", @"/Views/Order/Checkout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05ed7bd90dddcdd0e31b492e9523803b7c511599", @"/Views/Order/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff203aa6c9dd9399a1b91ce2aea0f7a81a6be712", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<prjMVCCoreClass.Models.CShoppingCartItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "PlaceOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CartView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Zona\try\prjFineFoodCore\Views\Order\Checkout.cshtml"
  
    ViewData["Title"] = "Checkout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("CSS", async() => {
                WriteLiteral(@"
    <style>

        .pcontainer {
            text-align: center;
        }

        .body-container {
            display: flex;
            align-items: center;
            justify-content: center;
            height: 20vh;
            overflow: hidden;
            margin: 0;
        }

        .progress-container {
            text-align: center;
            display: flex;
            justify-content: space-between;
            position: relative;
            margin-bottom: 30px;
            max-width: 100%;
            width: 1200px;
        }

            .progress-container::before {
                content: "" "";
                background-color: var(--line-border-empty);
                height: 4px;
                width: 100%;
                position: absolute;
                top: 50%;
                left: 0;
                transform: translateY(-50%);
                z-index: -1;
            }

        .progress {
            background-color: var(--line-b");
                WriteLiteral(@"order-fill);
            height: 4px;
            width: 34%;
            position: absolute;
            top: 50%;
            left: 0;
            transform: translateY(-50%);
            z-index: -1;
        }

        .circle {
            background-color: #fff;
            color: #999;
            border: 3px solid #999;
            border-radius: 50%;
            height: 90px;
            width: 90px;
            display: flex;
            align-items: center;
            justify-content: center;
        }

            .circle.active {
                border-color: var(--line-border-fill);
                color: var(--line-border-fill);
            }
    </style>

");
            }
            );
            WriteLiteral(@"



<div class=""container"">
    <main>
        <div class=""body-container"">
            <div class=""pcontainer"">
                <div class=""progress-container"">
                    <div class=""progress"" id=""progress""></div>
                    <div class=""circle active"">購物車</div>
                    <div class=""circle active"">訂單資料</div>
                    <div class=""circle"">訂單付款</div>
                    <div class=""circle"">完成訂單</div>
                </div>
            </div>
        </div>



        <h4>訂單資料</h4>
        <hr />
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05ed7bd90dddcdd0e31b492e9523803b7c5115997851", async() => {
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05ed7bd90dddcdd0e31b492e9523803b7c5115998121", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 98 "C:\Zona\try\prjFineFoodCore\Views\Order\Checkout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.ModelOnly;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            <input type=""hidden"" />
            <div class=""row"">
                <div class=""col-8"">
                    <div class=""card"">
                        <div class=""card-body"">
                            <h5 class=""card-title"">付款人資料</h5>
                            <div class=""form-group"">
                                <label class=""control-label"">付款人姓名</label>
                                <input readonly class=""form-control"" value=""楊曉華"" />
                            </div>
                            <div class=""form-group"">
                                <label class=""control-label"">付款人電話</label>
                                <input readonly class=""form-control"" value=""0921964758"" />
                            </div>
                        </div>
                    </div>
                    <p></p>
                    <div class=""card"">
                        <div class=""card-body"">
                            <h5 class=""card-title"">取件人資料</h5>
               ");
                WriteLiteral(@"             <div class=""row"">
                                <div class=""form-group col"">
                                    <label class=""control-label"">取件人姓名</label>
                                    <input class=""form-control"" value=""楊曉華"" />
                                    <span class=""text-danger""></span>
                                </div>
                                <div class=""form-group col"">
                                    <label class=""control-label"">取件人電話</label>
                                    <input class=""form-control"" value=""0921964758"" />
                                    <span class=""text-danger""></span>
                                </div>
                            </div>
                        </div>
                    </div>

                </div>
                <div class=""col-4"">
                    <div class=""card"" style=""background-color: #f8f9fa"">
                        <input type=""hidden"" />
                        <div class=""c");
                WriteLiteral(@"ard-body"">
                            <h5 class=""card-title"">訂單內容</h5>
                            <table class=""table table-borderless"">
                                <thead>
                                    <tr>
                                        <th>商品名稱</th>
                                        <th>小計</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 148 "C:\Zona\try\prjFineFoodCore\Views\Order\Checkout.cshtml"
                                      
                                        decimal total = 0;
                                        foreach (var item in Model)
                                        {
                                            total += item.小計;

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <tr>\r\n                                                <td>");
#nullable restore
#line 154 "C:\Zona\try\prjFineFoodCore\Views\Order\Checkout.cshtml"
                                               Write(item.food.FoodName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 155 "C:\Zona\try\prjFineFoodCore\Views\Order\Checkout.cshtml"
                                               Write(item.小計);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                            </tr>\r\n");
#nullable restore
#line 157 "C:\Zona\try\prjFineFoodCore\Views\Order\Checkout.cshtml"
                                        }
                                    

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                </tbody>
                            </table>
                            <hr />
                            <div class=""text-right"">
                                <input type=""hidden"" />
                                <p class=""card-text font-weight-bolder"" style=""padding-right:12px"">總計: $ ");
#nullable restore
#line 165 "C:\Zona\try\prjFineFoodCore\Views\Order\Checkout.cshtml"
                                                                                                    Write(total);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                            </div>
                            <p></p>
                            <div class=""text-center card-link"">
                                <button class=""btn btn-outline-dark""
                                        type=""button""");
                BeginWriteAttribute("onclick", "\r\n                                        onclick=\"", 6256, "\"", 6358, 3);
                WriteAttributeValue("", 6307, "location.href=\'", 6307, 15, true);
#nullable restore
#line 171 "C:\Zona\try\prjFineFoodCore\Views\Order\Checkout.cshtml"
WriteAttributeValue("", 6322, Url.Action("ReviewOrder", "Order"), 6322, 35, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 6357, "\'", 6357, 1, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    確認付款\r\n                                </button>\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05ed7bd90dddcdd0e31b492e9523803b7c51159915432", async() => {
                    WriteLiteral("<i class=\"fas fa-angle-left\"></i> 返回購物車");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
                WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <p></p>\r\n        \r\n    </main>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 188 "C:\Zona\try\prjFineFoodCore\Views\Order\Checkout.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<prjMVCCoreClass.Models.CShoppingCartItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
