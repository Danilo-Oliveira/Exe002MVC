#pragma checksum "/home/danilo/Documentos/Faculdade/Jose/Exercicios/Ex002/Views/Users/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb6cfcd940e3c088bd7d98625e5d145eb3e393df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_Details), @"mvc.1.0.view", @"/Views/Users/Details.cshtml")]
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
#line 1 "/home/danilo/Documentos/Faculdade/Jose/Exercicios/Ex002/Views/_ViewImports.cshtml"
using Ex002;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/danilo/Documentos/Faculdade/Jose/Exercicios/Ex002/Views/_ViewImports.cshtml"
using Ex002.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb6cfcd940e3c088bd7d98625e5d145eb3e393df", @"/Views/Users/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23259c87386f2cbf6058fdb276a55b6ecd717237", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ex002.Models.Users>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<strong>Nome: </strong>");
#nullable restore
#line 3 "/home/danilo/Documentos/Faculdade/Jose/Exercicios/Ex002/Views/Users/Details.cshtml"
                  Write(Model.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\n<strong>Você nasceu: </strong>");
#nullable restore
#line 4 "/home/danilo/Documentos/Faculdade/Jose/Exercicios/Ex002/Views/Users/Details.cshtml"
                         Write(Model.DataNascimento.ToString("dd/MM/yyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\n<strong>Sua Altura: </strong>");
#nullable restore
#line 5 "/home/danilo/Documentos/Faculdade/Jose/Exercicios/Ex002/Views/Users/Details.cshtml"
                        Write(Model.Altura);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\n<strong>Seu Peso: </strong>");
#nullable restore
#line 6 "/home/danilo/Documentos/Faculdade/Jose/Exercicios/Ex002/Views/Users/Details.cshtml"
                      Write(Model.Peso);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\n<strong>Dia da Semana: </strong>");
#nullable restore
#line 7 "/home/danilo/Documentos/Faculdade/Jose/Exercicios/Ex002/Views/Users/Details.cshtml"
                           Write(Model.DiaSemana);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\n<strong>Imc: </strong>");
#nullable restore
#line 8 "/home/danilo/Documentos/Faculdade/Jose/Exercicios/Ex002/Views/Users/Details.cshtml"
                 Write(String.Format("{0:0.00}",@Model.Imc));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<br>
<br>

      <pre>
***************************************************************
|    IMC          |          CATEGORIA                        |
|-------------------------------------------------------------|
| Até 18,5        |  Abaixo do peso                           |
| De  18,5 - 24,9 |  Saudável                                 |
| De  25,0 - 29,9 |  Sobrepeso                                |
| De  30,0 - 39,9 |  Obeso                                    |
| Acima de 40     |  Extremo ou alto risco de obesidade       |
***************************************************************
      </pre>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ex002.Models.Users> Html { get; private set; }
    }
}
#pragma warning restore 1591
