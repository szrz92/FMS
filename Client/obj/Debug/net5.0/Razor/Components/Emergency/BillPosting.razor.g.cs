#pragma checksum "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Emergency\BillPosting.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab341d70a5a1c24f379bbacfb7f9dae2e508599e"
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
    public partial class BillPosting : Microsoft.AspNetCore.Components.ComponentBase
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
#line 8 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Emergency\BillPosting.razor"
                                          CheckPointId.Remarks

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(11, " ");
            __builder.AddContent(12, 
#nullable restore
#line 8 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Emergency\BillPosting.razor"
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
#line 9 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Emergency\BillPosting.razor"
                     CloseBillPosting

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
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(24);
            __builder.AddAttribute(25, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 17 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Emergency\BillPosting.razor"
                             bill

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 17 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Emergency\BillPosting.razor"
                                                  PostBill

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(28);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(30);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\r\n                ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "card w-100");
                __builder2.AddMarkupContent(34, "<div class=\"card-header\">\r\n                        Total Amount:\r\n                    </div>\r\n                    ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "card-body");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "d-flex flex-column");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "form-group");
                __Blazor.SOS.FMS.Client.Components.Emergency.BillPosting.TypeInference.CreateSfNumericTextBox_0(__builder2, 41, 42, "form-control", 43, 
#nullable restore
#line 27 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Emergency\BillPosting.razor"
                                                               bill.BillAmount

#line default
#line hidden
#nullable disable
                , 44, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => bill.BillAmount = __value, bill.BillAmount)), 45, () => bill.BillAmount);
                __builder2.AddMarkupContent(46, "\r\n                                ");
                __builder2.AddMarkupContent(47, "<span class=\"form-text text-muted\">Please enter total amount paid</span>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n                            ");
                __builder2.OpenComponent<SOS.FMS.Client.Components.Accident.ImageUpload>(49);
                __builder2.AddAttribute(50, "OnImagePost", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 30 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Emergency\BillPosting.razor"
                                                                                         OnImagePost

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n                    ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "card-footer");
                __builder2.AddMarkupContent(54, "<button type=\"submit\" class=\"btn btn-primary mr-2\">Submit</button>\r\n                        ");
                __builder2.OpenElement(55, "button");
                __builder2.AddAttribute(56, "type", "reset");
                __builder2.AddAttribute(57, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Emergency\BillPosting.razor"
                                                       CloseBillPosting

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(58, "class", "btn btn-secondary");
                __builder2.AddContent(59, "Cancel");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Emergency\BillPosting.razor"
       
    [Parameter]
    public ApiRequest CheckPointId { get; set; }
    [Parameter]
    public string VehicleNumber { get; set; }
    [Parameter]
    public bool Visible { get; set; }
    [Parameter]
    public EventCallback<bool> OnVisibilityChanged { get; set; }

    FMSEmergencyCheckCommentVM EmergencyCheckComment;

    public BillPostingVM BillPostingVM = new BillPostingVM();
    public EmergencyBill bill = new EmergencyBill();

    public List<EmergencyBill> BillsList = new List<EmergencyBill>();

    protected override async Task OnInitializedAsync()
    {
        BillsList = await GetBills();
        await base.OnInitializedAsync();
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        bill.CheckPointId = CheckPointId.FMSEmergencyCheckId;
        BillPostingVM.CheckPointId = CheckPointId.FMSEmergencyCheckId;
        await base.OnAfterRenderAsync(firstRender);
    }

    public void OnImagePost(string image)
    {
        BillPostingVM.images.Add(image);
        bill.BillImage = image;
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

    public async void PostBill()
    {
        var postBillResponse = await Http.PostAsJsonAsync<EmergencyBill>("api/Emergency/PostBill", bill);

        if (postBillResponse.StatusCode == System.Net.HttpStatusCode.OK)
        {
            BillsList = await GetBills();
            StateHasChanged();
        }
        else
        {
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
namespace __Blazor.SOS.FMS.Client.Components.Emergency.BillPosting
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateSfNumericTextBox_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Inputs.SfNumericTextBox<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
