#pragma checksum "C:\Users\HP\source\repos\fms\Client\Components\Configuration\AddConfiguration.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e28ff7fe5b406837b09fa0a2a2a694932baee16a"
// <auto-generated/>
#pragma warning disable 1591
namespace SOS.FMS.Client.Components.Configuration
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\HP\source\repos\fms\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HP\source\repos\fms\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HP\source\repos\fms\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HP\source\repos\fms\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HP\source\repos\fms\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HP\source\repos\fms\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\HP\source\repos\fms\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\HP\source\repos\fms\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\HP\source\repos\fms\Client\_Imports.razor"
using SOS.FMS.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\HP\source\repos\fms\Client\_Imports.razor"
using SOS.FMS.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\HP\source\repos\fms\Client\_Imports.razor"
using SOS.FMS.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\HP\source\repos\fms\Client\_Imports.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\HP\source\repos\fms\Client\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\HP\source\repos\fms\Client\_Imports.razor"
using SOS.FMS.Client.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\HP\source\repos\fms\Client\_Imports.razor"
using SOS.FMS.Shared.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\HP\source\repos\fms\Client\_Imports.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\HP\source\repos\fms\Client\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\HP\source\repos\fms\Client\_Imports.razor"
using Syncfusion.Blazor.Spinner;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\HP\source\repos\fms\Client\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\HP\source\repos\fms\Client\_Imports.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\HP\source\repos\fms\Client\_Imports.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\HP\source\repos\fms\Client\_Imports.razor"
using Append.Blazor.Notifications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\HP\source\repos\fms\Client\_Imports.razor"
using SOS.FMS.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\HP\source\repos\fms\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\HP\source\repos\fms\Client\_Imports.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
    public partial class AddConfiguration : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "kt_quick_cart");
            __builder.AddAttribute(2, "class", "offcanvas offcanvas-right p-10 offcanvas-on");
