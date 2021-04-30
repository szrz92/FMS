// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SOS.FMS.Client.Components.Emergency
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
#line 3 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Emergency\BillPosting.razor"
using SOS.FMS.Shared.ViewModels.Emergency;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Emergency\BillPosting.razor"
using SOS.FMS.Shared.ViewModels.Incident;

#line default
#line hidden
#nullable disable
    public partial class BillPosting : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 130 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Emergency\BillPosting.razor"
       
    [Parameter]
    public ApiRequest CheckPointId { get; set; }
    [Parameter]
    public string VehicleNumber { get; set; }
    [Parameter]
    public string ReferenceNumber { get; set; }
    [Parameter]
    public bool Visible { get; set; }
    [Parameter]
    public EventCallback<bool> OnVisibilityChanged { get; set; }

    public Modal videomodal { get; set; }
    public Modal filemodal { get; set; }

    FMSEmergencyCheckCommentVM EmergencyCheckComment;

    public List<string> fileNames { get; set; }

    public BillPostingVM BillPostingVM = new BillPostingVM();
    public EmergencyBill bill = new EmergencyBill();

    public List<EmergencyBill> BillsList = new List<EmergencyBill>();
    public List<BillDetailVM> BillDetailsList { get; set; }

    protected override async Task OnInitializedAsync()
    {
        LoaderOn();
        await LoadData();
        await base.OnInitializedAsync();
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await LoadData();
        bill.CheckPointId = CheckPointId.FMSEmergencyCheckId;
        bill.BillAmount = BillDetailsList.Sum(x => Convert.ToInt32(x.Amount));
        bill.Ref = ReferenceNumber;
        BillPostingVM.CheckPointId = CheckPointId.FMSEmergencyCheckId;
        await base.OnAfterRenderAsync(firstRender);
    }

    public Task CloseBillPosting()
    {
        return OnVisibilityChanged.InvokeAsync(false);
    }

    public async Task<List<EmergencyBill>> GetBills()
    {
        ApiRequest request = new ApiRequest() { FMSEmergencyCheckId = CheckPointId.FMSEmergencyCheckId };
        var getBillResponse = await Http.PostAsJsonAsync<ApiRequest>("api/Emergency/GetBills", request);
        return JsonConvert.DeserializeObject<List<EmergencyBill>>(await getBillResponse.Content.ReadAsStringAsync());
    }
    public async Task<List<string>> GetFiles()
    {
        ApiRequest request = new ApiRequest() { FMSEmergencyCheckId = CheckPointId.FMSEmergencyCheckId };
        var getBillResponse = await Http.PostAsJsonAsync<ApiRequest>("api/Files/Files", request);
        return JsonConvert.DeserializeObject<List<string>>(await getBillResponse.Content.ReadAsStringAsync());
    }
    public async Task<List<BillDetailVM>> GetBillDetails()
    {
        ApiRequest request = new ApiRequest() { FMSEmergencyCheckId = CheckPointId.FMSEmergencyCheckId };
        var getBillResponse = await Http.PostAsJsonAsync<ApiRequest>("api/Emergency/GetBillDetails", request);
        return JsonConvert.DeserializeObject<List<BillDetailVM>>(await getBillResponse.Content.ReadAsStringAsync());
    }

    public async void PostBill()
    {
        LoaderOn();
        var postBillResponse = await Http.PostAsJsonAsync<EmergencyBill>("api/Emergency/PostBill", bill);

        if (postBillResponse.StatusCode == System.Net.HttpStatusCode.OK)
        {
            await CloseBillPosting();
        }
        else
        {
        }
    }

    private async void OnChange(UploadChangeEventArgs args)
    {
        LoaderOn();
        var files = new List<FileInfo>();
        foreach (var file in args.Files)
        {
            var content = new MultipartFormDataContent {
                    { new ByteArrayContent(file.Stream.GetBuffer()), CheckPointId.FMSEmergencyCheckId.ToString(), file.FileInfo.Name}
                };
            var filepath = await Http.PostAsync("api/Files/Save", content);
        }
        await LoadData();

    }


    #region Add to bill
    public bool addVisible { get; set; } = false;
    public async void ShowHideAddModal(bool status)
    {
        LoaderOn();
        addVisible = status;
        await LoadData();
        StateHasChanged();
    }
    public void ShowAddModal()
    {
        addVisible = true;
    }
    #endregion

    public void LoaderOn()
    {
        BillDetailsList = null;
        BillsList = null;
        fileNames = null;
    }
    public async Task LoadData()
    {
        fileNames = await GetFiles();
        BillsList = await GetBills();
        BillDetailsList = await GetBillDetails();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private INotificationService NotificationService { get; set; }
    }
}
#pragma warning restore 1591
