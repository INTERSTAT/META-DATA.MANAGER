#pragma checksum "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DM_API_WS\Views\Wizard\Step03ExtAuthDb.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8748296c459699a46d31fc8661760bc0bb454f46"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Wizard_Step03ExtAuthDb), @"mvc.1.0.view", @"/Views/Wizard/Step03ExtAuthDb.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Wizard/Step03ExtAuthDb.cshtml", typeof(AspNetCore.Views_Wizard_Step03ExtAuthDb))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8748296c459699a46d31fc8661760bc0bb454f46", @"/Views/Wizard/Step03ExtAuthDb.cshtml")]
    public class Views_Wizard_Step03ExtAuthDb : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DM_API_WS.Wizard.Model.ConfigData>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Wizard/Step04ListMSDB"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Wizard/Start"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Wizard/Home"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 2 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DM_API_WS\Views\Wizard\Step03ExtAuthDb.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(83, 28, true);
            WriteLiteral("\r\n<h1>DM API Wizard</h1>\r\n\r\n");
            EndContext();
#line 8 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DM_API_WS\Views\Wizard\Step03ExtAuthDb.cshtml"
 using (Html.BeginForm("ExtendAuthDb", "Wizard", FormMethod.Post))
{
    //this is for create form tag
    

#line default
#line hidden
            BeginContext(222, 23, false);
#line 11 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DM_API_WS\Views\Wizard\Step03ExtAuthDb.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
#line 11 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DM_API_WS\Views\Wizard\Step03ExtAuthDb.cshtml"
                             // this is for prevent CSRF attack
    

#line default
#line hidden
            BeginContext(287, 28, false);
#line 12 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DM_API_WS\Views\Wizard\Step03ExtAuthDb.cshtml"
Write(Html.ValidationSummary(true));

#line default
#line hidden
            EndContext();
#line 12 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DM_API_WS\Views\Wizard\Step03ExtAuthDb.cshtml"
                                 
    if (@ViewBag.Message != null)
    {


#line default
#line hidden
            BeginContext(361, 56, true);
            WriteLiteral("        <div style=\"border:1px solid red\">\r\n            ");
            EndContext();
            BeginContext(418, 15, false);
#line 17 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DM_API_WS\Views\Wizard\Step03ExtAuthDb.cshtml"
       Write(ViewBag.Message);

#line default
#line hidden
            EndContext();
            BeginContext(433, 18, true);
            WriteLiteral("\r\n        </div>\r\n");
            EndContext();
#line 19 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DM_API_WS\Views\Wizard\Step03ExtAuthDb.cshtml"
    }


#line default
#line hidden
            BeginContext(460, 13, true);
            WriteLiteral("    <table>\r\n");
            EndContext();
#line 22 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DM_API_WS\Views\Wizard\Step03ExtAuthDb.cshtml"
         if (!string.IsNullOrWhiteSpace(ViewBag.MessageAuthDb))
        {

#line default
#line hidden
            BeginContext(549, 69, true);
            WriteLiteral("            <tr>\r\n                <td><span style=\"color: darkgreen\">");
            EndContext();
            BeginContext(619, 21, false);
#line 25 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DM_API_WS\Views\Wizard\Step03ExtAuthDb.cshtml"
                                              Write(ViewBag.MessageAuthDb);

#line default
#line hidden
            EndContext();
            BeginContext(640, 87, true);
            WriteLiteral("</span></td>\r\n                <td></td>\r\n                <td></td>\r\n            </tr>\r\n");
            EndContext();
#line 29 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DM_API_WS\Views\Wizard\Step03ExtAuthDb.cshtml"
        }

#line default
#line hidden
            BeginContext(738, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 31 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DM_API_WS\Views\Wizard\Step03ExtAuthDb.cshtml"
         if (Model.AuthDbExtInitialized)
        {

#line default
#line hidden
            BeginContext(793, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(805, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8748296c459699a46d31fc8661760bc0bb454f467522", async() => {
                BeginContext(839, 19, true);
                WriteLiteral("Check Mapping Store");
                EndContext();
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
            EndContext();
            BeginContext(862, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 34 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DM_API_WS\Views\Wizard\Step03ExtAuthDb.cshtml"
        }
        else
        {
            

#line default
#line hidden
#line 37 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DM_API_WS\Views\Wizard\Step03ExtAuthDb.cshtml"
             using (Html.BeginForm("ExtendAuthDb", "Wizard", FormMethod.Post))
            {

#line default
#line hidden
            BeginContext(995, 210, true);
            WriteLiteral("                <tr>\r\n                    <td>AuthDb need to be extended <input type=\"submit\" value=\"Extend AuthDb\" /></td>\r\n                    <td></td>\r\n                    <td></td>\r\n                </tr>\r\n");
            EndContext();
#line 44 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DM_API_WS\Views\Wizard\Step03ExtAuthDb.cshtml"

            }

#line default
#line hidden
#line 45 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DM_API_WS\Views\Wizard\Step03ExtAuthDb.cshtml"
             
        }

#line default
#line hidden
            BeginContext(1233, 14, true);
            WriteLiteral("    </table>\r\n");
            EndContext();
#line 48 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DM_API_WS\Views\Wizard\Step03ExtAuthDb.cshtml"
}

#line default
#line hidden
            BeginContext(1250, 16, true);
            WriteLiteral("<br />\r\n<br />\r\n");
            EndContext();
            BeginContext(1266, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8748296c459699a46d31fc8661760bc0bb454f4610280", async() => {
                BeginContext(1291, 13, true);
                WriteLiteral("Back to Login");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1308, 10, true);
            WriteLiteral("\r\n<br />\r\n");
            EndContext();
            BeginContext(1318, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8748296c459699a46d31fc8661760bc0bb454f4611592", async() => {
                BeginContext(1342, 12, true);
                WriteLiteral("Back to Home");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
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
