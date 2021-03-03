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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Index")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 536 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Index.razor"
 
    [CascadingParameter]
    Task<AuthenticationState> AuthenticationState { get; set; }
    private DotNetObjectReference<Index> dotNetObjectReference;

    #region Filter
    public List<SelectListItem> regionsList { get; set; } = new List<SelectListItem>();
    public List<SelectListItem> subRegionsList { get; set; } = new List<SelectListItem>();
    public List<SelectListItem> vehicleNumbersList { get; set; } = new List<SelectListItem>();

    public VehicleVM Filter = new VehicleVM();

    public List<VehicleVM> filteredVehiclesList { get; set; } = new List<VehicleVM>();

    public async void FilterData()
    {
        filteredVehiclesList = vehiclesList
            .Where(x => (string.IsNullOrEmpty(Filter.Region) || x.Region == Filter.Region))
            .Where(x => (string.IsNullOrEmpty(Filter.SubRegion) || x.SubRegion == Filter.SubRegion))
            .Where(x => (string.IsNullOrEmpty(Filter.VehicleNumber) || x.VehicleNumber == Filter.VehicleNumber))
            .ToList();
        await JSRuntime.InvokeVoidAsync("updateMarkers", dotNetObjectReference, filteredVehiclesList);
        StateHasChanged();
    }
    public void FilterDataWithoutUpdateMarkers()
    {
        filteredVehiclesList = vehiclesList
            .Where(x => (string.IsNullOrEmpty(Filter.Region) || x.Region == Filter.Region))
            .Where(x => (string.IsNullOrEmpty(Filter.SubRegion) || x.SubRegion == Filter.SubRegion))
            .Where(x => (string.IsNullOrEmpty(Filter.VehicleNumber) || x.VehicleNumber == Filter.VehicleNumber))
            .ToList();
        //await JSRuntime.InvokeVoidAsync("updateMarkers", dotNetObjectReference, filteredVehiclesList);
        StateHasChanged();
    }

    public async void ResetData()
    {
        Filter = new VehicleVM();
        filteredVehiclesList = vehiclesList;
        await JSRuntime.InvokeVoidAsync("updateMarkers", dotNetObjectReference, filteredVehiclesList);
    }

    public async Task OnRegionChange(Syncfusion.Blazor.DropDowns.ChangeEventArgs<string> args)
    {
        vehicleNumbersList = vehiclesList.Where(x => x.Region == args.Value).GroupBy(x => x.VehicleNumber).Select(x => new SelectListItem() { Text = x.Key, Value = x.Key }).ToList();
        subRegionsList = vehiclesList.Where(x => x.Region == args.Value).GroupBy(x => x.SubRegion).Select(x => new SelectListItem() { Text = x.Key, Value = x.Key }).ToList();
        StateHasChanged();
    }
    public async Task OnSubRegionChange(Syncfusion.Blazor.DropDowns.ChangeEventArgs<string> args)
    {
        Filter.Region = vehiclesList.Where(x => x.SubRegion == args.Value).FirstOrDefault().Region;
        vehicleNumbersList = vehiclesList.Where(x => x.SubRegion == args.Value)
            .GroupBy(x => x.VehicleNumber).Select(x => new SelectListItem() { Text = x.Key, Value = x.Key }).ToList();
    }
    public async Task OnVehicleNumberChange(Syncfusion.Blazor.DropDowns.ChangeEventArgs<string> args)
    {
        Filter.Region = vehiclesList.Where(x => x.VehicleNumber == args.Value).FirstOrDefault().Region;
        Filter.SubRegion = vehiclesList.Where(x => x.VehicleNumber == args.Value).FirstOrDefault().SubRegion;
        StateHasChanged();
    }
    #endregion

    public List<VehicleVM> vehiclesList { get; set; } = new List<VehicleVM>();
    public List<GBMSUserVM> usersList { get; set; } = new List<GBMSUserVM>();
    public List<FMSAccidentalCheckCommentVM> commentsList = new List<FMSAccidentalCheckCommentVM>();


    public List<FMSEmergencyCheckVM> emergencyCheckList { get; set; }
    public Guid emergencyId { get; set; }
    public Guid emergencyCheckPointId { get; set; }

    public int AccidentalVehiclesCount { get; set; } = 0;
    public int EmergencyVehiclesCount { get; set; } = 0;
    public int PeriodicVehiclesCount { get; set; } = 0;
    public int MaintainedVehiclesCount { get; set; } = 0;
    public int TotalVehiclesCount { get; set; } = 0;

    public bool emergencyCheckListSideModal { get; set; } = false;
    public bool dailyCheckListSideModal { get; set; } = false;
    public bool periodicCheckListSideModal { get; set; } = false;

    public string emergencyCheckListVehicleNumber;
    public string dailyCheckListVehicleNumber;
    public string periodicCheckVehicleNumber;

    public bool visibleCommentBox { get; set; } = true;
    public bool emergencyCommentModal { get; set; } = false;

    FMSEmergencyCommentModalVM EmergencyCommentModal;
    FMSEmergencyCheckCommentVM EmergencyCheckComment;

    public string commentSideModalHeading;

    public string mentionId;

    public string displayImage;

    public void DisplayImage(string item)
    {
        displayImage = item;
    }

    protected override async Task OnInitializedAsync()
    {

        dotNetObjectReference = DotNetObjectReference.Create(this);
        vehiclesList = await Http.GetFromJsonAsync<List<VehicleVM>>("api/Vehicles/FMS/All");
        vehicleNumbersList = vehiclesList.GroupBy(x => x.VehicleNumber).Select(x => new SelectListItem() { Text = x.Key, Value = x.Key }).ToList();
        regionsList = vehiclesList.GroupBy(x => x.Region).Select(x => new SelectListItem() { Text = x.Key, Value = x.Key }).ToList();
        subRegionsList = vehiclesList.GroupBy(x => x.SubRegion).Select(x => new SelectListItem() { Text = x.Key, Value = x.Key }).ToList();
        filteredVehiclesList = vehiclesList;
        usersList = await Http.GetFromJsonAsync<List<GBMSUserVM>>("api/Users/FMS/All");
        CountVehicles(filteredVehiclesList);
        StartTimer();
        await base.OnInitializedAsync();
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        mentionId = "mention1";
        await JSRuntime.InvokeVoidAsync("mention", dotNetObjectReference, usersList);
        if (firstRender)
        {
            await JSRuntime.InvokeVoidAsync("initialize", dotNetObjectReference, filteredVehiclesList);
        }
    }

    public void CountVehicles(List<VehicleVM> vehicles)
    {
        TotalVehiclesCount = 0;
        AccidentalVehiclesCount = 0;
        EmergencyVehiclesCount = 0;
        PeriodicVehiclesCount = 0;
        MaintainedVehiclesCount = 0;
        foreach (var vehicle in vehicles)
        {

            switch (vehicle.Type)
            {
                case "maintained":
                    MaintainedVehiclesCount++;
                    break;
                case "emergency":
                    EmergencyVehiclesCount++;
                    break;
                case "periodic":
                    PeriodicVehiclesCount++;
                    break;
                case "accidental":
                    AccidentalVehiclesCount++;
                    break;
            }

            switch (vehicle.PeriodicRemarks)
            {
                case "maintained":
                    MaintainedVehiclesCount++;
                    break;
                case "emergency":
                    EmergencyVehiclesCount++;
                    break;
                case "Periodic Maintenance Pending":
                    PeriodicVehiclesCount++;
                    break;
                case "accidental":
                    AccidentalVehiclesCount++;
                    break;
            }
            TotalVehiclesCount++;
        }
    }

    private IList<string> imageDataUrls = new List<string>();

    private async Task OnInputFileChange(InputFileChangeEventArgs e)
    {
        var maxAllowedFiles = 3;
        var format = "image/png";

        foreach (var imageFile in e.GetMultipleFiles(maxAllowedFiles))
        {
            var resizedImageFile = await imageFile.RequestImageFileAsync(format,
                100, 100);
            var buffer = new byte[resizedImageFile.Size];
            await resizedImageFile.OpenReadStream().ReadAsync(buffer);
            var imageDataUrl =
                $"data:{format};base64,{Convert.ToBase64String(buffer)}";
            imageDataUrls.Add(imageDataUrl);
        }
    }

    public void closeSideModals()
    {
        HideEmergencyCheckList();
        dailyCheckListSideModal = false;
        emergencyCommentModal = false;

        dailyCheckListVehicleNumber = null;
        commentSideModalHeading = null;
    }
    public void ShowHideDailyCheckList()
    {
        Description = null;
        dailyCheckListSideModal = !dailyCheckListSideModal;
    }

    #region Accidental Check List

    public List<FMSAccidentalCheckVM> accidentalCheckList { get; set; }

    public string accidentalCheckListVehicleNumber;

    public bool accidentalCheckListSideModal { get; set; } = false;

    public void ShowHideAccidentalCheckList()
    {
        Description = null;
        accidentalCheckListSideModal = !accidentalCheckListSideModal;
    }

    #endregion


    public void closeEmergencyCommentModal()
    {
        Emergency_JSInvoked(EmergencyCommentModal.VehicleNumber);
        StateHasChanged();
    }

    public void closeCommentModals()
    {

        commentSideModalHeading = null;
    }

    #region Periodic Checklist
    public void ShowHidePeriodicCheckList()
    {
        Description = null;
        Periodic_JSInvoked(periodicCheckVehicleNumber);
        periodicCheckListSideModal = !periodicCheckListSideModal;
        StateHasChanged();
    }
    #endregion

    #region JS Invokables
    [JSInvokable]
    public async void Emergency_JSInvoked(string vehicleNumber)
    {

        emergencyCheckListVehicleNumber = vehicleNumber;

        var emergencyStatusResponse = await Http.PostAsJsonAsync("api/Emergency/FMS/checkEmergencyStatus", new ApiRequest() { VehicleNumber = vehicleNumber });

        var vehicleResponse = await Http.PostAsJsonAsync("api/Vehicles/FMS/Demo/GetByNumber", new ApiRequest() { VehicleNumber = vehicleNumber });
        string res = await vehicleResponse.Content.ReadAsStringAsync();
        var vehicle = Newtonsoft.Json.JsonConvert.DeserializeObject<VehicleVM>(res);
        if (vehicle.Type == "emergency")
        {
            var getEmergencyCheckListResponse = await Http.PostAsJsonAsync<ApiRequest>("api/Emergency/FMS/CheckList", new ApiRequest() { VehicleNumber = vehicleNumber });
            if (getEmergencyCheckListResponse.StatusCode == System.Net.HttpStatusCode.OK)
            {
                emergencyCheckList = JsonConvert.DeserializeObject<List<FMSEmergencyCheckVM>>(await getEmergencyCheckListResponse.Content.ReadAsStringAsync());
                ShowEmergencyCheckList(emergencyCheckList);
            }
            else
            {
            }
        }
        else
        {
            ConfirmEmergencyDlgVisible = true;
        }
        StateHasChanged();
    }
    [JSInvokable]
    public async void Accidental_JSInvoked(string vehicleNumber)
    {
        try
        {
            accidentalCheckListVehicleNumber = vehicleNumber;

            var accidentStatusResponse = await Http.PostAsJsonAsync("api/Accident/FMS/checkAccidentalStatus", new ApiRequest() { VehicleNumber = vehicleNumber });

            var vehicleResponse = await Http.PostAsJsonAsync("api/Vehicles/FMS/Demo/GetByNumber", new ApiRequest() { VehicleNumber = vehicleNumber });
            var vehicle = JsonConvert.DeserializeObject<VehicleVM>(await vehicleResponse.Content.ReadAsStringAsync());

            if (vehicle.Type == "accidental" || accidentStatusResponse.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var getAccidentalCheckListResponse = await Http.PostAsJsonAsync<ApiRequest>("api/Accident/FMS/CheckList", new ApiRequest() { VehicleNumber = vehicleNumber });

                if (getAccidentalCheckListResponse.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    accidentalCheckList=JsonConvert.DeserializeObject<List<FMSAccidentalCheckVM>>(await getAccidentalCheckListResponse.Content.ReadAsStringAsync());
                    ShowAccidentalCheckList(accidentalCheckList);
                }
                else
                {
                }
            }
            else
            {
                ConfirmAccidentDlgVisible = true;
            }
            StateHasChanged();
        }
        catch (Exception ex)
        {
            throw;
        }
    }
    [JSInvokable]
    public void Daily_JSInvoked(string vehicleNumber)
    {
        dailyCheckListVehicleNumber = vehicleNumber;
        ConfirmDailyDlgVisible = true;
        StateHasChanged();
    }

    [JSInvokable]
    public void Periodic_JSInvoked(string vehicleNumber)
    {
        periodicCheckVehicleNumber = vehicleNumber;
        PeriodicHistoryDlgVisible = true;
        StateHasChanged();
    }


    List<HistoryVM> histories { get; set; }
    [JSInvokable]
    public async void History_JSInvoked(string vehicleNumber)
    {
        var history = await Http.PostAsJsonAsync("api/Jobs/History", new ApiRequest() { VehicleNumber = vehicleNumber });
        if (history.IsSuccessStatusCode)
        {
            string historyString = await history.Content.ReadAsStringAsync();
            histories = JsonConvert.DeserializeObject<List<HistoryVM>>(historyString);
            HistoryDlgVisible = true;
            StateHasChanged();
        }
    }
    [JSInvokable]
    public void mention_JSInvoked(List<FMSUserVM> mentionedUsers, string comment)
    {
        if (EmergencyCheckComment != null)
        {
            EmergencyCheckComment.Comment = comment;
            EmergencyCheckComment.Mentions = (string.Join(",", mentionedUsers.Select(x => x.Id).ToArray()));
        }

        StateHasChanged();
    }
    #endregion

    #region Timer
    public async void StartTimer()
    {
        await JSRuntime.InvokeVoidAsync("updateMarkers", dotNetObjectReference, filteredVehiclesList);
        Timer.SetTimer(10000);
        Timer.OnElapsed += TimerElapsedHandler;
        Console.WriteLine("Markers Sync Started.");
    }

    private async void TimerElapsedHandler()
    {
        vehiclesList = await Http.GetFromJsonAsync<List<VehicleVM>>("api/Vehicles/FMS/All");
        filteredVehiclesList = vehiclesList;
        FilterDataWithoutUpdateMarkers();
        CountVehicles(filteredVehiclesList);
        await JSRuntime.InvokeVoidAsync("updateMarkerPositions", dotNetObjectReference, filteredVehiclesList);
        StateHasChanged();
    }
    #endregion

    #region Dialog

    public bool ConfirmEmergencyDlgVisible { get; set; } = false;
    public bool ConfirmAccidentDlgVisible { get; set; } = false;
    public bool ConfirmDailyDlgVisible { get; set; } = false;
    public bool HistoryDlgVisible { get; set; } = false;
    public bool PeriodicHistoryDlgVisible { get; set; } = false;

    public string Description { get; set; } = "";

    private void HideDialog(Object e)
    {
        this.ConfirmEmergencyDlgVisible = false;
        this.ConfirmAccidentDlgVisible = false;
        this.ConfirmDailyDlgVisible = false;
        this.PeriodicHistoryDlgVisible = false;
    }

    private void DialogClose(CloseEventArgs args)
    {
        this.ConfirmEmergencyDlgVisible = false;
        this.ConfirmAccidentDlgVisible = false;
        this.ConfirmDailyDlgVisible = false;
        this.HistoryDlgVisible = false;
        this.PeriodicHistoryDlgVisible = false;
    }
    public void MaintainBtnClick()
    {
        periodicCheckListSideModal = true;
        this.PeriodicHistoryDlgVisible = false;
        StateHasChanged();
    }

    public async void ConfirmEmergency()
    {
        var newEmergency = new FMSEmergencyVM()
        {
            VehicleNumber = emergencyCheckListVehicleNumber,
            Description = Description,
            MaintenanceStatus = "Pending"
        };

        var getEmergencyCheckListResponse = await Http.PostAsJsonAsync<FMSEmergencyVM>("api/Emergency/Report", newEmergency);

        if (getEmergencyCheckListResponse.StatusCode == System.Net.HttpStatusCode.OK)
        {
            //if (IsConnected)
            //    await hubConnection.SendAsync("SendMessage", "z.raza@batech.com.pk", "Notification", $"Vehicle {accidentalCheckListVehicleNumber} marked as Emergency");

            string response = await (getEmergencyCheckListResponse).Content.ReadAsStringAsync();
            emergencyCheckList = JsonConvert.DeserializeObject<List<FMSEmergencyCheckVM>>(response);
            ShowEmergencyCheckList(emergencyCheckList);
            this.ConfirmEmergencyDlgVisible = false;
            StateHasChanged();
        }
    }

    public async void ConfirmAccident()
    {
        var newAccident = new FMSAccidentVM()
        {
            VehicleNumber = accidentalCheckListVehicleNumber,
            Description = Description,
            MaintenanceStatus = "Pending"
        };

        var getAccidentalCheckListResponse = await Http.PostAsJsonAsync<FMSAccidentVM>("api/Accident/Report", newAccident);

        if (getAccidentalCheckListResponse.StatusCode == System.Net.HttpStatusCode.OK)
        {
            string response = await (getAccidentalCheckListResponse).Content.ReadAsStringAsync();
            accidentalCheckList = JsonConvert.DeserializeObject<List<FMSAccidentalCheckVM>>(response);

            //if (IsConnected)
            //    await hubConnection.SendAsync("SendMessage", "z.raza@batech.com.pk", "Notification", $"Vehicle {accidentalCheckListVehicleNumber} marked as Accidental");

            ShowAccidentalCheckList(accidentalCheckList);
            this.ConfirmAccidentDlgVisible = false;
            StateHasChanged();
        }
    }

    public void ConfirmDaily()
    {
        this.ConfirmDailyDlgVisible = false;
        dailyCheckListSideModal = true;
    }
    #endregion



    public void ShowAccidentalCheckList(List<FMSAccidentalCheckVM> checkVMs)
    {
        accidentalCheckListSideModal = true;
    }

    public void ShowEmergencyCheckList(List<FMSEmergencyCheckVM> checkVMs)
    {
        emergencyId = checkVMs.FirstOrDefault().FMSEmergencyId;
        emergencyCheckListSideModal = true;
        emergencyCommentModal = false;
    }

    public async void MarkEmergencyPointDone(Guid pointId)
    {
        EmergencyCheckComment = new FMSEmergencyCheckCommentVM();
        var getMarkEmergencyPointDoneResponse = await Http.PostAsJsonAsync<ApiRequest>("api/Emergency/FMS/CheckList/Point/MarkDone",
            new ApiRequest() { FMSEmergencyCheckId = pointId, VehicleNumber = emergencyCheckListVehicleNumber });

        if (getMarkEmergencyPointDoneResponse.StatusCode == System.Net.HttpStatusCode.OK)
        {
            Emergency_JSInvoked(emergencyCheckListVehicleNumber);
        }
        else
        {
        }

    }
    public async void ShowEmergencyCommentModal(Guid pointId)
    {
        EmergencyCheckComment = new FMSEmergencyCheckCommentVM();
        var getFMSEmergencyCommentModalResponse = await Http.PostAsJsonAsync<ApiRequest>("api/Emergency/FMS/CheckList/Point", new ApiRequest() { FMSEmergencyCheckId = pointId, VehicleNumber = emergencyCheckListVehicleNumber });

        if (getFMSEmergencyCommentModalResponse.StatusCode == System.Net.HttpStatusCode.OK)
        {
            string response = await (getFMSEmergencyCommentModalResponse).Content.ReadAsStringAsync();
            EmergencyCommentModal = JsonConvert.DeserializeObject<FMSEmergencyCommentModalVM>(response);
            EmergencyCheckComment.FMSEmergencyCheckId = pointId;
            EmergencyCheckComment.FMSEmergencyId = EmergencyCommentModal.FMSEmergencyId;
            EmergencyCheckComment.FMSVehicleId = EmergencyCommentModal.FMSVehicleId;
            EmergencyCheckComment.VehicleNumber = EmergencyCommentModal.VehicleNumber;
        }
        else
        {
        }

        closeSideModals();
        commentSideModalHeading = "Comment Box";

        emergencyCommentModal = true;
    }


    public async void PostEmergencyComment()
    {
        visibleCommentBox = false;
        var postCommentResponse = await Http.PostAsJsonAsync<FMSEmergencyCheckCommentVM>("api/Emergency/FMS/CheckList/Point/Comment/Add", EmergencyCheckComment);
        if (postCommentResponse.StatusCode == System.Net.HttpStatusCode.OK)
        {
            ShowEmergencyCommentModal(EmergencyCheckComment.FMSEmergencyCheckId);
            visibleCommentBox = true;
            StateHasChanged();
            closeSideModals();

        }
        else
        {
        }

    }

    public void HideEmergencyCheckList()
    {
        emergencyCheckListSideModal = false;
        //emergencyCheckListVehicleNumber = null;
        emergencyId = Guid.Empty;
        emergencyCheckList = null;
    }
    public async void EmergencyCloseJob()
    {
        var vehicleResponse = await Http.PostAsJsonAsync("api/Emergency/FMS/Demo/CloseJob",
            new ApiRequest() { VehicleNumber = emergencyCheckListVehicleNumber });
        if (vehicleResponse.StatusCode == System.Net.HttpStatusCode.OK)
        {
            closeSideModals();
        }
        StateHasChanged();
    }
    public void Dispose()
    {
        Timer.Dispose();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Services.TimerService Timer { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private INotificationService NotificationService { get; set; }
    }
}
#pragma warning restore 1591