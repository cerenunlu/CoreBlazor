#pragma checksum "C:\Users\MSI PC\source\repos\FM\FM.Web\Pages\SignIn.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bcd7db10f6295c34e87250517f238f2aa67e29d8"
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
#line 6 "C:\Users\MSI PC\source\repos\FM\FM.Web\Pages\SignIn.razor"
using FM.DTOs;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(NoLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/signin")]
    public partial class SignIn : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "html");
            __builder.AddAttribute(1, "lang", "en");
            __builder.AddAttribute(2, "class", "no-js");
            __builder.AddMarkupContent(3, @"<head><meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <title>Solid Template</title>
    <link href=""https://fonts.googleapis.com/css?family=IBM+Plex+Sans:400,600"" rel=""stylesheet"">

    <link href=""/solid/dist/css/style.css"" rel=""stylesheet""></head>
");
            __builder.OpenElement(4, "body");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "container-scroller");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "container-fluid page-body-wrapper full-page-wrapper");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "row w-100 m-0");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "content-wrapper full-page-wrapper d-flex align-items-center auth login-bg");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "card col-lg-4 mx-auto");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "card-body px-5 py-5");
            __builder.AddMarkupContent(17, "<h3 class=\"card-title text-left mb-3\">Login</h3>\r\n                            ");
            __builder.OpenElement(18, "div");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "form-group");
            __builder.AddMarkupContent(21, "<label>email *</label>\r\n                                    ");
            __builder.OpenElement(22, "input");
            __builder.AddAttribute(23, "type", "text");
            __builder.AddAttribute(24, "class", "form-control p_input");
            __builder.AddAttribute(25, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "C:\Users\MSI PC\source\repos\FM\FM.Web\Pages\SignIn.razor"
                                                        loginRequestDto.Email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => loginRequestDto.Email = __value, loginRequestDto.Email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                                ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "form-group");
            __builder.AddMarkupContent(30, "<label>Password *</label>\r\n                                    ");
            __builder.OpenElement(31, "input");
            __builder.AddAttribute(32, "type", "password");
            __builder.AddAttribute(33, "class", "form-control p_input");
            __builder.AddAttribute(34, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "C:\Users\MSI PC\source\repos\FM\FM.Web\Pages\SignIn.razor"
                                                        loginRequestDto.Password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => loginRequestDto.Password = __value, loginRequestDto.Password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n\r\n                                ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "text-center");
            __builder.OpenElement(39, "button");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\MSI PC\source\repos\FM\FM.Web\Pages\SignIn.razor"
                                                      LoginRequest

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "type", "submit");
            __builder.AddAttribute(42, "class", "btn btn-primary btn-block enter-btn");
            __builder.AddContent(43, "Login");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 39 "C:\Users\MSI PC\source\repos\FM\FM.Web\Pages\SignIn.razor"
                                 if (AlertLoginFail)
                                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(44, "<p class=\"text-danger\">Email or password is incorrect</p>");
#nullable restore
#line 42 "C:\Users\MSI PC\source\repos\FM\FM.Web\Pages\SignIn.razor"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\MSI PC\source\repos\FM\FM.Web\Pages\SignIn.razor"
                                 if (AlertLoginWarning)
                                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(45, "<p class=\"text-warning\">You must enter email and password</p>");
#nullable restore
#line 46 "C:\Users\MSI PC\source\repos\FM\FM.Web\Pages\SignIn.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(46, "<p class=\"sign-up\">Don\'t have an Account?<a href=\"#\"> Sign Up</a></p>");
            __builder.CloseElement();
            __builder.CloseElement();
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
#line 64 "C:\Users\MSI PC\source\repos\FM\FM.Web\Pages\SignIn.razor"
       
    bool AlertLoginFail { get; set; }
    bool AlertLoginWarning { get; set; }
    LoginRequestDto loginRequestDto = new LoginRequestDto();
    public async Task LoginRequest()
    {
        if (loginRequestDto.Email != null && loginRequestDto.Password != null)
        {
            var loginResponse = await Http.PostAsJsonAsync("User/Login", loginRequestDto);
            var responsestr = await loginResponse.Content.ReadFromJsonAsync<ApiResponseDto<LoginResponseDto>>();
            if (responsestr.IsSucces)
            {
                AlertLoginFail = false;
                Http.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", responsestr.Data.TokenID);
                await sessionStorage.SetItemAsync("ID", responsestr.Data.ID);
                await sessionStorage.SetItemAsync("Name", responsestr.Data.Name);
                await sessionStorage.SetItemAsync("Surname", responsestr.Data.Surname);
                await sessionStorage.SetItemAsync("RoleID", responsestr.Data.RoleID.ToString());

                
                navigationaManager.NavigateTo("/dashboard");
                AlertLoginWarning = false;
            }
            else
            {
                AlertLoginFail = true;
                this.StateHasChanged();
            }
        }
        else
        {
            AlertLoginWarning = true;
            this.StateHasChanged();

        }
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
