#pragma checksum "C:\Users\Amanda\Desktop\DODAWANIE PACJENTA\VetSystemEngineer\VetSystemEngineer\Views\Visit\MedicalDocumentation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f4ae34ce3ec408ed914ca89b191aa623e053ddf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Visit_MedicalDocumentation), @"mvc.1.0.view", @"/Views/Visit/MedicalDocumentation.cshtml")]
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
#line 1 "C:\Users\Amanda\Desktop\DODAWANIE PACJENTA\VetSystemEngineer\VetSystemEngineer\Views\_ViewImports.cshtml"
using VetSystemEngineer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Amanda\Desktop\DODAWANIE PACJENTA\VetSystemEngineer\VetSystemEngineer\Views\_ViewImports.cshtml"
using VetSystemEngineer.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Amanda\Desktop\DODAWANIE PACJENTA\VetSystemEngineer\VetSystemEngineer\Views\_ViewImports.cshtml"
using VetSystemEngineer.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Amanda\Desktop\DODAWANIE PACJENTA\VetSystemEngineer\VetSystemEngineer\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Amanda\Desktop\DODAWANIE PACJENTA\VetSystemEngineer\VetSystemEngineer\Views\_ViewImports.cshtml"
using VetSystemEngineer.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f4ae34ce3ec408ed914ca89b191aa623e053ddf", @"/Views/Visit/MedicalDocumentation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b29eec520779ec3c8309d1f7432ef073c429e26e", @"/Views/_ViewImports.cshtml")]
    public class Views_Visit_MedicalDocumentation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VetSystemEngineer.ViewModels.MedicalDocumentation>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Amanda\Desktop\DODAWANIE PACJENTA\VetSystemEngineer\VetSystemEngineer\Views\Visit\MedicalDocumentation.cshtml"
  
    ViewData["Title"] = "NewVisit";
    Layout = "_Layout";




#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""box-cont"">
    <div class=""container-fluid"">


        <div class=""row"">
            <div class=""col-sm-6"">
                <div class=""card"">
                    <div class=""card-header"">Dane właściciela</div>
                    <div class=""card-body"">
                        <table class=""table"">
                            <tbody>
                                <tr>
                                    <th>Imię</th>
                                    <td>");
