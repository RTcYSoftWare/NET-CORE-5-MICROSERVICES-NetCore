#pragma checksum "C:\Users\turan\source\repos\NetCore5Microservices\OgrenciMvc\Views\Ogrenciler\Anasayfa.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9a7f1f486ce186ab74523f0d583d47960ec57fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ogrenciler_Anasayfa), @"mvc.1.0.view", @"/Views/Ogrenciler/Anasayfa.cshtml")]
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
#line 1 "C:\Users\turan\source\repos\NetCore5Microservices\OgrenciMvc\Views\_ViewImports.cshtml"
using OgrenciMvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\turan\source\repos\NetCore5Microservices\OgrenciMvc\Views\_ViewImports.cshtml"
using OgrenciMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9a7f1f486ce186ab74523f0d583d47960ec57fd", @"/Views/Ogrenciler/Anasayfa.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"069ba25ad7ea17f06bd610249945dd9936f2db52", @"/Views/_ViewImports.cshtml")]
    public class Views_Ogrenciler_Anasayfa : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OgrenciMvc.Models.Ogrenci>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/css/profil.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/css/icons.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\turan\source\repos\NetCore5Microservices\OgrenciMvc\Views\Ogrenciler\Anasayfa.cshtml"
   ViewData["Title"] = "Anasayfa";

    Layout = "~/Views/Shared/_LayoutYeni.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f9a7f1f486ce186ab74523f0d583d47960ec57fd4536", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n<link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css\">\n\n\n\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f9a7f1f486ce186ab74523f0d583d47960ec57fd5761", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n<div class=\"page-spacer\"></div>\n\n<div class=\"uk-container\">\n    <div class=\"flex gap-12\">\n        <div class=\"w-1/5 space-y-4 uk-visible@m\">\n            <div class=\"grid grid-cols-1 gap-1 ustmenu\">\n                <a");
            BeginWriteAttribute("href", " href=\"", 555, "\"", 594, 2);
            WriteAttributeValue("", 562, "/ogrenciler/Anasayfa/", 562, 21, true);
#nullable restore
#line 22 "C:\Users\turan\source\repos\NetCore5Microservices\OgrenciMvc\Views\Ogrenciler\Anasayfa.cshtml"
WriteAttributeValue("", 583, ViewBag.Id, 583, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"bg-gray-300 inline-block px-4 py-2 font-semibold rounded-md text-center text-gray-700 hover:text-gray-700 hover:bg-gray-400\">Anasayafa</a>\n                <a");
            BeginWriteAttribute("href", " href=\"", 760, "\"", 804, 2);
            WriteAttributeValue("", 767, "/ogrenciler/StajBasvurusu/", 767, 26, true);
#nullable restore
#line 23 "C:\Users\turan\source\repos\NetCore5Microservices\OgrenciMvc\Views\Ogrenciler\Anasayfa.cshtml"
WriteAttributeValue("", 793, ViewBag.Id, 793, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"bg-gray-300 inline-block px-4 py-2 font-semibold rounded-md text-center text-gray-700 hover:text-gray-700 hover:bg-gray-400\">Staj Ba??vurum</a>\n                <a");
            BeginWriteAttribute("href", " href=\"", 974, "\"", 1015, 2);
            WriteAttributeValue("", 981, "/ogrenciler/StajDurumu/", 981, 23, true);
#nullable restore
#line 24 "C:\Users\turan\source\repos\NetCore5Microservices\OgrenciMvc\Views\Ogrenciler\Anasayfa.cshtml"
WriteAttributeValue("", 1004, ViewBag.Id, 1004, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"bg-gray-300 inline-block px-4 py-2 font-semibold rounded-md text-center text-gray-700 hover:text-gray-700 hover:bg-gray-400\">G??ncel Staj Durumu</a>\n                <a");
            BeginWriteAttribute("href", " href=\"", 1190, "\"", 1230, 2);
            WriteAttributeValue("", 1197, "/ogrenciler/SoruCevap/", 1197, 22, true);
