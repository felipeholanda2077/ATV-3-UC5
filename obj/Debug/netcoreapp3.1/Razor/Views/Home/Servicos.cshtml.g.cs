#pragma checksum "C:\Users\felip\OneDrive\Documentos\ATV-3 UC5\Views\Home\Servicos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6335d1a73f40d43a4f4a43327de3bfaec710b9f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Servicos), @"mvc.1.0.view", @"/Views/Home/Servicos.cshtml")]
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
#line 1 "C:\Users\felip\OneDrive\Documentos\ATV-3 UC5\Views\_ViewImports.cshtml"
using ATV_3_UC5;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6335d1a73f40d43a4f4a43327de3bfaec710b9f", @"/Views/Home/Servicos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd4809469311c0a07199ffb44d04aac312171eb3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Servicos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 3 "C:\Users\felip\OneDrive\Documentos\ATV-3 UC5\Views\Home\Servicos.cshtml"
  
    ViewData["Title"] = "Serviços";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 class=""titulo"">Conheça nossos serviços!</h1>

<div class=""serviços-container"">
    <div class=""serviço"">
        <div id=""vet"">
        </div>
        <div class=""serviço-descrição"">
            <h2>Atendimento Veterinário</h2>
            <h3>Agende um horário com um de nossos veterinários. Temos os melhores profissionais para garantir a saúde e bem estar do seu <span style=""color: yellow;"">Pet</span>!</h3>
            <button");
            BeginWriteAttribute("onclick", " onclick=\"", 494, "\"", 550, 3);
            WriteAttributeValue("", 504, "location.href=\'", 504, 15, true);
#nullable restore
#line 16 "C:\Users\felip\OneDrive\Documentos\ATV-3 UC5\Views\Home\Servicos.cshtml"
WriteAttributeValue("", 519, Url.Action("Contato", "Home"), 519, 30, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 549, "\'", 549, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary"">Agendar</button>
        </div>
    </div>

    <div class=""serviço"">
        <div class=""serviço-descrição"">
            <h2>Banho & Tosa</h2>
            <h3>O <span style=""color: yellow;"">Pet</span> está sujinho ou precisando de um novo penteado? Temos um salão de beleza exclusivo para o seu bichinho!</h3>
            <button");
            BeginWriteAttribute("onclick", " onclick=\"", 914, "\"", 970, 3);
            WriteAttributeValue("", 924, "location.href=\'", 924, 15, true);
#nullable restore
#line 24 "C:\Users\felip\OneDrive\Documentos\ATV-3 UC5\Views\Home\Servicos.cshtml"
WriteAttributeValue("", 939, Url.Action("Contato", "Home"), 939, 30, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 969, "\'", 969, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Agendar</button>\r\n        </div>\r\n        <div id=\"banho\">\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
