#pragma checksum "E:\jeden z ostatnich\VetSystemEngineer\VetSystemEngineer\Views\Role\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df24f38793613c20c87a279ac1041d1ede9eea4f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Role_Index), @"mvc.1.0.view", @"/Views/Role/Index.cshtml")]
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
#line 1 "E:\jeden z ostatnich\VetSystemEngineer\VetSystemEngineer\Views\_ViewImports.cshtml"
using VetSystemEngineer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\jeden z ostatnich\VetSystemEngineer\VetSystemEngineer\Views\_ViewImports.cshtml"
using VetSystemEngineer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\jeden z ostatnich\VetSystemEngineer\VetSystemEngineer\Views\_ViewImports.cshtml"
using VetSystemEngineer.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\jeden z ostatnich\VetSystemEngineer\VetSystemEngineer\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\jeden z ostatnich\VetSystemEngineer\VetSystemEngineer\Views\_ViewImports.cshtml"
using VetSystemEngineer.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df24f38793613c20c87a279ac1041d1ede9eea4f", @"/Views/Role/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b29eec520779ec3c8309d1f7432ef073c429e26e", @"/Views/_ViewImports.cshtml")]
    public class Views_Role_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Microsoft.AspNetCore.Identity.IdentityRole>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-lg  btn-primary float-left "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "E:\jeden z ostatnich\VetSystemEngineer\VetSystemEngineer\Views\Role\Index.cshtml"
  Layout = "_Layout";
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"box-cont  mx-1 mx-lg-5 mx-md-2 text-center\">\r\n        <div class=\"special\" style=\"padding-top:6rem\">\r\n            <span class=\"icon fas fa-user-friends\"></span>\r\n            <h1>Lista ról</h1>\r\n            \r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df24f38793613c20c87a279ac1041d1ede9eea4f4874", async() => {
                WriteLiteral("Dodaj rolę");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
           
            <table class=""table table-striped table-bordered pt-4"">
                <thead>
                    <tr>
                        <td style=""width:60%"">Id</td>
                        <td style=""width:40%"">Nazwa</td>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 20 "E:\jeden z ostatnich\VetSystemEngineer\VetSystemEngineer\Views\Role\Index.cshtml"
                     foreach (var role in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 23 "E:\jeden z ostatnich\VetSystemEngineer\VetSystemEngineer\Views\Role\Index.cshtml"
                           Write(role.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 24 "E:\jeden z ostatnich\VetSystemEngineer\VetSystemEngineer\Views\Role\Index.cshtml"
                           Write(role.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 26 "E:\jeden z ostatnich\VetSystemEngineer\VetSystemEngineer\Views\Role\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n\r\n           \r\n            </div></div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Microsoft.AspNetCore.Identity.IdentityRole>> Html { get; private set; }
    }
}
#pragma warning restore 1591
