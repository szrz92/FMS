#pragma checksum "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Complaints.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9f72ad3756e6311a30426f0a905bea7428a7f17"
// <auto-generated/>
#pragma warning disable 1591
namespace SOS.FMS.Client.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Complaints")]
    public partial class Complaints : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "subheader py-2 py-lg-4 subheader-solid");
            __builder.AddAttribute(2, "id", "kt_subheader");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "container-fluid d-flex align-items-center justify-content-between flex-wrap flex-sm-nowrap");
            __builder.AddMarkupContent(5, @"<div class=""d-flex align-items-center flex-wrap mr-2""><h5 class=""text-dark font-weight-bold mt-2 mb-2 mr-5"">FMS</h5>
            
            
            <div class=""subheader-separator subheader-separator-ver mt-2 mb-2 mr-5 bg-gray-200""></div>
            
            
            <ul class=""breadcrumb breadcrumb-transparent breadcrumb-dot font-weight-bold p-0 my-2 font-size-sm""><li class=""breadcrumb-item""><a href=""/"" class=""text-muted"">All Complaints</a></li></ul></div>
        
        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "d-flex align-items-center");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "mr-2");
            __builder.AddAttribute(10, "style", "width:135%");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "control-wrapper");
            __builder.OpenComponent<Syncfusion.Blazor.DropDowns.SfDropDownList<string, SelectListItem>>(13);
            __builder.AddAttribute(14, "Placeholder", "Select a region");
            __builder.AddAttribute(15, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 27 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Complaints.razor"
                                                                                                                                                     true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<SelectListItem>>(
#nullable restore
#line 27 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Complaints.razor"
                                                                                                                                                                        regionsList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 27 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Complaints.razor"
                                                                                                                      Filter.Region

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Filter.Region = __value, Filter.Region))));
            __builder.AddAttribute(19, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<string>>>(() => Filter.Region));
            __builder.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.DropDowns.DropDownListFieldSettings>(21);
                __builder2.AddAttribute(22, "Text", "Text");
                __builder2.AddAttribute(23, "Value", "Value");
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "mr-2");
            __builder.AddAttribute(27, "style", "width:135%");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "control-wrapper");
            __builder.OpenComponent<Syncfusion.Blazor.DropDowns.SfDropDownList<string, SelectListItem>>(30);
            __builder.AddAttribute(31, "Placeholder", "Select a subregion");
            __builder.AddAttribute(32, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 34 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Complaints.razor"
                                                                                                                                                           true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<SelectListItem>>(
#nullable restore
#line 34 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Complaints.razor"
                                                                                                                                                                              subRegionsList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 34 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Complaints.razor"
                                                                                                                         Filter.Subregion

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Filter.Subregion = __value, Filter.Subregion))));
            __builder.AddAttribute(36, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<string>>>(() => Filter.Subregion));
            __builder.AddAttribute(37, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.DropDowns.DropDownListFieldSettings>(38);
                __builder2.AddAttribute(39, "Text", "Text");
                __builder2.AddAttribute(40, "Value", "Value");
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "mr-2");
            __builder.AddAttribute(44, "style", "width:135%");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "control-wrapper");
            __builder.OpenComponent<Syncfusion.Blazor.DropDowns.SfDropDownList<string, SelectListItem>>(47);
            __builder.AddAttribute(48, "Placeholder", "Select a vehicle");
            __builder.AddAttribute(49, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 41 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Complaints.razor"
                                                                                                                                                             true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "DataSource", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<SelectListItem>>(
#nullable restore
#line 41 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Complaints.razor"
                                                                                                                                                                                vehiclesList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<string>(
#nullable restore
#line 41 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Complaints.razor"
                                                                                                                       Filter.VehicleNumber

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<string>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<string>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Filter.VehicleNumber = __value, Filter.VehicleNumber))));
            __builder.AddAttribute(53, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<string>>>(() => Filter.VehicleNumber));
            __builder.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.DropDowns.DropDownListFieldSettings>(55);
                __builder2.AddAttribute(56, "Text", "Text");
                __builder2.AddAttribute(57, "Value", "Value");
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n            ");
            __builder.OpenElement(59, "button");
            __builder.AddAttribute(60, "class", "btn btn-bg-danger text-white mr-2");
            __builder.AddAttribute(61, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Complaints.razor"
                                                                        FilterData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(62, "FILTER");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n            ");
            __builder.OpenElement(64, "button");
            __builder.AddAttribute(65, "class", "btn btn-bg-info text-white mr-2");
            __builder.AddAttribute(66, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Complaints.razor"
                                                                      ResetData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(67, "RESET");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n\r\n\r\n");
            __builder.OpenElement(69, "div");
            __builder.AddAttribute(70, "class", "d-flex flex-column-fluid");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "container-fluid");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "class", "card card-custom card-stretch");
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "class", "card-body");
#nullable restore
#line 70 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Complaints.razor"
                 if (FilteredComplaintsList != null)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "col-lg-12 control-section");
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "content-wrapper");
            __builder.OpenElement(81, "div");
            __builder.AddAttribute(82, "class", "row");
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "id", "container");
            __Blazor.SOS.FMS.Client.Pages.Complaints.TypeInference.CreateSfGrid_0(__builder, 85, 86, "ComplaintsGrid", 87, 
#nullable restore
#line 76 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Complaints.razor"
                                                                                                   FilteredComplaintsList

#line default
#line hidden
#nullable disable
            , 88, 
#nullable restore
#line 77 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Complaints.razor"
                                                         true

#line default
#line hidden
#nullable disable
            , 89, 
#nullable restore
#line 77 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Complaints.razor"
                                                                             true

#line default
#line hidden
#nullable disable
            , 90, 
#nullable restore
#line 77 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Complaints.razor"
                                                                                                   true

#line default
#line hidden
#nullable disable
            , 91, "600", 92, 
#nullable restore
#line 78 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Complaints.razor"
                                                                    38

#line default
#line hidden
#nullable disable
            , 93, 
#nullable restore
#line 79 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Complaints.razor"
                                                       new List<string>() { "ExcelExport", "CsvExport", "PdfExport" }

#line default
#line hidden
#nullable disable
            , 94, 
#nullable restore
#line 80 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Complaints.razor"
                                                              true

#line default
#line hidden
#nullable disable
            , 95, 
#nullable restore
#line 80 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Complaints.razor"
                                                                                    true

#line default
#line hidden
#nullable disable
            , 96, (__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridPageSettings>(97);
                __builder2.AddAttribute(98, "PageCount", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 81 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Complaints.razor"
                                                                     5

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(99, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 81 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Complaints.razor"
                                                                                  20

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(100, "PageSizes", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 81 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Complaints.razor"
                                                                                                 new int[]{ 5, 10, 20, 50, 100 }

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(101, "\r\n                                        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridFilterSettings>(102);
                __builder2.AddAttribute(103, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.FilterType>(
#nullable restore
#line 82 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Complaints.razor"
                                                                  Syncfusion.Blazor.Grids.FilterType.Menu

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(104, "\r\n                                        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridSelectionSettings>(105);
                __builder2.AddAttribute(106, "CheckboxOnly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 83 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Complaints.razor"
                                                                             true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(107, "PersistSelection", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 83 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Complaints.razor"
                                                                                                     true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(108, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.SelectionType>(
#nullable restore
#line 83 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Complaints.razor"
                                                                                                                 SelectionType.Multiple

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(109, "\r\n                                        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridEvents<ComplaintVM>>(110);
                __builder2.AddAttribute(111, "OnToolbarClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Navigations.ClickEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Navigations.ClickEventArgs>(this, 
#nullable restore
#line 84 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Complaints.razor"
                                                                    ComplaintsToolbarClick

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(112, "\r\n                                        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridColumns>(113);
                __builder2.AddAttribute(114, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(115);
                    __builder3.AddAttribute(116, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 86 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Complaints.razor"
                                                               nameof(ComplaintVM.PointCodeDescription)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(117, "HeaderText", "Point");
                    __builder3.AddAttribute(118, "Width", "200");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(119, "\r\n                                            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(120);
                    __builder3.AddAttribute(121, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 87 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Complaints.razor"
                                                               nameof(ComplaintVM.ComplaintDescription)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(122, "HeaderText", "Complaint");
                    __builder3.AddAttribute(123, "Width", "250");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(124, "\r\n                                            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(125);
                    __builder3.AddAttribute(126, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 88 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Complaints.razor"
                                                               nameof(ComplaintVM.VehicleNumber)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(127, "HeaderText", "Vehicle");
                    __builder3.AddAttribute(128, "Width", "100");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(129, "\r\n                                            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(130);
                    __builder3.AddAttribute(131, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 89 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Complaints.razor"
                                                               nameof(ComplaintVM.DriverName)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(132, "HeaderText", "Driver");
                    __builder3.AddAttribute(133, "Width", "100");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(134, "\r\n                                            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(135);
                    __builder3.AddAttribute(136, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 90 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Complaints.razor"
                                                               nameof(ComplaintVM.Region)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(137, "HeaderText", "Region");
                    __builder3.AddAttribute(138, "Width", "100");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(139, "\r\n                                            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(140);
                    __builder3.AddAttribute(141, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 91 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Complaints.razor"
                                                               nameof(ComplaintVM.Subregion)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(142, "HeaderText", "Subregion");
                    __builder3.AddAttribute(143, "Width", "100");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(144, "\r\n                                            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(145);
                    __builder3.AddAttribute(146, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 92 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Complaints.razor"
                                                               nameof(ComplaintVM.ReportTime)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(147, "Format", "dd/MM/yy hh:mm");
                    __builder3.AddAttribute(148, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.ColumnType>(
#nullable restore
#line 92 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Complaints.razor"
                                                                                                                            ColumnType.DateTime

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(149, "HeaderText", "Reported At");
                    __builder3.AddAttribute(150, "Width", "150");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            , 151, (__value) => {
#nullable restore
#line 76 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Complaints.razor"
                                                                      ComplaintsGrid = __value;

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
#line 99 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Complaints.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(152, "<h5>Loading.....</h5>");
#nullable restore
#line 103 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Complaints.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 111 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Complaints.razor"
       
    public List<ComplaintVM> ComplaintsList { get; set; }
    public List<ComplaintVM> FilteredComplaintsList { get; set; }

    public List<SelectListItem> regionsList { get; set; } = new List<SelectListItem>();
    public List<SelectListItem> subRegionsList { get; set; } = new List<SelectListItem>();
    public List<SelectListItem> vehiclesList { get; set; } = new List<SelectListItem>();
    public List<SelectListItem> typesList { get; set; } = new List<SelectListItem>();
    public ComplaintVM Filter { get; set; } = new ComplaintVM();
    public void FilterData()
    {
        FilteredComplaintsList = ComplaintsList
    .Where(x => (string.IsNullOrEmpty(Filter.Region) || x.Region == Filter.Region))
    .Where(x => (string.IsNullOrEmpty(Filter.Subregion) || x.Subregion == Filter.Subregion))
    .Where(x => (string.IsNullOrEmpty(Filter.VehicleNumber) || x.VehicleNumber == Filter.VehicleNumber))
    .ToList();
    }

    public void ResetData()
    {
        Filter = new ComplaintVM();
        FilteredComplaintsList = ComplaintsList;
    }

    protected override async Task OnInitializedAsync()
    {
        ComplaintsList = (await Http.GetFromJsonAsync<List<ComplaintVM>>("api/complaints/all/active"))
        .OrderByDescending(x => x.ReportTime)
        .ToList();
        FilteredComplaintsList = ComplaintsList;
        regionsList = ComplaintsList.GroupBy(x => x.Region).Select(x => new SelectListItem() { Text = x.Key, Value = x.Key }).ToList();
        subRegionsList = ComplaintsList.GroupBy(x => x.Subregion).Select(x => new SelectListItem() { Text = x.Key, Value = x.Key }).ToList();
        vehiclesList = ComplaintsList.GroupBy(x => x.VehicleNumber).Select(x => new SelectListItem() { Text = x.Key, Value = x.Key }).ToList();
        await base.OnInitializedAsync();
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await base.OnAfterRenderAsync(firstRender);
    }

    #region Syncfusion

    SfGrid<ComplaintVM> ComplaintsGrid;

    public void ComplaintsToolbarClick(Syncfusion.Blazor.Navigations.ClickEventArgs args)
    {
        if (args.Item.Id == "ComplaintsGrid_pdfexport")
        {
            PdfExportProperties Props = new PdfExportProperties();
            Props.PageOrientation = PageOrientation.Landscape;
            Props.PageSize = PdfPageSize.A4;
            this.ComplaintsGrid.PdfExport(Props);
        }
        if (args.Item.Id == "ComplaintsGrid_excelexport")
        {
            this.ComplaintsGrid.ExcelExport();
        }
        if (args.Item.Id == "ComplaintsGrid_csvexport")
        {
            this.ComplaintsGrid.CsvExport();
        }
    }
    #endregion

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private INotificationService NotificationService { get; set; }
    }
}
namespace __Blazor.SOS.FMS.Client.Pages.Complaints
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateSfGrid_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, global::System.Collections.Generic.IEnumerable<TValue> __arg1, int __seq2, global::System.Boolean __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, global::System.String __arg5, int __seq6, global::System.Double __arg6, int __seq7, global::System.Object __arg7, int __seq8, global::System.Boolean __arg8, int __seq9, global::System.Boolean __arg9, int __seq10, global::Microsoft.AspNetCore.Components.RenderFragment __arg10, int __seq11, global::System.Action<global::Syncfusion.Blazor.Grids.SfGrid<TValue>> __arg11)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Grids.SfGrid<TValue>>(seq);
        __builder.AddAttribute(__seq0, "ID", __arg0);
        __builder.AddAttribute(__seq1, "DataSource", __arg1);
        __builder.AddAttribute(__seq2, "AllowPaging", __arg2);
        __builder.AddAttribute(__seq3, "AllowSorting", __arg3);
        __builder.AddAttribute(__seq4, "AllowFiltering", __arg4);
        __builder.AddAttribute(__seq5, "Height", __arg5);
        __builder.AddAttribute(__seq6, "RowHeight", __arg6);
        __builder.AddAttribute(__seq7, "Toolbar", __arg7);
        __builder.AddAttribute(__seq8, "AllowExcelExport", __arg8);
        __builder.AddAttribute(__seq9, "AllowPdfExport", __arg9);
        __builder.AddAttribute(__seq10, "ChildContent", __arg10);
        __builder.AddComponentReferenceCapture(__seq11, (__value) => { __arg11((global::Syncfusion.Blazor.Grids.SfGrid<TValue>)__value); });
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
