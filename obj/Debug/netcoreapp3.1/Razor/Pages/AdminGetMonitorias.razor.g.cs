#pragma checksum "C:\Users\Juand\Desktop\dotnet\monitorias-front\Pages\AdminGetMonitorias.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d042ea114076a3d5d960c473f8d911fd4566841b"
// <auto-generated/>
#pragma warning disable 1591
namespace TodoList.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
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
using TodoList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Juand\Desktop\dotnet\monitorias-front\_Imports.razor"
using TodoList.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Juand\Desktop\dotnet\monitorias-front\Pages\AdminGetMonitorias.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/monitorias")]
    public partial class AdminGetMonitorias : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "mainLayout");
            __builder.AddMarkupContent(2, "\r\n\t\t\t");
            __builder.AddMarkupContent(3, @"<div class=""mainLayout__navPanel"">
				<div class=""mainLayout__navPanel__user"">
					<img class=""mainLayout__navPanel__img"" src=""/img/perfil.svg"" alt=""Perfil"">
					<div>
						<span class=""mainLayout__navPanel__username"">Admin</span>
						<br>
						<span>USC</span>
					</div>
				</div>
				<nav class=""nav"">
					<ul class=""nav__ul"">
						<li>
							<a href=""/"" class=""nav__item active"">
								<span class=""nav__item__text"">Monitores</span>
							</a>
						</li>
						<li>
							<a href=""/"" class=""nav__item"">
								<span class=""nav__item__text"">Monitores</span>
							</a>
						</li>
						<li>
							<a href=""/"" class=""nav__item"">
								<span class=""nav__item__text--logOut"">Cerrar Sesión</span>
							</a>
						</li>
					</ul>
				</nav>
			</div>
			");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "mainLayout__container");
            __builder.AddMarkupContent(6, "\r\n\t\t\t\t");
            __builder.AddMarkupContent(7, @"<header class=""mainLayout__container__header"">
					<div class=""mainLayout__container__header__gradient"">
						<h1 class=""color-white"">Sistema de monitorías</h1>
						<span class=""color-white"">Universidad Santiago de Cali</span>
					</div>
				</header>
				");
            __builder.OpenElement(8, "main");
            __builder.AddMarkupContent(9, "\r\n\t\t\t\t");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "C:\Users\Juand\Desktop\dotnet\monitorias-front\Pages\AdminGetMonitorias.razor"
                                   getData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(12, "hola");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n\t\t");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\Users\Juand\Desktop\dotnet\monitorias-front\Pages\AdminGetMonitorias.razor"
                
    private Newtonsoft.Json.Linq.JArray _monitorias;

     protected override async Task OnInitializedAsync() { await getMonitorias(); }

    private async Task getMonitorias() => _monitorias = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(await
        Http.GetStringAsync("http://localhost:5000/api/monitorias/"));

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\Juand\Desktop\dotnet\monitorias-front\Pages\AdminGetMonitorias.razor"
       

  async void getData()
    {
        var response = await Http.GetStringAsync("http://localhost:8080/api/monitorias");

        Console.WriteLine(response);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
