#pragma checksum "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Periodic\ShortPeriodicHistory.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7292b8f896454dc91566741840825b6130b853a9"
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
    public partial class ShortPeriodicHistory : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Periodic\ShortPeriodicHistory.razor"
 if (PeriodicList != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "d-flex flex-column");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "p-2");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "control-section");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "content-wrapper");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "row");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "id", "container");
            __Blazor.SOS.FMS.Client.Components.Periodic.ShortPeriodicHistory.TypeInference.CreateSfGrid_0(__builder, 12, 13, "PeriodicGrid", 14, 
#nullable restore
#line 11 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Periodic\ShortPeriodicHistory.razor"
                                                                                       PeriodicList

#line default
#line hidden
#nullable disable
            , 15, 
#nullable restore
#line 12 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Periodic\ShortPeriodicHistory.razor"
                                                 true

#line default
#line hidden
#nullable disable
            , 16, 
#nullable restore
#line 12 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Periodic\ShortPeriodicHistory.razor"
                                                                     true

#line default
#line hidden
#nullable disable
            , 17, 
#nullable restore
#line 12 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Periodic\ShortPeriodicHistory.razor"
                                                                                           true

#line default
#line hidden
#nullable disable
            , 18, 
#nullable restore
#line 12 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Periodic\ShortPeriodicHistory.razor"
                                                                                                            38

#line default
#line hidden
#nullable disable
            , 19, 
#nullable restore
#line 13 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Periodic\ShortPeriodicHistory.razor"
                                               new List<string>() { "ExcelExport", "CsvExport", "PdfExport" }

#line default
#line hidden
#nullable disable
            , 20, 
#nullable restore
#line 14 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Periodic\ShortPeriodicHistory.razor"
                                                      true

#line default
#line hidden
#nullable disable
            , 21, 
#nullable restore
#line 14 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Periodic\ShortPeriodicHistory.razor"
                                                                            true

#line default
#line hidden
#nullable disable
            , 22, (__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridPageSettings>(23);
                __builder2.AddAttribute(24, "PageCount", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 15 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Periodic\ShortPeriodicHistory.razor"
                                                             5

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 15 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Periodic\ShortPeriodicHistory.razor"
                                                                          20

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "PageSizes", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 15 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Periodic\ShortPeriodicHistory.razor"
                                                                                         new int[]{ 5, 10, 20, 50, 100 }

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n                                ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridFilterSettings>(28);
                __builder2.AddAttribute(29, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.FilterType>(
#nullable restore
#line 16 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Periodic\ShortPeriodicHistory.razor"
                                                          Syncfusion.Blazor.Grids.FilterType.Menu

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n                                ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridSelectionSettings>(31);
                __builder2.AddAttribute(32, "CheckboxOnly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Periodic\ShortPeriodicHistory.razor"
                                                                     true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "PersistSelection", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 17 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Periodic\ShortPeriodicHistory.razor"
                                                                                             true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.SelectionType>(
#nullable restore
#line 17 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Periodic\ShortPeriodicHistory.razor"
                                                                                                         SelectionType.Multiple

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n                                ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridEvents<PeriodicVM>>(36);
                __builder2.AddAttribute(37, "OnToolbarClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Navigations.ClickEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Navigations.ClickEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Periodic\ShortPeriodicHistory.razor"
                                                            PeriodicToolbarClick

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(38, "\r\n                                ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridColumns>(39);
                __builder2.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(41);
                    __builder3.AddAttribute(42, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Periodic\ShortPeriodicHistory.razor"
                                                       nameof(PeriodicVM.Description)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(43, "HeaderText", "Description");
                    __builder3.AddAttribute(44, "Width", "230");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(45, "\r\n                                    ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(46);
                    __builder3.AddAttribute(47, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Periodic\ShortPeriodicHistory.razor"
                                                       nameof(PeriodicVM.LastCheckDistance)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(48, "HeaderText", "Last (kms)");
                    __builder3.AddAttribute(49, "Width", "110");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(50, "\r\n                                    ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(51);
                    __builder3.AddAttribute(52, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Periodic\ShortPeriodicHistory.razor"
                                                       nameof(PeriodicVM.LastCheckTime)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(53, "HeaderText", "Last (time)");
                    __builder3.AddAttribute(54, "Width", "130");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(55, "\r\n                                    ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(56);
                    __builder3.AddAttribute(57, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Periodic\ShortPeriodicHistory.razor"
                                                       nameof(PeriodicVM.Status)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(58, "HeaderText", "Status");
                    __builder3.AddAttribute(59, "Width", "130");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            , 60, (__value) => {
#nullable restore
#line 11 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Periodic\ShortPeriodicHistory.razor"
                                                            PeriodicGrid = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 32 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Periodic\ShortPeriodicHistory.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(61, "<h5>Loading.....</h5>");
#nullable restore
#line 36 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Periodic\ShortPeriodicHistory.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Periodic\ShortPeriodicHistory.razor"
       
    [Parameter]
    public string VehicleNumber { get; set; }

    public List<PeriodicVM> PeriodicList { get; set; }

    protected override async Task OnInitializedAsync()
    {
        if (VehicleNumber != null)
        {
            PeriodicList = JsonConvert.DeserializeObject<List<PeriodicVM>>(
                await (await Http.PostAsJsonAsync("api/Periodic/Status", new ApiRequest() { VehicleNumber = VehicleNumber }))
            .Content.ReadAsStringAsync());
        }
        else
        {
            PeriodicList = (await Http.GetFromJsonAsync<List<PeriodicVM>>("api/Periodic/Status/All"))
            .ToList();
        };
        PeriodicList = PeriodicList.OrderByDescending(x => x.LastCheckTime).ToList();
        await base.OnInitializedAsync();
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            if (VehicleNumber != null)
            {
                PeriodicList = JsonConvert.DeserializeObject<List<PeriodicVM>>(
                    await (await Http.PostAsJsonAsync("api/Periodic/Status", new ApiRequest() { VehicleNumber = VehicleNumber }))
                .Content.ReadAsStringAsync());
            }
            else
            {
                PeriodicList = (await Http.GetFromJsonAsync<List<PeriodicVM>>("api/Periodic/Status/All"))
                .ToList();
            };
            PeriodicList = PeriodicList.OrderByDescending(x => x.LastCheckTime).ToList();
            StateHasChanged();
        }
        await base.OnAfterRenderAsync(firstRender);
    }

    #region Syncfusion

    SfGrid<PeriodicVM> PeriodicGrid;

    public void PeriodicToolbarClick(Syncfusion.Blazor.Navigations.ClickEventArgs args)
    {
        if (args.Item.Id == "PeriodicGrid_pdfexport")
        {
            PdfExportProperties Props = new PdfExportProperties();
            Props.PageOrientation = PageOrientation.Landscape;
            Props.PageSize = PdfPageSize.A4;
            this.PeriodicGrid.PdfExport(Props);
        }
        if (args.Item.Id == "PeriodicGrid_excelexport")
        {
            this.PeriodicGrid.ExcelExport();
        }
        if (args.Item.Id == "PeriodicGrid_csvexport")
        {
            this.PeriodicGrid.CsvExport();
        }
    }
    #endregion


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private INotificationService NotificationService { get; set; }
    }
}
namespace __Blazor.SOS.FMS.Client.Components.Periodic.ShortPeriodicHistory
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateSfGrid_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Collections.Generic.IEnumerable<TValue> __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, global::System.Double __arg5, int __seq6, global::System.Object __arg6, int __seq7, global::System.Boolean __arg7, int __seq8, global::System.Boolean __arg8, int __seq9, global::Microsoft.AspNetCore.Components.RenderFragment __arg9, int __seq10, global::System.Action<global::Syncfusion.Blazor.Grids.SfGrid<TValue>> __arg10)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Grids.SfGrid<TValue>>(seq);
        __builder.AddAttribute(__seq0, "ID", __arg0);
        __builder.AddAttribute(__seq1, "DataSource", __arg1);
        __builder.AddAttribute(__seq2, "AllowPaging", __arg2);
        __builder.AddAttribute(__seq3, "AllowSorting", __arg3);
        __builder.AddAttribute(__seq4, "AllowFiltering", __arg4);
        __builder.AddAttribute(__seq5, "RowHeight", __arg5);
        __builder.AddAttribute(__seq6, "Toolbar", __arg6);
        __builder.AddAttribute(__seq7, "AllowExcelExport", __arg7);
        __builder.AddAttribute(__seq8, "AllowPdfExport", __arg8);
        __builder.AddAttribute(__seq9, "ChildContent", __arg9);
        __builder.AddComponentReferenceCapture(__seq10, (__value) => { __arg10((global::Syncfusion.Blazor.Grids.SfGrid<TValue>)__value); });
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
