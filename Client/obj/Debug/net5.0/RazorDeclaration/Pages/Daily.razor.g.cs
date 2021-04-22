// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 20 "C:\Users\BA Tech\source\repos\sosfms\Client\_Imports.razor"
using SOS.FMS.Shared.ViewModels.Incident;

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Daily")]
    public partial class Daily : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 133 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Daily.razor"
       
    public List<FMSDailyCheckListVM> DailyChecksList { get; set; }
    public List<FMSDailyCheckListVM> FilteredDailyChecksList { get; set; }
    public List<SelectListItem> regionsList { get; set; } = new List<SelectListItem>();
    public List<SelectListItem> subRegionsList { get; set; } = new List<SelectListItem>();
    public List<SelectListItem> stationList { get; set; } = new List<SelectListItem>();

    public List<SelectListItem> statusList { get; set; } = new List<SelectListItem>();
    public List<SelectListItem> vehiclesList { get; set; } = new List<SelectListItem>();

    public FMSDailyCheckListVM Filter { get; set; } = new FMSDailyCheckListVM();

    protected override async Task OnInitializedAsync()
    {
        DailyChecksList = (await Http.GetFromJsonAsync<List<FMSDailyCheckListVM>>("api/Daily/All"))
                                .OrderByDescending(x => x.LastUpdated)
                                .ToList();
        FilteredDailyChecksList = DailyChecksList;
        regionsList = DailyChecksList.GroupBy(x => x.Region).Select(x => new SelectListItem() { Text = x.Key, Value = x.Key }).ToList();
        subRegionsList = DailyChecksList.GroupBy(x => x.Subregion).Select(x => new SelectListItem() { Text = x.Key, Value = x.Key }).ToList();
        stationList = DailyChecksList.GroupBy(x => x.Station).Select(x => new SelectListItem() { Text = x.Key, Value = x.Key }).ToList();
        statusList = DailyChecksList.GroupBy(x => x.Status).Select(x => new SelectListItem() { Text = x.Key, Value = x.Key }).ToList();
        vehiclesList = DailyChecksList.GroupBy(x => x.VehicleNumber).Select(x => new SelectListItem() { Text = x.Key, Value = x.Key }).ToList();
        await base.OnInitializedAsync();
    }

    public async Task OnRegionChange(Syncfusion.Blazor.DropDowns.ChangeEventArgs<string> args)
    {
        subRegionsList = DailyChecksList.Where(x => x.Region == args.Value).GroupBy(x => x.Subregion).Select(x => new SelectListItem() { Text = x.Key, Value = x.Key }).ToList();
        stationList = DailyChecksList.Where(x => x.Region == args.Value).GroupBy(x => x.Station).Select(x => new SelectListItem() { Text = x.Key, Value = x.Key }).ToList();
        statusList = DailyChecksList.Where(x => x.Region == args.Value).GroupBy(x => x.Status).Select(x => new SelectListItem() { Text = x.Key, Value = x.Key }).ToList();
        vehiclesList = DailyChecksList.Where(x => x.Region == args.Value).GroupBy(x => x.VehicleNumber).Select(x => new SelectListItem() { Text = x.Key, Value = x.Key }).ToList();
        StateHasChanged();
    }
    public async Task OnSubRegionChange(Syncfusion.Blazor.DropDowns.ChangeEventArgs<string> args)
    {
        stationList = DailyChecksList.Where(x => x.Subregion == args.Value).GroupBy(x => x.Station).Select(x => new SelectListItem() { Text = x.Key, Value = x.Key }).ToList();
        statusList = DailyChecksList.Where(x => x.Subregion == args.Value).GroupBy(x => x.Status).Select(x => new SelectListItem() { Text = x.Key, Value = x.Key }).ToList();
        vehiclesList = DailyChecksList.Where(x => x.Subregion == args.Value).GroupBy(x => x.VehicleNumber).Select(x => new SelectListItem() { Text = x.Key, Value = x.Key }).ToList();
        StateHasChanged();
    }
    public async Task OnStationChange(Syncfusion.Blazor.DropDowns.ChangeEventArgs<string> args)
    {
        statusList = DailyChecksList.Where(x => x.Station == args.Value).GroupBy(x => x.Status).Select(x => new SelectListItem() { Text = x.Key, Value = x.Key }).ToList();
        vehiclesList = DailyChecksList.Where(x => x.Station == args.Value).GroupBy(x => x.VehicleNumber).Select(x => new SelectListItem() { Text = x.Key, Value = x.Key }).ToList();
        StateHasChanged();
    }

    public async Task OnStatusChange(Syncfusion.Blazor.DropDowns.ChangeEventArgs<string> args)
    {
        vehiclesList = DailyChecksList
            .Where(x => x.Status == args.Value && (string.IsNullOrEmpty(Filter.Subregion) || x.Subregion == Filter.Subregion))
            .GroupBy(x => x.VehicleNumber).Select(x => new SelectListItem() { Text = x.Key, Value = x.Key }).ToList();
        StateHasChanged();
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await base.OnAfterRenderAsync(firstRender);
    }

    public void FilterData()
    {
        FilteredDailyChecksList = DailyChecksList
            .Where(x => (string.IsNullOrEmpty(Filter.Region) || x.Region == Filter.Region))
            .Where(x=> (string.IsNullOrEmpty(Filter.Subregion) || x.Subregion == Filter.Subregion))
            .Where(x => (string.IsNullOrEmpty(Filter.Station) || x.Station == Filter.Station))
            .Where(x=> (string.IsNullOrEmpty(Filter.Status) || x.Status == Filter.Status))
            .Where(x=> (string.IsNullOrEmpty(Filter.VehicleNumber) || x.VehicleNumber == Filter.VehicleNumber))
            .ToList();
    }

    public void ResetData()
    {
        Filter = new FMSDailyCheckListVM();
        FilteredDailyChecksList = DailyChecksList;
    }

    #region Syncfusion

    SfGrid<FMSDailyCheckListVM> DailyGrid;

    public void DailyToolbarClick(Syncfusion.Blazor.Navigations.ClickEventArgs args)
    {
        if (args.Item.Id == "DailyGrid_pdfexport")
        {
            PdfExportProperties Props = new PdfExportProperties();
            Props.PageOrientation = PageOrientation.Landscape;
            Props.PageSize = PdfPageSize.A4;
            this.DailyGrid.PdfExport(Props);
        }
        if (args.Item.Id == "DailyGrid_excelexport")
        {
            this.DailyGrid.ExcelExport();
        }
        if (args.Item.Id == "DailyGrid_csvexport")
        {
            this.DailyGrid.CsvExport();
        }
    }
    #endregion

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
