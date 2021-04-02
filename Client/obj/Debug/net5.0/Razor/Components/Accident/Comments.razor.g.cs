#pragma checksum "C:\Users\Btech\source\repos\fms\Client\Components\Accident\Comments.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d55b9bb9fb788a7e388ec8d038ca2d3b2bcafaf"
// <auto-generated/>
#pragma warning disable 1591
namespace SOS.FMS.Client.Components.Accident
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Btech\source\repos\fms\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Btech\source\repos\fms\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Btech\source\repos\fms\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Btech\source\repos\fms\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Btech\source\repos\fms\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Btech\source\repos\fms\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Btech\source\repos\fms\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Btech\source\repos\fms\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Btech\source\repos\fms\Client\_Imports.razor"
using SOS.FMS.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Btech\source\repos\fms\Client\_Imports.razor"
using SOS.FMS.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Btech\source\repos\fms\Client\_Imports.razor"
using SOS.FMS.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Btech\source\repos\fms\Client\_Imports.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Btech\source\repos\fms\Client\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Btech\source\repos\fms\Client\_Imports.razor"
using SOS.FMS.Client.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Btech\source\repos\fms\Client\_Imports.razor"
using SOS.FMS.Shared.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Btech\source\repos\fms\Client\_Imports.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Btech\source\repos\fms\Client\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Btech\source\repos\fms\Client\_Imports.razor"
using Syncfusion.Blazor.Spinner;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Btech\source\repos\fms\Client\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Btech\source\repos\fms\Client\_Imports.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Btech\source\repos\fms\Client\_Imports.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Btech\source\repos\fms\Client\_Imports.razor"
using Syncfusion.Blazor.PivotView;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\Btech\source\repos\fms\Client\_Imports.razor"
using Append.Blazor.Notifications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Btech\source\repos\fms\Client\_Imports.razor"
using SOS.FMS.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\Btech\source\repos\fms\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\Btech\source\repos\fms\Client\_Imports.razor"
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
#line 4 "C:\Users\Btech\source\repos\fms\Client\Components\Accident\Comments.razor"
       
    [Parameter]
    public FMSAccidentalCommentModalVM AccidentalCommentModal { get; set; }
    [Parameter]
    public ApiRequest CheckPointId { get; set; }
    [Parameter]
    public string VehicleNumber { get; set; }
    [Parameter]
    public EventCallback OnNewCommentModelRequest { get; set; }
    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }

    public ClaimsPrincipal CurrentUser { get; set; }

    private DotNetObjectReference<Comments> dotNetObjectReference;

    public List<GBMSUserVM> usersList { get; set; } = new List<GBMSUserVM>();

    FMSAccidentalCheckCommentVM AccidentalCheckComment;

    public bool resetCommentBox { get; set; } = false;

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
        if (AccidentalCommentModal == null)
        {
            NewCommentModel();
        }
        await base.OnAfterRenderAsync(firstRender);
    }
    public async void PostAccidentalComment()
    {
        resetCommentBox = true;
        var postCommentResponse = await Http.PostAsJsonAsync<FMSAccidentalCheckCommentVM>("api/Accident/FMS/CheckList/Point/Comment/Add", AccidentalCheckComment);
        if (postCommentResponse.StatusCode == System.Net.HttpStatusCode.OK)
        {
            NewCommentModel();
            resetCommentBox = false;
            StateHasChanged();
        }
        else
        {
        }
    }

    public async void NewCommentModel()
    {
        try
        {
            await OnNewCommentModelRequest.InvokeAsync();
        }
        catch (Exception ex)
        {
            throw;
        }
    }

    [JSInvokable]
    public void mention_JSInvoked(List<GBMSUserVM> mentionedUsers, string comment)
    {
        if (AccidentalCheckComment != null)
        {
            AccidentalCheckComment.Comment = comment;
            AccidentalCheckComment.Mentions = (string.Join(",", mentionedUsers.Select(x => x.Id).ToArray()));
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
