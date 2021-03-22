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
#line 28 "C:\Users\BA Tech\source\repos\sosfms\Client\_Imports.razor"
using Syncfusion.Blazor.PivotView;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\BA Tech\source\repos\sosfms\Client\_Imports.razor"
using Append.Blazor.Notifications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\BA Tech\source\repos\sosfms\Client\_Imports.razor"
using SOS.FMS.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\BA Tech\source\repos\sosfms\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\BA Tech\source\repos\sosfms\Client\_Imports.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Fueling")]
    public partial class Fueling : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 141 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Fueling.razor"
       
    public List<FuelingInfoVM> FuelingInfoList { get; set; }
    public List<FuelingInfoVM> FilteredFuelingInfoList { get; set; }

    public List<SelectListItem> regionsList { get; set; } = new List<SelectListItem>();
    public List<SelectListItem> paymentTypesList { get; set; } = new List<SelectListItem>();
    public List<SelectListItem> vehiclesList { get; set; } = new List<SelectListItem>();
    public FuelingInfoVM Filter { get; set; } = new FuelingInfoVM();
    public void FilterData()
    {
        FilteredFuelingInfoList = FuelingInfoList
                                    .Where(x => (string.IsNullOrEmpty(Filter.Region) || x.Region == Filter.Region))
                                    .Where(x => (string.IsNullOrEmpty(Filter.VehicleNumber) || x.VehicleNumber == Filter.VehicleNumber))
                                    .Where(x => (string.IsNullOrEmpty(Filter.PaymentType) || x.VehicleNumber == Filter.PaymentType))
                                    .ToList();
    }

    public void ResetData()
    {
        Filter = new FuelingInfoVM();
        FilteredFuelingInfoList = FuelingInfoList;
    }

    protected override async Task OnInitializedAsync()
    {
        await GetFuelingInfo();
        await base.OnInitializedAsync();
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await base.OnAfterRenderAsync(firstRender);
    }

    #region Syncfusion

    SfGrid<FuelingInfoVM> FuelingInfoGrid;

    public void FuelingInfoToolbarClick(Syncfusion.Blazor.Navigations.ClickEventArgs args)
    {
        if (args.Item.Id == "FuelingInfoGrid_pdfexport")
        {
            PdfExportProperties Props = new PdfExportProperties();
            Props.PageOrientation = PageOrientation.Landscape;
            Props.PageSize = PdfPageSize.A4;
            this.FuelingInfoGrid.PdfExport(Props);
        }
        if (args.Item.Id == "FuelingInfoGrid_excelexport")
        {
            this.FuelingInfoGrid.ExcelExport();
        }
        if (args.Item.Id == "FuelingInfoGrid_csvexport")
        {
            this.FuelingInfoGrid.CsvExport();
        }
    }
    #endregion

    public async Task GetFuelingInfo()
    {
        FuelingInfoList = (await Http.GetFromJsonAsync<List<FuelingInfoVM>>("api/Fuel/all"))
        .OrderByDescending(x => x.Timestamp)
        .ToList();
        FilteredFuelingInfoList = FuelingInfoList;
        regionsList = FuelingInfoList.GroupBy(x => x.Region).Select(x => new SelectListItem() { Text = x.Key, Value = x.Key }).ToList();
        paymentTypesList = FuelingInfoList.GroupBy(x => x.PaymentType).Select(x => new SelectListItem() { Text = x.Key, Value = x.Key }).ToList();
        vehiclesList = FuelingInfoList.GroupBy(x => x.VehicleNumber).Select(x => new SelectListItem() { Text = x.Key, Value = x.Key }).ToList();
    }

    public void ImportData()
    {
        UploadDlgVisible = true;
    }

    private async void OnChange(UploadChangeEventArgs args)
    {
        var files = new List<FileInfo>();
        foreach (var file in args.Files)
        {
            var content = new MultipartFormDataContent {
                    { new ByteArrayContent(file.Stream.GetBuffer()), file.FileInfo.Name, file.FileInfo.Name}
                };
            var filepath = await Http.PostAsync("api/Files/Upload", content);
            if (filepath.IsSuccessStatusCode)
            {
                ResponseHeader = "Success";
                ResponseBody = $"Excel File successfully imported";
                ResponseDialog = true;

                await GetFuelingInfo();

                StateHasChanged();
            }
            else
            {
                ResponseHeader = "Failure";
                ResponseBody = $"Excel File failed to be imported";
                ResponseDialog = true;
            }
        }

    }

    #region Dialog

    public bool UploadDlgVisible { get; set; } = false;

    public bool ResponseDialog { get; set; } = false;
    public string ResponseHeader { get; set; }
    public string ResponseBody { get; set; }

    public void DialogClose()
    {
        UploadDlgVisible = false;
        ResponseHeader = null;
        ResponseBody = null;
        ResponseDialog = false;
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
