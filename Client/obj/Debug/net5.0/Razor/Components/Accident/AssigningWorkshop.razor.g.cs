#pragma checksum "C:\Users\Btech\source\repos\fms\Client\Components\Accident\AssigningWorkshop.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "06e5dc33c7a1bd22048499fc932583ee8e7c9221"
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
    public partial class AssigningWorkshop : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "kt_quick_cart");
            __builder.AddAttribute(2, "class", "offcanvas offcanvas-right p-10 offcanvas-on");
            __builder.AddAttribute(3, "style", "width:50%");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "offcanvas-header d-flex align-items-center justify-content-between pb-7");
            __builder.AddAttribute(6, "kt-hidden-height", "46");
            __builder.AddAttribute(7, "style");
            __builder.OpenElement(8, "h4");
            __builder.AddAttribute(9, "class", "font-weight-bold m-0");
            __builder.AddContent(10, 
#nullable restore
#line 7 "C:\Users\Btech\source\repos\fms\Client\Components\Accident\AssigningWorkshop.razor"
                                          CheckPointId.Remarks

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(11, " ");
            __builder.AddContent(12, 
#nullable restore
#line 7 "C:\Users\Btech\source\repos\fms\Client\Components\Accident\AssigningWorkshop.razor"
                                                                VehicleNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "a");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\Btech\source\repos\fms\Client\Components\Accident\AssigningWorkshop.razor"
                     Close

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "class", "btn btn-xs btn-icon btn-light btn-hover-primary");
            __builder.AddAttribute(17, "id", "kt_quick_cart_close");
            __builder.AddMarkupContent(18, "<i class=\"ki ki-close icon-xs text-muted\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n    \r\n    \r\n    ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "offcanvas-content pr-5 mr-n5 scroll ps ps--active-y");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "d-flex flex-column");
#nullable restore
#line 16 "C:\Users\Btech\source\repos\fms\Client\Components\Accident\AssigningWorkshop.razor"
             if (!loading)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(24);
            __builder.AddAttribute(25, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 18 "C:\Users\Btech\source\repos\fms\Client\Components\Accident\AssigningWorkshop.razor"
                                 WorkshopVM

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 18 "C:\Users\Btech\source\repos\fms\Client\Components\Accident\AssigningWorkshop.razor"
                                                            OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "form-group");
                __builder2.AddMarkupContent(30, "<label>Vendor Type:</label>\r\n                        ");
                __builder2.OpenComponent<Syncfusion.Blazor.DropDowns.SfDropDownList<string, SelectListItem>>(31);
                __builder2.AddAttribute(32, "PopupHeight", "230px");
                __builder2.AddAttribute(33, "Enabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 21 "C:\Users\Btech\source\repos\fms\Client\Components\Accident\AssigningWorkshop.razor"
                                                                                                            !readOnly

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "Placeholder", "Select a type");
                __builder2.AddAttribute(35, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<SelectListItem>>(
#nullable restore
#line 21 "C:\Users\Btech\source\repos\fms\Client\Components\Accident\AssigningWorkshop.razor"
                                                                                                                                                                                              VendorTypes

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 21 "C:\Users\Btech\source\repos\fms\Client\Components\Accident\AssigningWorkshop.razor"
                                                                                                                                                                WorkshopVM.Type

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => WorkshopVM.Type = __value, WorkshopVM.Type))));
                __builder2.AddAttribute(38, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<string>>>(() => WorkshopVM.Type));
                __builder2.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.DropDowns.DropDownListEvents<string>>(40);
                    __builder3.AddAttribute(41, "ValueChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.DropDowns.ChangeEventArgs<string>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.DropDowns.ChangeEventArgs<string>>(this, 
#nullable restore
#line 22 "C:\Users\Btech\source\repos\fms\Client\Components\Accident\AssigningWorkshop.razor"
                                                                             OnVendorTypeChange

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(42, "\r\n                            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.DropDowns.DropDownListFieldSettings>(43);
                    __builder3.AddAttribute(44, "Text", "Text");
                    __builder3.AddAttribute(45, "Value", "Value");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
#nullable restore
#line 25 "C:\Users\Btech\source\repos\fms\Client\Components\Accident\AssigningWorkshop.razor"
                         if (WorkshopVM.Type == "Approved")
                        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(46, "div");
                __builder2.AddAttribute(47, "class", "form-group");
                __builder2.AddMarkupContent(48, "<label>Vendor Name:</label>\r\n                                ");
                __builder2.OpenComponent<Syncfusion.Blazor.DropDowns.SfDropDownList<string, SelectListItem>>(49);
                __builder2.AddAttribute(50, "Enabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 29 "C:\Users\Btech\source\repos\fms\Client\Components\Accident\AssigningWorkshop.razor"
                                                                                                !readOnly

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "PopupHeight", "230px");
                __builder2.AddAttribute(52, "Placeholder", "Select a vendor");
                __builder2.AddAttribute(53, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<SelectListItem>>(
#nullable restore
#line 29 "C:\Users\Btech\source\repos\fms\Client\Components\Accident\AssigningWorkshop.razor"
                                                                                                                                                                                                        ApprovedVendors

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(54, "Readonly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 29 "C:\Users\Btech\source\repos\fms\Client\Components\Accident\AssigningWorkshop.razor"
                                                                                                                                                                                                                                    readOnly

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(55, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 29 "C:\Users\Btech\source\repos\fms\Client\Components\Accident\AssigningWorkshop.razor"
                                                                                                                                                                          WorkshopVM.Code

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(56, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => WorkshopVM.Code = __value, WorkshopVM.Code))));
                __builder2.AddAttribute(57, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<string>>>(() => WorkshopVM.Code));
                __builder2.AddAttribute(58, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.DropDowns.DropDownListEvents<string>>(59);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(60, "\r\n                                    ");
                    __builder3.OpenComponent<Syncfusion.Blazor.DropDowns.DropDownListFieldSettings>(61);
                    __builder3.AddAttribute(62, "Text", "Text");
                    __builder3.AddAttribute(63, "Value", "Value");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
#nullable restore
#line 34 "C:\Users\Btech\source\repos\fms\Client\Components\Accident\AssigningWorkshop.razor"
                        }
                        else if (WorkshopVM.Type == "Un Approved")
                        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "form-group");
                __builder2.AddMarkupContent(66, "<label>Vendor Name:</label>\r\n                                ");
                __builder2.OpenComponent<Syncfusion.Blazor.DropDowns.SfDropDownList<string, SelectListItem>>(67);
                __builder2.AddAttribute(68, "Enabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 39 "C:\Users\Btech\source\repos\fms\Client\Components\Accident\AssigningWorkshop.razor"
                                                                                !readOnly

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(69, "PopupHeight", "230px");
                __builder2.AddAttribute(70, "Placeholder", "Select a vendor");
                __builder2.AddAttribute(71, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<SelectListItem>>(
#nullable restore
#line 39 "C:\Users\Btech\source\repos\fms\Client\Components\Accident\AssigningWorkshop.razor"
                                                                                                                                                                                                        UnApprovedVendors

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(72, "Readonly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 39 "C:\Users\Btech\source\repos\fms\Client\Components\Accident\AssigningWorkshop.razor"
                                                                                                                                                                                                                                      readOnly

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(73, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 39 "C:\Users\Btech\source\repos\fms\Client\Components\Accident\AssigningWorkshop.razor"
                                                                                                                                                                          WorkshopVM.Code

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(74, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => WorkshopVM.Code = __value, WorkshopVM.Code))));
                __builder2.AddAttribute(75, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<string>>>(() => WorkshopVM.Code));
                __builder2.AddAttribute(76, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.DropDowns.DropDownListEvents<string>>(77);
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(78, "\r\n                                    ");
                    __builder3.OpenComponent<Syncfusion.Blazor.DropDowns.DropDownListFieldSettings>(79);
                    __builder3.AddAttribute(80, "Text", "Text");
                    __builder3.AddAttribute(81, "Value", "Value");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
#nullable restore
#line 44 "C:\Users\Btech\source\repos\fms\Client\Components\Accident\AssigningWorkshop.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(82, "div");
                __builder2.AddAttribute(83, "class", "form-group");
                __builder2.AddMarkupContent(84, "<label>Remarks:</label>\r\n                            ");
                __builder2.OpenComponent<Syncfusion.Blazor.Inputs.SfTextBox>(85);
                __builder2.AddAttribute(86, "class", "form-control");
                __builder2.AddAttribute(87, "Multiline", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 47 "C:\Users\Btech\source\repos\fms\Client\Components\Accident\AssigningWorkshop.razor"
                                                                                                         true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(88, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 47 "C:\Users\Btech\source\repos\fms\Client\Components\Accident\AssigningWorkshop.razor"
                                                    WorkshopVM.Remarks

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(89, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => WorkshopVM.Remarks = __value, WorkshopVM.Remarks))));
                __builder2.AddAttribute(90, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => WorkshopVM.Remarks));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(91, "\r\n                            \r\n                            ");
                __builder2.AddMarkupContent(92, "<span class=\"form-text text-muted\">Please enter remarks</span>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n                        ");
                __builder2.OpenElement(94, "button");
                __builder2.AddAttribute(95, "type", "submit");
                __builder2.AddAttribute(96, "class", "btn btn-fms ml-2 mt-2");
                __builder2.AddAttribute(97, "disabled", 
#nullable restore
#line 52 "C:\Users\Btech\source\repos\fms\Client\Components\Accident\AssigningWorkshop.razor"
                                                                                       readOnly

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(98, "SUBMIT");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 56 "C:\Users\Btech\source\repos\fms\Client\Components\Accident\AssigningWorkshop.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(99, "<img style=\"position:fixed;top:50%;left:70%;\" src=\"assets/media/loading.gif\">");
#nullable restore
#line 60 "C:\Users\Btech\source\repos\fms\Client\Components\Accident\AssigningWorkshop.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "C:\Users\Btech\source\repos\fms\Client\Components\Accident\AssigningWorkshop.razor"
       
    [Parameter]
    public ApiRequest CheckPointId { get; set; }
    [Parameter]
    public string VehicleNumber { get; set; }
    [Parameter]
    public bool Visible { get; set; }
    [Parameter]
    public EventCallback<bool> OnVisibilityChanged { get; set; }

    public List<SelectListItem> VendorTypes { get; set; } = new List<SelectListItem>
{
        new SelectListItem(){ Text ="Approved", Value= "Approved" },
        new SelectListItem(){ Text ="Un Approved", Value= "Un Approved" }
    };

    public List<SelectListItem> ApprovedVendors { get; set; }
    public List<SelectListItem> UnApprovedVendors { get; set; }

    public WorkshopVM WorkshopVM { get; set; }

    public bool readOnly { get; set; } = false;

    public bool loading { get; set; } = false;

    protected override async Task OnInitializedAsync()
    {
        loading = true;
        ApprovedVendors = await Http.GetFromJsonAsync<List<SelectListItem>>("api/vendors/all");
        UnApprovedVendors = await Http.GetFromJsonAsync<List<SelectListItem>>("api/drivers/all");

        WorkshopVM = new WorkshopVM() { IncidentId = CheckPointId.FMSAccidentId, CheckId = CheckPointId.FMSAccidentalCheckId, IncidentType = "Accident" };

        var responseMessage = await Http.PostAsJsonAsync("api/vendors/CheckAssigned", WorkshopVM);
        if (responseMessage.IsSuccessStatusCode)
        {
            WorkshopVM = JsonConvert.DeserializeObject<WorkshopVM>(await responseMessage.Content.ReadAsStringAsync());
            readOnly = true;
        }
        loading = false;
        await base.OnInitializedAsync();
    }

    public Task Close()
    {
        return OnVisibilityChanged.InvokeAsync(false);
    }

    public void OnVendorTypeChange(Syncfusion.Blazor.DropDowns.ChangeEventArgs<string> args)
    {
        if (args.Value != null)
        {
            readOnly = false;
            WorkshopVM.Type = args.Value;
            StateHasChanged();
        }
    }

    public async void OnValidSubmit()
    {
        loading = true;
        var submitResponse = await Http.PostAsJsonAsync("api/vendors/assign", WorkshopVM);
        if (submitResponse.IsSuccessStatusCode)
        {
            readOnly = true;
            loading = false;
            await Close();
        }
        else
        {
            readOnly = false;
            loading = false;
        }
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
