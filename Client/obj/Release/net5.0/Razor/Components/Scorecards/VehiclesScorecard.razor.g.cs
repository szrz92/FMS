#pragma checksum "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Scorecards\VehiclesScorecard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c87d025fa220fefe2a4525f5091d425b9014972"
// <auto-generated/>
#pragma warning disable 1591
namespace SOS.FMS.Client.Components.Scorecards
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
    public partial class VehiclesScorecard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Scorecards\VehiclesScorecard.razor"
 if (FMSVehiclesList != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-lg-12 control-section");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "content-wrapper");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "id", "container");
            __Blazor.SOS.FMS.Client.Components.Scorecards.VehiclesScorecard.TypeInference.CreateSfGrid_0(__builder, 8, 9, "ScoreCardsGrid", 10, 
#nullable restore
#line 9 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Scorecards\VehiclesScorecard.razor"
                                                                                   FMSVehiclesList

#line default
#line hidden
#nullable disable
            , 11, 
#nullable restore
#line 9 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Scorecards\VehiclesScorecard.razor"
                                                                                                                    true

#line default
#line hidden
#nullable disable
            , 12, 
#nullable restore
#line 9 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Scorecards\VehiclesScorecard.razor"
                                                                                                                                        true

#line default
#line hidden
#nullable disable
            , 13, 
#nullable restore
#line 9 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Scorecards\VehiclesScorecard.razor"
                                                                                                                                                              true

#line default
#line hidden
#nullable disable
            , 14, 
#nullable restore
#line 9 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Scorecards\VehiclesScorecard.razor"
                                                                                                                                                                                          true

#line default
#line hidden
#nullable disable
            , 15, 
#nullable restore
#line 9 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Scorecards\VehiclesScorecard.razor"
                                                                                                                                                                                                             false

#line default
#line hidden
#nullable disable
            , 16, "600", 17, 
#nullable restore
#line 9 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Scorecards\VehiclesScorecard.razor"
                                                                                                                                                                                                                                            38

#line default
#line hidden
#nullable disable
            , 18, 
#nullable restore
#line 9 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Scorecards\VehiclesScorecard.razor"
                                                                                                                                                                                                                                                           new List<string>() { "ExcelExport", "CsvExport", "PdfExport" }

#line default
#line hidden
#nullable disable
            , 19, 
#nullable restore
#line 9 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Scorecards\VehiclesScorecard.razor"
                                                                                                                                                                                                                                                                                                                                              true

#line default
#line hidden
#nullable disable
            , 20, 
#nullable restore
#line 9 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Scorecards\VehiclesScorecard.razor"
                                                                                                                                                                                                                                                                                                                                                                    true

#line default
#line hidden
#nullable disable
            , 21, (__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridFilterSettings>(22);
                __builder2.AddAttribute(23, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.FilterType>(
#nullable restore
#line 10 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Scorecards\VehiclesScorecard.razor"
                                                  Syncfusion.Blazor.Grids.FilterType.Menu

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n                        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridPageSettings>(25);
                __builder2.AddAttribute(26, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 11 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Scorecards\VehiclesScorecard.razor"
                                                    40

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(27, "\r\n                        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridSelectionSettings>(28);
                __builder2.AddAttribute(29, "CheckboxOnly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Scorecards\VehiclesScorecard.razor"
                                                             true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "PersistSelection", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Scorecards\VehiclesScorecard.razor"
                                                                                     true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(31, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.SelectionType>(
#nullable restore
#line 12 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Scorecards\VehiclesScorecard.razor"
                                                                                                 SelectionType.Multiple

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridEvents<VehicleVM>>(32);
                __builder2.AddAttribute(33, "OnToolbarClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Navigations.ClickEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Navigations.ClickEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Scorecards\VehiclesScorecard.razor"
                                                                                                                                                                             ScoreCardToolbarClick

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\r\n                        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridColumns>(35);
                __builder2.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(37);
                    __builder3.AddAttribute(38, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Scorecards\VehiclesScorecard.razor"
                                               nameof(VehicleVM.VehicleNumber)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(39, "HeaderText", "Vehicle Number");
                    __builder3.AddAttribute(40, "Width", "130");
                    __builder3.AddAttribute(41, "HeaderTemplate", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((context) => (__builder4) => {
                        __builder4.AddMarkupContent(42, "<div><span class=\"pl-2\"></span> Vehicle Number\r\n                                    </div>");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(43, "\r\n                            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(44);
                    __builder3.AddAttribute(45, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Scorecards\VehiclesScorecard.razor"
                                               nameof(VehicleVM.Breakdowns)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(46, "HeaderText", "Breakdowns");
                    __builder3.AddAttribute(47, "Width", "130");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(48, "\r\n                            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(49);
                    __builder3.AddAttribute(50, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Scorecards\VehiclesScorecard.razor"
                                               nameof(VehicleVM.FuelAverage)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(51, "HeaderText", "Fuel Average");
                    __builder3.AddAttribute(52, "Width", "130");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(53, "\r\n                            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(54);
                    __builder3.AddAttribute(55, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Scorecards\VehiclesScorecard.razor"
                                               nameof(VehicleVM.CostThisMonth)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(56, "HeaderText", "Cost This Month");
                    __builder3.AddAttribute(57, "Width", "130");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(58, "\r\n                            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(59);
                    __builder3.AddAttribute(60, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Scorecards\VehiclesScorecard.razor"
                                               nameof(VehicleVM.Ranking)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(61, "HeaderText", "Ranking");
                    __builder3.AddAttribute(62, "Width", "130");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(63, "\r\n                            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(64);
                    __builder3.AddAttribute(65, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Scorecards\VehiclesScorecard.razor"
                                               nameof(VehicleVM.Score)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(66, "HeaderText", "Score");
                    __builder3.AddAttribute(67, "Width", "130");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            , 68, (__value) => {
#nullable restore
#line 9 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Scorecards\VehiclesScorecard.razor"
                                                      ScoreCardsGrid = __value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 32 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Scorecards\VehiclesScorecard.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(69, "<h5>Loading.....</h5>");
#nullable restore
#line 36 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Scorecards\VehiclesScorecard.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Scorecards\VehiclesScorecard.razor"
       
    [Parameter]
    public List<VehicleVM> FMSVehiclesList { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await base.OnInitializedAsync();
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await base.OnAfterRenderAsync(firstRender);
    }

    #region Syncfusion

    SfGrid<VehicleVM> ScoreCardsGrid;

    public void ScoreCardToolbarClick(Syncfusion.Blazor.Navigations.ClickEventArgs args)
    {
        if (args.Item.Id == "ScoreCardsGrid_pdfexport")
        {
            PdfExportProperties Props = new PdfExportProperties();
            Props.PageOrientation = PageOrientation.Landscape;
            Props.PageSize = PdfPageSize.A4;
            this.ScoreCardsGrid.PdfExport(Props);
        }
        if (args.Item.Id == "ScoreCardsGrid_excelexport")
        {
            this.ScoreCardsGrid.ExcelExport();
        }
        if (args.Item.Id == "ScoreCardsGrid_csvexport")
        {
            this.ScoreCardsGrid.CsvExport();
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
namespace __Blazor.SOS.FMS.Client.Components.Scorecards.VehiclesScorecard
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateSfGrid_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Collections.Generic.IEnumerable<TValue> __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, global::System.Boolean __arg5, int __seq6, global::System.Boolean __arg6, int __seq7, global::System.String __arg7, int __seq8, global::System.Double __arg8, int __seq9, global::System.Object __arg9, int __seq10, global::System.Boolean __arg10, int __seq11, global::System.Boolean __arg11, int __seq12, global::Microsoft.AspNetCore.Components.RenderFragment __arg12, int __seq13, global::System.Action<global::Syncfusion.Blazor.Grids.SfGrid<TValue>> __arg13)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Grids.SfGrid<TValue>>(seq);
        __builder.AddAttribute(__seq0, "ID", __arg0);
        __builder.AddAttribute(__seq1, "DataSource", __arg1);
        __builder.AddAttribute(__seq2, "AllowSelection", __arg2);
        __builder.AddAttribute(__seq3, "AllowSorting", __arg3);
        __builder.AddAttribute(__seq4, "AllowFiltering", __arg4);
        __builder.AddAttribute(__seq5, "EnableVirtualization", __arg5);
        __builder.AddAttribute(__seq6, "EnableHover", __arg6);
        __builder.AddAttribute(__seq7, "Height", __arg7);
        __builder.AddAttribute(__seq8, "RowHeight", __arg8);
        __builder.AddAttribute(__seq9, "Toolbar", __arg9);
        __builder.AddAttribute(__seq10, "AllowExcelExport", __arg10);
        __builder.AddAttribute(__seq11, "AllowPdfExport", __arg11);
        __builder.AddAttribute(__seq12, "ChildContent", __arg12);
        __builder.AddComponentReferenceCapture(__seq13, (__value) => { __arg13((global::Syncfusion.Blazor.Grids.SfGrid<TValue>)__value); });
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
