#pragma checksum "C:\Users\Luis\Documents\Senac\UC 07\Ativ2\projeto\Biblioteca\Views\Usuarios\ListaUsuarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "604d6278dbcabd5ffd0e077959109b97395642ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuarios_ListaUsuarios), @"mvc.1.0.view", @"/Views/Usuarios/ListaUsuarios.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Luis\Documents\Senac\UC 07\Ativ2\projeto\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Luis\Documents\Senac\UC 07\Ativ2\projeto\Biblioteca\Views\_ViewImports.cshtml"
using Biblioteca.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Luis\Documents\Senac\UC 07\Ativ2\projeto\Biblioteca\Views\Usuarios\ListaUsuarios.cshtml"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Luis\Documents\Senac\UC 07\Ativ2\projeto\Biblioteca\Views\Usuarios\ListaUsuarios.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Luis\Documents\Senac\UC 07\Ativ2\projeto\Biblioteca\Views\Usuarios\ListaUsuarios.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Luis\Documents\Senac\UC 07\Ativ2\projeto\Biblioteca\Views\Usuarios\ListaUsuarios.cshtml"
using System.Collections;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"604d6278dbcabd5ffd0e077959109b97395642ee", @"/Views/Usuarios/ListaUsuarios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ea07f0214da259abc315dec5bc842518e8ae187", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuarios_ListaUsuarios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("<h1>Usuários cadastrados no sistema</h1>\r\n\r\n<p class=\"text-danger\">");
#nullable restore
#line 9 "C:\Users\Luis\Documents\Senac\UC 07\Ativ2\projeto\Biblioteca\Views\Usuarios\ListaUsuarios.cshtml"
                  Write(ViewData["Mensagem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr >\r\n            <th scope=\"row\">Nome</th>\r\n            <th scope=\"row\">Login</th>\r\n            <th scope=\"row\">Tipo</th>\r\n        </tr>\r\n    </thead>\r\n\r\n    <tbody>\r\n");
#nullable restore
#line 21 "C:\Users\Luis\Documents\Senac\UC 07\Ativ2\projeto\Biblioteca\Views\Usuarios\ListaUsuarios.cshtml"
         foreach (Usuario u in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\Luis\Documents\Senac\UC 07\Ativ2\projeto\Biblioteca\Views\Usuarios\ListaUsuarios.cshtml"
           Write(u.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\Luis\Documents\Senac\UC 07\Ativ2\projeto\Biblioteca\Views\Usuarios\ListaUsuarios.cshtml"
           Write(u.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 26 "C:\Users\Luis\Documents\Senac\UC 07\Ativ2\projeto\Biblioteca\Views\Usuarios\ListaUsuarios.cshtml"
             if(u.Tipo==Usuario.ADMIN)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>Administrador</td>\r\n");
#nullable restore
#line 29 "C:\Users\Luis\Documents\Senac\UC 07\Ativ2\projeto\Biblioteca\Views\Usuarios\ListaUsuarios.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>Padrão</td>\r\n");
#nullable restore
#line 33 "C:\Users\Luis\Documents\Senac\UC 07\Ativ2\projeto\Biblioteca\Views\Usuarios\ListaUsuarios.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 782, "\"", 811, 2);
            WriteAttributeValue("", 789, "editarUsuario?id=", 789, 17, true);
#nullable restore
#line 35 "C:\Users\Luis\Documents\Senac\UC 07\Ativ2\projeto\Biblioteca\Views\Usuarios\ListaUsuarios.cshtml"
WriteAttributeValue("", 806, u.Id, 806, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">editar</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 848, "\"", 878, 2);
            WriteAttributeValue("", 855, "ExcluirUsuario?id=", 855, 18, true);
#nullable restore
#line 36 "C:\Users\Luis\Documents\Senac\UC 07\Ativ2\projeto\Biblioteca\Views\Usuarios\ListaUsuarios.cshtml"
WriteAttributeValue("", 873, u.Id, 873, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">excluir</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 38 "C:\Users\Luis\Documents\Senac\UC 07\Ativ2\projeto\Biblioteca\Views\Usuarios\ListaUsuarios.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<a href=\"RegistrarUsuarios\">Registrar novo usuário</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
