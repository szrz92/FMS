#pragma checksum "C:\Users\Btech\source\repos\fms\Client\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a92f49cf178e99a4423fdc35f3c1b4a795cff4f3"
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
#line 1 "C:\Users\Btech\source\repos\fms\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Btech\source\repos\fms\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Btech\source\repos\fms\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Btech\source\repos\fms\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Btech\source\repos\fms\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Btech\source\repos\fms\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Btech\source\repos\fms\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Btech\source\repos\fms\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Btech\source\repos\fms\Client\_Imports.razor"
using SOS.FMS.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Btech\source\repos\fms\Client\_Imports.razor"
using SOS.FMS.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Btech\source\repos\fms\Client\_Imports.razor"
using SOS.FMS.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Btech\source\repos\fms\Client\_Imports.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Btech\source\repos\fms\Client\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Btech\source\repos\fms\Client\_Imports.razor"
using SOS.FMS.Client.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Btech\source\repos\fms\Client\_Imports.razor"
using SOS.FMS.Shared.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Btech\source\repos\fms\Client\_Imports.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Btech\source\repos\fms\Client\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Btech\source\repos\fms\Client\_Imports.razor"
using Syncfusion.Blazor.Spinner;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Btech\source\repos\fms\Client\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Btech\source\repos\fms\Client\_Imports.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Btech\source\repos\fms\Client\_Imports.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Btech\source\repos\fms\Client\_Imports.razor"
using Syncfusion.Blazor.PivotView;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\Btech\source\repos\fms\Client\_Imports.razor"
using Append.Blazor.Notifications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Btech\source\repos\fms\Client\_Imports.razor"
using SOS.FMS.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\Btech\source\repos\fms\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\Btech\source\repos\fms\Client\_Imports.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style b-mpuof77w1v>
    i {
        --fa-primary-color: #c22020;
        --fa-secondary-color: #7a7a7a;
    }

    .text-danger {
        color: #EB1B1B !important;
    }

    .inverse {
        --fa-primary-color: #7a7a7a !important;
        --fa-secondary-color: #c22020 !important;
        --fa-primary-opacity: 0.5;
        --fa-secondary-opacity: 0.7;
    }
    /*.menu-link:hover {
        color: black !important;
    }

    .menu-text:hover {
        color: black !important;
    }*/

    .menu-item.menu-item-active > .menu-link .menu-text {
        color: black !important;
    }
</style>

