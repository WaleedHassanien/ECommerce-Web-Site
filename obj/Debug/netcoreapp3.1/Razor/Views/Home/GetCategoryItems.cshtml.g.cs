#pragma checksum "E:\WorkStudy\Iti\Mvc\TaskTarq\OnlineShopping\OnlineShopping\Views\Home\GetCategoryItems.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60fddcadb3728c98834b7211e18dd210ce35b0df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetCategoryItems), @"mvc.1.0.view", @"/Views/Home/GetCategoryItems.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60fddcadb3728c98834b7211e18dd210ce35b0df", @"/Views/Home/GetCategoryItems.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"927d08e84458342e0535e4e5b57d85e5143a4556", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetCategoryItems : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineShopping.Persistence.ViewModels.HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary m-auto btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color:#FF324D;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\WorkStudy\Iti\Mvc\TaskTarq\OnlineShopping\OnlineShopping\Views\Home\GetCategoryItems.cshtml"
  
    ViewData["Title"] = "GetCategoryItems";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "E:\WorkStudy\Iti\Mvc\TaskTarq\OnlineShopping\OnlineShopping\Views\Home\GetCategoryItems.cshtml"
 if (Model.products.Count() == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"m-auto font-weight-bolder \">No Items Found</div>\r\n");
#nullable restore
#line 11 "E:\WorkStudy\Iti\Mvc\TaskTarq\OnlineShopping\OnlineShopping\Views\Home\GetCategoryItems.cshtml"
}
else
{

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\WorkStudy\Iti\Mvc\TaskTarq\OnlineShopping\OnlineShopping\Views\Home\GetCategoryItems.cshtml"
     foreach (var item in Model.products)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-md-3\">\r\n\r\n            <div class=\"card w-100 m-2\" style=\"width: 18rem;\">\r\n                <img class=\"card-img-top card-img\" style=\"height:240px\"");
            BeginWriteAttribute("src", " src=\"", 457, "\"", 513, 1);
#nullable restore
#line 21 "E:\WorkStudy\Iti\Mvc\TaskTarq\OnlineShopping\OnlineShopping\Views\Home\GetCategoryItems.cshtml"
WriteAttributeValue("", 463, item.ProductImages.ToList().FirstOrDefault().Path, 463, 50, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\">\r\n                <div class=\"card-body\">\r\n                    <h5 class=\"card-title text-center\">");
#nullable restore
#line 23 "E:\WorkStudy\Iti\Mvc\TaskTarq\OnlineShopping\OnlineShopping\Views\Home\GetCategoryItems.cshtml"
                                                  Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    <p class=\"card-text\">\r\n                        Price : <span class=\"price\">");
#nullable restore
#line 25 "E:\WorkStudy\Iti\Mvc\TaskTarq\OnlineShopping\OnlineShopping\Views\Home\GetCategoryItems.cshtml"
                                               Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" $</span><br />\r\n                        Category : <span>");
#nullable restore
#line 26 "E:\WorkStudy\Iti\Mvc\TaskTarq\OnlineShopping\OnlineShopping\Views\Home\GetCategoryItems.cshtml"
                                    Write(item.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span><br />\r\n                        Brand : <span>");
#nullable restore
#line 27 "E:\WorkStudy\Iti\Mvc\TaskTarq\OnlineShopping\OnlineShopping\Views\Home\GetCategoryItems.cshtml"
                                 Write(item.Brand.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </p>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "60fddcadb3728c98834b7211e18dd210ce35b0df7673", async() => {
                WriteLiteral("Details");
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
#line 29 "E:\WorkStudy\Iti\Mvc\TaskTarq\OnlineShopping\OnlineShopping\Views\Home\GetCategoryItems.cshtml"
                                                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 33 "E:\WorkStudy\Iti\Mvc\TaskTarq\OnlineShopping\OnlineShopping\Views\Home\GetCategoryItems.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "E:\WorkStudy\Iti\Mvc\TaskTarq\OnlineShopping\OnlineShopping\Views\Home\GetCategoryItems.cshtml"
     
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n");
            DefineSection("Category", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 40 "E:\WorkStudy\Iti\Mvc\TaskTarq\OnlineShopping\OnlineShopping\Views\Home\GetCategoryItems.cshtml"
Write(Html.Partial("_Category"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Search", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 45 "E:\WorkStudy\Iti\Mvc\TaskTarq\OnlineShopping\OnlineShopping\Views\Home\GetCategoryItems.cshtml"
Write(Html.Partial("_Search"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            DefineSection("Brand", async() => {
                WriteLiteral("\r\n\r\n    ");
#nullable restore
#line 49 "E:\WorkStudy\Iti\Mvc\TaskTarq\OnlineShopping\OnlineShopping\Views\Home\GetCategoryItems.cshtml"
Write(Html.Partial("_Brand"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
            }
            );
            WriteLiteral("   ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineShopping.Persistence.ViewModels.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591