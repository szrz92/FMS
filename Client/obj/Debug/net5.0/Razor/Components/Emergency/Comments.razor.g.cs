#pragma checksum "C:\Users\Btech\Desktop\FMS\Client\Components\Emergency\Comments.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c76dede8088e6de554d3f494f2084515e4da8f7"
// <auto-generated/>
#pragma warning disable 1591
namespace SOS.FMS.Client.Components.Emergency
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Btech\Desktop\FMS\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Btech\Desktop\FMS\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Btech\Desktop\FMS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Btech\Desktop\FMS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Btech\Desktop\FMS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Btech\Desktop\FMS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Btech\Desktop\FMS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Btech\Desktop\FMS\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Btech\Desktop\FMS\Client\_Imports.razor"
using SOS.FMS.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Btech\Desktop\FMS\Client\_Imports.razor"
using SOS.FMS.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Btech\Desktop\FMS\Client\_Imports.razor"
using SOS.FMS.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Btech\Desktop\FMS\Client\_Imports.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Btech\Desktop\FMS\Client\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Btech\Desktop\FMS\Client\_Imports.razor"
using SOS.FMS.Client.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Btech\Desktop\FMS\Client\_Imports.razor"
using SOS.FMS.Shared.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Btech\Desktop\FMS\Client\_Imports.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Btech\Desktop\FMS\Client\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Btech\Desktop\FMS\Client\_Imports.razor"
using Syncfusion.Blazor.Spinner;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Btech\Desktop\FMS\Client\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Btech\Desktop\FMS\Client\_Imports.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Btech\Desktop\FMS\Client\_Imports.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Btech\Desktop\FMS\Client\_Imports.razor"
using Syncfusion.Blazor.PivotView;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\Btech\Desktop\FMS\Client\_Imports.razor"
using Append.Blazor.Notifications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Btech\Desktop\FMS\Client\_Imports.razor"
using SOS.FMS.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\Btech\Desktop\FMS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\Btech\Desktop\FMS\Client\_Imports.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
    public partial class Comments : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "kt_quick_cart");
            __builder.AddAttribute(2, "class", "offcanvas offcanvas-right p-10 offcanvas-on");
            __builder.AddAttribute(3, "style", "width:50%");
