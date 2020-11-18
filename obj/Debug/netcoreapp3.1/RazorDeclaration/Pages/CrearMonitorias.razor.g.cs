#pragma checksum "C:\Users\Juand\Desktop\dotnet\monitorias-front\Pages\CrearMonitorias.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9fbad4fbabbdc914318249d08c6ea893145316a4"
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
#line 10 "C:\Users\Juand\Desktop\dotnet\monitorias-front\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Juand\Desktop\dotnet\monitorias-front\Pages\CrearMonitorias.razor"
using System.Net.Http;

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
#line 89 "C:\Users\Juand\Desktop\dotnet\monitorias-front\Pages\CrearMonitorias.razor"
       
  private string name;
  private string faculty;
  private string day;
  private DateTime init;
  private DateTime end;
  private string livingRoom;
  private string initialQuotas;
  private string description;
  private string[] students;
	public bool success = false;
	public bool error = false;

  private async Task sendData()
    {
			try
			{	
        var postBody = new { name = name, faculty = faculty, day= day, init= init.ToString(), end= end.ToString(), livingRoom= livingRoom, initialQuotas= initialQuotas, description= description, students=students};
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
