#pragma checksum "C:\Users\MSI PC\source\repos\FM\FM.Web\Pages\Users.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ebf7ad5f103ccdca6c3563e3b7e7e4265d385d5"
// <auto-generated/>
#pragma warning disable 1591
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
#line 4 "C:\Users\MSI PC\source\repos\FM\FM.Web\Pages\Users.razor"
using FM.DTOs;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/users")]
    public partial class Users : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row ");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-12 grid-margin");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card-body");
            __builder.AddMarkupContent(8, "<h4 class=\"card-title\">User List</h4>\r\n                ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "table-responsive");
            __builder.OpenElement(11, "table");
            __builder.AddAttribute(12, "class", "table");
            __builder.AddMarkupContent(13, @"<thead><tr><th> ID</th>
                                <th> Name</th>
                                <th> Surname</th>
                                <th> Email</th>
                                <th> Role</th>
                                <th>Setting</th></tr></thead>
                        ");
            __builder.OpenElement(14, "tbody");
#nullable restore
#line 28 "C:\Users\MSI PC\source\repos\FM\FM.Web\Pages\Users.razor"
                             foreach (var item in userList)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "tr");
            __builder.OpenElement(16, "td");
            __builder.OpenElement(17, "span");
            __builder.AddAttribute(18, "class", "pl-2");
            __builder.AddContent(19, 
#nullable restore
#line 33 "C:\Users\MSI PC\source\repos\FM\FM.Web\Pages\Users.razor"
                                                            item.ID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                                    ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 35 "C:\Users\MSI PC\source\repos\FM\FM.Web\Pages\Users.razor"
                                          item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                                    ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 36 "C:\Users\MSI PC\source\repos\FM\FM.Web\Pages\Users.razor"
                                          item.Surname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                                    ");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 37 "C:\Users\MSI PC\source\repos\FM\FM.Web\Pages\Users.razor"
                                          item.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                                    ");
            __builder.OpenElement(30, "td");
            __builder.AddContent(31, 
#nullable restore
#line 38 "C:\Users\MSI PC\source\repos\FM\FM.Web\Pages\Users.razor"
                                          item.RoleID

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n\r\n                                    ");
            __builder.AddMarkupContent(33, "<td><div class=\"badge badge-outline-success\">Edit</div>\r\n                                        <div class=\"badge badge-outline-danger\">Delete</div></td>");
            __builder.CloseElement();
#nullable restore
#line 45 "C:\Users\MSI PC\source\repos\FM\FM.Web\Pages\Users.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\Users\MSI PC\source\repos\FM\FM.Web\Pages\Users.razor"
       

    List<UserDto> userList = new List<UserDto>();
    protected async override Task OnInitializedAsync()
    {
       
         userList = await Http.GetFromJsonAsync<List<UserDto>>("User/GetAll");
    }
   


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationaManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
#pragma warning restore 1591
