#pragma checksum "C:\Users\Juand\Desktop\segundo-parcial-dotnet\Parte 3 - Frontend\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4020519ba91547015636c96ae4e0d07ed8f9f846"
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
#line 2 "C:\Users\Juand\Desktop\segundo-parcial-dotnet\Parte 3 - Frontend\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Juand\Desktop\segundo-parcial-dotnet\Parte 3 - Frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Juand\Desktop\segundo-parcial-dotnet\Parte 3 - Frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Juand\Desktop\segundo-parcial-dotnet\Parte 3 - Frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Juand\Desktop\segundo-parcial-dotnet\Parte 3 - Frontend\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Juand\Desktop\segundo-parcial-dotnet\Parte 3 - Frontend\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Juand\Desktop\segundo-parcial-dotnet\Parte 3 - Frontend\_Imports.razor"
using Frontend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Juand\Desktop\segundo-parcial-dotnet\Parte 3 - Frontend\_Imports.razor"
using Frontend.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Juand\Desktop\segundo-parcial-dotnet\Parte 3 - Frontend\Pages\Login.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Juand\Desktop\segundo-parcial-dotnet\Parte 3 - Frontend\Pages\Login.razor"
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
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Users\Juand\Desktop\segundo-parcial-dotnet\Parte 3 - Frontend\Pages\Login.razor"
       
  private string email;
  private string password;
  private string error;

  public class responseData
    { 
        public string token { get; set; }
        public string error { get; set; }
    }

  private void OnPasswordChanged(ChangeEventArgs e)
    {
        password = e.Value.ToString();
    }
  private void OnEmailChanged(ChangeEventArgs e)
    {
        email = e.Value.ToString();
    }

  private async Task sendData()
    {
        var postBody = new { email = email, password = password };
        var response = await Http.PostAsJsonAsync("http://localhost:8080/api/users", postBody);

        var responseString = await response.Content.ReadFromJsonAsync<responseData>();
        if (responseString.token != null)
        {
            NavigationManager.NavigateTo("/store");
        }
        if (responseString.error != null)
        {
            error = responseString.error;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