#nullable restore
#line 5 "C:\Users\HP\source\repos\fms\Client\Components\Configuration\AddConfiguration.razor"
     if (configuration != null)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "offcanvas-header d-flex align-items-center justify-content-between pb-7");
            __builder.AddAttribute(5, "kt-hidden-height", "46");
            __builder.AddAttribute(6, "style");
            __builder.AddMarkupContent(7, "<h4 class=\"font-weight-bold m-0\">New Configuration for Vehicles</h4>\r\n            ");
            __builder.OpenElement(8, "a");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\HP\source\repos\fms\Client\Components\Configuration\AddConfiguration.razor"
                         Close

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "class", "btn btn-xs btn-icon btn-light btn-hover-primary");
            __builder.AddAttribute(11, "id", "kt_quick_cart_close");
            __builder.AddMarkupContent(12, "<i class=\"ki ki-close icon-xs text-muted\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        \r\n        \r\n        ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "offcanvas-content pr-5 mr-n5 scroll ps ps--active-y");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "d-flex flex-column-fluid");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(18);
            __builder.AddAttribute(19, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 18 "C:\Users\HP\source\repos\fms\Client\Components\Configuration\AddConfiguration.razor"
                                 configuration

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 18 "C:\Users\HP\source\repos\fms\Client\Components\Configuration\AddConfiguration.razor"
                                                               Submit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(22);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(23, "\r\n                    ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "form-group");
                __builder2.AddMarkupContent(26, "<label>Description:</label>\r\n                        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Inputs.SfTextBox>(27);
                __builder2.AddAttribute(28, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Inputs.InputType>(
#nullable restore
#line 22 "C:\Users\HP\source\repos\fms\Client\Components\Configuration\AddConfiguration.razor"
                                         InputType.Text

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "Placeholder", "Enter Description");
                __builder2.AddAttribute(30, "class", "form-control");
                __builder2.AddAttribute(31, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\HP\source\repos\fms\Client\Components\Configuration\AddConfiguration.razor"
                                                                                                      configuration.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(32, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => configuration.Description = __value, configuration.Description))));
                __builder2.AddAttribute(33, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => configuration.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\r\n                        ");
                __Blazor.SOS.FMS.Client.Components.Configuration.AddConfiguration.TypeInference.CreateValidationMessage_0(__builder2, 35, 36, 
#nullable restore
#line 23 "C:\Users\HP\source\repos\fms\Client\Components\Configuration\AddConfiguration.razor"
                                                () => configuration.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n                    ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "form-group");
                __builder2.AddMarkupContent(40, "<label>Months (Change Interval):</label>\r\n                        ");
                __Blazor.SOS.FMS.Client.Components.Configuration.AddConfiguration.TypeInference.CreateSfNumericTextBox_1(__builder2, 41, 42, "Enter Distance Limit", 43, "form-control", 44, 
#nullable restore
#line 27 "C:\Users\HP\source\repos\fms\Client\Components\Configuration\AddConfiguration.razor"
                                                                                          configuration.Month

#line default
#line hidden
#nullable disable
                , 45, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => configuration.Month = __value, configuration.Month)), 46, () => configuration.Month);
                __builder2.AddMarkupContent(47, "\r\n                        ");
                __Blazor.SOS.FMS.Client.Components.Configuration.AddConfiguration.TypeInference.CreateValidationMessage_2(__builder2, 48, 49, 
#nullable restore
#line 28 "C:\Users\HP\source\repos\fms\Client\Components\Configuration\AddConfiguration.razor"
                                                () => configuration.Month

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n                    ");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "form-group");
                __builder2.AddMarkupContent(53, "<label>Distance in KMs:</label>\r\n                        ");
                __Blazor.SOS.FMS.Client.Components.Configuration.AddConfiguration.TypeInference.CreateSfNumericTextBox_3(__builder2, 54, 55, "Enter Distance Limit", 56, "form-control", 57, 
#nullable restore
#line 32 "C:\Users\HP\source\repos\fms\Client\Components\Configuration\AddConfiguration.razor"
                                                                                          configuration.Distance

#line default
#line hidden
#nullable disable
                , 58, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => configuration.Distance = __value, configuration.Distance)), 59, () => configuration.Distance);
                __builder2.AddMarkupContent(60, "\r\n                        ");
                __Blazor.SOS.FMS.Client.Components.Configuration.AddConfiguration.TypeInference.CreateValidationMessage_4(__builder2, 61, 62, 
#nullable restore
#line 33 "C:\Users\HP\source\repos\fms\Client\Components\Configuration\AddConfiguration.razor"
                                                () => configuration.Distance

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n                    ");
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "form-group");
                __builder2.AddMarkupContent(66, "<label>Points:</label>\r\n                        ");
                __Blazor.SOS.FMS.Client.Components.Configuration.AddConfiguration.TypeInference.CreateSfNumericTextBox_5(__builder2, 67, 68, "Enter Points to be Deducted", 69, "form-control", 70, 
#nullable restore
#line 37 "C:\Users\HP\source\repos\fms\Client\Components\Configuration\AddConfiguration.razor"
                                                                                                 configuration.PenalityPoints

#line default
#line hidden
#nullable disable
                , 71, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => configuration.PenalityPoints = __value, configuration.PenalityPoints)), 72, () => configuration.PenalityPoints);
                __builder2.AddMarkupContent(73, "\r\n                        ");
                __Blazor.SOS.FMS.Client.Components.Configuration.AddConfiguration.TypeInference.CreateValidationMessage_6(__builder2, 74, 75, 
#nullable restore
#line 38 "C:\Users\HP\source\repos\fms\Client\Components\Configuration\AddConfiguration.razor"
                                                () => configuration.PenalityPoints

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n                    ");
                __builder2.AddMarkupContent(77, "<button type=\"submit\" class=\"btn btn-primary mr-2\">Submit</button>\r\n                    ");
                __builder2.OpenElement(78, "button");
                __builder2.AddAttribute(79, "type", "reset");
                __builder2.AddAttribute(80, "class", "btn btn-secondary");
                __builder2.AddAttribute(81, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\HP\source\repos\fms\Client\Components\Configuration\AddConfiguration.razor"
                                                                             Close

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(82, "Cancel");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 46 "C:\Users\HP\source\repos\fms\Client\Components\Configuration\AddConfiguration.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(83, "<img style=\"position:fixed;top:50%;left:70%;\" src=\"assets/media/loading.gif\">");
#nullable restore
#line 50 "C:\Users\HP\source\repos\fms\Client\Components\Configuration\AddConfiguration.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\Users\HP\source\repos\fms\Client\Components\Configuration\AddConfiguration.razor"
       
    [Parameter]
    public string VehicleNumber { get; set; }
    [Parameter]
    public bool Visible { get; set; }
    [Parameter]
    public EventCallback<bool> OnVisibilityChanged { get; set; }
    [Parameter]
    public EventCallback<VehicleConfigurationVM> OnSubmit { get; set; }

    VehicleConfigurationVM configuration { get; set; } = new VehicleConfigurationVM();

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await base.OnAfterRenderAsync(firstRender);
    }

    public async void Submit()
    {
        await OnSubmit.InvokeAsync(configuration);
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
namespace __Blazor.SOS.FMS.Client.Components.Configuration.AddConfiguration
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateSfNumericTextBox_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Inputs.SfNumericTextBox<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Placeholder", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateSfNumericTextBox_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Inputs.SfNumericTextBox<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Placeholder", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateSfNumericTextBox_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Inputs.SfNumericTextBox<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Placeholder", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