#nullable restore
#line 25 "C:\Users\turan\source\repos\NetCore5Microservices\OgrenciMvc\Views\Ogrenciler\Anasayfa.cshtml"
WriteAttributeValue("", 1219, ViewBag.Id, 1219, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""bg-gray-300 inline-block px-4 py-2 font-semibold rounded-md text-center text-gray-700 hover:text-gray-700 hover:bg-gray-400"">Sorular</a>
            </div>
        </div>
        <div class=""w-4/5"">

            <div class=""container"">
                <div class=""main-body"">

                    <div class=""row gutters-sm"">
                        <div class=""col-md-4 mb-3"">
                            <div class=""card"">
                                <div class=""card-body"">
                                    <div class=""d-flex flex-column align-items-center text-center"">
                                        <img src=""https://bootdey.com/img/Content/avatar/avatar7.png"" alt=""Admin"" class=""rounded-circle"" width=""150"">
                                        <div class=""mt-3"">
                                            <h4>");
#nullable restore
#line 40 "C:\Users\turan\source\repos\NetCore5Microservices\OgrenciMvc\Views\Ogrenciler\Anasayfa.cshtml"
                                           Write(Model.Adi);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 40 "C:\Users\turan\source\repos\NetCore5Microservices\OgrenciMvc\Views\Ogrenciler\Anasayfa.cshtml"
                                                      Write(Model.SoyAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
                                            <p class=""text-secondary mb-1"">RTcY Software Kurucu Ba??kan</p>
                                            <p class=""text-muted font-size-sm"">Bay Area, San Francisco, CA</p>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-md-8"">
                            <div class=""card mb-3"">
                                <div class=""card-body"">
                                    <div class=""row"">
                                        <div class=""col-sm-3"">
                                            <h6 class=""mb-0"">????renci No:</h6>
                                        </div>
                                        <div class=""col-sm-9 text-secondary"">
                                            171213049
                                        </div>
                             ");
            WriteLiteral(@"       </div>
                                    <hr>
                                    <div class=""row"">
                                        <div class=""col-sm-3"">
                                            <h6 class=""mb-0"">Ad?? Soyad??:</h6>
                                        </div>
                                        <div class=""col-sm-9 text-secondary"">
                                            ");
#nullable restore
#line 65 "C:\Users\turan\source\repos\NetCore5Microservices\OgrenciMvc\Views\Ogrenciler\Anasayfa.cshtml"
                                       Write(Model.Adi);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 65 "C:\Users\turan\source\repos\NetCore5Microservices\OgrenciMvc\Views\Ogrenciler\Anasayfa.cshtml"
                                                  Write(Model.SoyAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </div>
                                    </div>
                                    <hr>
                                    <div class=""row"">
                                        <div class=""col-sm-3"">
                                            <h6 class=""mb-0"">Fak??lte:</h6>
                                        </div>
                                        <div class=""col-sm-9 text-secondary"">
                                            M??HEND??SL??K VE DO??A B??L??MLER?? FAK??LTES??
                                        </div>
                                    </div>
                                    <hr>
                                    <div class=""row"">
                                        <div class=""col-sm-3"">
                                            <h6 class=""mb-0"">B??l??m:</h6>
                                        </div>
                                        <div class=""col-sm-9 text-secondary"">
                                            B");
            WriteLiteral(@"ilgisayar M??hendisli??i
                                        </div>
                                    </div>
                                    <hr>
                                    <div class=""row"">
                                        <div class=""col-sm-3"">
                                            <h6 class=""mb-0"">Eposta:</h6>
                                        </div>
                                        <div class=""col-sm-9 text-secondary"">
                                            ");
#nullable restore
#line 92 "C:\Users\turan\source\repos\NetCore5Microservices\OgrenciMvc\Views\Ogrenciler\Anasayfa.cshtml"
                                       Write(Model.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <div class=""row gutters-sm"">
                                <div class=""col-sm-6 mb-3"">
                                    <div class=""card h-100"">
                                        <div class=""card-body"">
                                            <h6 class=""d-flex align-items-center mb-3""><i class=""material-icons text-info mr-2"">Staj Durum Bilgisi</i></h6>
                                            <small>Staj Belge-1</small>
                                            <div class=""mb-3"" style=""height: 5px"">
");
#nullable restore
#line 105 "C:\Users\turan\source\repos\NetCore5Microservices\OgrenciMvc\Views\Ogrenciler\Anasayfa.cshtml"
                                                 if (Model.StajBasvuruFormu != null)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <a href=\"/ogrenciler/StajBasvurusu\" class=\"text-sm font-bold inline-block text-green-600\">Y??klendi</a>\n");
#nullable restore
#line 108 "C:\Users\turan\source\repos\NetCore5Microservices\OgrenciMvc\Views\Ogrenciler\Anasayfa.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <a href=\"/ogrenciler/StajBasvurusu\" class=\"text-sm font-bold inline-block text-red-600\">Y??klenmedi</a>\n");
#nullable restore
#line 112 "C:\Users\turan\source\repos\NetCore5Microservices\OgrenciMvc\Views\Ogrenciler\Anasayfa.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </div>\n                                            <small>Staj Belge-2</small>\n                                            <div class=\"mb-3\" style=\"height: 5px\">\n");
#nullable restore
#line 116 "C:\Users\turan\source\repos\NetCore5Microservices\OgrenciMvc\Views\Ogrenciler\Anasayfa.cshtml"
                                                 if (Model.StajSaglikFormu != null)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <a href=\"/ogrenciler/StajBasvurusu\" class=\"text-sm font-bold inline-block text-green-600\">Y??klendi</a>\n");
#nullable restore
#line 119 "C:\Users\turan\source\repos\NetCore5Microservices\OgrenciMvc\Views\Ogrenciler\Anasayfa.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <a href=\"/ogrenciler/StajBasvurusu\" class=\"text-sm font-bold inline-block text-red-600\">Y??klenmedi</a>\n");
#nullable restore
#line 123 "C:\Users\turan\source\repos\NetCore5Microservices\OgrenciMvc\Views\Ogrenciler\Anasayfa.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </div>\n                                            <small>Staj Belge-3</small>\n                                            <div class=\"mb-3\" style=\"height: 5px\">\n");
#nullable restore
#line 127 "C:\Users\turan\source\repos\NetCore5Microservices\OgrenciMvc\Views\Ogrenciler\Anasayfa.cshtml"
                                                 if (Model.StajUcertFormu != null)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <a href=\"/ogrenciler/StajBasvurusu\" class=\"text-sm font-bold inline-block text-green-600\">Y??klendi</a>\n");
#nullable restore
#line 130 "C:\Users\turan\source\repos\NetCore5Microservices\OgrenciMvc\Views\Ogrenciler\Anasayfa.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <a href=\"/ogrenciler/StajBasvurusu\" class=\"text-sm font-bold inline-block text-red-600\">Y??klenmedi</a>\n");
#nullable restore
#line 134 "C:\Users\turan\source\repos\NetCore5Microservices\OgrenciMvc\Views\Ogrenciler\Anasayfa.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class=""col-sm-6 mb-3"">
                                    <div class=""card h-100"">
                                        <div class=""card-body"">
                                            <h6 class=""d-flex align-items-center mb-3""><i class=""material-icons text-info mr-2"">Duyurular</i></h6>
                                            <a>Duyuru-1</a>
                                            <br>
                                            <small>Selam</small>
                                            <hr>
                                            <a>Duyuru-2</a>
                                            <br>
                                            <small>Melaba</small>
                                            <hr><a>Duyuru-3</a>
                                            <br>
 ");
            WriteLiteral(@"                                           <small>Deneme</small>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OgrenciMvc.Models.Ogrenci> Html { get; private set; }
    }
}
#pragma warning restore 1591
