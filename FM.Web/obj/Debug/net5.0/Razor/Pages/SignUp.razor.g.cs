#pragma checksum "C:\Users\MSI PC\source\repos\FM\FM.Web\Pages\SignUp.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11958d044ee8047ed675368606826e5a98399f1e"
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
#line 4 "C:\Users\MSI PC\source\repos\FM\FM.Web\Pages\SignUp.razor"
using FM.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\MSI PC\source\repos\FM\FM.Web\Pages\SignUp.razor"
using FM.Web.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(NoLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/signup")]
    public partial class SignUp : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<head><meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <title>Solid Template</title>
    <link href=""https://fonts.googleapis.com/css?family=IBM+Plex+Sans:400,600"" rel=""stylesheet"">

    <link href=""/solid/dist/css/style.css"" rel=""stylesheet""></head>
");
            __builder.OpenElement(1, "html");
            __builder.AddAttribute(2, "lang", "en");
            __builder.AddAttribute(3, "class", "no-js");
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
            __builder.AddAttribute(16, "class", "card-body px-2 py-2");
            __builder.AddMarkupContent(17, "<h3 class=\"card-title text-left mb-3  ml-3\" style=\"font-size:25px\">Register</h3>\r\n                            ");
            __builder.OpenElement(18, "div");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "form-group");
            __builder.AddMarkupContent(21, "<label style=\"font-size:15px\" class=\"ml-3\">Name</label>\r\n                                    ");
            __builder.OpenElement(22, "input");
            __builder.AddAttribute(23, "type", "text");
            __builder.AddAttribute(24, "class", "form-control p_input ml-3");
            __builder.AddAttribute(25, "style", "height:25px;width:300px");
            __builder.AddAttribute(26, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "C:\Users\MSI PC\source\repos\FM\FM.Web\Pages\SignUp.razor"
                                                         user.Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.Name = __value, user.Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                                ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "form-group");
            __builder.AddMarkupContent(31, "<label style=\"font-size:15px\" class=\"ml-3\">Surname</label>\r\n                                    ");
            __builder.OpenElement(32, "input");
            __builder.AddAttribute(33, "type", "text");
            __builder.AddAttribute(34, "class", "form-control p_input ml-3");
            __builder.AddAttribute(35, "style", "height:25px;width:300px");
            __builder.AddAttribute(36, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 36 "C:\Users\MSI PC\source\repos\FM\FM.Web\Pages\SignUp.razor"
                                                         user.Surname

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(37, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.Surname = __value, user.Surname));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                                ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "form-group");
            __builder.AddMarkupContent(41, "<label style=\"font-size:15px\" class=\"ml-3\">Email</label>\r\n                                    ");
            __builder.OpenElement(42, "input");
            __builder.AddAttribute(43, "type", "email");
            __builder.AddAttribute(44, "class", "form-control p_input ml-3");
            __builder.AddAttribute(45, "style", "height:25px;width:300px");
            __builder.AddAttribute(46, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 40 "C:\Users\MSI PC\source\repos\FM\FM.Web\Pages\SignUp.razor"
                                                         user.Email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.Email = __value, user.Email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                                ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", "form-group");
            __builder.AddMarkupContent(51, "<label style=\"font-size:15px\" class=\"ml-3\">Age</label>\r\n                                    ");
            __builder.OpenElement(52, "input");
            __builder.AddAttribute(53, "type", "text");
            __builder.AddAttribute(54, "class", "form-control p_input ml-3");
            __builder.AddAttribute(55, "style", "height:25px;width:300px");
            __builder.AddAttribute(56, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 44 "C:\Users\MSI PC\source\repos\FM\FM.Web\Pages\SignUp.razor"
                                                         user.Age

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.Age = __value, user.Age));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                                ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "form-group");
            __builder.AddMarkupContent(61, "<label for=\"exampleFormControlSelect3\" style=\"font-size:15px\" class=\"ml-3\">Select Gender</label>\r\n                                    ");
            __builder.OpenElement(62, "select");
            __builder.AddAttribute(63, "class", "form-control form-control ml-3");
            __builder.AddAttribute(64, "id", "exampleFormControlSelect3");
            __builder.AddAttribute(65, "style", "width:300px");
            __builder.OpenElement(66, "option");
            __builder.AddAttribute(67, "selected");
            __builder.AddContent(68, "Select Gender");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                                        ");
            __builder.OpenElement(70, "option");
            __builder.AddAttribute(71, "value", "Woman");
            __builder.AddContent(72, "Woman");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                                        ");
            __builder.OpenElement(74, "option");
            __builder.AddAttribute(75, "value", "Man");
            __builder.AddContent(76, "Man");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                                ");
            __builder.OpenElement(78, "div");
            __builder.AddAttribute(79, "class", "form-group");
            __builder.AddMarkupContent(80, "<label style=\"font-size:15px\" class=\"ml-3\">Password</label>\r\n                                    ");
            __builder.OpenElement(81, "input");
            __builder.AddAttribute(82, "type", "password");
            __builder.AddAttribute(83, "class", "form-control p_input ml-3");
            __builder.AddAttribute(84, "style", "height:25px;width:300px");
            __builder.AddAttribute(85, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 56 "C:\Users\MSI PC\source\repos\FM\FM.Web\Pages\SignUp.razor"
                                                         user.Password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(86, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => user.Password = __value, user.Password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n                                ");
            __builder.OpenElement(88, "div");
            __builder.AddAttribute(89, "class", "text-center");
            __builder.OpenElement(90, "button");
            __builder.AddAttribute(91, "type", "submit");
            __builder.AddAttribute(92, "class", "btn btn-primary btn-block enter-btn");
            __builder.AddAttribute(93, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\MSI PC\source\repos\FM\FM.Web\Pages\SignUp.razor"
                                                                                                                RegisterPerson

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(94, "Sign Up");
            __builder.CloseElement();
            __builder.CloseElement();
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
#line 77 "C:\Users\MSI PC\source\repos\FM\FM.Web\Pages\SignUp.razor"
       
    UserDto user = new UserDto();

    RegisterDto register = new RegisterDto();
    public async Task RegisterPerson()
    {
        if (user.Name != null && user.Surname != null && user.Email != null && user.Password != null && user.Age != null)
        {


            register.Name = user.Name;
            register.Surname = user.Surname;
            register.EMail = user.Email;
            register.Password = user.Password;
            register.Age = user.Age;
            register.Gender = user.Gender;
            register.RoleID = user.RoleID;

            var responseUser = await Http.PostAsJsonAsync("User/Register", register);
            var responsestr = await responseUser.Content.ReadFromJsonAsync<ApiResponseDto<LoginResponseDto>>();
            if (responsestr.IsSucces)
            {
                await sessionStorage.SetItemAsync("ID", responsestr.Data.ID);
                await sessionStorage.SetItemAsync("Name", responsestr.Data.Name);
                await sessionStorage.SetItemAsync("Surname", responsestr.Data.Surname);
                await sessionStorage.SetItemAsync("RoleID", responsestr.Data.RoleID.ToString());

                Http.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", responsestr.Data.TokenID.ToString());
                OnlineUserInformation onlineUser = new OnlineUserInformation()
                {
                    ID = responsestr.Data.ID,
                    Name = responsestr.Data.Name,
                    Surname = responsestr.Data.Surname,
                    Email = responsestr.Data.Email,
                    RoleID = responsestr.Data.RoleID,
                    TokenID = responsestr.Data.TokenID,
                };
                await sessionStorage.SetItemAsync("ID", onlineUser.ID);
                await sessionStorage.SetItemAsync("Name", onlineUser.Name);
                await sessionStorage.SetItemAsync("Surname", onlineUser.Surname);
                navigationaManager.NavigateTo("/signin");

            }



        }
    }

    async void SelectGender(ChangeEventArgs e = null)
    {
        if (e != null)
        {
            user.Gender = e.Value.ToString();

        }
        else
        {
            user.Gender = null;
        }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationaManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
#pragma warning restore 1591