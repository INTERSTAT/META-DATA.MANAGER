#pragma checksum "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DMApiWs\Views\Wizard\Step05CheckAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ca2a20c5dcef64d87832f055f2bfa54633911b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Wizard_Step05CheckAll), @"mvc.1.0.view", @"/Views/Wizard/Step05CheckAll.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ca2a20c5dcef64d87832f055f2bfa54633911b9", @"/Views/Wizard/Step05CheckAll.cshtml")]
    public class Views_Wizard_Step05CheckAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DM_API_WS.Wizard.Model.ConfigData>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Wizard/Step04ListMSDB"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Wizard/Home"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DMApiWs\Views\Wizard\Step05CheckAll.cshtml"
  
    ViewData["Title"] = "Check Status";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Check Status</h1>\r\n\r\n<span style=\"color: darkgreen\">Authentication database is already initialized to version ");
#nullable restore
#line 8 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DMApiWs\Views\Wizard\Step05CheckAll.cshtml"
                                                                                    Write(Model.AuthDbVersion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n<br />\r\n<br />\r\n");
#nullable restore
#line 11 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DMApiWs\Views\Wizard\Step05CheckAll.cshtml"
 if (!Model.AuthDbExtInitialized && !string.IsNullOrWhiteSpace(ViewBag.MessageAuthDb))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span style=\"color: red\">");
#nullable restore
#line 13 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DMApiWs\Views\Wizard\Step05CheckAll.cshtml"
                        Write(ViewBag.MessageAuthDb);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <input type=\"submit\" value=\"Extend AuthDb\" /></span>\r\n");
#nullable restore
#line 14 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DMApiWs\Views\Wizard\Step05CheckAll.cshtml"
}
else if (!string.IsNullOrWhiteSpace(ViewBag.MessageAuthDb))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span style=\"color: darkgreen\">");
#nullable restore
#line 17 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DMApiWs\Views\Wizard\Step05CheckAll.cshtml"
                              Write(ViewBag.MessageAuthDb);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 18 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DMApiWs\Views\Wizard\Step05CheckAll.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<br />\r\n\r\n");
#nullable restore
#line 22 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DMApiWs\Views\Wizard\Step05CheckAll.cshtml"
 if (!Model.StatusSelectedMappingStore)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DMApiWs\Views\Wizard\Step05CheckAll.cshtml"
     using (Html.BeginForm("InizializeMSDB", "Wizard", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span style=\"color: red\">");
#nullable restore
#line 26 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DMApiWs\Views\Wizard\Step05CheckAll.cshtml"
                            Write(Model.StepMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 27 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DMApiWs\Views\Wizard\Step05CheckAll.cshtml"
         if (!Model.ErrorSelectedMappingStore)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <input type=\"submit\" value=\"Inizialize MSDB\" />\r\n");
#nullable restore
#line 30 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DMApiWs\Views\Wizard\Step05CheckAll.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DMApiWs\Views\Wizard\Step05CheckAll.cshtml"
         
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DMApiWs\Views\Wizard\Step05CheckAll.cshtml"
     
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span style=\"color: darkgreen\">Everything seems fine. Version: ");
#nullable restore
#line 35 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DMApiWs\Views\Wizard\Step05CheckAll.cshtml"
                                                              Write(Model.MappingStoreVersion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    <br />\r\n    <br />\r\n");
#nullable restore
#line 38 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DMApiWs\Views\Wizard\Step05CheckAll.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 40 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DMApiWs\Views\Wizard\Step05CheckAll.cshtml"
 if (!Model.StatusDDB.HasValue)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span style=\"color: red\">DDB not present in configuration</span>\r\n    <br />\r\n    <br />\r\n");
#nullable restore
#line 45 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DMApiWs\Views\Wizard\Step05CheckAll.cshtml"
}
else if (!Model.StatusDDB.Value)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DMApiWs\Views\Wizard\Step05CheckAll.cshtml"
     using (Html.BeginForm("InizializeDDB", "Wizard", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span style=\"color: red\">DDB initialization needed</span>\r\n");
#nullable restore
#line 51 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DMApiWs\Views\Wizard\Step05CheckAll.cshtml"
         if (!Model.ErrorDDB)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <input type=\"submit\" value=\"Inizialize DDB\" />\r\n");
#nullable restore
#line 54 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DMApiWs\Views\Wizard\Step05CheckAll.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span style=\"color: red\">: there are some problem to connect a database (check DDB connection string or see log error)</span>\r\n");
#nullable restore
#line 58 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DMApiWs\Views\Wizard\Step05CheckAll.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n        <br />\r\n");
#nullable restore
#line 61 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DMApiWs\Views\Wizard\Step05CheckAll.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DMApiWs\Views\Wizard\Step05CheckAll.cshtml"
     
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span style=\"color: darkgreen\">DDB is Initialized</span>\r\n    <br />\r\n    <br />\r\n");
#nullable restore
#line 68 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DMApiWs\Views\Wizard\Step05CheckAll.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 70 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DMApiWs\Views\Wizard\Step05CheckAll.cshtml"
 if (!Model.StatusRMDB.HasValue)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span style=\"color: red\">RMDB not present in configuration</span>\r\n    <br />\r\n    <br />\r\n");
#nullable restore
#line 75 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DMApiWs\Views\Wizard\Step05CheckAll.cshtml"
}
else if (!Model.StatusRMDB.Value)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DMApiWs\Views\Wizard\Step05CheckAll.cshtml"
     using (Html.BeginForm("InizializeRMDB", "Wizard", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span style=\"color: red\">RMDB initialization needed</span>\r\n");
#nullable restore
#line 81 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DMApiWs\Views\Wizard\Step05CheckAll.cshtml"
         if (!Model.ErrorRMDB)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <input type=\"submit\" value=\"Inizialize RMDB\" />\r\n");
#nullable restore
#line 84 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DMApiWs\Views\Wizard\Step05CheckAll.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <span style=\"color: red\">: there are some problem to connect a database (check RMDB connection string or see log error)</span>\r\n");
#nullable restore
#line 88 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DMApiWs\Views\Wizard\Step05CheckAll.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n        <br />\r\n");
#nullable restore
#line 91 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DMApiWs\Views\Wizard\Step05CheckAll.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DMApiWs\Views\Wizard\Step05CheckAll.cshtml"
     
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span style=\"color: darkgreen\">RMDB is Initialized</span>\r\n    <br />\r\n    <br />\r\n");
#nullable restore
#line 98 "C:\Users\f.pitto\Source\repos\sistan-hub\DM API WS\DMApiWs\Views\Wizard\Step05CheckAll.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ca2a20c5dcef64d87832f055f2bfa54633911b913081", async() => {
                WriteLiteral("Back to Check MSDB");
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
            WriteLiteral("\r\n<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ca2a20c5dcef64d87832f055f2bfa54633911b914179", async() => {
                WriteLiteral("Back to Home");
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
