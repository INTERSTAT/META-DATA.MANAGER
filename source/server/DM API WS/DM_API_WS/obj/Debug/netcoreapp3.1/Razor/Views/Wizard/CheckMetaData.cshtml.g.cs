#pragma checksum "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DM_API_WS\Views\Wizard\CheckMetaData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f31122f0b0baa6fc9eb49d3b259b089100639f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Wizard_CheckMetaData), @"mvc.1.0.view", @"/Views/Wizard/CheckMetaData.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f31122f0b0baa6fc9eb49d3b259b089100639f7", @"/Views/Wizard/CheckMetaData.cshtml")]
    public class Views_Wizard_CheckMetaData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DM_API_WS.Wizard.Model.ConfigData>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Wizard/Home"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DM_API_WS\Views\Wizard\CheckMetaData.cshtml"
  
    ViewData["Title"] = "Check";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Check MetaData API</h1>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DM_API_WS\Views\Wizard\CheckMetaData.cshtml"
 using (Html.BeginForm("CheckMetaData", "Wizard", FormMethod.Post))
{
    //this is for create form tag

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DM_API_WS\Views\Wizard\CheckMetaData.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DM_API_WS\Views\Wizard\CheckMetaData.cshtml"
                         // this is for prevent CSRF attack

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DM_API_WS\Views\Wizard\CheckMetaData.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DM_API_WS\Views\Wizard\CheckMetaData.cshtml"
                             
    if (@ViewBag.Message != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<div style=\"border:1px solid red\">\r\n    ");
#nullable restore
#line 16 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DM_API_WS\Views\Wizard\CheckMetaData.cshtml"
Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
#nullable restore
#line 18 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DM_API_WS\Views\Wizard\CheckMetaData.cshtml"
    }


#line default
#line hidden
#nullable disable
            WriteLiteral("<table>\r\n    <tr>\r\n        <td><span>METADATA API URL</span></td>\r\n        <td>");
#nullable restore
#line 23 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DM_API_WS\Views\Wizard\CheckMetaData.cshtml"
       Write(Html.TextBoxFor(a => a.MA, new { placeholder = "https://www.metamanager.ext:44375/", @class = "form-input", style = "width:500px;" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td></td>\r\n        <td>\r\n            <input type=\"submit\" value=\"Check\" />\r\n        </td>\r\n        <td></td>\r\n    </tr>\r\n</table>\r\n");
#nullable restore
#line 33 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DM_API_WS\Views\Wizard\CheckMetaData.cshtml"
    if (@ViewBag.MetadataAPIStatus != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<h3>Result:</h3>\r\n<div>\r\n    ");
#nullable restore
#line 37 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DM_API_WS\Views\Wizard\CheckMetaData.cshtml"
Write(ViewBag.MetadataAPIStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br /><br />\r\n    ");
#nullable restore
#line 39 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DM_API_WS\Views\Wizard\CheckMetaData.cshtml"
Write(ViewBag.MetadataAPIStatusMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
#nullable restore
#line 41 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DM_API_WS\Views\Wizard\CheckMetaData.cshtml"
    }
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<br /><br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9f31122f0b0baa6fc9eb49d3b259b089100639f76660", async() => {
                WriteLiteral("Back to Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DM_API_WS.Wizard.Model.ConfigData> Html { get; private set; }
    }
}
#pragma warning restore 1591
