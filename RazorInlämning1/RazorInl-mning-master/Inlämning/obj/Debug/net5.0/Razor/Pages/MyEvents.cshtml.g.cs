#pragma checksum "C:\Users\jojje\source\repos\ASPNETProjekt\RazorInlämning1\RazorInl-mning-master\Inlämning\Pages\MyEvents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "555b969f29e32123800d62720285926e1f90db5d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Inlämning.Pages.Pages_MyEvents), @"mvc.1.0.razor-page", @"/Pages/MyEvents.cshtml")]
namespace Inlämning.Pages
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
#line 1 "C:\Users\jojje\source\repos\ASPNETProjekt\RazorInlämning1\RazorInl-mning-master\Inlämning\Pages\_ViewImports.cshtml"
using Inlämning;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"555b969f29e32123800d62720285926e1f90db5d", @"/Pages/MyEvents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fd1029528ac2091b44e8868412a34a6c70d375e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MyEvents : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Events", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\jojje\source\repos\ASPNETProjekt\RazorInlämning1\RazorInl-mning-master\Inlämning\Pages\MyEvents.cshtml"
  
    ViewData["Title"] = "MyEvents";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>MyEvents</h1>\r\n");
#nullable restore
#line 9 "C:\Users\jojje\source\repos\ASPNETProjekt\RazorInlämning1\RazorInl-mning-master\Inlämning\Pages\MyEvents.cshtml"
 if (Model.Event == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p> You have no Events!</p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "555b969f29e32123800d62720285926e1f90db5d4532", async() => {
                WriteLiteral("Click here to Event");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\Users\jojje\source\repos\ASPNETProjekt\RazorInlämning1\RazorInl-mning-master\Inlämning\Pages\MyEvents.cshtml"
}
else if (Model.Event != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 20 "C:\Users\jojje\source\repos\ASPNETProjekt\RazorInlämning1\RazorInl-mning-master\Inlämning\Pages\MyEvents.cshtml"
               Write(Html.DisplayNameFor(model => model.Event[0].Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 23 "C:\Users\jojje\source\repos\ASPNETProjekt\RazorInlämning1\RazorInl-mning-master\Inlämning\Pages\MyEvents.cshtml"
               Write(Html.DisplayNameFor(model => model.Event[0].Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 26 "C:\Users\jojje\source\repos\ASPNETProjekt\RazorInlämning1\RazorInl-mning-master\Inlämning\Pages\MyEvents.cshtml"
               Write(Html.DisplayNameFor(model => model.Event[0].Organizer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 29 "C:\Users\jojje\source\repos\ASPNETProjekt\RazorInlämning1\RazorInl-mning-master\Inlämning\Pages\MyEvents.cshtml"
               Write(Html.DisplayNameFor(model => model.Event[0].Place));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 32 "C:\Users\jojje\source\repos\ASPNETProjekt\RazorInlämning1\RazorInl-mning-master\Inlämning\Pages\MyEvents.cshtml"
               Write(Html.DisplayNameFor(model => model.Event[0].Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 35 "C:\Users\jojje\source\repos\ASPNETProjekt\RazorInlämning1\RazorInl-mning-master\Inlämning\Pages\MyEvents.cshtml"
               Write(Html.DisplayNameFor(model => model.Event[0].Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 38 "C:\Users\jojje\source\repos\ASPNETProjekt\RazorInlämning1\RazorInl-mning-master\Inlämning\Pages\MyEvents.cshtml"
               Write(Html.DisplayNameFor(model => model.Event[0].SpotsAvailable));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 44 "C:\Users\jojje\source\repos\ASPNETProjekt\RazorInlämning1\RazorInl-mning-master\Inlämning\Pages\MyEvents.cshtml"
             foreach (var item in Model.Event)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 48 "C:\Users\jojje\source\repos\ASPNETProjekt\RazorInlämning1\RazorInl-mning-master\Inlämning\Pages\MyEvents.cshtml"
                   Write(Html.DisplayFor(model => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 51 "C:\Users\jojje\source\repos\ASPNETProjekt\RazorInlämning1\RazorInl-mning-master\Inlämning\Pages\MyEvents.cshtml"
                   Write(Html.DisplayFor(model => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 54 "C:\Users\jojje\source\repos\ASPNETProjekt\RazorInlämning1\RazorInl-mning-master\Inlämning\Pages\MyEvents.cshtml"
                   Write(Html.DisplayFor(model => item.Organizer.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 57 "C:\Users\jojje\source\repos\ASPNETProjekt\RazorInlämning1\RazorInl-mning-master\Inlämning\Pages\MyEvents.cshtml"
                   Write(Html.DisplayFor(model => item.Place));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 60 "C:\Users\jojje\source\repos\ASPNETProjekt\RazorInlämning1\RazorInl-mning-master\Inlämning\Pages\MyEvents.cshtml"
                   Write(Html.DisplayFor(model => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 63 "C:\Users\jojje\source\repos\ASPNETProjekt\RazorInlämning1\RazorInl-mning-master\Inlämning\Pages\MyEvents.cshtml"
                   Write(Html.DisplayFor(model => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 66 "C:\Users\jojje\source\repos\ASPNETProjekt\RazorInlämning1\RazorInl-mning-master\Inlämning\Pages\MyEvents.cshtml"
                   Write(Html.DisplayFor(model => item.SpotsAvailable));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 69 "C:\Users\jojje\source\repos\ASPNETProjekt\RazorInlämning1\RazorInl-mning-master\Inlämning\Pages\MyEvents.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 72 "C:\Users\jojje\source\repos\ASPNETProjekt\RazorInlämning1\RazorInl-mning-master\Inlämning\Pages\MyEvents.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Inlämning.Pages.MyEventsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Inlämning.Pages.MyEventsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Inlämning.Pages.MyEventsModel>)PageContext?.ViewData;
        public Inlämning.Pages.MyEventsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
