#pragma checksum "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Vehicles.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96c6f12b4651f14646aeff49225ddd0e126e3e36"
// <auto-generated/>
#pragma warning disable 1591
namespace SOS.FMS.Client.Pages
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
#line 30 "C:\Users\BA Tech\source\repos\sosfms\Client\_Imports.razor"
using Append.Blazor.Notifications;

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
#line 36 "C:\Users\BA Tech\source\repos\sosfms\Client\_Imports.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Vehicles")]
    public partial class Vehicles : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"subheader py-2 py-lg-4 subheader-solid\" id=\"kt_subheader\"><div class=\"container-fluid d-flex align-items-center justify-content-between flex-wrap flex-sm-nowrap\"><div class=\"d-flex align-items-center flex-wrap mr-2\"><h5 class=\"text-dark font-weight-bold mt-2 mb-2 mr-5\">FMS</h5>\r\n            \r\n            \r\n            <div class=\"subheader-separator subheader-separator-ver mt-2 mb-2 mr-5 bg-gray-200\"></div>\r\n            \r\n            \r\n            <ul class=\"breadcrumb breadcrumb-transparent breadcrumb-dot font-weight-bold p-0 my-2 font-size-sm\"><li class=\"breadcrumb-item\"><a href=\"/\" class=\"text-muted\">Vehicles</a></li></ul></div>\r\n        \r\n        <div class=\"d-flex align-items-center\"><ul class=\"nav nav-light-fms nav-bold nav-pills\"><li class=\"nav-item\"><a class=\"nav-link active\" data-toggle=\"tab\" href=\"#kt_tab_pane_4_1\"><span class=\"nav-icon\"><i class=\"flaticon2-dashboard\"></i></span>\r\n                        <span class=\"nav-text\">Vehicle Management</span></a></li>\r\n                <li class=\"nav-item\"><a class=\"nav-link\" data-toggle=\"tab\" href=\"#kt_tab_pane_4_2\"><span class=\"nav-icon\"><i class=\"flaticon2-information\"></i></span>\r\n                        <span class=\"nav-text\">Accidental History</span></a></li>\r\n                <li class=\"nav-item\"><a class=\"nav-link\" data-toggle=\"tab\" href=\"#kt_tab_pane_4_3\"><span class=\"nav-icon\"><i class=\"flaticon2-sheet\"></i></span>\r\n                        <span class=\"nav-text\">Scorecard</span></a></li>\r\n                <li class=\"nav-item\"><a class=\"nav-link\" data-toggle=\"tab\" href=\"#kt_tab_pane_4_4\"><span class=\"nav-icon\"><i class=\"flaticon2-add-square\"></i></span>\r\n                        <span class=\"nav-text\">Add Vehicle</span></a></li></ul></div></div></div>\r\n\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "d-flex flex-column-fluid");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container-fluid");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card card-custom card-stretch");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card-body");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "tab-content");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "tab-pane fade show active");
            __builder.AddAttribute(13, "id", "kt_tab_pane_4_1");
            __builder.AddAttribute(14, "role", "tabpanel");
            __builder.AddAttribute(15, "aria-labelledby", "kt_tab_pane_4_1");
            __builder.OpenComponent<SOS.FMS.Client.Components.Lists.VehiclesList>(16);
            __builder.AddAttribute(17, "FMSVehiclesList", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<SOS.FMS.Shared.ViewModels.VehicleVM>>(
#nullable restore
#line 65 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Vehicles.razor"
                                                                                       FMSVehiclesList

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "tab-pane fade");
            __builder.AddAttribute(21, "id", "kt_tab_pane_4_2");
            __builder.AddAttribute(22, "role", "tabpanel");
            __builder.AddAttribute(23, "aria-labelledby", "kt_tab_pane_4_2");
            __builder.OpenComponent<SOS.FMS.Client.Components.IncidentalHistory.AccidentalHistory>(24);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                    ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "tab-pane fade");
            __builder.AddAttribute(28, "id", "kt_tab_pane_4_3");
            __builder.AddAttribute(29, "role", "tabpanel");
            __builder.AddAttribute(30, "aria-labelledby", "kt_tab_pane_4_3");
            __builder.OpenComponent<SOS.FMS.Client.Components.Scorecards.VehiclesScorecard>(31);
            __builder.AddAttribute(32, "FMSVehiclesList", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<SOS.FMS.Shared.ViewModels.VehicleVM>>(
#nullable restore
#line 71 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Vehicles.razor"
                                                                                                 FMSVehiclesList

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "tab-pane fade");
            __builder.AddAttribute(36, "id", "kt_tab_pane_4_4");
            __builder.AddAttribute(37, "role", "tabpanel");
            __builder.AddAttribute(38, "aria-labelledby", "kt_tab_pane_4_4");
            __builder.OpenComponent<SOS.FMS.Client.Components.Vehicles.AddVehicle>(39);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 84 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Vehicles.razor"
       
    public List<VehicleVM> FMSVehiclesList { get; set; }

    protected override async Task OnInitializedAsync()
    {
        FMSVehiclesList = await Http.GetFromJsonAsync<List<VehicleVM>>("api/Vehicles/FMS/Demo/All");
        await base.OnInitializedAsync();
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await base.OnAfterRenderAsync(firstRender);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private INotificationService NotificationService { get; set; }
    }
}
#pragma warning restore 1591
