#pragma checksum "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckListCommentBox.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68081fc8180cb3effe7a5fe6ac4d86fd84b18655"
// <auto-generated/>
#pragma warning disable 1591
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
    public partial class AccidentalCheckListCommentBox : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "kt_quick_cart");
            __builder.AddAttribute(2, "class", "offcanvas offcanvas-right p-10 offcanvas-on");
            __builder.AddAttribute(3, "style", "width:50%");
#nullable restore
#line 5 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckListCommentBox.razor"
     if (AccidentalCommentModal != null)
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
#line 9 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckListCommentBox.razor"
                                              AccidentalCommentModal.CheckPointName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "a");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckListCommentBox.razor"
                         CloseAccidentalCommentModal

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
            __builder.AddAttribute(27, "class", "col-xl-7");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "container");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "card border border-secondary");
            __builder.AddMarkupContent(32, "<div class=\"card-header\"><div class=\"card-title mb-0 font-weight-bolder\">Comments</div></div>\r\n                                    \r\n                                    ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "card-body");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "scrollable");
            __builder.AddAttribute(37, "style", "overflow-y: auto; max-height: 300px;");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "messages");
#nullable restore
#line 33 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckListCommentBox.razor"
                                                 foreach (var comment in AccidentalCommentModal.Comments)
                                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "d-flex flex-column mb-5 align-items-start");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "d-flex align-items-center");
            __builder.OpenElement(44, "div");
            __builder.OpenElement(45, "a");
            __builder.AddAttribute(46, "href", "#");
            __builder.AddAttribute(47, "class", "text-dark-75 text-hover-primary font-weight-bold font-size-lg");
            __builder.AddContent(48, 
#nullable restore
#line 39 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckListCommentBox.razor"
                                                                                                                                                   comment.FMSUserName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                                                                ");
            __builder.OpenElement(50, "span");
            __builder.AddAttribute(51, "class", "text-muted font-size-sm");
            __builder.AddContent(52, 
#nullable restore
#line 40 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckListCommentBox.razor"
                                                                                                       comment.LastUpdated

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                                                        ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "mt-2 rounded p-5 bg-light-secondary text-dark-50 font-weight-bold font-size-sm text-left w-90");
            __builder.AddContent(56, 
#nullable restore
#line 43 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckListCommentBox.razor"
                                                                                                                                                                    comment.Comment

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 46 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckListCommentBox.razor"
                                                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                                    \r\n                                    ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "card-footer p-0");
#nullable restore
#line 53 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckListCommentBox.razor"
                                         if (!resetCommentBox)
                                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "input-group p-2");
            __builder.AddMarkupContent(62, "<textarea id=\"mention1\" class=\"form-control\" placeholder=\"Type comment here.\" style=\"resize: none\" rows=\"3\" aria-label=\"With textarea\"></textarea>\r\n                                                ");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "input-group-append");
            __builder.OpenElement(65, "span");
            __builder.AddAttribute(66, "class", "input-group-text btn btn-fms");
            __builder.AddAttribute(67, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckListCommentBox.razor"
                                                                                                         PostAccidentalComment

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(68, "Post");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 62 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckListCommentBox.razor"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(69, @"<div class=""input-group p-2""><textarea id=""mention5"" class=""form-control"" placeholder=""Type comment here."" style=""resize: none"" rows=""3"" aria-label=""With textarea""></textarea>
                                                <div class=""input-group-append""><span class=""input-group-text btn btn-fms"">Post</span></div></div>");
#nullable restore
#line 72 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckListCommentBox.razor"
                                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                                <div class=\"row\"></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                        ");
            __builder.AddMarkupContent(72, @"<div class=""col-xl-5""><div class=""row""><div class=""card""><div class=""card-header""><div class=""card-title mb-0 font-weight-bolder"">History</div></div>
                                    <div class=""card-body""><div class=""row""><div class=""col-xl-4""><a href=""#"" class=""btn btn-fms-emergency font-weight-boldest font-size-sm px-2 py-5"">EMERGENCY <br> 15 JOBS</a></div>
                                            <div class=""col-xl-4""><a href=""#"" class=""btn btn-fms font-weight-boldest font-size-sm px-2 py-5"">ACCIDENTAL <br> 15 JOBS</a></div>
                                            <div class=""col-xl-4""><a href=""#"" class=""btn btn-fms-daily font-weight-boldest font-size-sm px-5 py-5 w-100"">DAILY <br> 15 JOBS</a></div></div></div></div></div>
                            <hr>
                            <div class=""row""><div class=""col-xl-12""><div class=""card""><div class=""card-header""><div class=""card-title mb-0 font-weight-bolder"">Photo Viewer</div></div>
                                        <div class=""card-body""><div class=""h-50""></div></div></div></div></div></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 150 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckListCommentBox.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(73, "<img style=\"position:fixed;top:50%;left:70%;\" src=\"assets/media/loading.gif\">");
#nullable restore
#line 154 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckListCommentBox.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 156 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckListCommentBox.razor"
       
    [Parameter]
    public FMSAccidentalCommentModalVM AccidentalCommentModal { get; set; }
    [Parameter]
    public ApiRequest CheckPointId { get; set; }
    [Parameter]
    public string VehicleNumber { get; set; }
    [Parameter]
    public bool Visible { get; set; }
    [Parameter]
    public EventCallback<bool> OnVisibilityChanged { get; set; }


    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }

    public ClaimsPrincipal CurrentUser { get; set; }

    private DotNetObjectReference<AccidentalCheckListCommentBox> dotNetObjectReference;

    public List<GBMSUserVM> usersList { get; set; } = new List<GBMSUserVM>();

    FMSAccidentalCheckCommentVM AccidentalCheckComment;

    public bool resetCommentBox { get; set; } = false;

    protected override async Task OnInitializedAsync()
    {
        CurrentUser = (await authenticationStateTask).User;
        dotNetObjectReference = DotNetObjectReference.Create(this);
        usersList = await Http.GetFromJsonAsync<List<GBMSUserVM>>("api/Users/FMS/All");

        await base.OnInitializedAsync();
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (usersList != null)
        {
            await JSRuntime.InvokeVoidAsync("mention", dotNetObjectReference, usersList);
        }

        if (AccidentalCommentModal == null)
        {
            await NewCommentModel();
        }
        await base.OnAfterRenderAsync(firstRender);
    }

    public async Task NewCommentModel()
    {
        AccidentalCheckComment = new FMSAccidentalCheckCommentVM();
        var getFMSAccidentalCommentModalResponse = await Http.PostAsJsonAsync<ApiRequest>("api/Accident/FMS/CheckList/Point",
            new ApiRequest() { FMSAccidentalCheckId = CheckPointId.FMSAccidentalCheckId, VehicleNumber = VehicleNumber });

        if (getFMSAccidentalCommentModalResponse.StatusCode == System.Net.HttpStatusCode.OK)
        {
            string response = await(getFMSAccidentalCommentModalResponse).Content.ReadAsStringAsync();
            AccidentalCommentModal = JsonConvert.DeserializeObject<FMSAccidentalCommentModalVM>(response);
            AccidentalCheckComment.FMSAccidentalCheckId = CheckPointId.FMSAccidentalCheckId;
            AccidentalCheckComment.FMSAccidentId = AccidentalCommentModal.FMSAccidentId;
            AccidentalCheckComment.FMSVehicleId = AccidentalCommentModal.FMSVehicleId;
            AccidentalCheckComment.VehicleNumber = AccidentalCommentModal.VehicleNumber;
        }
        else
        {
        }
    }

    public Task CloseAccidentalCommentModal()
    {
        return OnVisibilityChanged.InvokeAsync(false);
    }

    public async void PostAccidentalComment()
    {
        resetCommentBox = true;
        var postCommentResponse = await Http.PostAsJsonAsync<FMSAccidentalCheckCommentVM>("api/Accident/FMS/CheckList/Point/Comment/Add", AccidentalCheckComment);
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
