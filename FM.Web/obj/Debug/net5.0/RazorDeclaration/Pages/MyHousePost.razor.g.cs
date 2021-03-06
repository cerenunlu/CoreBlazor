// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FM.Web.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\MSI PC\source\repos\FM\FM.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MSI PC\source\repos\FM\FM.Web\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\MSI PC\source\repos\FM\FM.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\MSI PC\source\repos\FM\FM.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\MSI PC\source\repos\FM\FM.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\MSI PC\source\repos\FM\FM.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\MSI PC\source\repos\FM\FM.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\MSI PC\source\repos\FM\FM.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\MSI PC\source\repos\FM\FM.Web\_Imports.razor"
using FM.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\MSI PC\source\repos\FM\FM.Web\_Imports.razor"
using FM.Web.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\MSI PC\source\repos\FM\FM.Web\_Imports.razor"
using Blazored.SessionStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\MSI PC\source\repos\FM\FM.Web\Pages\MyHousePost.razor"
using FM.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\MSI PC\source\repos\FM\FM.Web\Pages\MyHousePost.razor"
using FM.Web.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/MyHousePost")]
    public partial class MyHousePost : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "C:\Users\MSI PC\source\repos\FM\FM.Web\Pages\MyHousePost.razor"
       
    List<HouseDto> houseDtos = new List<HouseDto>();
    public string ID;
    public string Message { get; set; }
    public bool alertMessage { get; set; }
    public bool post { get; set; }
    protected async override Task OnInitializedAsync()
    {
        ID = await sessionStorage.GetItemAsync<string>("ID");
        var houseResponse = await Http.GetFromJsonAsync<List<HouseDto>>("HousePost/GetHouseListByUserID/" + ID);

        if (houseResponse == null || !houseResponse.Any())
        {

            Message = "You have not any Post";
            alertMessage = true;
        }
        else
        {
            houseDtos = houseResponse;
            post = true;
        }


    }
    public async void CreateNewPost()
    {
        navigationaManager.NavigateTo("/NewPost");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationaManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
