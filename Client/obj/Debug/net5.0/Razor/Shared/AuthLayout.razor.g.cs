#pragma checksum "C:\Users\HP\source\repos\fms\Client\Shared\AuthLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa65abf13dde33819585ef0f4f43eeac05b9a5cd"
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
#line 1 "C:\Users\HP\source\repos\fms\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\source\repos\fms\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\source\repos\fms\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\source\repos\fms\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HP\source\repos\fms\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HP\source\repos\fms\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HP\source\repos\fms\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\HP\source\repos\fms\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\HP\source\repos\fms\Client\_Imports.razor"
using SOS.FMS.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\HP\source\repos\fms\Client\_Imports.razor"
using SOS.FMS.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\HP\source\repos\fms\Client\_Imports.razor"
using SOS.FMS.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\HP\source\repos\fms\Client\_Imports.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\HP\source\repos\fms\Client\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\HP\source\repos\fms\Client\_Imports.razor"
using SOS.FMS.Client.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\HP\source\repos\fms\Client\_Imports.razor"
using SOS.FMS.Shared.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\HP\source\repos\fms\Client\_Imports.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\HP\source\repos\fms\Client\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\HP\source\repos\fms\Client\_Imports.razor"
using Syncfusion.Blazor.Spinner;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\HP\source\repos\fms\Client\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\HP\source\repos\fms\Client\_Imports.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\HP\source\repos\fms\Client\_Imports.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\HP\source\repos\fms\Client\_Imports.razor"
using Append.Blazor.Notifications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\HP\source\repos\fms\Client\_Imports.razor"
using SOS.FMS.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\HP\source\repos\fms\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\HP\source\repos\fms\Client\_Imports.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
    public partial class AuthLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "html");
            __builder.AddAttribute(1, "lang", "en");
            __builder.AddMarkupContent(2, "<head><base href=\"/\">\r\n        <meta charset=\"utf-8\">\r\n        <title>Login - FMS</title>\r\n        <meta name=\"description\" content=\"Login page example\">\r\n        <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\r\n        \r\n        <link rel=\"stylesheet\" href=\"https://fonts.googleapis.com/css?family=Poppins:300,400,500,600,700\">\r\n        \r\n        \r\n        <link href=\"assets/css/pages/users/login-3.css\" rel=\"stylesheet\" type=\"text/css\">\r\n        \r\n        \r\n        <link href=\"assets/plugins/global/plugins.bundle.css\" rel=\"stylesheet\" type=\"text/css\">\r\n        <link href=\"assets/plugins/custom/prismjs/prismjs.bundle.css\" rel=\"stylesheet\" type=\"text/css\">\r\n        <link href=\"assets/css/style.bundle.css\" rel=\"stylesheet\" type=\"text/css\">\r\n        \r\n        \r\n        <link href=\"assets/css/themes/layout/header/base/light.min.css\" rel=\"stylesheet\" type=\"text/css\">\r\n        <link href=\"assets/css/themes/layout/header/menu/light.min.css\" rel=\"stylesheet\" type=\"text/css\">\r\n        <link href=\"assets/css/themes/layout/brand/dark.min.css\" rel=\"stylesheet\" type=\"text/css\">\r\n        <link href=\"assets/css/themes/layout/aside/dark.min.css\" rel=\"stylesheet\" type=\"text/css\">\r\n        \r\n        <link rel=\"shortcut icon\" href=\"sos-fms-logo.png\">\r\n        <link rel=\"apple-touch-icon\" sizes=\"512x512\" href=\"sos-fms-logo.png\">\r\n        <style>\r\n            .validation-summary-errors {\r\n                color: #c82f2f;\r\n                font-weight: 500;\r\n            }\r\n\r\n                .validation-summary-errors ul li {\r\n                    list-style: none\r\n                }\r\n        </style></head>\r\n    \r\n    \r\n    ");
            __builder.OpenElement(3, "body");
            __builder.AddAttribute(4, "id", "kt_body");
            __builder.AddAttribute(5, "class", "header-fixed header-mobile-fixed subheader-enabled subheader-fixed aside-enabled aside-fixed aside-minimize-hoverable page-loading");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "d-flex flex-column flex-root");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "login login-signin-on login-3 d-flex flex-row-fluid");
            __builder.AddAttribute(10, "id", "kt_login");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "d-flex flex-center flex-row-fluid bgi-size-cover bgi-position-top bgi-no-repeat");
            __builder.AddAttribute(13, "style", "background-image: url(assets/media/bg/bg-3.jpg);");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "login-form text-center p-7 position-relative overflow-hidden");
            __builder.AddMarkupContent(16, "<div class=\"d-flex flex-center mb-15\"><a href=\"#\"><img src=\"sos-fms-logo.png\" class=\"max-h-75px\" alt></a></div>\r\n                        ");
            __builder.AddContent(17, 
#nullable restore
#line 56 "C:\Users\HP\source\repos\fms\Client\Shared\AuthLayout.razor"
                         Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private INotificationService NotificationService { get; set; }
    }
}
#pragma warning restore 1591
