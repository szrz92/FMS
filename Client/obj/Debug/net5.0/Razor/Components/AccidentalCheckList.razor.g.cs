#pragma checksum "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a01c12f6751437be4ccec115abb89089665cebc"
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
#nullable restore
#line 2 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
using SOS.FMS.Client.Components.AccidentalComments;

#line default
#line hidden
#nullable disable
    public partial class AccidentalCheckList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
 if (Visible)
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
            __builder.AddContent(10, "Accidental Check List for ");
            __builder.AddContent(11, 
#nullable restore
#line 8 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
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
#line 9 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
                         CloseAccidentalCheckListSideBar

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
#line 19 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
                 if (CheckList != null)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(23, "table");
            __builder.AddAttribute(24, "class", "w-100");
            __builder.AddMarkupContent(25, @"<tr class=""row px-1 py-2 border-bottom""><td class=""col-6 text-dark font-weight-bolder"">Description</td>
                            <td class=""col-2 text-dark font-weight-bolder"">Status</td>
                            <td class=""col-2 text-dark font-weight-bolder"">Updated</td>
                            <td class=""col-2 text-dark font-weight-bolder"">Action</td></tr>");
#nullable restore
#line 28 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
                         foreach (var item in CheckList)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(26, "tr");
            __builder.AddAttribute(27, "class", "row px-1 py-2 border-bottom");
            __builder.OpenElement(28, "td");
            __builder.AddAttribute(29, "class", "col-6");
            __builder.AddContent(30, 
#nullable restore
#line 31 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
                                                   item.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 32 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
                                 if (item.MaintenanceStatus == FMS.Shared.Enums.MaintenanceStatus.NotInitiated)
                                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(31, "<td class=\"col-2 text-danger\">Not Initiated</td>\r\n                                    ");
            __builder.AddMarkupContent(32, "<td class=\"col-2 text-danger\"> NA</td>\r\n                                    ");
            __builder.OpenElement(33, "td");
            __builder.AddAttribute(34, "class", "col-2");
#nullable restore
#line 37 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
                                         if (item.CommentCount == 0)
                                        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(35, "<label class=\"checkbox checkbox-disabled pb-2\"><input type=\"checkbox\" disabled>\r\n                                                <span></span></label>");
#nullable restore
#line 43 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(36, "label");
            __builder.AddAttribute(37, "class", "checkbox checkbox-success pb-2");
            __builder.OpenElement(38, "input");
            __builder.AddAttribute(39, "type", "checkbox");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
                                                                                 () => MarkAccidentalPointDone(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                                                <span></span>");
            __builder.CloseElement();
#nullable restore
#line 50 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
                                         if (item.Description.Contains("Bills Posting"))
                                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(42, "img");
            __builder.AddAttribute(43, "class", "ml-2");
            __builder.AddAttribute(44, "alt", "Pic");
            __builder.AddAttribute(45, "src", "assets/icons/conversation1x.png");
            __builder.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
                                                                                                                        () => ShowBillPostingModal(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 56 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
                                        }
                                        else if (item.Description.Contains("Assigning Workshop"))
                                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(47, "img");
            __builder.AddAttribute(48, "class", "ml-2");
            __builder.AddAttribute(49, "alt", "Pic");
            __builder.AddAttribute(50, "src", "assets/icons/conversation1x.png");
            __builder.AddAttribute(51, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
                                                                                                                        () => ShowAssignWorkshopModal(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 60 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(52, "img");
            __builder.AddAttribute(53, "class", "ml-2");
            __builder.AddAttribute(54, "alt", "Pic");
            __builder.AddAttribute(55, "src", "assets/icons/conversation1x.png");
            __builder.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 63 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
                                                                                                                        () => ShowAccidentalCommentModal(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 64 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
                                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 66 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(57, "<td class=\"col-2 text-success\">Done</td>\r\n                                    ");
            __builder.OpenElement(58, "td");
            __builder.AddAttribute(59, "class", "col-2");
            __builder.AddContent(60, 
#nullable restore
#line 70 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
                                                        item.LastUpdated.ToString("dd-MMM-yy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                                    ");
            __builder.OpenElement(62, "td");
            __builder.AddAttribute(63, "class", "col-2");
            __builder.AddMarkupContent(64, "<label class=\"checkbox checkbox-success pb-2\"><input type=\"checkbox\" checked=\"checked\" disabled>\r\n                                            <span></span></label>");
#nullable restore
#line 76 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
                                         if (item.Description.Contains("Bills Posting"))
                                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(65, "img");
            __builder.AddAttribute(66, "class", "ml-2");
            __builder.AddAttribute(67, "alt", "Pic");
            __builder.AddAttribute(68, "src", "assets/icons/conversation1x.png");
            __builder.AddAttribute(69, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 78 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
                                                                                                                        () => ShowBillPostingModal(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 79 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
                                        }
                                        else if (item.Description.Contains("Assigning Workshop"))
                                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(70, "img");
            __builder.AddAttribute(71, "class", "ml-2");
            __builder.AddAttribute(72, "alt", "Pic");
            __builder.AddAttribute(73, "src", "assets/icons/conversation1x.png");
            __builder.AddAttribute(74, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 82 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
                                                                                                                        () => ShowAssignWorkshopModal(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 83 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(75, "img");
            __builder.AddAttribute(76, "class", "ml-2");
            __builder.AddAttribute(77, "alt", "Pic");
            __builder.AddAttribute(78, "src", "assets/icons/conversation1x.png");
            __builder.AddAttribute(79, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 86 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
                                                                                                                        () => ShowAccidentalCommentModal(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 87 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
                                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 89 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 91 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 93 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(80, "<p>Loading...</p>");
#nullable restore
#line 97 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n\r\n        ");
            __builder.OpenElement(82, "div");
            __builder.AddAttribute(83, "class", "offcanvas-footer");
            __builder.AddAttribute(84, "kt-hidden-height", "112");
            __builder.AddAttribute(85, "style");
            __builder.OpenElement(86, "button");
            __builder.AddAttribute(87, "class", "btn btn-fms mr-2");
            __builder.AddAttribute(88, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 103 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
                                                       AccidentalCarOperational

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(89, "CAR OPERATIONAL");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n            ");
            __builder.OpenElement(91, "button");
            __builder.AddAttribute(92, "class", "btn btn-secondary");
            __builder.AddAttribute(93, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 104 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
                                                        AccidentalCloseJob

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(94, "CLOSE JOB");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 107 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 108 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
 if (commentBoxVisible)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<SOS.FMS.Client.Components.AccidentalCheckListCommentBox>(95);
            __builder.AddAttribute(96, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 110 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
                                            commentBoxVisible

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(97, "OnVisibilityChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 111 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
                                                        ShowHideCommentBox

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(98, "VehicleNumber", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 112 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
                                                   VehicleNumber

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(99, "CheckPointId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<SOS.FMS.Shared.ApiRequest>(
#nullable restore
#line 113 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
                                                  PointId

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 114 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 115 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
 if (billPostingVisible)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<SOS.FMS.Client.Components.AccidentalComments.BillPosting>(100);
            __builder.AddAttribute(101, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 117 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
                          billPostingVisible

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(102, "OnVisibilityChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 118 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
                                      ShowHideBillPosting

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(103, "VehicleNumber", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 119 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
                                 VehicleNumber

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(104, "CheckPointId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<SOS.FMS.Shared.ApiRequest>(
#nullable restore
#line 120 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
                                PointId

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 121 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 122 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
 if (assignWorkShopVisible)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<SOS.FMS.Client.Components.AccidentalComments.AssigningWorkshop>(105);
            __builder.AddAttribute(106, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 124 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
                                assignWorkShopVisible

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(107, "OnVisibilityChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 125 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
                                            ShowHideAssignWorkshop

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(108, "VehicleNumber", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 126 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
                                       VehicleNumber

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(109, "CheckPointId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<SOS.FMS.Shared.ApiRequest>(
#nullable restore
#line 127 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
                                      PointId

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 128 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Syncfusion.Blazor.Popups.SfDialog>(110);
            __builder.AddAttribute(111, "Target", "#target");
            __builder.AddAttribute(112, "Width", "500px");
            __builder.AddAttribute(113, "ShowCloseIcon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 130 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
                                                        true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(114, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 130 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
                                                                             responseDialogVisibility

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(115, "VisibleChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => responseDialogVisibility = __value, responseDialogVisibility))));
            __builder.AddAttribute(116, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Popups.DialogTemplates>(117);
                __builder2.AddAttribute(118, "Header", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(119, 
#nullable restore
#line 132 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
                  responseHeader

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.AddAttribute(120, "Content", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(121, "p");
                    __builder3.AddContent(122, 
#nullable restore
#line 135 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
                 responseBody

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(123, "\r\n    ");
                __builder2.OpenComponent<Syncfusion.Blazor.Popups.DialogEvents>(124);
                __builder2.AddAttribute(125, "Closed", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Popups.CloseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Popups.CloseEventArgs>(this, 
#nullable restore
#line 139 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
                           DialogClose

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 143 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalCheckList.razor"
       
    [CascadingParameter]
    private Task<AuthenticationState> authenticationStateTask { get; set; }

    public ClaimsPrincipal CurrentUser { get; set; }
    [Parameter]
    public string VehicleNumber { get; set; }
    [Parameter]
    public bool Visible { get; set; }
    [Parameter]
    public EventCallback<bool> OnVisibilityChanged { get; set; }
    [Parameter]
    public List<FMSAccidentalCheckVM> AccidentalsCheckList { get; set; }

    public List<FMSAccidentalCheckVM> CheckList { get; set; }

    FMSAccidentalCheckCommentVM AccidentalCheckComment;

    #region Comment Box
    public bool commentBoxVisible { get; set; } = false;
    public ApiRequest PointId { get; set; }
    FMSAccidentalCommentModalVM AccidentalCommentModal;
    public void ShowHideCommentBox()
    {
        commentBoxVisible = !commentBoxVisible;
        if (!commentBoxVisible) ReloadCheckList();
    }
    #endregion
    #region Bill Posting
    public bool billPostingVisible { get; set; } = false;
    public void ShowHideBillPosting()
    {
        billPostingVisible = !billPostingVisible;
        if (!billPostingVisible) ReloadCheckList();
    }
    public void ShowBillPostingModal(Guid pointId)
    {
        PointId = new ApiRequest() { FMSAccidentalCheckId = pointId, Remarks = CheckList.Where(x => x.Id == pointId).FirstOrDefault().Description };
        billPostingVisible = true;
    }
    #endregion
    #region Assign Work Shop
    public bool assignWorkShopVisible { get; set; } = false;
    public void ShowHideAssignWorkshop()
    {
        assignWorkShopVisible = !assignWorkShopVisible;
        if (!assignWorkShopVisible) ReloadCheckList();
    }
    public void ShowAssignWorkshopModal(Guid pointId)
    {
        PointId = new ApiRequest() { FMSAccidentalCheckId = pointId, Remarks = CheckList.Where(x => x.Id == pointId).FirstOrDefault().Description };
        assignWorkShopVisible = true;
    }
    #endregion

    protected override async Task OnInitializedAsync()
    {
        CurrentUser = (await authenticationStateTask).User;
        CheckList = AccidentalsCheckList;
        await base.OnInitializedAsync();
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await base.OnAfterRenderAsync(firstRender);
    }

    public async void AccidentalCarOperational()
    {
        var vehicleResponse = await Http.PostAsJsonAsync("api/Accident/FMS/Demo/CarOperational",
            new FMSVehicleVM() { VehicleNumber = VehicleNumber });
        if (vehicleResponse.StatusCode == System.Net.HttpStatusCode.OK)
        {
            responseHeader = "Operation Successful";
            responseBody = "Car is marked as operational";
            responseDialogVisibility = true;
        }
        StateHasChanged();
    }
    public async void AccidentalCloseJob()
    {
        var vehicleResponse = await Http.PostAsJsonAsync("api/Accident/FMS/Demo/CloseJob",
            new FMSVehicleVM() { VehicleNumber = VehicleNumber });
        if (vehicleResponse.StatusCode == System.Net.HttpStatusCode.OK)
        {

            responseHeader = "Operation Successful";
            responseBody = "Job is marked as closed.";
            responseDialogVisibility = true;
        }
        StateHasChanged();
    }
    public async void MarkAccidentalPointDone(Guid pointId)
    {
        AccidentalCheckComment = new FMSAccidentalCheckCommentVM();
        var getMarkAccidentalPointDoneResponse = await Http.PostAsJsonAsync<ApiRequest>("api/Accident/FMS/CheckList/Point/MarkDone",
            new ApiRequest() { FMSAccidentalCheckId = pointId, VehicleNumber = VehicleNumber });

        if (getMarkAccidentalPointDoneResponse.StatusCode == System.Net.HttpStatusCode.OK)
        {
            ReloadCheckList();
        }
        else
        {
        }
    }

    public async void ReloadCheckList()
    {
        var vehicleResponse = await Http.PostAsJsonAsync("api/Vehicles/FMS/Demo/GetByNumber", new FMSVehicleVM() { VehicleNumber = VehicleNumber });
        var vehicle = Newtonsoft.Json.JsonConvert.DeserializeObject<FMSVehicleVM>(await vehicleResponse.Content.ReadAsStringAsync());
        if (vehicle.Type == "accidental")
        {
            var getAccidentalCheckListResponse = await Http.PostAsJsonAsync<ApiRequest>("api/Accident/FMS/CheckList", new ApiRequest() { VehicleNumber = VehicleNumber });

            if (getAccidentalCheckListResponse.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string response = await (getAccidentalCheckListResponse).Content.ReadAsStringAsync();
                CheckList = JsonConvert.DeserializeObject<List<FMSAccidentalCheckVM>>(response);
                //ShowAccidentalCheckList(CheckList);
            }
            else
            {
            }
        }
        else
        {
            //ConfirmAccidentDlgVisible = true;
        }
        StateHasChanged();
    }
    #region Dialog
    public bool responseDialogVisibility { get; set; }
    public string responseHeader { get; set; }
    public string responseBody { get; set; }

    private void DialogClose(CloseEventArgs args)
    {
        CloseAccidentalCheckListSideBar();
    }
    #endregion

    public Guid accidentalId { get; set; }
    public Guid accidentalCheckPointId { get; set; }
    public bool accidentalCheckListSideModal { get; set; } = false;
    public bool accidentalCommentModal { get; set; } = false;

    public void ShowAccidentalCheckList(List<FMSAccidentalCheckVM> checkVMs)
    {
        accidentalId = checkVMs.FirstOrDefault().FMSAccidentId;
        accidentalCheckListSideModal = true;
        accidentalCommentModal = false;
    }

    public Task CloseAccidentalCheckListSideBar()
    {
        return OnVisibilityChanged.InvokeAsync(false);
    }

    public void ShowAccidentalCommentModal(Guid pointId)
    {
        PointId = new ApiRequest() { FMSAccidentalCheckId = pointId };
        commentBoxVisible = true;
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
