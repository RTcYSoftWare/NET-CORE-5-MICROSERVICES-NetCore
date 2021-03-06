#pragma checksum "C:\Users\turan\source\repos\NetCore5Microservices\OgrenciMvc\Views\Akademisyenler\PuanGor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35b2f8fe593e1d5da1cb884bc31b1b22d34a40f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Akademisyenler_PuanGor), @"mvc.1.0.view", @"/Views/Akademisyenler/PuanGor.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35b2f8fe593e1d5da1cb884bc31b1b22d34a40f6", @"/Views/Akademisyenler/PuanGor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"069ba25ad7ea17f06bd610249945dd9936f2db52", @"/Views/_ViewImports.cshtml")]
    public class Views_Akademisyenler_PuanGor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ogrenci>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\turan\source\repos\NetCore5Microservices\OgrenciMvc\Views\Akademisyenler\PuanGor.cshtml"
  
    ViewData["Title"] = "PuanGor";
    Layout = "~/Views/Shared/_LayoutYeni.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"page-spacer\"></div>\r\n\r\n<div class=\"ml-5\">\r\n    <h1> ");
#nullable restore
#line 10 "C:\Users\turan\source\repos\NetCore5Microservices\OgrenciMvc\Views\Akademisyenler\PuanGor.cshtml"
    Write(Model.Adi);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 10 "C:\Users\turan\source\repos\NetCore5Microservices\OgrenciMvc\Views\Akademisyenler\PuanGor.cshtml"
               Write(Model.SoyAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Adl?? ????rencinizin Puan Durmu </h1>

    <p class=""text -lg"">
        ????rencilerinizin staj ??efleri taraf??nadan verilen puanlar??n?? g??rebilir, inceleyebilirsiniz.
    </p>

</div>


<div class=""page-spacer""></div>

<div>
    <hr />
</div>


<div class=""max-w-3xl m-auto py-10 px-4"">
    <div class=""bg-white lg:p-12 p-6 space-y-3"">
        <div>
            <label class=""mb-0""> DEVAM </label>
            <input readonly");
            BeginWriteAttribute("placeholder", " placeholder=\"", 640, "\"", 666, 1);
#nullable restore
#line 30 "C:\Users\turan\source\repos\NetCore5Microservices\OgrenciMvc\Views\Akademisyenler\PuanGor.cshtml"
WriteAttributeValue("", 654, Model.Devam, 654, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                   class=""bg-gray-200 inp_staj_sef_devam shadow-none border focus:border-blue-600 mt-2 outline-none px-3 py-2 rounded-md w-full"">
        </div>
        <div>
            <label class=""mb-0""> ??ALI??MA VE GAYRET </label>
            <input readonly");
            BeginWriteAttribute("placeholder", " placeholder=\"", 935, "\"", 971, 1);
#nullable restore
#line 35 "C:\Users\turan\source\repos\NetCore5Microservices\OgrenciMvc\Views\Akademisyenler\PuanGor.cshtml"
WriteAttributeValue("", 949, Model.CalismaVeGayret, 949, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                   class=""bg-gray-200 inp_staj_sef_gayret shadow-none border w-full px-3 py-2 rounded-md focus:border-blue-600 outline-none mt-2"">
        </div>
        <div>
            <label class=""mb-0""> ?????? VAKT??NDE VE TAM YAPMA </label>
            <input readonly");
            BeginWriteAttribute("placeholder", " placeholder=\"", 1249, "\"", 1289, 1);
#nullable restore
#line 40 "C:\Users\turan\source\repos\NetCore5Microservices\OgrenciMvc\Views\Akademisyenler\PuanGor.cshtml"
WriteAttributeValue("", 1263, Model.IsiVaktindeTamYapma, 1263, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                   class=""bg-gray-200 inp_staj_sef_is_vakti shadow-none border w-full px-3 py-2 rounded-md focus:border-blue-600 outline-none mt-2"">
        </div>
        <div>
            <label class=""mb-0""> TAVIR VE HAREKET (GENEL) </label>
            <input readonly");
            BeginWriteAttribute("placeholder", " placeholder=\"", 1568, "\"", 1606, 1);
#nullable restore
#line 45 "C:\Users\turan\source\repos\NetCore5Microservices\OgrenciMvc\Views\Akademisyenler\PuanGor.cshtml"
WriteAttributeValue("", 1582, Model.TavirHareketGenel, 1582, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                   class=""bg-gray-200 inp_staj_sef_tavir shadow-none border w-full px-3 py-2 rounded-md focus:border-blue-600 outline-none mt-2"">
        </div>
        <div>
            <label class=""mb-0""> TAVIR VE HAREKET (????????LERE VE ARKADA??LARA) </label>
            <input readonly");
            BeginWriteAttribute("placeholder", " placeholder=\"", 1900, "\"", 1942, 1);
#nullable restore
#line 50 "C:\Users\turan\source\repos\NetCore5Microservices\OgrenciMvc\Views\Akademisyenler\PuanGor.cshtml"
WriteAttributeValue("", 1914, Model.TavirHareketIsAkradas, 1914, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"
                   class=""bg-gray-200 inp_staj_sef_tavir2 shadow-none border w-full px-3 py-2 rounded-md focus:border-blue-600 outline-none mt-2"">
        </div>


        <button type=""button""
                class=""bg-blue-600 btn_akademisyenler_puan_gor_listeye_don font-semibold p-2 mt-2 rounded-md text-center text-green-600 text-white w-full"">
            Listeye D??n
        </button>
    </div>
</div>


<script>

    $(document).ready(function () {

        $("".btn_akademisyenler_puan_gor_listeye_don"").click(function () {

            window.location.href = ""/akademisyenler/StajDurum"";

        });



    })


</script>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ogrenci> Html { get; private set; }
    }
}
#pragma warning restore 1591
