#pragma checksum "E:\WorkStudy\Iti\Mvc\TaskTarq\OnlineShopping\OnlineShopping\Views\Product\GetFavourite.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06b9afbd758d996daf564679cc4cd77d28e4d2b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_GetFavourite), @"mvc.1.0.view", @"/Views/Product/GetFavourite.cshtml")]
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
#line 1 "E:\WorkStudy\Iti\Mvc\TaskTarq\OnlineShopping\OnlineShopping\Views\_ViewImports.cshtml"
using OnlineShopping;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\WorkStudy\Iti\Mvc\TaskTarq\OnlineShopping\OnlineShopping\Views\_ViewImports.cshtml"
using OnlineShopping.Persistence.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"06b9afbd758d996daf564679cc4cd77d28e4d2b4", @"/Views/Product/GetFavourite.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"927d08e84458342e0535e4e5b57d85e5143a4556", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_GetFavourite : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OnlineShopping.Core.DbEntities.MemberProductFavourite>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-ajax", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\WorkStudy\Iti\Mvc\TaskTarq\OnlineShopping\OnlineShopping\Views\Product\GetFavourite.cshtml"
  
    ViewData["Title"] = "GetFavouriteAsync";
    Layout = "~/Views/shared/_AccountLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\" id=\"products\">\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 9 "E:\WorkStudy\Iti\Mvc\TaskTarq\OnlineShopping\OnlineShopping\Views\Product\GetFavourite.cshtml"
         if (Model.Count() == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <br />\r\n            <h1 class=\"m-auto\" style=\"color:red\">No Favourite Items</h1>\r\n            <br />\r\n");
#nullable restore
#line 14 "E:\WorkStudy\Iti\Mvc\TaskTarq\OnlineShopping\OnlineShopping\Views\Product\GetFavourite.cshtml"
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "E:\WorkStudy\Iti\Mvc\TaskTarq\OnlineShopping\OnlineShopping\Views\Product\GetFavourite.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-md-6"">
                    <div class=""card mb-3"" style=""max-width: 540px;"">
                        <div class=""row no-gutters"">
                            <div class=""col-md-4 d-flex align-items-center"">
                                <img");
            BeginWriteAttribute("src", " src=\"", 777, "\"", 827, 1);
