#pragma checksum "C:\Users\Juand\Desktop\dotnet\monitorias-front\Pages\Monitorias.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de50b343470e31238adea0ac7a076eb64d6d98bc"
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
#nullable restore
#line 2 "C:\Users\Juand\Desktop\dotnet\monitorias-front\Pages\Monitorias.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Juand\Desktop\dotnet\monitorias-front\Pages\Monitorias.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/monitorias")]
    public partial class Monitorias : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "mainLayout");
            __builder.AddMarkupContent(2, "\r\n");
#nullable restore
#line 7 "C:\Users\Juand\Desktop\dotnet\monitorias-front\Pages\Monitorias.razor"
         if (modal == true){

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "\t\t\t");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "modal");
            __builder.AddMarkupContent(6, "\r\n\t\t\t\t\t");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "modal__container");
            __builder.AddMarkupContent(9, "\r\n\t\t\t\t\t\t");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\Juand\Desktop\dotnet\monitorias-front\Pages\Monitorias.razor"
                                          closeModal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "class", "modal__container__exit");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\t\t\t\t\t\t");
            __builder.AddMarkupContent(14, "<p>¿Quieres eliminar esta monitoria?</p>\r\n\t\t\t\t\t\t");
            __builder.OpenElement(15, "div");
            __builder.AddMarkupContent(16, "\r\n\t\t\t\t\t\t\t");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\Juand\Desktop\dotnet\monitorias-front\Pages\Monitorias.razor"
                                              closeModal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "class", "modal__container__button");
            __builder.AddMarkupContent(20, "\r\n\t\t\t\t\t\t\t\tCancelar\r\n\t\t\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n\t\t\t\t\t\t\t");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "class", "modal__container__button modal__container__button--red");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\Juand\Desktop\dotnet\monitorias-front\Pages\Monitorias.razor"
                                          eliminarMonitoria

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(25, "\r\n\t\t\t\t\t\t\t\tEliminar\r\n\t\t\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n\t\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n\t\t\t\t");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\Juand\Desktop\dotnet\monitorias-front\Pages\Monitorias.razor"
                               closeModal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "class", "modal__overlay");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n");
#nullable restore
#line 26 "C:\Users\Juand\Desktop\dotnet\monitorias-front\Pages\Monitorias.razor"
		}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(34, "\t\t\t");
            __builder.OpenComponent<Frontend.Shared.NavMenu>(35);
            __builder.CloseComponent();
            __builder.AddMarkupContent(36, "\r\n\t\t\t");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "mainLayout__container");
            __builder.AddMarkupContent(39, "\r\n\t\t\t\t");
            __builder.AddMarkupContent(40, @"<header class=""mainLayout__container__header"">
					<div class=""mainLayout__container__header__gradient"">
						<h1 class=""color-white"">Sistema de monitorias</h1>
						<span class=""color-white"">Universidad Santiago de Cali</span>
					</div>
				</header>
				");
            __builder.OpenElement(41, "main");
            __builder.AddMarkupContent(42, "\r\n\t\t\t\t\t");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "monitorias");
            __builder.AddMarkupContent(45, "\r\n\t\t\t\t\t");
            __builder.AddMarkupContent(46, "<a class=\"form-monitoria__button monitorias\" href=\"/nueva-monitoria\">Crear una monitoria</a>\r\n");
#nullable restore
#line 38 "C:\Users\Juand\Desktop\dotnet\monitorias-front\Pages\Monitorias.razor"
           if (loading == false){
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\Juand\Desktop\dotnet\monitorias-front\Pages\Monitorias.razor"
             foreach (var item in monitorias)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(47, "\t\t\t\t\t\t\t");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "monitorias__item");
            __builder.AddMarkupContent(50, "\r\n\t\t\t\t\t\t\t\t");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "monitorias__item__header");
            __builder.AddMarkupContent(53, "\r\n\t\t\t\t\t\t\t\t\t");
            __builder.OpenElement(54, "h2");
            __builder.AddContent(55, 
#nullable restore
#line 43 "C:\Users\Juand\Desktop\dotnet\monitorias-front\Pages\Monitorias.razor"
                                         item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n\t\t\t\t\t\t\t\t\t");
            __builder.OpenElement(57, "div");
            __builder.AddMarkupContent(58, "\r\n\t\t\t\t\t\t\t\t\t\t");
            __builder.OpenElement(59, "a");
            __builder.AddAttribute(60, "href", "/monitorias/" + (
#nullable restore
#line 45 "C:\Users\Juand\Desktop\dotnet\monitorias-front\Pages\Monitorias.razor"
                                                              item.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "class", "monitorias__item__button edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n\t\t\t\t\t\t\t\t\t\t");
            __builder.OpenElement(63, "button");
            __builder.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "C:\Users\Juand\Desktop\dotnet\monitorias-front\Pages\Monitorias.razor"
                                                            () => openModal(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(65, "class", "monitorias__item__button trash");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n\t\t\t\t\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n\t\t\t\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n\t\t\t\t\t\t\t\t<hr>\r\n              \t");
            __builder.AddContent(69, 
#nullable restore
#line 50 "C:\Users\Juand\Desktop\dotnet\monitorias-front\Pages\Monitorias.razor"
                   item.faculty

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(70, "\r\n\t\t\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n");
#nullable restore
#line 52 "C:\Users\Juand\Desktop\dotnet\monitorias-front\Pages\Monitorias.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\Juand\Desktop\dotnet\monitorias-front\Pages\Monitorias.razor"
             
          }else{

#line default
#line hidden
#nullable disable
            __builder.AddContent(72, "            ");
            __builder.AddMarkupContent(73, "<div>loading...</div>\r\n");
#nullable restore
#line 55 "C:\Users\Juand\Desktop\dotnet\monitorias-front\Pages\Monitorias.razor"
          }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(74, "\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n\t\t\t\t\r\n\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n\t\t");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "C:\Users\Juand\Desktop\dotnet\monitorias-front\Pages\Monitorias.razor"
       
  public bool loading = true;
  public bool modal = false;

  public string currentId = "";
	
	[CascadingParameter(Name="Token")]
  private string Token { get; set; }
	
  
  Monitoria[] monitorias { get; set; }

  private static readonly System.Text.Json.JsonSerializerOptions s_options = 
    new System.Text.Json.JsonSerializerOptions() 
  {
    PropertyNamingPolicy = System.Text.Json.JsonNamingPolicy.CamelCase,
    PropertyNameCaseInsensitive = true,
  };
  
  protected override async Task OnInitializedAsync()
    {
        var httpResponse = await Http.GetFromJsonAsync<Monitoria[]>("http://localhost:8080/api/monitorias", s_options);
        monitorias = httpResponse;
        loading = false;
    }

	private void openModal(string id)
    {
				currentId = id;
        modal = true;
    }
	private void closeModal()
    {
				currentId = "";
        modal = false;
    }

	private async Task eliminarMonitoria(){
		var httpResponse = await Http.DeleteAsync("http://localhost:8080/api/monitorias/"+currentId);
		monitorias = await httpResponse.Content.ReadFromJsonAsync<Monitoria[]>();
		closeModal();
	}

    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
