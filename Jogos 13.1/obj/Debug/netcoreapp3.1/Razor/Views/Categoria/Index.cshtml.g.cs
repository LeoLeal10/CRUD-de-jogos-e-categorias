#pragma checksum "C:\Users\Leonardo\Desktop\Portifólio\CRUD-de-jogos-e-categorias\Jogos 13.1\Views\Categoria\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "244d2f564c33f314481a80e59561a02b6bd212bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categoria_Index), @"mvc.1.0.view", @"/Views/Categoria/Index.cshtml")]
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
#line 1 "C:\Users\Leonardo\Desktop\Portifólio\CRUD-de-jogos-e-categorias\Jogos 13.1\Views\_ViewImports.cshtml"
using Jogos_22._1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Leonardo\Desktop\Portifólio\CRUD-de-jogos-e-categorias\Jogos 13.1\Views\_ViewImports.cshtml"
using Jogos_22._1.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Leonardo\Desktop\Portifólio\CRUD-de-jogos-e-categorias\Jogos 13.1\Views\Categoria\Index.cshtml"
using Jogos_26._1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"244d2f564c33f314481a80e59561a02b6bd212bc", @"/Views/Categoria/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65d51bb1eac4d4b8ce432065aaf778410d1a0af7", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Categoria_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CategoriaViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Leonardo\Desktop\Portifólio\CRUD-de-jogos-e-categorias\Jogos 13.1\Views\Categoria\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Lista de categorias</h2>

<a href=""/categoria/create"" class=""btn btn-primary"">Novo Registro</a>
<br />
<br />

<table class=""table table-responsive"">
    <tr>
        <th>Ações</th>
        <th>Id</th>
        <th>Descrição</th>
    </tr>

");
#nullable restore
#line 20 "C:\Users\Leonardo\Desktop\Portifólio\CRUD-de-jogos-e-categorias\Jogos 13.1\Views\Categoria\Index.cshtml"
     foreach (CategoriaViewModel c in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 476, "\"", 507, 2);
            WriteAttributeValue("", 483, "/categoria/Edit?id=", 483, 19, true);
#nullable restore
#line 24 "C:\Users\Leonardo\Desktop\Portifólio\CRUD-de-jogos-e-categorias\Jogos 13.1\Views\Categoria\Index.cshtml"
WriteAttributeValue("", 502, c.id, 502, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">Editar</a>\r\n                <br>\r\n                <br>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 604, "\"", 644, 3);
            WriteAttributeValue("", 611, "javascript:apagarCategoria(", 611, 27, true);
#nullable restore
#line 27 "C:\Users\Leonardo\Desktop\Portifólio\CRUD-de-jogos-e-categorias\Jogos 13.1\Views\Categoria\Index.cshtml"
WriteAttributeValue("", 638, c.id, 638, 5, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 643, ")", 643, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Apagar</a>\r\n            </td>\r\n            \r\n            <td>");
#nullable restore
#line 30 "C:\Users\Leonardo\Desktop\Portifólio\CRUD-de-jogos-e-categorias\Jogos 13.1\Views\Categoria\Index.cshtml"
           Write(c.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 31 "C:\Users\Leonardo\Desktop\Portifólio\CRUD-de-jogos-e-categorias\Jogos 13.1\Views\Categoria\Index.cshtml"
           Write(c.descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 33 "C:\Users\Leonardo\Desktop\Portifólio\CRUD-de-jogos-e-categorias\Jogos 13.1\Views\Categoria\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n<script>\r\n function apagarCategoria(id)\r\n {\r\n if (confirm(\'Confirma a exclusão do registro?\'))\r\n location.href = \'categoria/Delete?id=\' + id;\r\n }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CategoriaViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