#nullable restore
#line 23 "C:\Users\Amanda\Desktop\DODAWANIE PACJENTA\VetSystemEngineer\VetSystemEngineer\Views\Visit\MedicalDocumentation.cshtml"
                                   Write(Model.Owner.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                </tr>\r\n                                <tr>\r\n                                    <th>Nazwisko</th>\r\n                                    <td>");
#nullable restore
#line 28 "C:\Users\Amanda\Desktop\DODAWANIE PACJENTA\VetSystemEngineer\VetSystemEngineer\Views\Visit\MedicalDocumentation.cshtml"
                                   Write(Model.Owner.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                </tr>\r\n                                <tr>\r\n                                    <th>Email</th>\r\n                                    <td>");
#nullable restore
#line 33 "C:\Users\Amanda\Desktop\DODAWANIE PACJENTA\VetSystemEngineer\VetSystemEngineer\Views\Visit\MedicalDocumentation.cshtml"
                                   Write(Model.Owner.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                </tr>\r\n\r\n                                <tr>\r\n                                    <th>Numer telefonu</th>\r\n                                    <td>");
#nullable restore
#line 39 "C:\Users\Amanda\Desktop\DODAWANIE PACJENTA\VetSystemEngineer\VetSystemEngineer\Views\Visit\MedicalDocumentation.cshtml"
                                   Write(Model.Owner.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                </tr>\r\n                                <tr>\r\n                                    <th>Adres</th>\r\n                                    <td>");
#nullable restore
#line 44 "C:\Users\Amanda\Desktop\DODAWANIE PACJENTA\VetSystemEngineer\VetSystemEngineer\Views\Visit\MedicalDocumentation.cshtml"
                                   Write(Model.Owner.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>

                                </tr>
                            </tbody>
                        </table>

                    </div>
                </div>
            </div>



            <div class=""col-sm-6"">
                <div class=""card"">
                    <div class=""card-header"">Dane pacjenta</div>
                    <div class=""card-body"">
                        <table class=""table"">
                            <tbody>
                                <tr>
                                    <th>Imię</th>
                                    <td>");
#nullable restore
#line 64 "C:\Users\Amanda\Desktop\DODAWANIE PACJENTA\VetSystemEngineer\VetSystemEngineer\Views\Visit\MedicalDocumentation.cshtml"
                                   Write(Model.Pet.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                </tr>\r\n                                <tr>\r\n                                    <th>Płeć</th>\r\n                                    <td>");
#nullable restore
#line 69 "C:\Users\Amanda\Desktop\DODAWANIE PACJENTA\VetSystemEngineer\VetSystemEngineer\Views\Visit\MedicalDocumentation.cshtml"
                                   Write(Model.Pet.Sex);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                </tr>\r\n                                <tr>\r\n                                    <th>Data urodzenia</th>\r\n                                    <td>");
#nullable restore
#line 74 "C:\Users\Amanda\Desktop\DODAWANIE PACJENTA\VetSystemEngineer\VetSystemEngineer\Views\Visit\MedicalDocumentation.cshtml"
                                   Write(Convert.ToDateTime(Model.Pet.Age).ToString("MM/dd/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                </tr>\r\n                                <tr>\r\n                                    <th>Gatunek</th>\r\n                                    <td>");
#nullable restore
#line 79 "C:\Users\Amanda\Desktop\DODAWANIE PACJENTA\VetSystemEngineer\VetSystemEngineer\Views\Visit\MedicalDocumentation.cshtml"
                                   Write(Model.Pet.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                </tr>\r\n\r\n                                <tr>\r\n                                    <th>Rasa</th>\r\n                                    <td>");
#nullable restore
#line 85 "C:\Users\Amanda\Desktop\DODAWANIE PACJENTA\VetSystemEngineer\VetSystemEngineer\Views\Visit\MedicalDocumentation.cshtml"
                                   Write(Model.Pet.Breed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                </tr>\r\n\r\n                                <tr>\r\n                                    <th>Waga</th>\r\n                                    <td>");
#nullable restore
#line 91 "C:\Users\Amanda\Desktop\DODAWANIE PACJENTA\VetSystemEngineer\VetSystemEngineer\Views\Visit\MedicalDocumentation.cshtml"
                                   Write(Model.Pet.Weight);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" kg</td>

                                </tr>
                            </tbody>
                        </table>

                    </div>
                </div>
            </div>
        </div>

        <div class=""card"" style=""margin-top:2em"">
            <h5 class=""card-header text-center"">
                <a data-toggle=""collapse"" href=""#collapse-example"" aria-expanded=""true"" aria-controls=""collapse-example"" id=""heading-example"" class=""d-block"">
                    <i class=""fa fa-chevron-down pull-right ""></i>
                    Historia medyczna
                </a>
            </h5>
            <div id=""collapse-example"" class=""collapse show"" aria-labelledby=""heading-example"">
                <div class=""card-body"">
");
#nullable restore
#line 111 "C:\Users\Amanda\Desktop\DODAWANIE PACJENTA\VetSystemEngineer\VetSystemEngineer\Views\Visit\MedicalDocumentation.cshtml"
                     for (int i = 0; i < Model.medicalHistory.Count(); i++)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""card"" style=""margin-bottom:1em"">
                            <div class=""card-header "">
                                <div class=""row"">
                                    <div class=""col text-right"">
                                        <i class=""far fa-clock pr-1""></i> ");
#nullable restore
#line 118 "C:\Users\Amanda\Desktop\DODAWANIE PACJENTA\VetSystemEngineer\VetSystemEngineer\Views\Visit\MedicalDocumentation.cshtml"
                                                                     Write(Model.medicalHistory[i].DateVisit);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"col text-left\">\r\n                                        <i class=\"fas fa-user\"></i> ");
#nullable restore
#line 121 "C:\Users\Amanda\Desktop\DODAWANIE PACJENTA\VetSystemEngineer\VetSystemEngineer\Views\Visit\MedicalDocumentation.cshtml"
                                                               Write(Model.VetInfo[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 121 "C:\Users\Amanda\Desktop\DODAWANIE PACJENTA\VetSystemEngineer\VetSystemEngineer\Views\Visit\MedicalDocumentation.cshtml"
                                                                                      Write(Model.VetInfo[i].Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </div>
                                </div>
                            </div>

                            <div class=""card-body"">

                                <div class=""container-fluid"">
                                    <div class=""row"">
                                        <div class=""col text-center"">
                                            <h5 class=""card-title"">Powód przyjęcia</h5>
                                            ");
#nullable restore
#line 132 "C:\Users\Amanda\Desktop\DODAWANIE PACJENTA\VetSystemEngineer\VetSystemEngineer\Views\Visit\MedicalDocumentation.cshtml"
                                       Write(Model.medicalHistory[i].Purpose);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </div>\r\n                                        <div class=\"col text-center\">\r\n                                            <h5 class=\"card-title\"> Czynności</h5>\r\n\r\n                                            ");
#nullable restore
#line 137 "C:\Users\Amanda\Desktop\DODAWANIE PACJENTA\VetSystemEngineer\VetSystemEngineer\Views\Visit\MedicalDocumentation.cshtml"
                                       Write(Model.medicalHistory[i].DecrDisActions);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </div>\r\n                                    </div>\r\n\r\n\r\n                                </div>\r\n                            </div>\r\n\r\n                        </div>\r\n");
#nullable restore
#line 146 "C:\Users\Amanda\Desktop\DODAWANIE PACJENTA\VetSystemEngineer\VetSystemEngineer\Views\Visit\MedicalDocumentation.cshtml"


                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n\r\n\r\n    </div>\r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VetSystemEngineer.ViewModels.MedicalDocumentation> Html { get; private set; }
    }
}
#pragma warning restore 1591