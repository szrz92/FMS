// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SOS.FMS.Client.Components.Reports
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
#nullable restore
#line 2 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Reports\VehicleAverageReport.razor"
using SOS.FMS.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Reports\VehicleAverageReport.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
    public partial class VehicleAverageReport : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 127 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Reports\VehicleAverageReport.razor"
       
    public bool showReportModal = false;
    SfGrid<DailyFuelReport> FuelReportGrid;
    public DateTime MinDate { get; set; } = new DateTime(2020, 1, 1);
    public DateTime ToDate = DateTime.Now;

    public List<DailyFuelReport> DailyFuelReportList { get; set; } = new List<DailyFuelReport>();
    public List<DailyFuelReport> FilteredDailyFuelReportList { get; set; } = new List<DailyFuelReport>();

    public DailyFuelReport Filter { get; set; } = new DailyFuelReport() { DailyMonthlyType = "Daily"};

    public List<SelectListItem> regionsList { get; set; } = new List<SelectListItem>();
    public List<SelectListItem> subRegionsList { get; set; } = new List<SelectListItem>();
    public List<SelectListItem> stationsList { get; set; } = new List<SelectListItem>();

    public List<SelectListItem> paymentTypeList { get; set; } = new List<SelectListItem>();
    public List<SelectListItem> fuelTypeList { get; set; } = new List<SelectListItem>();
    public List<SelectListItem> vehiclesList { get; set; } = new List<SelectListItem>();

    public List<SelectListItem> VehicleTypeList { get; set; } = new List<SelectListItem>();
    public List<SelectListItem> MakeList { get; set; } = new List<SelectListItem>();
    public List<SelectListItem> ModelList { get; set; } = new List<SelectListItem>();

    public List<string> DailyMonthly { get; set; } = new List<string>() { "Daily", "Monthly" };

    protected override async Task OnInitializedAsync()
    {
        await GetDailyFuelReportsList();
        await base.OnInitializedAsync();
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await base.OnAfterRenderAsync(firstRender);
    }

    public void ToolbarClick(Syncfusion.Blazor.Navigations.ClickEventArgs args)
    {
        if (args.Item.Id == "FuelReportGrid_pdfexport")
        {
            PdfExportProperties Props = new PdfExportProperties();
            Props.PageOrientation = PageOrientation.Landscape;
            Props.PageSize = PdfPageSize.A3;
            this.FuelReportGrid.PdfExport(Props);
        }
        if (args.Item.Id == "FuelReportGrid_excelexport")
        {
            this.FuelReportGrid.ExcelExport();
        }
        if (args.Item.Id == "FuelReportGrid_csvexport")
        {
            this.FuelReportGrid.CsvExport();
        }
    }

    public void NotifyChangeState()
    {
        StateHasChanged();
    }

    public async Task GetDailyFuelReportsList()
    {
        DailyFuelReportList = (await Http.GetFromJsonAsync<List<DailyFuelReport>>("api/reports/all"))
        .OrderByDescending(x => x.Timestamp)
        .ToList();
        FilteredDailyFuelReportList = DailyFuelReportList;

        DistinctEntries();

        regionsList = DailyFuelReportList.GroupBy(x => x.Region).Select(x => new SelectListItem() { Text = x.Key, Value = x.Key }).ToList();

        paymentTypeList = DailyFuelReportList.GroupBy(x => x.PaymentType).Select(x => new SelectListItem() { Text = x.Key, Value = x.Key }).ToList();
        fuelTypeList = DailyFuelReportList.GroupBy(x => x.FuelType).Select(x => new SelectListItem() { Text = x.Key, Value = x.Key }).ToList();

        VehicleTypeList = DailyFuelReportList.GroupBy(x => x.VehicleType).Select(x => new SelectListItem() { Text = x.Key, Value = x.Key }).ToList();
        MakeList = DailyFuelReportList.GroupBy(x => x.Make).Select(x => new SelectListItem() { Text = x.Key, Value = x.Key }).ToList();
        ModelList = DailyFuelReportList.GroupBy(x => x.Model).Select(x => new SelectListItem() { Text = x.Key, Value = x.Key }).ToList();
        vehiclesList = DailyFuelReportList.GroupBy(x => x.VehicleNumber).Select(x => new SelectListItem() { Text = x.Key, Value = x.Key }).ToList();
        StateHasChanged();
    }

    #region Filter
    public void FilterData()
    {
        showReportModal = false;

        if (Filter.Timestamp.Day.Equals(1) && Filter.Timestamp.Month.Equals(1) && Filter.Timestamp.Year.Equals(1))
        {
            FilteredDailyFuelReportList = DailyFuelReportList
   .Where(x => (string.IsNullOrEmpty(Filter.Region) || x.Region == Filter.Region))
   .Where(x => (string.IsNullOrEmpty(Filter.FuelType) || x.FuelType == Filter.FuelType))
   .Where(x => (string.IsNullOrEmpty(Filter.PaymentType) || x.PaymentType == Filter.PaymentType))
   .Where(x => (string.IsNullOrEmpty(Filter.VehicleType) || x.VehicleType == Filter.VehicleType))
   .Where(x => (string.IsNullOrEmpty(Filter.Make) || x.Make == Filter.Make))
   .Where(x => (string.IsNullOrEmpty(Filter.Model) || x.Model == Filter.Model))
   .Where(x => (string.IsNullOrEmpty(Filter.VehicleNumber) || x.VehicleNumber == Filter.VehicleNumber))
   .ToList();

        }
        else
        {
            if (Filter.DailyMonthlyType == "Daily")
            {
                FilteredDailyFuelReportList = DailyFuelReportList
.Where(x => (string.IsNullOrEmpty(Filter.Region) || x.Region == Filter.Region))
.Where(x => (string.IsNullOrEmpty(Filter.FuelType) || x.FuelType == Filter.FuelType))
.Where(x => (string.IsNullOrEmpty(Filter.PaymentType) || x.PaymentType == Filter.PaymentType))
.Where(x => (string.IsNullOrEmpty(Filter.VehicleType) || x.VehicleType == Filter.VehicleType))
.Where(x => (string.IsNullOrEmpty(Filter.Make) || x.Make == Filter.Make))
.Where(x => (string.IsNullOrEmpty(Filter.Model) || x.Model == Filter.Model))
.Where(x => (x.Timestamp.Day >= Filter.Timestamp.Day && x.Timestamp.Month >= Filter.Timestamp.Month && x.Timestamp.Year >= Filter.Timestamp.Year && x.Timestamp.Day <= ToDate.Day && x.Timestamp.Month <= ToDate.Month && x.Timestamp.Year <= ToDate.Year))
.Where(x => (string.IsNullOrEmpty(Filter.VehicleNumber) || x.VehicleNumber == Filter.VehicleNumber))
.ToList();

            }
            else
            {
                FilteredDailyFuelReportList = DailyFuelReportList
.Where(x => (string.IsNullOrEmpty(Filter.Region) || x.Region == Filter.Region))
.Where(x => (string.IsNullOrEmpty(Filter.FuelType) || x.FuelType == Filter.FuelType))
.Where(x => (string.IsNullOrEmpty(Filter.PaymentType) || x.PaymentType == Filter.PaymentType))
.Where(x => (string.IsNullOrEmpty(Filter.VehicleType) || x.VehicleType == Filter.VehicleType))
.Where(x => (string.IsNullOrEmpty(Filter.Make) || x.Make == Filter.Make))
.Where(x => (string.IsNullOrEmpty(Filter.Model) || x.Model == Filter.Model))
.Where(x => (x.Timestamp.Month == Filter.Timestamp.Month && x.Timestamp.Year == Filter.Timestamp.Year))
.Where(x => (string.IsNullOrEmpty(Filter.VehicleNumber) || x.VehicleNumber == Filter.VehicleNumber))
.ToList();
            }
        }
        DistinctEntries();
    }

    public void ResetData()
    {
        Filter = new DailyFuelReport() { DailyMonthlyType = "Daily"};
        showReportModal = false;
        FilteredDailyFuelReportList = DailyFuelReportList;
        DistinctEntries();

    }
    #endregion

    private void OnDailyMonthlyChange(Syncfusion.Blazor.DropDowns.ChangeEventArgs<string> args)
    {
        Filter.DailyMonthlyType = args.Value;
        StateHasChanged();
    }

    public void DistinctEntries()
    {
        FilteredDailyFuelReportList = FilteredDailyFuelReportList.GroupBy(x => new { x.Region, x.VehicleNumber, x.FuelType, x.Driver })
        .Select(x => new DailyFuelReport()
        {
            Region = x.Key.Region,
            VehicleNumber = x.Key.VehicleNumber,
            Litres = Convert.ToString(x.Sum(y => Convert.ToDouble(y.Litres))),
            Odometer = x.OrderBy(y => y.Timestamp).Select(z => z.Odometer).Last(),
            PreviousOdometer = x.OrderBy(y => y.Timestamp).Select(z => z.PreviousOdometer).First(),
            Average = Convert.ToString((x.OrderBy(x => x.Timestamp).Select(y => Convert.ToDouble(y.Odometer)).Last() - x.OrderBy(x => x.Timestamp).Select(y => Convert.ToDouble(y.PreviousOdometer)).First()) / x.Sum(y => Convert.ToDouble(y.Litres))),
            Mileage = Convert.ToString(x.OrderBy(x => x.Timestamp).Select(y => Convert.ToDouble(y.Odometer)).Last() - x.OrderBy(x => x.Timestamp).Select(y => Convert.ToDouble(y.PreviousOdometer)).First()),
            Amount = Convert.ToString(x.Sum(y => Convert.ToDouble(y.Amount))),
            FuelType = x.Key.FuelType,
            Driver = x.Key.Driver

        }).ToList();
       
        showReportModal = true;
        StateHasChanged();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private INotificationService NotificationService { get; set; }
    }
}
#pragma warning restore 1591