#nullable restore
#line 5 "C:\Users\Btech\Desktop\FMS\Client\Components\Emergency\Comments.razor"
     if (EmergencyCommentModal != null)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "offcanvas-header d-flex align-items-center justify-content-between pb-7");
            __builder.AddAttribute(6, "kt-hidden-height", "46");
            __builder.AddAttribute(7, "style");
            __builder.OpenElement(8, "h4");
            __builder.AddAttribute(9, "class", "font-weight-bold m-0");
            __builder.AddContent(10, 
#nullable restore
#line 9 "C:\Users\Btech\Desktop\FMS\Client\Components\Emergency\Comments.razor"
                                              EmergencyCommentModal.CheckPointName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "a");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\Btech\Desktop\FMS\Client\Components\Emergency\Comments.razor"
                         CloseEmergencyCommentModal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "class", "btn btn-xs btn-icon btn-light btn-hover-primary");
            __builder.AddAttribute(15, "id", "kt_quick_cart_close");
            __builder.AddMarkupContent(16, "<i class=\"ki ki-close icon-xs text-muted\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        \r\n        \r\n        ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "offcanvas-content pr-5 mr-n5 scroll ps ps--active-y");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "d-flex flex-column-fluid");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "container pl-0");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "row");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "col-xl-12");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "card border border-secondary");
            __builder.AddMarkupContent(30, "<div class=\"card-header\"><div class=\"card-title mb-0 font-weight-bolder\">Comments</div></div>\r\n                                \r\n                                ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "card-body");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "scrollable");
            __builder.AddAttribute(35, "style", "overflow-y: auto; max-height: 250px;");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "messages");
#nullable restore
#line 32 "C:\Users\Btech\Desktop\FMS\Client\Components\Emergency\Comments.razor"
                                             foreach (var comment in EmergencyCommentModal.Comments)
                                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "d-flex flex-column mb-5 align-items-start");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "d-flex align-items-center");
            __builder.OpenElement(42, "div");
            __builder.OpenElement(43, "a");
            __builder.AddAttribute(44, "href", "#");
            __builder.AddAttribute(45, "class", "text-dark-75 text-hover-primary font-weight-bold font-size-lg");
            __builder.AddContent(46, 
#nullable restore
#line 38 "C:\Users\Btech\Desktop\FMS\Client\Components\Emergency\Comments.razor"
                                                                                                                                               comment.FMSUserName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                                                            ");
            __builder.OpenElement(48, "span");
            __builder.AddAttribute(49, "class", "text-muted font-size-sm");
            __builder.AddContent(50, 
#nullable restore
#line 39 "C:\Users\Btech\Desktop\FMS\Client\Components\Emergency\Comments.razor"
                                                                                                   comment.LastUpdated

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                                                    ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "mt-2 rounded p-5 bg-light-secondary text-dark-50 font-weight-bold font-size-sm text-left w-90");
            __builder.AddContent(54, 
#nullable restore
#line 42 "C:\Users\Btech\Desktop\FMS\Client\Components\Emergency\Comments.razor"
                                                                                                                                                                comment.Comment

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 45 "C:\Users\Btech\Desktop\FMS\Client\Components\Emergency\Comments.razor"
                                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                                \r\n                                ");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "card-footer p-0");
#nullable restore
#line 52 "C:\Users\Btech\Desktop\FMS\Client\Components\Emergency\Comments.razor"
                                     if (!resetCommentBox)
                                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "input-group p-2");
            __builder.AddMarkupContent(60, "<textarea id=\"mention1\" class=\"form-control\" placeholder=\"Type comment here.\" style=\"resize: none\" rows=\"3\" aria-label=\"With textarea\"></textarea>\r\n                                            ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "input-group-append");
            __builder.OpenElement(63, "span");
            __builder.AddAttribute(64, "class", "input-group-text btn btn-fms");
            __builder.AddAttribute(65, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "C:\Users\Btech\Desktop\FMS\Client\Components\Emergency\Comments.razor"
                                                                                                     PostEmergencyComment

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(66, "Post");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 61 "C:\Users\Btech\Desktop\FMS\Client\Components\Emergency\Comments.razor"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(67, @"<div class=""input-group p-2""><textarea id=""mention5"" class=""form-control"" placeholder=""Type comment here."" style=""resize: none"" rows=""3"" aria-label=""With textarea""></textarea>
                                            <div class=""input-group-append""><span class=""input-group-text btn btn-fms"">Post</span></div></div>");
#nullable restore
#line 71 "C:\Users\Btech\Desktop\FMS\Client\Components\Emergency\Comments.razor"
                                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                    ");
            __builder.OpenComponent<SOS.FMS.Client.Components.Emergency.ImageUpload>(69);
            __builder.AddAttribute(70, "FMSEmergencyCommentModalVM", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<SOS.FMS.Shared.ViewModels.FMSEmergencyCommentModalVM>(
#nullable restore
#line 98 "C:\Users\Btech\Desktop\FMS\Client\Components\Emergency\Comments.razor"
                                                                                                 EmergencyCommentModal

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 105 "C:\Users\Btech\Desktop\FMS\Client\Components\Emergency\Comments.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(71, "<img style=\"position:fixed;top:50%;left:70%;\" src=\"assets/media/loading.gif\">");
#nullable restore
#line 109 "C:\Users\Btech\Desktop\FMS\Client\Components\Emergency\Comments.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 111 "C:\Users\Btech\Desktop\FMS\Client\Components\Emergency\Comments.razor"
       
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
