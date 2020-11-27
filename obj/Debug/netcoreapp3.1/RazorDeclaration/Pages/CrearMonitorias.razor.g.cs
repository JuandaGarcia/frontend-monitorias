#pragma checksum "C:\Users\Juand\Desktop\dotnet\monitorias-front\Pages\CrearMonitorias.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2eaf57a811fc2fc11874d28f8db05ab4d240452"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Users\Juand\Desktop\dotnet\monitorias-front\Pages\CrearMonitorias.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Juand\Desktop\dotnet\monitorias-front\Pages\CrearMonitorias.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/nueva-monitoria")]
    public partial class CrearMonitorias : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 107 "C:\Users\Juand\Desktop\dotnet\monitorias-front\Pages\CrearMonitorias.razor"
       
  private string name;
  private string faculty;
  private string day;
  private DateTime init;
  private DateTime end;
  private string livingRoom;
  private string initialQuotas;
  private string description;
	bool loadingToken = true;
	Usuario usuario { get; set; }

string[] students =  new List<string>().ToArray();
	public bool success = false;
	public bool error = false;
	public bool loading = true;

	private static readonly System.Text.Json.JsonSerializerOptions s_options = 
    new System.Text.Json.JsonSerializerOptions() 
  {
    PropertyNamingPolicy = System.Text.Json.JsonNamingPolicy.CamelCase,
    PropertyNameCaseInsensitive = true,
  };

	protected async override Task OnAfterRenderAsync(bool firstRender)    
	{
		if (firstRender)
    {
  			var aux = await localStorage.GetItemAsync<string>("token");
				if(aux == null){
					loadingToken = false;
					NavigationManager.NavigateTo("/");
				}else{
					loadingToken = false;
					var httpResponseUser = await Http.GetFromJsonAsync<Usuario>("http://localhost:8080/api/usuarios/" + aux, s_options );
					usuario = httpResponseUser; 
					if (usuario.roll != 1)
					{
							NavigationManager.NavigateTo("/monitorias");
					}
        	loading = false;
				}
    }
		StateHasChanged();
	}

  private async Task sendData()
    {
			try
			{	

        var postBody = new { name = name, faculty = faculty, day= day, init= init.ToString(), end= end.ToString(), livingRoom= livingRoom, initialQuotas= initialQuotas, description= description, students=students, monitor=""};
        var response = await Http.PostAsJsonAsync("http://localhost:8080/api/monitorias", postBody);
				success = true;
			}
			catch (System.Exception)
			{
					error = true;
			}
	
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
