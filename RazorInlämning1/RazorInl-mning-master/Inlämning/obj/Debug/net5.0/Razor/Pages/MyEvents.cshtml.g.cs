#pragma checksum "C:\Users\marti\Desktop\SenasteInlämning\RazorInlämning1\RazorInl-mning-master\Inlämning\Pages\MyEvents.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4d460ba95b65d82b31129c5406116a90a1d31c2"
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
#line 1 "C:\Users\marti\Desktop\SenasteInlämning\RazorInlämning1\RazorInl-mning-master\Inlämning\Pages\_ViewImports.cshtml"
using Inlämning;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4d460ba95b65d82b31129c5406116a90a1d31c2", @"/Pages/MyEvents.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fd1029528ac2091b44e8868412a34a6c70d375e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_MyEvents : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\marti\Desktop\SenasteInlämning\RazorInlämning1\RazorInl-mning-master\Inlämning\Pages\MyEvents.cshtml"
  
    ViewData["Title"] = "MyEvents";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>MyEvents</h1>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 15 "C:\Users\marti\Desktop\SenasteInlämning\RazorInlämning1\RazorInl-mning-master\Inlämning\Pages\MyEvents.cshtml"
           Write(Html.DisplayNameFor(model => model.Event[0].Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 18 "C:\Users\marti\Desktop\SenasteInlämning\RazorInlämning1\RazorInl-mning-master\Inlämning\Pages\MyEvents.cshtml"
           Write(Html.DisplayNameFor(model => model.Event[0].Place));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 21 "C:\Users\marti\Desktop\SenasteInlämning\RazorInlämning1\RazorInl-mning-master\Inlämning\Pages\MyEvents.cshtml"
           Write(Html.DisplayNameFor(model => model.Event[0].Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 24 "C:\Users\marti\Desktop\SenasteInlämning\RazorInlämning1\RazorInl-mning-master\Inlämning\Pages\MyEvents.cshtml"
           Write(Html.DisplayNameFor(model => model.Event[0].Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 27 "C:\Users\marti\Desktop\SenasteInlämning\RazorInlämning1\RazorInl-mning-master\Inlämning\Pages\MyEvents.cshtml"
           Write(Html.DisplayNameFor(model => model.Event[0].SpotsAvailable));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 33 "C:\Users\marti\Desktop\SenasteInlämning\RazorInlämning1\RazorInl-mning-master\Inlämning\Pages\MyEvents.cshtml"
         foreach (var item in Model.Event)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 37 "C:\Users\marti\Desktop\SenasteInlämning\RazorInlämning1\RazorInl-mning-master\Inlämning\Pages\MyEvents.cshtml"
               Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 40 "C:\Users\marti\Desktop\SenasteInlämning\RazorInlämning1\RazorInl-mning-master\Inlämning\Pages\MyEvents.cshtml"
               Write(Html.DisplayFor(modelItem => item.Place));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 43 "C:\Users\marti\Desktop\SenasteInlämning\RazorInlämning1\RazorInl-mning-master\Inlämning\Pages\MyEvents.cshtml"
               Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 46 "C:\Users\marti\Desktop\SenasteInlämning\RazorInlämning1\RazorInl-mning-master\Inlämning\Pages\MyEvents.cshtml"
               Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 49 "C:\Users\marti\Desktop\SenasteInlämning\RazorInlämning1\RazorInl-mning-master\Inlämning\Pages\MyEvents.cshtml"
               Write(Html.DisplayFor(modelItem => item.SpotsAvailable));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4d460ba95b65d82b31129c5406116a90a1d31c27753", async() => {
                WriteLiteral("\r\n                        <input hidden name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 1517, "\"", 1538, 1);
#nullable restore
#line 53 "C:\Users\marti\Desktop\SenasteInlämning\RazorInlämning1\RazorInl-mning-master\Inlämning\Pages\MyEvents.cshtml"
WriteAttributeValue("", 1525, item.EventID, 1525, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n                        <input type=\"submit\" value=\"Leave this event\" class=\"btn-primary\" />\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 59 "C:\Users\marti\Desktop\SenasteInlämning\RazorInlämning1\RazorInl-mning-master\Inlämning\Pages\MyEvents.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<h3>\r\n\r\n    ");
#nullable restore
#line 65 "C:\Users\marti\Desktop\SenasteInlämning\RazorInlämning1\RazorInl-mning-master\Inlämning\Pages\MyEvents.cshtml"
Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</h3>\r\n");
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
