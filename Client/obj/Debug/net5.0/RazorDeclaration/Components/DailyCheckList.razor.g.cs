// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SOS.FMS.Client.Components
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
    public partial class DailyCheckList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 135 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\DailyCheckList.razor"
      
    [Parameter]
    public string VehicleNumber { get; set; }
    [Parameter]
    public bool Visible { get; set; }
    [Parameter]
    public EventCallback<bool> OnVisibilityChanged { get; set; }

    List<FMSDailyCheckListVM> FMSDailyCheckList = new List<FMSDailyCheckListVM>();
    List<RemarksVM> RemarksList;

    public string Remarks { get; set; } = "";

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (Visible && !string.IsNullOrEmpty(VehicleNumber) && firstRender)
        {
            await PopulateCheckList();
        }
        await base.OnAfterRenderAsync(firstRender);
    }

    public Task closeDailyCheckList()
    {
        return OnVisibilityChanged.InvokeAsync(false);
    }

    public async Task PopulateCheckList()
    {

        var getDailyCheckListResponse = await Http.PostAsJsonAsync<ApiRequest>("api/Daily/FMS/CheckList", new ApiRequest() { VehicleNumber = VehicleNumber });
        if (getDailyCheckListResponse.StatusCode == System.Net.HttpStatusCode.OK)
        {
            string response = await (getDailyCheckListResponse).Content.ReadAsStringAsync();
            FMSDailyCheckList = JsonConvert.DeserializeObject<List<FMSDailyCheckListVM>>(response);
        }
        else
        {
        }
    }

    public async void MarkPointDone(string pointCode)
    {
        var postCheckListPointMarkDone = await Http.PostAsJsonAsync<ApiRequest>("api/Daily/FMS/CheckList/Point/MarkDone",
            new ApiRequest() { CheckListPointCode = pointCode, VehicleNumber = VehicleNumber });
        if (postCheckListPointMarkDone.IsSuccessStatusCode)
        {
            await PopulateCheckList();
        }
    }

    public async void PostRemarks()
    {
        ApiRequest request = new ApiRequest() { VehicleNumber = FMSDailyCheckList.FirstOrDefault().VehicleNumber, Remarks = Remarks };
        var postRemarksResponse = await Http.PostAsJsonAsync<ApiRequest>("api/Daily/FMS/CheckList/Remarks/Add", request);
        if (postRemarksResponse.IsSuccessStatusCode)
        {
            Remarks = "";
            await ShowRemarksList();
        }
        else
        {
        }
    }

    public async Task ShowRemarksList()
    {
        await PopulateCheckList();
        List<RemarksVM> remList = new List<RemarksVM>();
        string rem = FMSDailyCheckList.FirstOrDefault().Remarks;
        List<string> remSeparator = rem.Split('*').ToList();
        foreach (var r in remSeparator)
        {
            try
            {
                string[] data = r.Split('|');
                remList.Add(new RemarksVM() { Remark = data[0], TimeStamp = Convert.ToDateTime(data[1]) });
            }
            catch (Exception ex)
            {
            }
        }
        RemarksList = remList.OrderByDescending(x => x.TimeStamp).ToList();
        RemarksDialog = true;
        StateHasChanged();
    }

    #region Dialog
    public bool RemarksDialog { get; set; }
    public void DialogClose()
    {
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
