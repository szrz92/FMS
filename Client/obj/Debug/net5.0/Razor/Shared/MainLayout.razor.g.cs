#pragma checksum "C:\Users\BA Tech\source\repos\sosfms\Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3065d3391c571e98f9aabdd4826e52cb07e40285"
// <auto-generated/>
#pragma warning disable 1591
namespace SOS.FMS.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\BA Tech\source\repos\sosfms\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\BA Tech\source\repos\sosfms\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\BA Tech\source\repos\sosfms\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\BA Tech\source\repos\sosfms\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\BA Tech\source\repos\sosfms\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\BA Tech\source\repos\sosfms\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\BA Tech\source\repos\sosfms\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\BA Tech\source\repos\sosfms\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\BA Tech\source\repos\sosfms\Client\_Imports.razor"
using SOS.FMS.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\BA Tech\source\repos\sosfms\Client\_Imports.razor"
using SOS.FMS.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\BA Tech\source\repos\sosfms\Client\_Imports.razor"
using SOS.FMS.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\BA Tech\source\repos\sosfms\Client\_Imports.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\BA Tech\source\repos\sosfms\Client\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\BA Tech\source\repos\sosfms\Client\_Imports.razor"
using SOS.FMS.Client.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\BA Tech\source\repos\sosfms\Client\_Imports.razor"
using SOS.FMS.Shared.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\BA Tech\source\repos\sosfms\Client\_Imports.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\BA Tech\source\repos\sosfms\Client\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\BA Tech\source\repos\sosfms\Client\_Imports.razor"
using Syncfusion.Blazor.Spinner;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\BA Tech\source\repos\sosfms\Client\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\BA Tech\source\repos\sosfms\Client\_Imports.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\BA Tech\source\repos\sosfms\Client\_Imports.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\BA Tech\source\repos\sosfms\Client\_Imports.razor"
using SOS.FMS.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\BA Tech\source\repos\sosfms\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\BA Tech\source\repos\sosfms\Client\Shared\MainLayout.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\BA Tech\source\repos\sosfms\Client\Shared\MainLayout.razor"
using Append.Blazor.Notifications;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div id=\"kt_header_mobile\" class=\"header-mobile align-items-center header-mobile-fixed\" b-qmoch6hs3w><a href=\"/\" class=\"brand-logo\" b-qmoch6hs3w><img src=\"/assets/media/logos/sos-logo-300x100.png\" height=\"48\" b-qmoch6hs3w></a>\r\n    \r\n    \r\n    <div class=\"d-flex align-items-center\" b-qmoch6hs3w><button class=\"btn p-0 burger-icon burger-icon-left\" id=\"kt_aside_mobile_toggle\" b-qmoch6hs3w><span b-qmoch6hs3w></span></button>\r\n        \r\n        \r\n        <button class=\"btn p-0 burger-icon ml-4\" id=\"kt_header_mobile_toggle\" b-qmoch6hs3w><span b-qmoch6hs3w></span></button>\r\n        \r\n        \r\n        <button class=\"btn btn-hover-text-warning p-0 ml-2\" id=\"kt_header_mobile_topbar_toggle\" b-qmoch6hs3w><span class=\"svg-icon svg-icon-xl\" b-qmoch6hs3w><svg xmlns=\"http://www.w3.org/2000/svg\" xmlns:xlink=\"http://www.w3.org/1999/xlink\" width=\"24px\" height=\"24px\" viewBox=\"0 0 24 24\" version=\"1.1\" b-qmoch6hs3w><g stroke=\"none\" stroke-width=\"1\" fill=\"none\" fill-rule=\"evenodd\" b-qmoch6hs3w><polygon points=\"0 0 24 0 24 24 0 24\" b-qmoch6hs3w></polygon>\r\n                        <path d=\"M12,11 C9.790861,11 8,9.209139 8,7 C8,4.790861 9.790861,3 12,3 C14.209139,3 16,4.790861 16,7 C16,9.209139 14.209139,11 12,11 Z\" fill=\"#000000\" fill-rule=\"nonzero\" opacity=\"0.3\" b-qmoch6hs3w></path>\r\n                        <path d=\"M3.00065168,20.1992055 C3.38825852,15.4265159 7.26191235,13 11.9833413,13 C16.7712164,13 20.7048837,15.2931929 20.9979143,20.2 C21.0095879,20.3954741 20.9979143,21 20.2466999,21 C16.541124,21 11.0347247,21 3.72750223,21 C3.47671215,21 2.97953825,20.45918 3.00065168,20.1992055 Z\" fill=\"#000000\" fill-rule=\"nonzero\" b-qmoch6hs3w></path></g></svg></span></button></div></div>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "id", "main");
            __builder.AddAttribute(3, "class", "d-flex flex-column flex-root");
            __builder.AddAttribute(4, "b-qmoch6hs3w");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "d-flex flex-row flex-column-fluid page");
            __builder.AddAttribute(7, "b-qmoch6hs3w");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "aside aside-left aside-fixed d-flex flex-column flex-row-auto");
            __builder.AddAttribute(10, "id", "kt_aside");
            __builder.AddAttribute(11, "b-qmoch6hs3w");
            __builder.AddMarkupContent(12, "<div class=\"brand flex-column-auto\" id=\"kt_brand\" b-qmoch6hs3w><a href=\"/\" class=\"brand-logo\" b-qmoch6hs3w><img src=\"/assets/media/logos/sos-logo-300x100.png\" height=\"60\" b-qmoch6hs3w></a>\r\n                \r\n                \r\n                <button class=\"brand-toggle btn btn-sm px-0\" id=\"kt_aside_toggle\" b-qmoch6hs3w><span class=\"svg-icon svg-icon svg-icon-xl\" b-qmoch6hs3w><svg xmlns=\"http://www.w3.org/2000/svg\" xmlns:xlink=\"http://www.w3.org/1999/xlink\" width=\"24px\" height=\"24px\" viewBox=\"0 0 24 24\" version=\"1.1\" b-qmoch6hs3w><g stroke=\"none\" stroke-width=\"1\" fill=\"none\" fill-rule=\"evenodd\" b-qmoch6hs3w><polygon points=\"0 0 24 0 24 24 0 24\" b-qmoch6hs3w></polygon>\r\n                                <path d=\"M5.29288961,6.70710318 C4.90236532,6.31657888 4.90236532,5.68341391 5.29288961,5.29288961 C5.68341391,4.90236532 6.31657888,4.90236532 6.70710318,5.29288961 L12.7071032,11.2928896 C13.0856821,11.6714686 13.0989277,12.281055 12.7371505,12.675721 L7.23715054,18.675721 C6.86395813,19.08284 6.23139076,19.1103429 5.82427177,18.7371505 C5.41715278,18.3639581 5.38964985,17.7313908 5.76284226,17.3242718 L10.6158586,12.0300721 L5.29288961,6.70710318 Z\" fill=\"#000000\" fill-rule=\"nonzero\" transform=\"translate(8.999997, 11.999999) scale(-1, 1) translate(-8.999997, -11.999999)\" b-qmoch6hs3w></path>\r\n                                <path d=\"M10.7071009,15.7071068 C10.3165766,16.0976311 9.68341162,16.0976311 9.29288733,15.7071068 C8.90236304,15.3165825 8.90236304,14.6834175 9.29288733,14.2928932 L15.2928873,8.29289322 C15.6714663,7.91431428 16.2810527,7.90106866 16.6757187,8.26284586 L22.6757187,13.7628459 C23.0828377,14.1360383 23.1103407,14.7686056 22.7371482,15.1757246 C22.3639558,15.5828436 21.7313885,15.6103465 21.3242695,15.2371541 L16.0300699,10.3841378 L10.7071009,15.7071068 Z\" fill=\"#000000\" fill-rule=\"nonzero\" opacity=\"0.3\" transform=\"translate(15.999997, 11.999999) scale(-1, 1) rotate(-270.000000) translate(-15.999997, -11.999999)\" b-qmoch6hs3w></path></g></svg></span></button></div>\r\n            \r\n            \r\n            ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "aside-menu-wrapper flex-column-fluid");
            __builder.AddAttribute(15, "id", "kt_aside_menu_wrapper");
            __builder.AddAttribute(16, "b-qmoch6hs3w");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "id", "kt_aside_menu");
            __builder.AddAttribute(19, "class", "aside-menu my-4");
            __builder.AddAttribute(20, "data-menu-vertical", "1");
            __builder.AddAttribute(21, "data-menu-scroll", "1");
            __builder.AddAttribute(22, "data-menu-dropdown-timeout", "500");
            __builder.AddAttribute(23, "b-qmoch6hs3w");
            __builder.OpenComponent<SOS.FMS.Client.Shared.NavMenu>(24);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        \r\n        \r\n        ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "d-flex flex-column flex-row-fluid wrapper");
            __builder.AddAttribute(28, "id", "kt_wrapper");
            __builder.AddAttribute(29, "b-qmoch6hs3w");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "id", "kt_header");
            __builder.AddAttribute(32, "class", "header header-fixed");
            __builder.AddAttribute(33, "b-qmoch6hs3w");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "container-fluid d-flex align-items-stretch justify-content-between");
            __builder.AddAttribute(36, "b-qmoch6hs3w");
            __builder.AddMarkupContent(37, @"<div class=""header-menu-wrapper header-menu-wrapper-left"" id=""kt_header_menu_wrapper"" b-qmoch6hs3w><div id=""kt_header_menu"" class=""header-menu header-menu-mobile header-menu-layout-default"" b-qmoch6hs3w></div></div>
                    
                    
                    ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "topbar");
            __builder.AddAttribute(40, "b-qmoch6hs3w");
            __builder.AddMarkupContent(41, "<div class=\"topbar-item\" b-qmoch6hs3w><div class=\"dropdown\" b-qmoch6hs3w><div class=\"topbar-item\" data-toggle=\"dropdown\" data-offset=\"10px,0px\" aria-expanded=\"false\" b-qmoch6hs3w><div class=\"btn btn-icon btn-clean btn-dropdown btn-lg mr-1\" b-qmoch6hs3w><img class=\"h-20px w-20px rounded-sm\" src=\"assets/icons/notifications1x.png\" alt b-qmoch6hs3w></div></div>\r\n                                \r\n                                \r\n                                <div class=\"dropdown-menu p-0 m-0 dropdown-menu-anim-up dropdown-menu-sm dropdown-menu-right\" style b-qmoch6hs3w><ul class=\"navi navi-hover py-4\" b-qmoch6hs3w><li class=\"navi-item\" b-qmoch6hs3w><a href=\"#\" class=\"navi-link\" b-qmoch6hs3w><span class=\"symbol symbol-20 mr-3\" b-qmoch6hs3w><img src=\"assets/icons/notifications1x.png\" alt b-qmoch6hs3w></span>\r\n                                                <span class=\"navi-text\" b-qmoch6hs3w>Notification 1</span></a></li>\r\n                                        \r\n                                        \r\n                                        <li class=\"navi-item\" b-qmoch6hs3w><a href=\"#\" class=\"navi-link\" b-qmoch6hs3w><span class=\"symbol symbol-20 mr-3\" b-qmoch6hs3w><img src=\"assets/icons/notifications1x.png\" alt b-qmoch6hs3w></span>\r\n                                                <span class=\"navi-text\" b-qmoch6hs3w>Notification 2</span></a></li>\r\n                                        \r\n                                        \r\n                                        <li class=\"navi-item\" b-qmoch6hs3w><a href=\"#\" class=\"navi-link\" b-qmoch6hs3w><span class=\"symbol symbol-20 mr-3\" b-qmoch6hs3w><img src=\"assets/icons/notifications1x.png\" alt b-qmoch6hs3w></span>\r\n                                                <span class=\"navi-text\" b-qmoch6hs3w>Notification 3</span></a></li>\r\n                                        \r\n                                        \r\n                                        <li class=\"navi-item\" b-qmoch6hs3w><a href=\"#\" class=\"navi-link\" b-qmoch6hs3w><span class=\"symbol symbol-20 mr-3\" b-qmoch6hs3w><img src=\"assets/icons/notifications1x.png\" alt b-qmoch6hs3w></span>\r\n                                                <span class=\"navi-text\" b-qmoch6hs3w>Notification 4</span></a></li></ul></div></div></div>\r\n                        ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "topbar-item");
            __builder.AddAttribute(44, "b-qmoch6hs3w");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "dropdown");
            __builder.AddAttribute(47, "b-qmoch6hs3w");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(48);
            __builder.AddAttribute(49, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(50, "div");
                __builder2.AddAttribute(51, "class", "topbar-item");
                __builder2.AddAttribute(52, "data-toggle", "dropdown");
                __builder2.AddAttribute(53, "data-offset", "10px,0px");
                __builder2.AddAttribute(54, "aria-expanded", "false");
                __builder2.AddAttribute(55, "b-qmoch6hs3w");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "btn btn-icon w-auto btn-clean d-flex align-items-center btn-lg px-2");
                __builder2.AddAttribute(58, "b-qmoch6hs3w");
                __builder2.AddMarkupContent(59, "<span class=\"text-muted font-weight-bold font-size-base d-none d-md-inline mr-1\" b-qmoch6hs3w>Hi,</span>\r\n                                                ");
                __builder2.OpenElement(60, "span");
                __builder2.AddAttribute(61, "class", "text-dark-50 font-weight-bolder font-size-base d-none d-md-inline mr-3");
                __builder2.AddAttribute(62, "b-qmoch6hs3w");
                __builder2.AddContent(63, 
#nullable restore
#line 175 "C:\Users\BA Tech\source\repos\sosfms\Client\Shared\MainLayout.razor"
                                                     context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n                                                ");
                __builder2.OpenElement(65, "span");
                __builder2.AddAttribute(66, "class", "symbol symbol-35 symbol-light-danger");
                __builder2.AddAttribute(67, "b-qmoch6hs3w");
                __builder2.OpenElement(68, "span");
                __builder2.AddAttribute(69, "class", "symbol-label font-size-h5 font-weight-bold");
                __builder2.AddAttribute(70, "b-qmoch6hs3w");
                __builder2.AddContent(71, 
#nullable restore
#line 178 "C:\Users\BA Tech\source\repos\sosfms\Client\Shared\MainLayout.razor"
                                                                                                              context.User.Identity.Name[0]

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n                                        \r\n                                        \r\n                                        ");
                __builder2.OpenElement(73, "div");
                __builder2.AddAttribute(74, "class", "dropdown-menu p-0 m-0 dropdown-menu-anim-up dropdown-menu-sm dropdown-menu-right");
                __builder2.AddAttribute(75, "style");
                __builder2.AddAttribute(76, "b-qmoch6hs3w");
                __builder2.OpenElement(77, "ul");
                __builder2.AddAttribute(78, "class", "navi navi-hover py-4");
                __builder2.AddAttribute(79, "b-qmoch6hs3w");
                __builder2.OpenElement(80, "li");
                __builder2.AddAttribute(81, "class", "navi-item");
                __builder2.AddAttribute(82, "b-qmoch6hs3w");
                __builder2.OpenElement(83, "a");
                __builder2.AddAttribute(84, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 189 "C:\Users\BA Tech\source\repos\sosfms\Client\Shared\MainLayout.razor"
                                                                  LogoutClick

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(85, "class", "navi-link");
                __builder2.AddAttribute(86, "b-qmoch6hs3w");
                __builder2.AddMarkupContent(87, "<span class=\"symbol symbol-20 mr-3\" b-qmoch6hs3w><i class=\"icon-xl la la-sign-out\" b-qmoch6hs3w></i></span>\r\n                                                        ");
                __builder2.AddMarkupContent(88, "<span class=\"navi-text\" b-qmoch6hs3w>Logout</span>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(89, "Authorizing", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(90, "<h4 b-qmoch6hs3w>Loading ...</h4>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n            \r\n            ");
            __builder.OpenElement(92, "div");
            __builder.AddAttribute(93, "class", "content d-flex flex-column flex-column-fluid pb-16");
            __builder.AddAttribute(94, "id", "kt_content");
            __builder.AddAttribute(95, "b-qmoch6hs3w");
            __builder.AddContent(96, 
#nullable restore
#line 214 "C:\Users\BA Tech\source\repos\sosfms\Client\Shared\MainLayout.razor"
                 Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(98, @"<div id=""kt_quick_user"" class=""offcanvas offcanvas-right p-10"" b-qmoch6hs3w><div class=""offcanvas-header d-flex align-items-center justify-content-between pb-5"" b-qmoch6hs3w><h3 class=""font-weight-bold m-0"" b-qmoch6hs3w>
            User Profile
            <small class=""text-muted font-size-sm ml-2"" b-qmoch6hs3w>12 messages</small></h3>
        <a href=""#"" class=""btn btn-xs btn-icon btn-light btn-hover-warning"" id=""kt_quick_user_close"" b-qmoch6hs3w><i class=""ki ki-close icon-xs text-muted"" b-qmoch6hs3w></i></a></div>
    
    
    <div class=""offcanvas-content pr-5 mr-n5"" b-qmoch6hs3w><div class=""d-flex align-items-center mt-5"" b-qmoch6hs3w><div class=""symbol symbol-100 mr-5"" b-qmoch6hs3w><i class=""symbol-badge bg-success"" b-qmoch6hs3w></i></div></div></div></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 253 "C:\Users\BA Tech\source\repos\sosfms\Client\Shared\MainLayout.razor"
      
    [CascadingParameter]
    Task<AuthenticationState> AuthenticationState { get; set; }

    public ClaimsPrincipal CurrentUser { get; set; }
    private HubConnection hubConnection;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            CurrentUser = (await AuthenticationState).User;

            hubConnection = new HubConnectionBuilder()
            .WithUrl(navigationManager.ToAbsoluteUri("/notificationhub"))
            .Build();

            hubConnection.On<string, string, string>("ReceiveMessage", (user, title, message) =>
            {
                var encodedMsg = $"{user}: {message}";
                if (CurrentUser.Identity.Name == user)
                {
                    Notify(title, message);
                }

                //messages.Add(encodedMsg);
                StateHasChanged();
            });
            hubConnection.On<string, string, string>("ReceiveMessageAllUsers", (user, title, message) =>
            {
                var encodedMsg = $"{user}: {message}";
                Notify(title, message);
                //messages.Add(encodedMsg);
                StateHasChanged();
            });

            await hubConnection.StartAsync();
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    public async void Notify(string title, string message)
    {
        await NotificationService.CreateAsync(title, message);
    }

    public bool IsConnected =>
        hubConnection.State == HubConnectionState.Connected;

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {

        if (firstRender)
        {
            await _jsRuntime.InvokeVoidAsync("initializeJs");
        }
        await base.OnAfterRenderAsync(firstRender);
    }
    protected override async Task OnParametersSetAsync()
    {
        if (!(await AuthenticationState).User.Identity.IsAuthenticated)
        {
            navigationManager.NavigateTo("/login");
        }
    }
    async Task LogoutClick()
    {
        await authStateProvider.Logout();
        navigationManager.NavigateTo("/login");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private INotificationService NotificationService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CustomStateProvider authStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime _jsRuntime { get; set; }
    }
}
#pragma warning restore 1591
