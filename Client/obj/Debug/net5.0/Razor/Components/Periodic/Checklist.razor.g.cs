#pragma checksum "C:\Users\Btech\source\repos\fms\Client\Components\Periodic\Checklist.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "354ee02596787f1900f68eb2a1a78e71f1f7db09"
// <auto-generated/>
#pragma warning disable 1591
namespace SOS.FMS.Client.Components.Periodic
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
    public partial class Checklist : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 2 "C:\Users\Btech\source\repos\fms\Client\Components\Periodic\Checklist.razor"
 if (true)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "kt_quick_cart2");
            __builder.AddAttribute(2, "class", "offcanvas offcanvas-right p-10 offcanvas-on");
            __builder.AddAttribute(3, "style", "width:50%");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "offcanvas-header d-flex align-items-center justify-content-between pb-7");
            __builder.AddAttribute(6, "kt-hidden-height", "46");
            __builder.AddAttribute(7, "style");
            __builder.OpenElement(8, "h4");
            __builder.AddAttribute(9, "class", "font-weight-bold m-0");
            __builder.AddContent(10, "Periodic Maintenance for ");
            __builder.AddContent(11, 
#nullable restore
#line 7 "C:\Users\Btech\source\repos\fms\Client\Components\Periodic\Checklist.razor"
                                                                        VehicleNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "a");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\Btech\source\repos\fms\Client\Components\Periodic\Checklist.razor"
                         Close

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "class", "btn btn-xs btn-icon btn-light btn-hover-primary");
            __builder.AddAttribute(16, "id", "kt_quick_cart_close");
            __builder.AddMarkupContent(17, "<i class=\"ki ki-close icon-xs text-muted\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        \r\n        \r\n        ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "offcanvas-content pr-5 mr-n5 scroll ps ps--active-y");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "d-flex align-items-center justify-content-between py-4");
#nullable restore
#line 18 "C:\Users\Btech\source\repos\fms\Client\Components\Periodic\Checklist.razor"
                 if (PeriodicList != null)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(23, "table");
            __builder.AddAttribute(24, "class", "w-100");
            __builder.AddMarkupContent(25, @"<tr class=""row px-1 py-2 border-bottom""><td class=""col-5 text-dark font-weight-bolder"">Description</td>
                            <td class=""col-2 text-dark font-weight-bolder"">Status</td>
                            <td class=""col-3 text-dark font-weight-bolder"">Last Updated</td>
                            <td class=""col-2 text-dark font-weight-bolder"">Action</td></tr>");
#nullable restore
#line 27 "C:\Users\Btech\source\repos\fms\Client\Components\Periodic\Checklist.razor"
                         foreach (var item in PeriodicList)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(26, "tr");
            __builder.AddAttribute(27, "class", "row px-1 py-2 border-bottom");
            __builder.OpenElement(28, "td");
            __builder.AddAttribute(29, "class", "col-5");
            __builder.AddContent(30, 
#nullable restore
#line 30 "C:\Users\Btech\source\repos\fms\Client\Components\Periodic\Checklist.razor"
                                           item.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                        ");
            __builder.OpenElement(32, "td");
            __builder.AddAttribute(33, "class", "col-2");
            __builder.AddContent(34, 
#nullable restore
#line 31 "C:\Users\Btech\source\repos\fms\Client\Components\Periodic\Checklist.razor"
                                           item.Status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                        ");
            __builder.OpenElement(36, "td");
            __builder.AddAttribute(37, "class", "col-3");
            __builder.AddContent(38, 
#nullable restore
#line 32 "C:\Users\Btech\source\repos\fms\Client\Components\Periodic\Checklist.razor"
                                           item.LastCheckTime

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                        ");
            __builder.OpenElement(40, "td");
            __builder.AddAttribute(41, "class", "col-2");
#nullable restore
#line 34 "C:\Users\Btech\source\repos\fms\Client\Components\Periodic\Checklist.razor"
                             if (@item.Status != "Maintained")
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(42, "button");
            __builder.AddAttribute(43, "class", "btn btn-primary");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\Btech\source\repos\fms\Client\Components\Periodic\Checklist.razor"
                                                                          ()=>MaintainNow(item.Description)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(45, "MAINTAIN NOW");
            __builder.CloseElement();
#nullable restore
#line 37 "C:\Users\Btech\source\repos\fms\Client\Components\Periodic\Checklist.razor"
                            }
                            

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 44 "C:\Users\Btech\source\repos\fms\Client\Components\Periodic\Checklist.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 46 "C:\Users\Btech\source\repos\fms\Client\Components\Periodic\Checklist.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(46, "<p>Loading...</p>");
#nullable restore
#line 50 "C:\Users\Btech\source\repos\fms\Client\Components\Periodic\Checklist.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n\r\n        <div class=\"offcanvas-footer\" kt-hidden-height=\"112\" style></div>");
            __builder.CloseElement();
#nullable restore
#line 58 "C:\Users\Btech\source\repos\fms\Client\Components\Periodic\Checklist.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "C:\Users\Btech\source\repos\fms\Client\Components\Periodic\Checklist.razor"
       
    [Parameter]
    public string VehicleNumber { get; set; }
    [Parameter]
    public EventCallback<bool> OnVisibilityChanged { get; set; }

    public List<PeriodicVM> PeriodicList { get; set; }

    protected override async Task OnInitializedAsync()
    {
        PeriodicList = JsonConvert.DeserializeObject<List<PeriodicVM>>(
            await (await Http.PostAsJsonAsync("api/Periodic/Status/Last", new ApiRequest() { VehicleNumber = VehicleNumber }))
        .Content.ReadAsStringAsync());
        await base.OnInitializedAsync();
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await base.OnAfterRenderAsync(firstRender);
    }
    public async void MaintainNow(string Description)
    {
        PeriodicList = null;
        var maintainResponse = await Http.PostAsJsonAsync("api/Periodic/Maintain", new ApiRequest() { Remarks = Description, VehicleNumber = VehicleNumber });
        PeriodicList = JsonConvert.DeserializeObject<List<PeriodicVM>>(
            await (await Http.PostAsJsonAsync("api/Periodic/Status/Last", new ApiRequest() { VehicleNumber = VehicleNumber }))
        .Content.ReadAsStringAsync());
        StateHasChanged();
    }
    public Task Close()
    {
        return OnVisibilityChanged.InvokeAsync(false);
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
