#pragma checksum "C:\Users\Juand\Desktop\dotnet\monitorias-front\Pages\Registro.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1a8b611d295cddc344d1751333dd9541095af16"
// <auto-generated/>
#pragma warning disable 1591
namespace Frontend.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Juand\Desktop\dotnet\monitorias-front\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Juand\Desktop\dotnet\monitorias-front\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Juand\Desktop\dotnet\monitorias-front\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Juand\Desktop\dotnet\monitorias-front\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Juand\Desktop\dotnet\monitorias-front\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Juand\Desktop\dotnet\monitorias-front\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Juand\Desktop\dotnet\monitorias-front\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Juand\Desktop\dotnet\monitorias-front\_Imports.razor"
using Frontend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Juand\Desktop\dotnet\monitorias-front\_Imports.razor"
using Frontend.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Juand\Desktop\dotnet\monitorias-front\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/register")]
    public partial class Registro : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "main");
            __builder.AddAttribute(1, "class", "loginRegister");
            __builder.AddMarkupContent(2, "\r\n\t\t\t");
            __builder.OpenElement(3, "section");
            __builder.AddAttribute(4, "class", "loginRegister__formSection");
            __builder.AddMarkupContent(5, "\r\n\t\t\t\t<img class=\"loginRegister__logo\" src=\"/img/logo.png\" alt=\"Logo\">\r\n\t\t\t\t");
            __builder.OpenElement(6, "form");
            __builder.AddAttribute(7, "class", "loginRegister__form");
            __builder.AddAttribute(8, "action", true);
            __builder.AddMarkupContent(9, "\r\n\t\t\t\t\t");
            __builder.AddMarkupContent(10, "<h1 class=\"loginRegister__title\">Registrarse</h1>\r\n\t\t\t\t\t<input placeholder=\"Correo\" class=\"loginRegister__input\" type=\"email\">\r\n\t\t\t\t\t<input placeholder=\"Contraseña\" class=\"loginRegister__input\" type=\"password\">\r\n\t\t\t\t\t");
            __builder.OpenElement(11, "select");
            __builder.AddAttribute(12, "class", "loginRegister__input");
            __builder.AddAttribute(13, "name", true);
            __builder.AddAttribute(14, "id", true);
            __builder.AddMarkupContent(15, "\r\n\t\t\t\t\t\t");
            __builder.OpenElement(16, "option");
            __builder.AddAttribute(17, "value", "f");
            __builder.AddContent(18, "G");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n\t\t\t\t\t\t");
            __builder.OpenElement(20, "option");
            __builder.AddAttribute(21, "value", "f");
            __builder.AddContent(22, "G");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n\t\t\t\t\t\t");
            __builder.OpenElement(24, "option");
            __builder.AddAttribute(25, "value", "f");
            __builder.AddContent(26, "G");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n\t\t\t\t\t");
            __builder.AddMarkupContent(29, "<button class=\"loginRegister__button\">Registrarse</button>\r\n\t\t\t\t\t");
            __builder.AddMarkupContent(30, "<p class=\"loginRegister__question\">\r\n\t\t\t\t\t\t¿Ya tienes cuenta?\r\n\t\t\t\t\t\t<a class=\"loginRegister__question__a\" href=\"/login\"> Inicia Sesión </a>\r\n\t\t\t\t\t</p>\r\n\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n\t\t\t");
            __builder.AddMarkupContent(33, @"<section class=""loginRegister__imageSection--register"">
				<h2 class=""loginRegister__imageSection__title"">
					Sistema de <br>
					monitorias
				</h2>
				<img class=""loginRegister__imageSection__img--register"" src=""/img/login-register/students2.png"" alt=""Estudiantes"">
			</section>
		");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
