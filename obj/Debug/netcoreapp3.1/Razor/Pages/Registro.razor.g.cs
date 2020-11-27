#pragma checksum "C:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\Pages\Registro.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87f340bb3e73d9a1082045715dfa593b9bc8c248"
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
#line 2 "C:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\_Imports.razor"
using Frontend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\_Imports.razor"
using Frontend.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\Pages\Registro.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\Pages\Registro.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\Pages\Registro.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\Pages\Registro.razor"
using Newtonsoft.Json;

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
            __builder.AddMarkupContent(2, "\r\n\t");
            __builder.OpenElement(3, "section");
            __builder.AddAttribute(4, "class", "loginRegister__formSection");
            __builder.AddMarkupContent(5, "\r\n\t\t<img class=\"loginRegister__logo\" src=\"/img/logo.png\" alt=\"Logo\">\r\n\t\t");
            __builder.OpenElement(6, "form");
            __builder.AddAttribute(7, "class", "loginRegister__form");
            __builder.AddAttribute(8, "action", true);
            __builder.AddMarkupContent(9, "\r\n\t\t\t");
            __builder.AddMarkupContent(10, "<h1 class=\"loginRegister__title\">Registrarse</h1>\r\n\t\t\t");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "placeholder", "Nombre");
            __builder.AddAttribute(13, "class", "loginRegister__input");
            __builder.AddAttribute(14, "type", "text");
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\Pages\Registro.razor"
                                                                                        name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => name = __value, name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n\t\t\t");
            __builder.OpenElement(18, "input");
            __builder.AddAttribute(19, "placeholder", "Código");
            __builder.AddAttribute(20, "class", "loginRegister__input");
            __builder.AddAttribute(21, "type", "text");
            __builder.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\Pages\Registro.razor"
                                                                                        code

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => code = __value, code));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n\t\t\t");
            __builder.OpenElement(25, "select");
            __builder.AddAttribute(26, "class", "loginRegister__input");
            __builder.AddAttribute(27, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\Pages\Registro.razor"
                                                        career

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => career = __value, career));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(29, "\r\n\t\t\t\t");
            __builder.OpenElement(30, "option");
            __builder.AddAttribute(31, "selected", "selected");
            __builder.AddAttribute(32, "value", "Facultad");
            __builder.AddContent(33, "Facultad");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n\t\t\t\t");
            __builder.OpenElement(35, "option");
            __builder.AddAttribute(36, "value", "Facultad de Ciencias Básicas");
            __builder.AddMarkupContent(37, "Facultad de Ciencias Básicas");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n\t\t\t\t");
            __builder.OpenElement(39, "option");
            __builder.AddAttribute(40, "value", "Facultad de Ciencias Básicas");
            __builder.AddMarkupContent(41, "Facultad de Ciencias Básicas");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n\t\t\t\t");
            __builder.OpenElement(43, "option");
            __builder.AddAttribute(44, "value", "Facultad de Ciencias Económicas y Empresariales");
            __builder.AddMarkupContent(45, "Facultad de Ciencias Económicas y\r\n\t\t\t\t\tEmpresariales");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n\t\t\t\t");
            __builder.OpenElement(47, "option");
            __builder.AddAttribute(48, "value", "Facultad de Comunicación  y Publicidad");
            __builder.AddMarkupContent(49, "Facultad de Comunicación y Publicidad");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n\t\t\t\t");
            __builder.OpenElement(51, "option");
            __builder.AddAttribute(52, "value", "Facultad de Derecho");
            __builder.AddContent(53, "Facultad de Derecho");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n\t\t\t\t");
            __builder.OpenElement(55, "option");
            __builder.AddAttribute(56, "value", "Facultad de Educación");
            __builder.AddMarkupContent(57, "Facultad de Educación");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n\t\t\t\t");
            __builder.OpenElement(59, "option");
            __builder.AddAttribute(60, "value", "Facultad de Ingeniería");
            __builder.AddMarkupContent(61, "Facultad de Ingeniería");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n\t\t\t\t");
            __builder.OpenElement(63, "option");
            __builder.AddAttribute(64, "value", "Facultad de Salud");
            __builder.AddContent(65, "Facultad de Salud");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n\t\t\t");
            __builder.OpenElement(68, "input");
            __builder.AddAttribute(69, "placeholder", "Correo");
            __builder.AddAttribute(70, "class", "loginRegister__input");
            __builder.AddAttribute(71, "type", "email");
            __builder.AddAttribute(72, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "C:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\Pages\Registro.razor"
                                                                                         mail

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(73, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => mail = __value, mail));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n\t\t\t");
            __builder.OpenElement(75, "input");
            __builder.AddAttribute(76, "placeholder", "Contraseña");
            __builder.AddAttribute(77, "class", "loginRegister__input");
            __builder.AddAttribute(78, "type", "password");
            __builder.AddAttribute(79, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "C:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\Pages\Registro.razor"
                                                                                                password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(80, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n\t\t\t");
            __builder.OpenElement(82, "p");
            __builder.AddContent(83, 
#nullable restore
#line 31 "C:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\Pages\Registro.razor"
                _error

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n\r\n\t\t\t");
            __builder.OpenElement(85, "button");
            __builder.AddAttribute(86, "class", "loginRegister__button");
            __builder.AddAttribute(87, "type", "button");
            __builder.AddAttribute(88, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\Pages\Registro.razor"
                                                                           sendData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(89, "Registrarse");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n\t\t\t");
            __builder.AddMarkupContent(91, "<p class=\"loginRegister__question\">\r\n\t\t\t\t¿Ya tienes cuenta?\r\n\t\t\t\t<a class=\"loginRegister__question__a\" href=\"/login\"> Inicia Sesión </a>\r\n\t\t\t</p>\r\n\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n\t");
            __builder.AddMarkupContent(94, @"<section class=""loginRegister__imageSection--register"">
		<h2 class=""loginRegister__imageSection__title"">
			Sistema de <br>
			monitorías
		</h2>
		<img class=""loginRegister__imageSection__img--register"" src=""/img/login-register/students2.png"" alt=""Estudiantes"">
	</section>
");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\catic\Documents\proyectos\.Net\frontend-monitorias\Pages\Registro.razor"
       
	private string name;
	private string career;
	private string mail;
	private string code;
	private string id;
	private string password;

	private string _error = "";

	public class responseData
	{
		public string token { get; set; }
		public string error { get; set; }
	}

	private async void sendData()
	{
		var postBody = new { name = name, code = code, career = career, mail = mail, password = password, roll = 3 };


		var response = await Http.PostAsync("http://localhost:8080/api/usuarios/register/", new
			StringContent(JsonConvert.SerializeObject(postBody), Encoding.UTF8, "application/json"));

		var responseString = await response.Content.ReadFromJsonAsync<responseData>();




		if (responseString.error == "")
		{
			if (responseString.token != null)
			{
				await localStore.SetItemAsync("token", responseString.token);
				NavigationManager.NavigateTo("/monitorias");
			}
		}
		else
		{
			_error = responseString.error;
		}


	}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStore { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
