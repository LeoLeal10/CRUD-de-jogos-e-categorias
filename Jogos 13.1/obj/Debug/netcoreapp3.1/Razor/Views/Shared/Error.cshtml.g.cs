#pragma checksum "C:\Users\Leonardo\Desktop\Jogos\CRUD-de-jogos-e-categorias\Jogos 13.1\Views\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d5b1916efd1ce44dd76d0ade2bca18cc09af3a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Error), @"mvc.1.0.view", @"/Views/Shared/Error.cshtml")]
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
#line 1 "C:\Users\Leonardo\Desktop\Jogos\CRUD-de-jogos-e-categorias\Jogos 13.1\Views\_ViewImports.cshtml"
using Jogos_22._1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Leonardo\Desktop\Jogos\CRUD-de-jogos-e-categorias\Jogos 13.1\Views\_ViewImports.cshtml"
using Jogos_22._1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d5b1916efd1ce44dd76d0ade2bca18cc09af3a4", @"/Views/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65d51bb1eac4d4b8ce432065aaf778410d1a0af7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ErrorViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Leonardo\Desktop\Jogos\CRUD-de-jogos-e-categorias\Jogos 13.1\Views\Shared\Error.cshtml"
  
 ViewData["Title"] = "Erro";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2 class=\"text-danger\">Um erro ocorreu durante o processamento da sua requisição. </h2>\r\n<p>\r\n <strong>Detalhes do erro: </strong> <code> ");
#nullable restore
#line 7 "C:\Users\Leonardo\Desktop\Jogos\CRUD-de-jogos-e-categorias\Jogos 13.1\Views\Shared\Error.cshtml"
                                       Write(Model.Erro);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </code>\r\n</p>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ErrorViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591