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
    [Microsoft.AspNetCore.Components.RouteAttribute("/CompletedJobs")]
    public partial class CompletedJobs : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 118 "C:\Users\HP\source\repos\fms\Client\Pages\CompletedJobs.razor"
       
    public List<FMSJobsVM> JobsList { get; set; }
    public List<FMSJobsVM> FilteredJobsList { get; set; }

    public List<SelectListItem> regionsList { get; set; } = new List<SelectListItem>();
    public List<SelectListItem> subRegionsList { get; set; } = new List<SelectListItem>();
    public List<SelectListItem> vehiclesList { get; set; } = new List<SelectListItem>();
    public List<SelectListItem> typesList { get; set; } = new List<SelectListItem>();
    public FMSJobsVM Filter { get; set; } = new FMSJobsVM();
    public void FilterData()
    {
        FilteredJobsList = JobsList
    .Where(x => (string.IsNullOrEmpty(Filter.Region) || x.Region == Filter.Region))
    .Where(x => (string.IsNullOrEmpty(Filter.SubRegion) || x.SubRegion == Filter.SubRegion))
    .Where(x => (string.IsNullOrEmpty(Filter.VehicleNumber) || x.VehicleNumber == Filter.VehicleNumber))
    .Where(x => (string.IsNullOrEmpty(Filter.JobType) || x.JobType == Filter.JobType))
    .ToList();
    }

    public void ResetData()
    {
        Filter = new FMSJobsVM();
        FilteredJobsList = JobsList;
    }

    protected override async Task OnInitializedAsync()
    {
        JobsList = (await Http.GetFromJsonAsync<List<FMSJobsVM>>("api/Jobs/All/Completed"))
        .OrderByDescending(x => x.LastUpdated)
        .ToList();
        FilteredJobsList = JobsList;
        regionsList = JobsList.GroupBy(x => x.Region).Select(x => new SelectListItem() { Text = x.Key, Value = x.Key }).ToList();
        subRegionsList = JobsList.GroupBy(x => x.SubRegion).Select(x => new SelectListItem() { Text = x.Key, Value = x.Key }).ToList();
        vehiclesList = JobsList.GroupBy(x => x.VehicleNumber).Select(x => new SelectListItem() { Text = x.Key, Value = x.Key }).ToList();
        typesList = JobsList.GroupBy(x => x.JobType).Select(x => new SelectListItem() { Text = x.Key, Value = x.Key }).ToList();
        await base.OnInitializedAsync();
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await base.OnAfterRenderAsync(firstRender);
    }

    #region Syncfusion

    SfGrid<FMSJobsVM> JobsGrid;

    public void JobsToolbarClick(Syncfusion.Blazor.Navigations.ClickEventArgs args)
    {
        if (args.Item.Id == "JobsGrid_pdfexport")
        {
            PdfExportProperties Props = new PdfExportProperties();
            Props.PageOrientation = PageOrientation.Landscape;
            Props.PageSize = PdfPageSize.A4;
            this.JobsGrid.PdfExport(Props);
        }
        if (args.Item.Id == "JobsGrid_excelexport")
        {
            this.JobsGrid.ExcelExport();
        }
        if (args.Item.Id == "JobsGrid_csvexport")
        {
            this.JobsGrid.CsvExport();
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
