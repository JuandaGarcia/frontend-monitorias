#pragma checksum "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10b6e124b9274314ea93f086c1b05d4c41a55147"
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
#line 2 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\_Imports.razor"
using Frontend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\_Imports.razor"
using Frontend.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Login.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Login.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 9 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Login.razor"
 if(loadingToken) {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "\t<div></div>\r\n");
#nullable restore
#line 11 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Login.razor"
}else {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "main");
            __builder.AddAttribute(2, "class", "loginRegister");
            __builder.AddMarkupContent(3, "\r\n\t");
            __builder.OpenElement(4, "section");
            __builder.AddAttribute(5, "class", "loginRegister__formSection");
            __builder.AddMarkupContent(6, "\r\n\t\t<img class=\"loginRegister__logo\" src=\"/img/logo.png\" alt=\"Logo\">\r\n\t\t");
            __builder.OpenElement(7, "form");
            __builder.AddAttribute(8, "class", "loginRegister__form");
            __builder.AddAttribute(9, "action", true);
            __builder.AddMarkupContent(10, "\r\n\t\t\t");
            __builder.AddMarkupContent(11, "<h1 class=\"loginRegister__title\">Iniciar Sesión</h1>\r\n\t\t\t");
            __builder.OpenElement(12, "input");
            __builder.AddAttribute(13, "placeholder", "Correo");
            __builder.AddAttribute(14, "class", "loginRegister__input");
            __builder.AddAttribute(15, "type", "email");
            __builder.AddAttribute(16, "value", 
#nullable restore
#line 18 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Login.razor"
                                                                                          mail

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(17, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Login.razor"
                          OnEmailChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n\t\t\t");
            __builder.OpenElement(19, "input");
            __builder.AddAttribute(20, "placeholder", "Contraseña");
            __builder.AddAttribute(21, "class", "loginRegister__input");
            __builder.AddAttribute(22, "type", "password");
            __builder.AddAttribute(23, "value", 
#nullable restore
#line 20 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Login.razor"
                                                                                                 password

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(24, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Login.razor"
                          OnPasswordChanged

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n\t\t\t");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "class", "loginRegister__button");
            __builder.AddAttribute(28, "type", "button");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Login.razor"
                                                                           sendData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(30, "Iniciar Sesión");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n\t\t\t");
            __builder.AddMarkupContent(32, "<p class=\"loginRegister__question\">\r\n\t\t\t\t¿Aún no tienes cuenta?\r\n\t\t\t\t<a class=\"loginRegister__question__a\" href=\"/register\">\r\n\t\t\t\t\tRegístrate\r\n\t\t\t\t</a>\r\n\t\t\t</p>\r\n\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n\t");
            __builder.AddMarkupContent(35, @"<section class=""loginRegister__imageSection"">
		<h2 class=""loginRegister__imageSection__title"">
			Sistema de <br>
			monitorias
		</h2>
		<img class=""loginRegister__imageSection__img"" src=""/img/login-register/students.png"" alt=""Estudiantes"">
	</section>
");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n");
#nullable restore
#line 39 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Login.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Login.razor"
       
	private string mail;
	private string password;
	private string error;
	public bool loadingToken = true;

	public class responseData
	{
		public string token { get; set; }
		public string error { get; set; }
	}

	protected async override Task OnAfterRenderAsync(bool firstRender)    
	{
		if (firstRender)
    {
    var aux = await localStorage.GetItemAsync<string>("token");
				if(aux == null){
					loadingToken = false;
				}else{
					loadingToken = false;
					NavigationManager.NavigateTo("/monitorias");
				}
		}
		StateHasChanged();
	}

	private void OnPasswordChanged(ChangeEventArgs e)
	{
		password = e.Value.ToString();
	}
	private void OnEmailChanged(ChangeEventArgs e)
	{
		mail = e.Value.ToString();
	}

	private async Task sendData()
	{
		var postBody = new { mail = mail, password = password };
		var response = await Http.PostAsJsonAsync("http://localhost:8080/api/usuarios/login", postBody);

		var responseString = await response.Content.ReadFromJsonAsync<responseData>();

		if (responseString.error == "")
		{
			await localStorage.SetItemAsync("token", responseString.token);

			NavigationManager.NavigateTo("/monitorias");
		}
		else
		{
			error = responseString.error;
		}
	}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
