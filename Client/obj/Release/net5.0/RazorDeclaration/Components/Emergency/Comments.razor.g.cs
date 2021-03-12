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
    public partial class Comments : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 111 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Emergency\Comments.razor"
       
    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }

    public ClaimsPrincipal CurrentUser { get; set; }

    private DotNetObjectReference<Comments> dotNetObjectReference;
    [Parameter]
    public FMSEmergencyCommentModalVM EmergencyCommentModal { get; set; }
    [Parameter]
    public ApiRequest CheckPointId { get; set; }
    [Parameter]
    public string VehicleNumber { get; set; }
    [Parameter]
    public bool Visible { get; set; }
    [Parameter]
    public EventCallback<bool> OnVisibilityChanged { get; set; }

    public List<GBMSUserVM> usersList { get; set; } = new List<GBMSUserVM>();

    public bool resetCommentBox { get; set; } = false;

    FMSEmergencyCheckCommentVM EmergencyCheckComment;

    protected override async Task OnInitializedAsync()
    {
        CurrentUser = (await authenticationStateTask).User;
        dotNetObjectReference = DotNetObjectReference.Create(this);

        NewCommentModel();
        usersList = await Http.GetFromJsonAsync<List<GBMSUserVM>>("api/Users/FMS/All");
        await base.OnInitializedAsync();
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (usersList != null)
        {
            await JSRuntime.InvokeVoidAsync("mention", dotNetObjectReference, usersList);
        }

        if (!(await authenticationStateTask).User.Identity.IsAuthenticated)
        {
            navigationManager.NavigateTo("/login");
        }
        else
        {
            CurrentUser = (await authenticationStateTask).User;
        }
        if (EmergencyCommentModal == null)
        {
            NewCommentModel();
        }
        await base.OnAfterRenderAsync(firstRender);
    }

    public Task CloseEmergencyCommentModal()
    {
        return OnVisibilityChanged.InvokeAsync(false);
    }
    public async void PostEmergencyComment()
    {
        resetCommentBox = true;
        var postCommentResponse = await Http.PostAsJsonAsync<FMSEmergencyCheckCommentVM>("api/Emergency/FMS/CheckList/Point/Comment/Add", EmergencyCheckComment);
        if (postCommentResponse.StatusCode == System.Net.HttpStatusCode.OK)
        {
            await NewCommentModel();
            resetCommentBox = false;
            StateHasChanged();
        }
        else
        {
        }

    }
    public async Task NewCommentModel()
    {
        EmergencyCheckComment = new FMSEmergencyCheckCommentVM();
        var getFMSEmergencyCommentModalResponse = await Http.PostAsJsonAsync<ApiRequest>("api/Emergency/FMS/CheckList/Point",
            new ApiRequest() { FMSEmergencyCheckId = CheckPointId.FMSEmergencyCheckId, VehicleNumber = VehicleNumber });

        if (getFMSEmergencyCommentModalResponse.StatusCode == System.Net.HttpStatusCode.OK)
        {
            string response = await (getFMSEmergencyCommentModalResponse).Content.ReadAsStringAsync();
            EmergencyCommentModal = JsonConvert.DeserializeObject<FMSEmergencyCommentModalVM>(response);
            EmergencyCheckComment.FMSEmergencyCheckId = CheckPointId.FMSEmergencyCheckId;
            EmergencyCheckComment.FMSEmergencyId = EmergencyCommentModal.FMSEmergencyId;
            EmergencyCheckComment.FMSVehicleId = EmergencyCommentModal.FMSVehicleId;
            EmergencyCheckComment.VehicleNumber = EmergencyCommentModal.VehicleNumber;
            StateHasChanged();
        }
        else
        {
        }
    }

    [JSInvokable]
    public void mention_JSInvoked(List<GBMSUserVM> mentionedUsers, string comment)
    {
        if (EmergencyCheckComment != null)
        {
            EmergencyCheckComment.Comment = comment;
            EmergencyCheckComment.Mentions = (string.Join(",", mentionedUsers.Select(x => x.Id).ToArray()));
        }

        StateHasChanged();
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