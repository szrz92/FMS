#pragma checksum "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Emergency\AddBillDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86e18a6629dbb3a3682a80ff10c0df78868e2fbc"
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
#line 3 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Emergency\AddBillDetails.razor"
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
#line 4 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Emergency\AddBillDetails.razor"
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
#line 9 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Emergency\AddBillDetails.razor"
                                              CheckPointId.Remarks

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(11, " ");
            __builder.AddContent(12, 
#nullable restore
#line 9 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Emergency\AddBillDetails.razor"
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
#line 10 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Emergency\AddBillDetails.razor"
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
#nullable restore
#line 17 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Emergency\AddBillDetails.razor"
             if (ServiceTypes != null)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "d-flex flex-column");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(24);
            __builder.AddAttribute(25, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 20 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Emergency\AddBillDetails.razor"
                                     BillDetail

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 20 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Emergency\AddBillDetails.razor"
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
                __builder2.AddMarkupContent(32, "<label>Service Type:</label>\r\n                                ");
                __builder2.OpenComponent<Syncfusion.Blazor.DropDowns.SfDropDownList<string, SelectListItem>>(33);
                __builder2.AddAttribute(34, "Placeholder", "Select service type");
                __builder2.AddAttribute(35, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 24 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Emergency\AddBillDetails.razor"
                                                                                                                                                                              true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<SelectListItem>>(
#nullable restore
#line 24 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Emergency\AddBillDetails.razor"
                                                                                                                                                                                                 ServiceList

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 24 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Emergency\AddBillDetails.razor"
                                                                                                    BillDetail.ServiceType

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => BillDetail.ServiceType = __value, BillDetail.ServiceType))));
                __builder2.AddAttribute(39, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<string>>>(() => BillDetail.ServiceType));
                __builder2.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.DropDowns.DropDownListFieldSettings>(41);
                    __builder3.AddAttribute(42, "Text", "Text");
                    __builder3.AddAttribute(43, "Value", "Value");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(44, "\r\n                                    ");
                    __builder3.OpenComponent<Syncfusion.Blazor.DropDowns.DropDownListEvents<string>>(45);
                    __builder3.AddAttribute(46, "ValueChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.DropDowns.ChangeEventArgs<string>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.DropDowns.ChangeEventArgs<string>>(this, 
#nullable restore
#line 26 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Emergency\AddBillDetails.razor"
                                                                                     OnServiceTypeChange

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(47, "\r\n                                ");
                __builder2.AddMarkupContent(48, "<span class=\"form-text text-muted\">Select Service Type</span>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n                            ");
                __builder2.OpenElement(50, "div");
                __builder2.AddAttribute(51, "class", "form-group");
                __builder2.AddMarkupContent(52, "<label>Sub Service Type:</label>\r\n                                ");
                __builder2.OpenComponent<Syncfusion.Blazor.DropDowns.SfDropDownList<string, SelectListItem>>(53);
                __builder2.AddAttribute(54, "Placeholder", "Select sub service type");
                __builder2.AddAttribute(55, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 32 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Emergency\AddBillDetails.razor"
                                                                                                                                                                                     true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(56, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<SelectListItem>>(
#nullable restore
#line 32 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Emergency\AddBillDetails.razor"
                                                                                                                                                                                                        SubServiceList

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(57, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 32 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Emergency\AddBillDetails.razor"
                                                                                                    BillDetail.SubServiceType

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(58, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => BillDetail.SubServiceType = __value, BillDetail.SubServiceType))));
                __builder2.AddAttribute(59, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<string>>>(() => BillDetail.SubServiceType));
                __builder2.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.DropDowns.DropDownListFieldSettings>(61);
                    __builder3.AddAttribute(62, "Text", "Text");
                    __builder3.AddAttribute(63, "Value", "Value");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(64, "\r\n                                    ");
                    __builder3.OpenComponent<Syncfusion.Blazor.DropDowns.DropDownListEvents<string>>(65);
                    __builder3.AddAttribute(66, "ValueChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.DropDowns.ChangeEventArgs<string>>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.DropDowns.ChangeEventArgs<string>>(this, 
#nullable restore
#line 34 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Emergency\AddBillDetails.razor"
                                                                                     OnSubServiceTypeChange

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(67, "\r\n                                ");
                __builder2.AddMarkupContent(68, "<span class=\"form-text text-muted\">Select Sub Service Type</span>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n                            ");
                __builder2.OpenElement(70, "div");
                __builder2.AddAttribute(71, "class", "form-group");
                __builder2.AddMarkupContent(72, "<label>Amount:</label>\r\n                                ");
                __Blazor.SOS.FMS.Client.Components.Emergency.AddBillDetails.TypeInference.CreateSfNumericTextBox_0(__builder2, 73, 74, "InputType.Text", 75, "Enter Amount", 76, 
#nullable restore
#line 40 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Emergency\AddBillDetails.razor"
                                                                                     BillDetail.Amount

#line default
#line hidden
#nullable disable
                , 77, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => BillDetail.Amount = __value, BillDetail.Amount)), 78, () => BillDetail.Amount);
                __builder2.AddMarkupContent(79, "\r\n                                ");
                __builder2.AddMarkupContent(80, "<span class=\"form-text text-muted\">Enter Amount</span>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n                            ");
                __builder2.OpenElement(82, "div");
                __builder2.AddAttribute(83, "class", "form-group");
                __builder2.AddMarkupContent(84, "<label>Odometer:</label>\r\n                                ");
                __builder2.OpenComponent<Syncfusion.Blazor.Inputs.SfTextBox>(85);
                __builder2.AddAttribute(86, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Inputs.InputType>(
#nullable restore
#line 45 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Emergency\AddBillDetails.razor"
                                                 InputType.Number

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(87, "Placeholder", "Enter Odometer");
                __builder2.AddAttribute(88, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 45 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Emergency\AddBillDetails.razor"
                                                                                BillDetail.Odometer

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(89, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => BillDetail.Odometer = __value, BillDetail.Odometer))));
                __builder2.AddAttribute(90, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => BillDetail.Odometer));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(91, "\r\n                                ");
                __builder2.AddMarkupContent(92, "<span class=\"form-text text-muted\">Enter Odometer</span>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n                        ");
                __builder2.AddMarkupContent(94, "<div class=\"card-footer\"><button type=\"submit\" class=\"btn btn-fms mr-2\">Submit</button>\r\n                            <button type=\"reset\" class=\"btn btn-secondary\">Cancel</button></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 55 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Emergency\AddBillDetails.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(95, "<img style=\"position:fixed;top:50%;left:70%;\" src=\"assets/media/loading.gif\">");
