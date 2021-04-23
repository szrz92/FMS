// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SOS.FMS.Client.Components.Special
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
#line 23 "C:\Users\BA Tech\source\repos\sosfms\Client\_Imports.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\BA Tech\source\repos\sosfms\Client\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\BA Tech\source\repos\sosfms\Client\_Imports.razor"
using Syncfusion.Blazor.Spinner;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\BA Tech\source\repos\sosfms\Client\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\BA Tech\source\repos\sosfms\Client\_Imports.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\BA Tech\source\repos\sosfms\Client\_Imports.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\BA Tech\source\repos\sosfms\Client\_Imports.razor"
using Syncfusion.Blazor.PivotView;

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\BA Tech\source\repos\sosfms\Client\_Imports.razor"
using Append.Blazor.Notifications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\BA Tech\source\repos\sosfms\Client\_Imports.razor"
using SOS.FMS.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\BA Tech\source\repos\sosfms\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\BA Tech\source\repos\sosfms\Client\_Imports.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Special\Maintain.razor"
using SOS.FMS.Shared.ViewModels.Incident;

#line default
#line hidden
#nullable disable
    public partial class Maintain : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 119 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Special\Maintain.razor"
       
    [Parameter]
    public EventCallback OnResponse { get; set; }

    public List<GBMSVehicleVM> Vehicles { get; set; }
    public List<SelectListItem> VehiclesList = new List<SelectListItem>();
    public List<SelectListItem> RegionsList = new List<SelectListItem>();
    public List<SelectListItem> SubRegionsList = new List<SelectListItem>();
    public List<SelectListItem> StationsList = new List<SelectListItem>();
    public List<SelectListItem> ServiceList = new List<SelectListItem>();
    public List<SelectListItem> SubServiceList = new List<SelectListItem>();

    List<ServicesList> ServiceTypes { get; set; }

    public BillDetailVM BillDetail { get; set; } = new BillDetailVM();

    protected override async Task OnInitializedAsync()
    {
        Vehicles = (await Http.GetFromJsonAsync<List<GBMSVehicleVM>>("api/Vehicles/All"))
                        .ToList();

        ServiceTypes = await Http.GetFromJsonAsync<List<ServicesList>>("api/Services");

        VehiclesList = Vehicles.GroupBy(x => x.Description).Select(x => new SelectListItem() { Text = x.Key, Value = x.Key })
                        .ToList();
        RegionsList = Vehicles.GroupBy(x => x.Region).Select(x => new SelectListItem() { Text = x.Key, Value = x.Key })
                        .ToList();
        SubRegionsList = Vehicles.GroupBy(x => x.Subregion).Select(x => new SelectListItem() { Text = x.Key, Value = x.Key })
                    .ToList();
        StationsList = Vehicles.GroupBy(x => x.Station).Select(x => new SelectListItem() { Text = x.Key, Value = x.Key })
                    .ToList();
        ServiceList = ServiceTypes.GroupBy(x => x.ServiceType).Select(x => new SelectListItem() { Text = x.Key, Value = x.Key }).ToList();
        SubServiceList = ServiceTypes.GroupBy(x => x.SubServiceType).Select(x => new SelectListItem() { Text = x.Key, Value = x.Key }).ToList();

        await base.OnInitializedAsync();
    }

    public void OnRegionChange(Syncfusion.Blazor.DropDowns.ChangeEventArgs<string> args)
    {
        SubRegionsList = Vehicles.Where(x => x.Region == args.Value)
            .GroupBy(x => x.Subregion).Select(x => new SelectListItem() { Text = x.Key, Value = x.Key }).ToList();
        VehiclesList = Vehicles.Where(x => x.Region == args.Value)
            .GroupBy(x => x.Description).Select(x => new SelectListItem() { Text = x.Key, Value = x.Key }).ToList();
        StationsList = Vehicles.Where(x => x.Region == args.Value)
            .GroupBy(x => x.Station).Select(x => new SelectListItem() { Text = x.Key, Value = x.Key }).ToList();
        StateHasChanged();
    }

    public void OnSubRegionChange(Syncfusion.Blazor.DropDowns.ChangeEventArgs<string> args)
    {
        BillDetail.Region = Vehicles.Where(x => x.Subregion == args.Value).FirstOrDefault().Region;
        VehiclesList = Vehicles.Where(x => x.Subregion == args.Value)
            .GroupBy(x => x.Description).Select(x => new SelectListItem() { Text = x.Key, Value = x.Key }).ToList();
        StationsList = Vehicles.Where(x => x.Subregion == args.Value)
            .GroupBy(x => x.Station).Select(x => new SelectListItem() { Text = x.Key, Value = x.Key }).ToList();
        StateHasChanged();
    }

    public void OnStationChange(Syncfusion.Blazor.DropDowns.ChangeEventArgs<string> args)
    {
        BillDetail.Region = Vehicles.Where(x => x.Station == args.Value).FirstOrDefault().Region;
        BillDetail.Subregion = Vehicles.Where(x => x.Station == args.Value).FirstOrDefault().Subregion;
        VehiclesList = Vehicles.Where(x => x.Station == args.Value)
        .GroupBy(x => x.Description).Select(x => new SelectListItem() { Text = x.Key, Value = x.Key }).ToList();
        StateHasChanged();
    }

    public void OnVehicleNumberChange(Syncfusion.Blazor.DropDowns.ChangeEventArgs<string> args)
    {
        BillDetail.Region = Vehicles.Where(x => x.Description == args.Value).FirstOrDefault().Region;
        BillDetail.Subregion = Vehicles.Where(x => x.Description == args.Value).FirstOrDefault().Subregion;
        BillDetail.Station = Vehicles.Where(x => x.Description == args.Value).FirstOrDefault().Station;
        StateHasChanged();
    }
    public void OnServiceTypeChange(Syncfusion.Blazor.DropDowns.ChangeEventArgs<string> args)
    {
        SubServiceList = ServiceTypes.Where(x => x.ServiceType == args.Value).GroupBy(x => x.SubServiceType).Select(x => new SelectListItem() { Text = x.Key, Value = x.Key }).ToList();
    }
    public void OnSubServiceTypeChange(Syncfusion.Blazor.DropDowns.ChangeEventArgs<string> args)
    {
        BillDetail.ServiceType = ServiceTypes.Where(x => x.SubServiceType == args.Value).FirstOrDefault().ServiceType;
    }
    public async void Save()
    {
        var response = await Http.PostAsJsonAsync("api/Periodic/Maintain/Special", BillDetail);
        dialogBody = await response.Content.ReadAsStringAsync();
        if (response.IsSuccessStatusCode)
        {
            dialogHeader = "Success";
        }
        else
        {
            dialogHeader = "Failed";
        }
        ResponseDialog = true;
        await OnResponse.InvokeAsync();
        BillDetail = new BillDetailVM();
        StateHasChanged();
    }

    public void Cancel()
    {
        BillDetail = new BillDetailVM();
        StateHasChanged();
    }

    #region Dialog
    public bool ResponseDialog { get; set; }
    public string dialogHeader { get; set; }
    public string dialogBody { get; set; }

    public void DialogClose()
    {
        dialogHeader = null;
        dialogBody = null;
    }
    #endregion


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private INotificationService NotificationService { get; set; }
    }
}
#pragma warning restore 1591