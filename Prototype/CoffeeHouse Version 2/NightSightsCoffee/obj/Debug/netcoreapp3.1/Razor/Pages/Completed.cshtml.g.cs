#pragma checksum "C:\Users\Chest\Documents\GitHub\NightSightsCoffeeRoaster\Prototype\CoffeeHouse Version 2\NightSightsCoffee\Pages\Completed.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a4fd0ff62069c7740a2e0991fa1197c2fc87ba0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(NightSightsCoffee.Pages.Pages_Completed), @"mvc.1.0.razor-page", @"/Pages/Completed.cshtml")]
namespace NightSightsCoffee.Pages
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
#line 2 "C:\Users\Chest\Documents\GitHub\NightSightsCoffeeRoaster\Prototype\CoffeeHouse Version 2\NightSightsCoffee\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.RazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Chest\Documents\GitHub\NightSightsCoffeeRoaster\Prototype\CoffeeHouse Version 2\NightSightsCoffee\Pages\_ViewImports.cshtml"
using NightSightsCoffee.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Chest\Documents\GitHub\NightSightsCoffeeRoaster\Prototype\CoffeeHouse Version 2\NightSightsCoffee\Pages\_ViewImports.cshtml"
using NightSightsCoffee.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a4fd0ff62069c7740a2e0991fa1197c2fc87ba0", @"/Pages/Completed.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"302c2268afced131825f8e109cbf538cc8526b11", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Completed : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"    <!-- Navigation -->
    <nav class=""navbar navbar-expand-lg navbar-dark bg-dark fixed-top"">
        <div class=""container"">
            <a class=""navbar-brand"" href=""/"">Night Sights Coffee Roasters</a>
            <div class=""col-6 text-right"">
                <vc:cart-summary />
            </div>
            <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarResponsive"" aria-controls=""navbarResponsive"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                <span class=""navbar-toggler-icon""></span>
            </button>
            <div class=""collapse navbar-collapse"" id=""navbarResponsive"">
                <ul class=""navbar-nav ml-auto"">
                    <li class=""nav-item active"">
                        <a class=""nav-link"" href=""/"">
                            Home
                            <span class=""sr-only"">(current)</span>
                        </a>
                    </li>
                    <li class=""nav-item"">
 ");
            WriteLiteral(@"                       <a class=""nav-link"" href=""Cart"">Cart</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""Story"">Our Story</a>
                    </li>
                    <li class=""nav-item"">
                        <a class=""nav-link"" href=""Contact"">Contact Us</a>
                    </li>
                </ul>
            </div>
        </div>
    </nav>

    <div class=""text-center"">
        <img class=""img-responsive mt-4"" width=""100%"" src=""/lib/images/Thanks.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 1596, "\"", 1602, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <h2>Thanks!</h2>\r\n        <p>Thanks for placing order #");
#nullable restore
#line 37 "C:\Users\Chest\Documents\GitHub\NightSightsCoffeeRoaster\Prototype\CoffeeHouse Version 2\NightSightsCoffee\Pages\Completed.cshtml"
                                Write(OrderId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <p>We\'ll ship your goods as soon as possible.</p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a4fd0ff62069c7740a2e0991fa1197c2fc87ba06443", async() => {
                WriteLiteral("Return to Store");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\Chest\Documents\GitHub\NightSightsCoffeeRoaster\Prototype\CoffeeHouse Version 2\NightSightsCoffee\Pages\Completed.cshtml"
                
        [BindProperty(SupportsGet = true)]
        public string OrderId { get; set; }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Completed> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Completed> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Completed>)PageContext?.ViewData;
        public Pages_Completed Model => ViewData.Model;
    }
}
#pragma warning restore 1591