#nullable restore
#line 23 "E:\WorkStudy\Iti\Mvc\TaskTarq\OnlineShopping\OnlineShopping\Views\Product\GetFavourite.cshtml"
WriteAttributeValue("", 783, item.Product.ProductImages.ToList()[0].Path, 783, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img\">\r\n                            </div>\r\n                            <div class=\"col-md-8\">\r\n                                <div class=\"card-body\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06b9afbd758d996daf564679cc4cd77d28e4d2b46871", async() => {
                WriteLiteral("<h5 class=\"card-title\">");
#nullable restore
#line 27 "E:\WorkStudy\Iti\Mvc\TaskTarq\OnlineShopping\OnlineShopping\Views\Product\GetFavourite.cshtml"
                                                                                                                                      Write(item.Product.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 27 "E:\WorkStudy\Iti\Mvc\TaskTarq\OnlineShopping\OnlineShopping\Views\Product\GetFavourite.cshtml"
                                                                                       WriteLiteral(item.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    <p class=\"card-text\">");
#nullable restore
#line 28 "E:\WorkStudy\Iti\Mvc\TaskTarq\OnlineShopping\OnlineShopping\Views\Product\GetFavourite.cshtml"
                                                    Write(item.Product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <p class=\"card-text\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06b9afbd758d996daf564679cc4cd77d28e4d2b410153", async() => {
                WriteLiteral(@"
                                            <button type=""submit"" class=""btn btn-sm btn-danger d-none d-md-inline-block"" id=""deleteRecord"" onclick=""xxx()"">
                                                Delete
                                            </button>
                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "E:\WorkStudy\Iti\Mvc\TaskTarq\OnlineShopping\OnlineShopping\Views\Product\GetFavourite.cshtml"
                                                                    WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 41 "E:\WorkStudy\Iti\Mvc\TaskTarq\OnlineShopping\OnlineShopping\Views\Product\GetFavourite.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "E:\WorkStudy\Iti\Mvc\TaskTarq\OnlineShopping\OnlineShopping\Views\Product\GetFavourite.cshtml"
             
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Category", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 48 "E:\WorkStudy\Iti\Mvc\TaskTarq\OnlineShopping\OnlineShopping\Views\Product\GetFavourite.cshtml"
Write(Html.Partial("_Category", ViewBag.e as HomeViewModel));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"


    <script>
        //$(document).ready(function () {
        //    $(""#deleteRecord"").click(function (e) {

        //        //        $.ajax({
        //        //            url: form.action,
        //        //            type: 'Delete',
        //        //        }).done(function () {alert(""Deleted"")});

        //        //}).error(function () {
        //        //    alert(""Failed"")

        //    });
        //});
        function xxx() {

                 
                $.ajax({
                    type: ""Get"",
                    url: '");
#nullable restore
#line 70 "E:\WorkStudy\Iti\Mvc\TaskTarq\OnlineShopping\OnlineShopping\Views\Product\GetFavourite.cshtml"
                     Write(Url.Action("Delete"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\',\r\n                    dataType: \"json\",\r\n                    success: function () {\r\n                       \r\n");
#nullable restore
#line 74 "E:\WorkStudy\Iti\Mvc\TaskTarq\OnlineShopping\OnlineShopping\Views\Product\GetFavourite.cshtml"
                         if (Model.Count() == 0)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <br />\r\n            <h1 class=\"m-auto\" style=\"color:red\">No Favourite Items</h1>\r\n            <br />\r\n");
#nullable restore
#line 79 "E:\WorkStudy\Iti\Mvc\TaskTarq\OnlineShopping\OnlineShopping\Views\Product\GetFavourite.cshtml"
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 82 "E:\WorkStudy\Iti\Mvc\TaskTarq\OnlineShopping\OnlineShopping\Views\Product\GetFavourite.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                <div class=""col-md-6"">
                    <div class=""card mb-3"" style=""max-width: 540px;"">
                        <div class=""row no-gutters"">
                            <div class=""col-md-4 d-flex align-items-center"">
                                <img");
                BeginWriteAttribute("src", " src=\"", 3354, "\"", 3404, 1);
#nullable restore
#line 88 "E:\WorkStudy\Iti\Mvc\TaskTarq\OnlineShopping\OnlineShopping\Views\Product\GetFavourite.cshtml"
WriteAttributeValue("", 3360, item.Product.ProductImages.ToList()[0].Path, 3360, 44, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"card-img\">\r\n                            </div>\r\n                            <div class=\"col-md-8\">\r\n                                <div class=\"card-body\">\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06b9afbd758d996daf564679cc4cd77d28e4d2b417044", async() => {
                    WriteLiteral("<h5 class=\"card-title\">");
#nullable restore
#line 92 "E:\WorkStudy\Iti\Mvc\TaskTarq\OnlineShopping\OnlineShopping\Views\Product\GetFavourite.cshtml"
                                                                                                                                      Write(item.Product.Title);

#line default
#line hidden
#nullable disable
                    WriteLiteral("</h5>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 92 "E:\WorkStudy\Iti\Mvc\TaskTarq\OnlineShopping\OnlineShopping\Views\Product\GetFavourite.cshtml"
                                                                                       WriteLiteral(item.ProductId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    <p class=\"card-text\">");
#nullable restore
#line 93 "E:\WorkStudy\Iti\Mvc\TaskTarq\OnlineShopping\OnlineShopping\Views\Product\GetFavourite.cshtml"
                                                    Write(item.Product.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                    <p class=\"card-text\">\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06b9afbd758d996daf564679cc4cd77d28e4d2b420439", async() => {
                    WriteLiteral(@"
                                            <button type=""submit"" class=""btn btn-sm btn-danger d-none d-md-inline-block"" id=""deleteRecord"" onclick=""xxx()"">
                                                Delete
                                            </button>
                                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 95 "E:\WorkStudy\Iti\Mvc\TaskTarq\OnlineShopping\OnlineShopping\Views\Product\GetFavourite.cshtml"
                                                                    WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                    </p>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 106 "E:\WorkStudy\Iti\Mvc\TaskTarq\OnlineShopping\OnlineShopping\Views\Product\GetFavourite.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 106 "E:\WorkStudy\Iti\Mvc\TaskTarq\OnlineShopping\OnlineShopping\Views\Product\GetFavourite.cshtml"
             
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    },\r\n                    error: function () {\r\n\r\n                    }\r\n                });\r\n                  \r\n        }\r\n    </script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OnlineShopping.Core.DbEntities.MemberProductFavourite>> Html { get; private set; }
    }
}
#pragma warning restore 1591
