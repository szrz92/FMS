#pragma checksum "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Accident\AddBillDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8b6972600aa2f950435fb93c4b991a537ef3ada"
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
#nullable restore
#line 3 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Accident\AddBillDetails.razor"
using SOS.FMS.Shared.ViewModels.Accident;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Accident\AddBillDetails.razor"
using SOS.FMS.Shared.ViewModels.Incident;

#line default
#line hidden
#nullable disable
    public partial class AddBillDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Accident\AddBillDetails.razor"
 if (Visible)
{

#line default
#line hidden
#nullable disable
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
#line 10 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Accident\AddBillDetails.razor"
                                              CheckPointId.Remarks

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(11, " ");
            __builder.AddContent(12, 
#nullable restore
#line 10 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Accident\AddBillDetails.razor"
                                                                    VehicleNumber

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.OpenElement(14, "a");
            __builder.AddAttribute(15, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Accident\AddBillDetails.razor"
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
            __builder.AddMarkupContent(19, "\r\n        \r\n        \r\n        ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "offcanvas-content pr-5 mr-n5 scroll ps ps--active-y");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "d-flex flex-column");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(24);
            __builder.AddAttribute(25, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 19 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Accident\AddBillDetails.razor"
                                 BillDetail

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 19 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Accident\AddBillDetails.razor"
                                                            OnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "card-body");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "form-group");
                __builder2.AddMarkupContent(32, "<label>Service Type:</label>\r\n                            ");
                __builder2.OpenComponent<Syncfusion.Blazor.DropDowns.SfDropDownList<string, ServicesList>>(33);
                __builder2.AddAttribute(34, "Placeholder", "Select a service");
                __builder2.AddAttribute(35, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 23 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Accident\AddBillDetails.razor"
                                                                                                                                                                     true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<ServicesList>>(
#nullable restore
#line 23 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Accident\AddBillDetails.razor"
                                                                                                                                                                                        ServiceTypes

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 23 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Accident\AddBillDetails.razor"
                                                                                              BillDetail.ServiceType

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => BillDetail.ServiceType = __value, BillDetail.ServiceType))));
                __builder2.AddAttribute(39, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<string>>>(() => BillDetail.ServiceType));
                __builder2.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.DropDowns.DropDownListFieldSettings>(41);
                    __builder3.AddAttribute(42, "Text", "ServiceType");
                    __builder3.AddAttribute(43, "Value", "ServiceType");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(44, "\r\n                            ");
                __builder2.AddMarkupContent(45, "<span class=\"form-text text-muted\">Select Service Type</span>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n                        ");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "form-group");
                __builder2.AddMarkupContent(49, "<label>Sub Service Type:</label>\r\n                            ");
                __builder2.OpenComponent<Syncfusion.Blazor.DropDowns.SfDropDownList<string, ServicesList>>(50);
                __builder2.AddAttribute(51, "Placeholder", "Select a sub service");
                __builder2.AddAttribute(52, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 30 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Accident\AddBillDetails.razor"
                                                                                                                                                                            true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(53, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<ServicesList>>(
#nullable restore
#line 30 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Accident\AddBillDetails.razor"
                                                                                                                                                                                               ServiceTypes

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(54, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 30 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Accident\AddBillDetails.razor"
                                                                                              BillDetail.SubServiceType

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(55, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => BillDetail.SubServiceType = __value, BillDetail.SubServiceType))));
                __builder2.AddAttribute(56, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<string>>>(() => BillDetail.SubServiceType));
                __builder2.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.DropDowns.DropDownListFieldSettings>(58);
                    __builder3.AddAttribute(59, "Text", "SubServiceType");
                    __builder3.AddAttribute(60, "Value", "SubServiceType");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(61, "\r\n                            ");
                __builder2.AddMarkupContent(62, "<span class=\"form-text text-muted\">Select Sub Service Type</span>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n                        ");
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "form-group");
                __builder2.AddMarkupContent(66, "<label>Amount:</label>\r\n                            ");
                __builder2.OpenComponent<Syncfusion.Blazor.Inputs.SfTextBox>(67);
                __builder2.AddAttribute(68, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Inputs.InputType>(
#nullable restore
#line 37 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Accident\AddBillDetails.razor"
                                             InputType.Text

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(69, "Placeholder", "Enter Amount");
                __builder2.AddAttribute(70, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 37 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Accident\AddBillDetails.razor"
                                                                          BillDetail.Amount

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(71, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => BillDetail.Amount = __value, BillDetail.Amount))));
                __builder2.AddAttribute(72, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => BillDetail.Amount));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(73, "\r\n                            ");
                __builder2.AddMarkupContent(74, "<span class=\"form-text text-muted\">Enter Amount</span>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\r\n                    ");
                __builder2.AddMarkupContent(76, "<div class=\"card-footer\"><button type=\"submit\" class=\"btn btn-fms mr-2\">Submit</button>\r\n                        <button type=\"reset\" class=\"btn btn-secondary\">Cancel</button></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 50 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Accident\AddBillDetails.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Accident\AddBillDetails.razor"
       
    [Parameter]
    public ApiRequest CheckPointId { get; set; }
    [Parameter]
    public string VehicleNumber { get; set; }
    [Parameter]
    public bool Visible { get; set; }
    [Parameter]
    public EventCallback<bool> OnVisibilityChanged { get; set; }

    public BillDetailVM BillDetail { get; set; }

    protected override async Task OnInitializedAsync()
    {
        GetServiceTypes();
        BillDetail = new BillDetailVM() { CheckPointId = CheckPointId.FMSAccidentalCheckId };
        await base.OnInitializedAsync();
    }

    List<ServicesList> ServiceTypes { get; set; }

    public async void GetServiceTypes()
    {
        ServiceTypes = await Http.GetFromJsonAsync<List<ServicesList>>("api/Services");
        if (ServiceTypes.Any())
        {

        }
        else
        {

        }
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await base.OnAfterRenderAsync(firstRender);
    }

    public async void OnValidSubmit()
    {
        var submitResponse = await Http.PostAsJsonAsync("api/Accident/PostBillDetail", BillDetail);
        if (submitResponse.IsSuccessStatusCode)
        {
            await Close();
        }
        else
        { 
        }
    }

    public Task Close()
    {
        return OnVisibilityChanged.InvokeAsync(false);
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