#nullable restore
#line 59 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Emergency\AddBillDetails.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 63 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Emergency\AddBillDetails.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 64 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Emergency\AddBillDetails.razor"
       
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
        BillDetail = new BillDetailVM() { CheckPointId = CheckPointId.FMSEmergencyCheckId };
        await base.OnInitializedAsync();
    }

    public List<SelectListItem> ServiceList = new List<SelectListItem>();
    public List<SelectListItem> SubServiceList = new List<SelectListItem>();
    List<ServicesList> ServiceTypes { get; set; }

    public async void GetServiceTypes()
    {
        ServiceTypes = await Http.GetFromJsonAsync<List<ServicesList>>("api/Services");
        ServiceList = ServiceTypes.GroupBy(x => x.ServiceType).Select(x => new SelectListItem() { Text = x.Key, Value = x.Key }).ToList();
        SubServiceList = ServiceTypes.GroupBy(x => x.SubServiceType).Select(x => new SelectListItem() { Text = x.Key, Value = x.Key }).ToList();
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

    public void OnServiceTypeChange(Syncfusion.Blazor.DropDowns.ChangeEventArgs<string> args)
    {
        SubServiceList = ServiceTypes.Where(x => x.ServiceType == args.Value).GroupBy(x => x.SubServiceType).Select(x => new SelectListItem() { Text = x.Key, Value = x.Key }).ToList();
    }

    public void OnSubServiceTypeChange(Syncfusion.Blazor.DropDowns.ChangeEventArgs<string> args)
    {
        BillDetail.ServiceType = ServiceTypes.Where(x => x.SubServiceType == args.Value).FirstOrDefault().ServiceType;
    }

    public async void OnValidSubmit()
    {
        if (BillDetail.ServiceType != null && BillDetail.SubServiceType != null && BillDetail.Amount != 0)
        {
            var submitResponse = await Http.PostAsJsonAsync("api/Emergency/PostBillDetail", BillDetail);
            if (submitResponse.IsSuccessStatusCode)
            {
                await Close();
            }
            else
            {
            }
        }
    }

    public Task Close()
    {
        BillDetail = new BillDetailVM();
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
namespace __Blazor.SOS.FMS.Client.Components.Emergency.AddBillDetails
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateSfNumericTextBox_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, global::System.String __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Inputs.SfNumericTextBox<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Type", __arg0);
        __builder.AddAttribute(__seq1, "Placeholder", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
