#pragma checksum "C:\Users\MSI PC\source\repos\FM\FM.Web\Shared\NavMenuAdmin.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b478a9a8e7f73e8ea36e3d3a47dfb91531e84bd6"
// <auto-generated/>
#pragma warning disable 1591
namespace FM.Web.Shared
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
#line 2 "C:\Users\MSI PC\source\repos\FM\FM.Web\Shared\NavMenuAdmin.razor"
using FM.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\MSI PC\source\repos\FM\FM.Web\Shared\NavMenuAdmin.razor"
using FM.Web.Data;

#line default
#line hidden
#nullable disable
    public partial class NavMenuAdmin : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "sidebar sidebar-offcanvas");
            __builder.AddAttribute(2, "id", "sidebar");
            __builder.AddMarkupContent(3, "<div class=\"sidebar-brand-wrapper d-none d-lg-flex align-items-center justify-content-center fixed-top\"><a class=\"sidebar-brand brand-logo\" href=\"index.html\">FlatMate</a></div>\n\n    ");
            __builder.OpenElement(4, "ul");
            __builder.AddAttribute(5, "class", "nav");
            __builder.AddMarkupContent(6, "<li class=\"nav-item nav-category\"><span class=\"nav-link\">Navigation</span></li>\n        ");
            __builder.AddMarkupContent(7, "<li class=\"nav-item menu-items\"><a class=\"nav-link\" href=\"index.html\"><span class=\"menu-icon\"><i class=\"mdi mdi-speedometer\"></i></span>\n                <span class=\"menu-title\">Dashboard</span></a></li>\n        ");
            __builder.AddMarkupContent(8, @"<li class=""nav-item menu-items""><a class=""nav-link"" data-toggle=""collapse"" href=""#ui-basic"" aria-expanded=""false"" aria-controls=""ui-basic""><span class=""menu-icon""><i class=""mdi mdi-laptop""></i></span>
                <span class=""menu-title"">Manage Features</span>
                <i class=""menu-arrow""></i></a>
            <div class=""collapse"" id=""ui-basic""><ul class=""nav flex-column sub-menu""><li class=""nav-item""><a class=""nav-link"" href=""/facility"">Facilities</a></li>
                    <li class=""nav-item""><a class=""nav-link"" href=""/criteria"">Criterias</a></li>
                    <li class=""nav-item""><a class=""nav-link"" href=""pages/ui-features/typography.html"">Cities</a></li>
                    <li class=""nav-item""><a class=""nav-link"" href=""pages/ui-features/typography.html"">Districts</a></li></ul></div></li>
        ");
            __builder.AddMarkupContent(9, "<li class=\"nav-item menu-items\"><a class=\"nav-link\" href=\"pages/forms/basic_elements.html\"><span class=\"menu-icon\"><i class=\"mdi mdi-playlist-play\"></i></span>\n                <span class=\"menu-title\">Manage Users</span></a></li>\n        ");
            __builder.AddMarkupContent(10, "<li class=\"nav-item menu-items\"><a class=\"nav-link\" href=\"pages/tables/basic-table.html\"><span class=\"menu-icon\"><i class=\"mdi mdi-table-large\"></i></span>\n                <span class=\"menu-title\">Control Posts</span></a></li>\n        ");
            __builder.OpenElement(11, "li");
            __builder.AddAttribute(12, "class", "nav-item menu-items");
            __builder.AddMarkupContent(13, "<a class=\"nav-link\" href=\"pages/tables/basic-table.html\"><span class=\"menu-icon\"><i class=\"mdi mdi-table-large\"></i></span></a>\n            ");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 64 "C:\Users\MSI PC\source\repos\FM\FM.Web\Shared\NavMenuAdmin.razor"
                              Logout

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "style", "margin-top:20px;margin-left:10px");
            __builder.AddAttribute(17, "class", "btn btn-danger btn-fw");
            __builder.AddContent(18, "Logout");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 69 "C:\Users\MSI PC\source\repos\FM\FM.Web\Shared\NavMenuAdmin.razor"
        public async void Logout()
    {

        await sessionStorage.ClearAsync();
        navigationaManager.NavigateTo("/");
    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationaManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