");
            __builder.OpenElement(1, "ul");
            __builder.AddAttribute(2, "class", "menu-nav");
            __builder.AddAttribute(3, "b-mpuof77w1v");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(4);
            __builder.AddAttribute(5, "Roles", "SA, HMT, MTAM, CIM, CPM, RMTO, RAO");
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(7, "li");
                __builder2.AddAttribute(8, "class", "menu-item");
                __builder2.AddAttribute(9, "aria-haspopup", "true");
                __builder2.AddAttribute(10, "b-mpuof77w1v");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(11);
                __builder2.AddAttribute(12, "href", "/");
                __builder2.AddAttribute(13, "class", "menu-link");
                __builder2.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(15, "<span class=\"svg-icon menu-icon\" b-mpuof77w1v><img src=\"icons/dashboard.png\" b-mpuof77w1v></span>\r\n                ");
                    __builder3.AddMarkupContent(16, "<span class=\"menu-text\" b-mpuof77w1v>Dashboard</span>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(18);
            __builder.AddAttribute(19, "Roles", "SA, HMT, CPM, RAO, RMTO");
            __builder.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(21, "li");
                __builder2.AddAttribute(22, "class", "menu-item");
                __builder2.AddAttribute(23, "aria-haspopup", "true");
                __builder2.AddAttribute(24, "b-mpuof77w1v");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(25);
                __builder2.AddAttribute(26, "href", "Daily");
                __builder2.AddAttribute(27, "class", "menu-link");
                __builder2.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(29, "<span class=\"svg-icon menu-icon\" b-mpuof77w1v><img src=\"icons/daily.png\" b-mpuof77w1v></span>\r\n                ");
                    __builder3.AddMarkupContent(30, "<span class=\"menu-text\" b-mpuof77w1v>Daily</span>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(31, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(32);
            __builder.AddAttribute(33, "Roles", "SA, HMT, CPM, RAO, RMTO");
            __builder.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(35, "li");
                __builder2.AddAttribute(36, "class", "menu-item");
                __builder2.AddAttribute(37, "aria-haspopup", "true");
                __builder2.AddAttribute(38, "b-mpuof77w1v");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(39);
                __builder2.AddAttribute(40, "href", "Periodic");
                __builder2.AddAttribute(41, "class", "menu-link");
                __builder2.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(43, "<span class=\"svg-icon menu-icon\" b-mpuof77w1v><img src=\"icons/daily.png\" b-mpuof77w1v></span>\r\n                ");
                    __builder3.AddMarkupContent(44, "<span class=\"menu-text\" b-mpuof77w1v>Periodic</span>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(45, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(46);
            __builder.AddAttribute(47, "Roles", "SA, HMT, CIM, RMTO, RAO");
            __builder.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(49, "li");
                __builder2.AddAttribute(50, "class", "menu-item");
                __builder2.AddAttribute(51, "aria-haspopup", "true");
                __builder2.AddAttribute(52, "b-mpuof77w1v");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(53);
                __builder2.AddAttribute(54, "href", "Accident");
                __builder2.AddAttribute(55, "class", "menu-link");
                __builder2.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(57, "<span class=\"svg-icon menu-icon\" b-mpuof77w1v><img src=\"icons/emergency.png\" b-mpuof77w1v></span>\r\n                ");
                    __builder3.AddMarkupContent(58, "<span class=\"menu-text\" b-mpuof77w1v>Accident</span>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(59, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(60);
            __builder.AddAttribute(61, "Roles", "SA, HMT, CIM, RMTO, RAO");
            __builder.AddAttribute(62, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(63, "li");
                __builder2.AddAttribute(64, "class", "menu-item");
                __builder2.AddAttribute(65, "aria-haspopup", "true");
                __builder2.AddAttribute(66, "b-mpuof77w1v");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(67);
                __builder2.AddAttribute(68, "href", "Emergency");
                __builder2.AddAttribute(69, "class", "menu-link");
                __builder2.AddAttribute(70, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(71, "<span class=\"svg-icon menu-icon\" b-mpuof77w1v><img src=\"icons/emergency.png\" b-mpuof77w1v></span>\r\n                ");
                    __builder3.AddMarkupContent(72, "<span class=\"menu-text\" b-mpuof77w1v>Emergency</span>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(73, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(74);
            __builder.AddAttribute(75, "Roles", "SA, HMT, CIM, RMTO, RAO");
            __builder.AddAttribute(76, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(77, "li");
                __builder2.AddAttribute(78, "class", "menu-item");
                __builder2.AddAttribute(79, "aria-haspopup", "true");
                __builder2.AddAttribute(80, "b-mpuof77w1v");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(81);
                __builder2.AddAttribute(82, "href", "Complaints");
                __builder2.AddAttribute(83, "class", "menu-link");
                __builder2.AddAttribute(84, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(85, "<span class=\"svg-icon menu-icon\" b-mpuof77w1v><img src=\"icons/vehicle.png\" b-mpuof77w1v></span>\r\n                ");
                    __builder3.AddMarkupContent(86, "<span class=\"menu-text\" b-mpuof77w1v>Daily Complaints</span>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(87, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(88);
            __builder.AddAttribute(89, "Roles", "SA, HMT, RMTO, RAO");
            __builder.AddAttribute(90, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(91, "li");
                __builder2.AddAttribute(92, "class", "menu-item");
                __builder2.AddAttribute(93, "aria-haspopup", "true");
                __builder2.AddAttribute(94, "b-mpuof77w1v");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(95);
                __builder2.AddAttribute(96, "href", "Vehicles");
                __builder2.AddAttribute(97, "class", "menu-link");
                __builder2.AddAttribute(98, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(99, "<span class=\"svg-icon menu-icon\" b-mpuof77w1v><img src=\"icons/vehicle.png\" b-mpuof77w1v></span>\r\n                ");
                    __builder3.AddMarkupContent(100, "<span class=\"menu-text\" b-mpuof77w1v>Vehicle Managment</span>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(101, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(102);
            __builder.AddAttribute(103, "Roles", "SA, HMT, RMTO, RAO");
            __builder.AddAttribute(104, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(105, "li");
                __builder2.AddAttribute(106, "class", "menu-item");
                __builder2.AddAttribute(107, "aria-haspopup", "true");
                __builder2.AddAttribute(108, "b-mpuof77w1v");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(109);
                __builder2.AddAttribute(110, "href", "Drivers");
                __builder2.AddAttribute(111, "class", "menu-link");
                __builder2.AddAttribute(112, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(113, "<span class=\"svg-icon menu-icon\" b-mpuof77w1v><img src=\"icons/driver.png\" b-mpuof77w1v></span>\r\n                ");
                    __builder3.AddMarkupContent(114, "<span class=\"menu-text\" b-mpuof77w1v>Driver Management</span>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(115, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(116);
            __builder.AddAttribute(117, "Roles", "SA, HMT, RMTO, RAO");
            __builder.AddAttribute(118, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(119, "li");
                __builder2.AddAttribute(120, "class", "menu-item");
                __builder2.AddAttribute(121, "aria-haspopup", "true");
                __builder2.AddAttribute(122, "b-mpuof77w1v");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(123);
                __builder2.AddAttribute(124, "href", "Fueling");
                __builder2.AddAttribute(125, "class", "menu-link");
                __builder2.AddAttribute(126, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(127, "<span class=\"svg-icon menu-icon\" b-mpuof77w1v><img src=\"icons/vehicle.png\" b-mpuof77w1v></span>\r\n                ");
                    __builder3.AddMarkupContent(128, "<span class=\"menu-text\" b-mpuof77w1v>Fueling</span>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(129, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(130);
            __builder.AddAttribute(131, "Roles", "SA, HMT");
            __builder.AddAttribute(132, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(133, "li");
                __builder2.AddAttribute(134, "class", "menu-item");
                __builder2.AddAttribute(135, "aria-haspopup", "true");
                __builder2.AddAttribute(136, "b-mpuof77w1v");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(137);
                __builder2.AddAttribute(138, "href", "Users");
                __builder2.AddAttribute(139, "class", "menu-link");
                __builder2.AddAttribute(140, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(141, "<span class=\"svg-icon menu-icon\" b-mpuof77w1v><img src=\"icons/dashboard.png\" b-mpuof77w1v></span>\r\n                ");
                    __builder3.AddMarkupContent(142, "<span class=\"menu-text\" b-mpuof77w1v>User Management</span>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(143, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(144);
            __builder.AddAttribute(145, "Roles", "SA, HMT");
            __builder.AddAttribute(146, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(147, "li");
                __builder2.AddAttribute(148, "class", "menu-item");
                __builder2.AddAttribute(149, "aria-haspopup", "true");
                __builder2.AddAttribute(150, "b-mpuof77w1v");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(151);
                __builder2.AddAttribute(152, "href", "Configuration");
                __builder2.AddAttribute(153, "class", "menu-link");
                __builder2.AddAttribute(154, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(155, "<span class=\"svg-icon menu-icon\" b-mpuof77w1v><img src=\"icons/vehicle.png\" b-mpuof77w1v></span>\r\n                ");
                    __builder3.AddMarkupContent(156, "<span class=\"menu-text\" b-mpuof77w1v>Periodic Configuration</span>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(157, "\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(158);
            __builder.AddAttribute(159, "Roles", "SA, HMT");
            __builder.AddAttribute(160, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(161, "li");
                __builder2.AddAttribute(162, "class", "menu-item");
                __builder2.AddAttribute(163, "aria-haspopup", "true");
                __builder2.AddAttribute(164, "b-mpuof77w1v");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(165);
                __builder2.AddAttribute(166, "href", "Reports");
                __builder2.AddAttribute(167, "class", "menu-link");
                __builder2.AddAttribute(168, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(169, "<span class=\"svg-icon menu-icon\" b-mpuof77w1v><img src=\"icons/prompt.png\" b-mpuof77w1v></span>\r\n                ");
                    __builder3.AddMarkupContent(170, "<span class=\"menu-text\" b-mpuof77w1v>Reporting</span>");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 156 "C:\Users\Btech\source\repos\fms\Client\Shared\NavMenu.razor"
       var assemblyVersion = typeof(SOS.FMS.Client.Program).Assembly.GetName().Version.ToString(); 

#line default
#line hidden
#nullable disable
            __builder.OpenElement(171, "li");
            __builder.AddAttribute(172, "class", "menu-item w-100");
            __builder.AddAttribute(173, "style", "position:absolute;bottom:0;");
            __builder.AddAttribute(174, "aria-haspopup", "true");
            __builder.AddAttribute(175, "b-mpuof77w1v");
            __builder.OpenElement(176, "span");
            __builder.AddAttribute(177, "class", "menu-link");
            __builder.AddAttribute(178, "b-mpuof77w1v");
            __builder.AddMarkupContent(179, "<span class=\"svg-icon menu-icon\" b-mpuof77w1v><i class=\"fad fa-info-circle\" b-mpuof77w1v></i></span>\r\n            ");
            __builder.OpenElement(180, "span");
            __builder.AddAttribute(181, "class", "menu-text");
            __builder.AddAttribute(182, "b-mpuof77w1v");
            __builder.AddContent(183, "Version ");
            __builder.AddContent(184, 
#nullable restore
#line 162 "C:\Users\Btech\source\repos\fms\Client\Shared\NavMenu.razor"
                                             assemblyVersion.Substring(0, assemblyVersion.Length - 2)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 168 "C:\Users\Btech\source\repos\fms\Client\Shared\NavMenu.razor"
      
    [CascadingParameter]
    Task<AuthenticationState> AuthenticationState { get; set; }

    protected override async Task OnParametersSetAsync()
    {
        if (!(await AuthenticationState).User.Identity.IsAuthenticated)
        {
            navigationManager.NavigateTo("/login");
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CustomStateProvider authStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private INotificationService NotificationService { get; set; }
    }
}
#pragma warning restore 1591
