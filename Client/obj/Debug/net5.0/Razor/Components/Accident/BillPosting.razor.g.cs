<<<<<<< HEAD
#pragma checksum "C:\Users\Btech\Source\Repos\fms\Client\Components\Accident\BillPosting.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34981cd81de70981ae45aa523f5c8f824dd7de40"
=======
#pragma checksum "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Accident\BillPosting.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc7c5e3f24be9a4205cc6292168d4c8043eff6c9"
>>>>>>> c4f6b5a305fa29cb053a7848c4267a5c0b345154
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
#line 1 "C:\Users\Btech\Source\Repos\fms\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Btech\Source\Repos\fms\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Btech\Source\Repos\fms\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Btech\Source\Repos\fms\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Btech\Source\Repos\fms\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Btech\Source\Repos\fms\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Btech\Source\Repos\fms\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Btech\Source\Repos\fms\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Btech\Source\Repos\fms\Client\_Imports.razor"
using SOS.FMS.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Btech\Source\Repos\fms\Client\_Imports.razor"
using SOS.FMS.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Btech\Source\Repos\fms\Client\_Imports.razor"
using SOS.FMS.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Btech\Source\Repos\fms\Client\_Imports.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Btech\Source\Repos\fms\Client\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Btech\Source\Repos\fms\Client\_Imports.razor"
using SOS.FMS.Client.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Btech\Source\Repos\fms\Client\_Imports.razor"
using SOS.FMS.Shared.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Btech\Source\Repos\fms\Client\_Imports.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Btech\Source\Repos\fms\Client\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Btech\Source\Repos\fms\Client\_Imports.razor"
using Syncfusion.Blazor.Spinner;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Btech\Source\Repos\fms\Client\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Btech\Source\Repos\fms\Client\_Imports.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Btech\Source\Repos\fms\Client\_Imports.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Btech\Source\Repos\fms\Client\_Imports.razor"
using Syncfusion.Blazor.PivotView;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\Btech\Source\Repos\fms\Client\_Imports.razor"
using Append.Blazor.Notifications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Btech\Source\Repos\fms\Client\_Imports.razor"
using SOS.FMS.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\Btech\Source\Repos\fms\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\Btech\Source\Repos\fms\Client\_Imports.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Btech\Source\Repos\fms\Client\Components\Accident\BillPosting.razor"
using SOS.FMS.Shared.ViewModels.Accident;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Btech\Source\Repos\fms\Client\Components\Accident\BillPosting.razor"
using SOS.FMS.Shared.ViewModels.Incident;

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
#line 9 "C:\Users\Btech\Source\Repos\fms\Client\Components\Accident\BillPosting.razor"
                                          CheckPointId.Remarks

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(11, " ");
            __builder.AddContent(12, 
#nullable restore
#line 9 "C:\Users\Btech\Source\Repos\fms\Client\Components\Accident\BillPosting.razor"
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
#line 10 "C:\Users\Btech\Source\Repos\fms\Client\Components\Accident\BillPosting.razor"
                     ShowAddModal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "class", "btn btn-fms");
            __builder.AddAttribute(17, "id", "kt_quick_cart_close");
            __builder.AddMarkupContent(18, "Add\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.OpenElement(20, "a");
            __builder.AddAttribute(21, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\Btech\Source\Repos\fms\Client\Components\Accident\BillPosting.razor"
                     CloseBillPosting

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "class", "btn btn-xs btn-icon btn-light btn-hover-primary");
            __builder.AddAttribute(23, "id", "kt_quick_cart_close");
            __builder.AddMarkupContent(24, "<i class=\"ki ki-close icon-xs text-muted\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n    \r\n    \r\n    ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "offcanvas-content pr-5 mr-n5 scroll ps ps--active-y");
#nullable restore
#line 19 "C:\Users\Btech\Source\Repos\fms\Client\Components\Accident\BillPosting.razor"
         if (BillDetailsList != null && fileNames != null)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "d-flex flex-column");
            __Blazor.SOS.FMS.Client.Components.Accident.BillPosting.TypeInference.CreateSfGrid_0(__builder, 30, 31, 
#nullable restore
#line 22 "C:\Users\Btech\Source\Repos\fms\Client\Components\Accident\BillPosting.razor"
                                     BillDetailsList

#line default
#line hidden
#nullable disable
            , 32, (__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridColumns>(33);
                __builder2.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(35);
                    __builder3.AddAttribute(36, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Users\Btech\Source\Repos\fms\Client\Components\Accident\BillPosting.razor"
                                           nameof(BillDetailVM.ServiceType)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(37, "HeaderText", "Service");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(38, "\r\n                        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(39);
                    __builder3.AddAttribute(40, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Users\Btech\Source\Repos\fms\Client\Components\Accident\BillPosting.razor"
                                           nameof(BillDetailVM.SubServiceType)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(41, "HeaderText", "Sub Service");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(42, "\r\n                        ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(43);
                    __builder3.AddAttribute(44, "HeaderText", "Amount");
                    __builder3.AddAttribute(45, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((context) => (__builder4) => {
#nullable restore
#line 28 "C:\Users\Btech\Source\Repos\fms\Client\Components\Accident\BillPosting.razor"
                                  
                                    var data = context as BillDetailVM;

#line default
#line hidden
#nullable disable
                        __builder4.OpenElement(46, "p");
                        __builder4.AddContent(47, "Rs ");
                        __builder4.AddContent(48, 
#nullable restore
#line 30 "C:\Users\Btech\Source\Repos\fms\Client\Components\Accident\BillPosting.razor"
                                            string.Format(String.Format("{0:N2}", data.Amount))

#line default
#line hidden
#nullable disable
                        );
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            );
            __builder.AddMarkupContent(49, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(50);
            __builder.AddAttribute(51, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 36 "C:\Users\Btech\Source\Repos\fms\Client\Components\Accident\BillPosting.razor"
                                 bill

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 36 "C:\Users\Btech\Source\Repos\fms\Client\Components\Accident\BillPosting.razor"
                                                      PostBill

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(54);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(55, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(56);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(57, "\r\n                    ");
                __builder2.OpenElement(58, "div");
                __builder2.AddAttribute(59, "class", "row");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "col-5");
                __builder2.OpenElement(62, "div");
                __builder2.AddAttribute(63, "class", "card");
                __builder2.AddMarkupContent(64, "<div class=\"card-header\">\r\n                                    Total Amount\r\n                                </div>\r\n                                ");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "class", "card-body");
                __builder2.OpenElement(67, "div");
                __builder2.AddAttribute(68, "class", "form-group");
                __Blazor.SOS.FMS.Client.Components.Accident.BillPosting.TypeInference.CreateSfNumericTextBox_1(__builder2, 69, 70, "form-control", 71, 
#nullable restore
#line 47 "C:\Users\Btech\Source\Repos\fms\Client\Components\Accident\BillPosting.razor"
                                                                       bill.BillAmount

#line default
#line hidden
#nullable disable
                , 72, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => bill.BillAmount = __value, bill.BillAmount)), 73, () => bill.BillAmount);
                __builder2.AddMarkupContent(74, "\r\n                                        ");
                __builder2.AddMarkupContent(75, "<span class=\"form-text text-muted\">Please enter total amount paid</span>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n                            ");
                __builder2.OpenElement(77, "div");
                __builder2.AddAttribute(78, "class", "card");
                __builder2.AddMarkupContent(79, "<div class=\"card-header\">\r\n                                    Remarks\r\n                                </div>\r\n                                ");
                __builder2.OpenElement(80, "div");
                __builder2.AddAttribute(81, "class", "card-body");
                __builder2.OpenElement(82, "div");
                __builder2.AddAttribute(83, "class", "form-group");
                __builder2.OpenComponent<Syncfusion.Blazor.Inputs.SfTextBox>(84);
                __builder2.AddAttribute(85, "class", "form-control");
                __builder2.AddAttribute(86, "Multiline", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 58 "C:\Users\Btech\Source\Repos\fms\Client\Components\Accident\BillPosting.razor"
                                                                                                              true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(87, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 58 "C:\Users\Btech\Source\Repos\fms\Client\Components\Accident\BillPosting.razor"
                                                                bill.Remarks

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(88, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => bill.Remarks = __value, bill.Remarks))));
                __builder2.AddAttribute(89, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => bill.Remarks));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(90, "\r\n                                        ");
                __builder2.AddMarkupContent(91, "<span class=\"form-text text-muted\">Please enter remarks</span>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n                                    ");
                __builder2.AddMarkupContent(93, "<button type=\"submit\" class=\"btn btn-fms\">POST</button>");
                __builder2.CloseElement();
                __builder2.CloseElement();
<<<<<<< HEAD
                __builder2.AddMarkupContent(92, "\r\n                            ");
                __builder2.OpenElement(93, "div");
                __builder2.AddAttribute(94, "class", "card");
                __builder2.AddMarkupContent(95, "<div class=\"card-header\">\r\n                                    Uploaded Files\r\n                                </div>\r\n                                ");
                __builder2.OpenElement(96, "div");
                __builder2.AddAttribute(97, "class", "card-body");
                __builder2.OpenElement(98, "ul");
#nullable restore
#line 69 "C:\Users\Btech\Source\Repos\fms\Client\Components\Accident\BillPosting.razor"
=======
                __builder2.AddMarkupContent(94, "\r\n                            ");
                __builder2.OpenElement(95, "div");
                __builder2.AddAttribute(96, "class", "card");
                __builder2.AddMarkupContent(97, "<div class=\"card-header\">\r\n                                    Uploaded Files\r\n                                </div>\r\n                                ");
                __builder2.OpenElement(98, "div");
                __builder2.AddAttribute(99, "class", "card-body");
                __builder2.OpenElement(100, "ul");
#nullable restore
#line 70 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Accident\BillPosting.razor"
>>>>>>> c4f6b5a305fa29cb053a7848c4267a5c0b345154
                                         foreach (var t in fileNames)
                                        {
                                            if (t != null)
                                            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(101, "li");
                __builder2.OpenElement(102, "a");
                __builder2.AddAttribute(103, "target", "_blank");
                __builder2.AddAttribute(104, "href", "api\\download\\" + (
#nullable restore
<<<<<<< HEAD
#line 74 "C:\Users\Btech\Source\Repos\fms\Client\Components\Accident\BillPosting.razor"
=======
#line 75 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Accident\BillPosting.razor"
>>>>>>> c4f6b5a305fa29cb053a7848c4267a5c0b345154
                                                                                            CheckPointId.FMSAccidentalCheckId.ToString()

#line default
#line hidden
#nullable disable
                ) + "\\" + (
#nullable restore
<<<<<<< HEAD
#line 74 "C:\Users\Btech\Source\Repos\fms\Client\Components\Accident\BillPosting.razor"
=======
#line 75 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Accident\BillPosting.razor"
>>>>>>> c4f6b5a305fa29cb053a7848c4267a5c0b345154
                                                                                                                                           t

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(105, 
#nullable restore
<<<<<<< HEAD
#line 74 "C:\Users\Btech\Source\Repos\fms\Client\Components\Accident\BillPosting.razor"
=======
#line 75 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Accident\BillPosting.razor"
>>>>>>> c4f6b5a305fa29cb053a7848c4267a5c0b345154
                                                                                                                                               t

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
<<<<<<< HEAD
#line 76 "C:\Users\Btech\Source\Repos\fms\Client\Components\Accident\BillPosting.razor"
=======
#line 77 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Accident\BillPosting.razor"
>>>>>>> c4f6b5a305fa29cb053a7848c4267a5c0b345154
                                            }
                                        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(106, "\r\n                        <div class=\"col-1\"></div>\r\n                        ");
                __builder2.OpenElement(107, "div");
<<<<<<< HEAD
                __builder2.AddAttribute(108, "class", "card");
                __builder2.AddMarkupContent(109, "<div class=\"card-header\">\r\n                                    Upload Files\r\n                                </div>\r\n                                ");
                __builder2.OpenElement(110, "div");
                __builder2.AddAttribute(111, "class", "card-body");
                __builder2.OpenComponent<Syncfusion.Blazor.Inputs.SfUploader>(112);
                __builder2.AddAttribute(113, "ID", "UploadFiles");
                __builder2.AddAttribute(114, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.Inputs.UploaderEvents>(115);
                    __builder3.AddAttribute(116, "ValueChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Inputs.UploadChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Inputs.UploadChangeEventArgs>(this, 
#nullable restore
#line 91 "C:\Users\Btech\Source\Repos\fms\Client\Components\Accident\BillPosting.razor"
=======
                __builder2.AddAttribute(108, "class", "col-6");
                __builder2.OpenElement(109, "div");
                __builder2.AddAttribute(110, "class", "card");
                __builder2.AddMarkupContent(111, "<div class=\"card-header\">\r\n                                    Upload Files\r\n                                </div>\r\n                                ");
                __builder2.OpenElement(112, "div");
                __builder2.AddAttribute(113, "class", "card-body");
                __builder2.OpenComponent<Syncfusion.Blazor.Inputs.SfUploader>(114);
                __builder2.AddAttribute(115, "ID", "UploadFiles");
                __builder2.AddAttribute(116, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.Inputs.UploaderEvents>(117);
                    __builder3.AddAttribute(118, "ValueChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Inputs.UploadChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Inputs.UploadChangeEventArgs>(this, 
#nullable restore
#line 92 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Accident\BillPosting.razor"
>>>>>>> c4f6b5a305fa29cb053a7848c4267a5c0b345154
                                                                     OnChange

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
<<<<<<< HEAD
#line 99 "C:\Users\Btech\Source\Repos\fms\Client\Components\Accident\BillPosting.razor"
=======
#line 100 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Accident\BillPosting.razor"
>>>>>>> c4f6b5a305fa29cb053a7848c4267a5c0b345154
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(119, "<img style=\"position:fixed;top:50%;left:70%;\" src=\"assets/media/loading.gif\">");
#nullable restore
<<<<<<< HEAD
#line 103 "C:\Users\Btech\Source\Repos\fms\Client\Components\Accident\BillPosting.razor"
=======
#line 104 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Accident\BillPosting.razor"
>>>>>>> c4f6b5a305fa29cb053a7848c4267a5c0b345154
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n\r\n");
            __builder.OpenComponent<SOS.FMS.Client.Components.Accident.AddBillDetails>(121);
            __builder.AddAttribute(122, "CheckPointId", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<SOS.FMS.Shared.ApiRequest>(
#nullable restore
<<<<<<< HEAD
#line 107 "C:\Users\Btech\Source\Repos\fms\Client\Components\Accident\BillPosting.razor"
=======
#line 108 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Accident\BillPosting.razor"
>>>>>>> c4f6b5a305fa29cb053a7848c4267a5c0b345154
                              CheckPointId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(123, "OnVisibilityChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
<<<<<<< HEAD
#line 107 "C:\Users\Btech\Source\Repos\fms\Client\Components\Accident\BillPosting.razor"
=======
#line 108 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Accident\BillPosting.razor"
>>>>>>> c4f6b5a305fa29cb053a7848c4267a5c0b345154
                                                                 ShowHideAddModal

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(124, "VehicleNumber", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
<<<<<<< HEAD
#line 107 "C:\Users\Btech\Source\Repos\fms\Client\Components\Accident\BillPosting.razor"
=======
#line 108 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Accident\BillPosting.razor"
>>>>>>> c4f6b5a305fa29cb053a7848c4267a5c0b345154
                                                                                                   VehicleNumber

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(125, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
<<<<<<< HEAD
#line 107 "C:\Users\Btech\Source\Repos\fms\Client\Components\Accident\BillPosting.razor"
=======
#line 108 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Accident\BillPosting.razor"
>>>>>>> c4f6b5a305fa29cb053a7848c4267a5c0b345154
                                                                                                                           addVisible

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
<<<<<<< HEAD
#line 108 "C:\Users\Btech\Source\Repos\fms\Client\Components\Accident\BillPosting.razor"
=======
#line 109 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\Accident\BillPosting.razor"
>>>>>>> c4f6b5a305fa29cb053a7848c4267a5c0b345154
       
    [Parameter]
    public ApiRequest CheckPointId { get; set; }
    [Parameter]
    public string VehicleNumber { get; set; }
    [Parameter]
    public bool Visible { get; set; }
    [Parameter]
    public EventCallback<bool> OnVisibilityChanged { get; set; }

    public Modal videomodal { get; set; }
    public Modal filemodal { get; set; }

    FMSAccidentalCheckCommentVM AccidentalCheckComment;

    public List<string> fileNames { get; set; }

    public BillPostingVM BillPostingVM = new BillPostingVM();
    public AccidentBill bill = new AccidentBill();

    public List<AccidentBill> BillsList = new List<AccidentBill>();
    public List<BillDetailVM> BillDetailsList { get; set; }

    protected override async Task OnInitializedAsync()
    {
        LoaderOn();
        await LoadData();
        await base.OnInitializedAsync();
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        //await LoadData();
        bill.CheckPointId = CheckPointId.FMSAccidentalCheckId;
        bill.BillAmount = BillDetailsList.Sum(x => Convert.ToInt32(x.Amount));
        BillPostingVM.CheckPointId = CheckPointId.FMSAccidentalCheckId;
        await base.OnAfterRenderAsync(firstRender);
    }

    public Task CloseBillPosting()
    {
        return OnVisibilityChanged.InvokeAsync(false);
    }

    public async Task<List<AccidentBill>> GetBills()
    {
        ApiRequest request = new ApiRequest() { FMSAccidentalCheckId = CheckPointId.FMSAccidentalCheckId };
        var getBillResponse = await Http.PostAsJsonAsync<ApiRequest>("api/Accident/GetBills", request);
        return JsonConvert.DeserializeObject<List<AccidentBill>>(await getBillResponse.Content.ReadAsStringAsync());
    }
    public async Task<AccidentBill> GetBill()
    {
        ApiRequest request = new ApiRequest() { FMSAccidentalCheckId = CheckPointId.FMSAccidentalCheckId };
        var getBillResponse = await Http.PostAsJsonAsync<ApiRequest>("api/Accident/GetBill", request);
        return JsonConvert.DeserializeObject<AccidentBill>(await getBillResponse.Content.ReadAsStringAsync());
    }
    public async Task<List<string>> GetFiles()
    {
        ApiRequest request = new ApiRequest() { FMSAccidentalCheckId = CheckPointId.FMSAccidentalCheckId };
        var getBillResponse = await Http.PostAsJsonAsync<ApiRequest>("api/Files/Files", request);
        return JsonConvert.DeserializeObject<List<string>>(await getBillResponse.Content.ReadAsStringAsync());
    }
    public async Task<List<BillDetailVM>> GetBillDetails()
    {
        ApiRequest request = new ApiRequest() { FMSAccidentalCheckId = CheckPointId.FMSAccidentalCheckId };
        var getBillResponse = await Http.PostAsJsonAsync<ApiRequest>("api/Accident/GetBillDetails", request);
        return JsonConvert.DeserializeObject<List<BillDetailVM>>(await getBillResponse.Content.ReadAsStringAsync());
    }

    public async void PostBill()
    {
        LoaderOn();
        var postBillResponse = await Http.PostAsJsonAsync<AccidentBill>("api/Accident/PostBill", bill);

        if (postBillResponse.StatusCode == System.Net.HttpStatusCode.OK)
        {
            BillsList = await GetBills();
            StateHasChanged();
        }
        else
        {
        }
    }

    private async void OnChange(UploadChangeEventArgs args)
    {
        LoaderOn();
        var files = new List<FileInfo>();
        foreach (var file in args.Files)
        {
            var content = new MultipartFormDataContent {
                    { new ByteArrayContent(file.Stream.GetBuffer()), CheckPointId.FMSAccidentalCheckId.ToString(), file.FileInfo.Name}
                };
            var filepath = await Http.PostAsync("api/Files/Save", content);
        }

    }


    #region Add to bill
    public bool addVisible { get; set; } = false;
    public void ShowHideAddModal(bool status)
    {
        LoaderOn();
        addVisible = status;
        //if (!addVisible) ReloadCheckList();
        StateHasChanged();
    }
    public void ShowAddModal()
    {
        addVisible = true;
    }
    #endregion

    public void LoaderOn()
    {
        BillDetailsList = null;
        BillsList = null;
        fileNames = null;
    }
    public async Task LoadData()
    {
        bill = await GetBill();
        fileNames = await GetFiles();
        BillsList = await GetBills();
        BillDetailsList = await GetBillDetails();
    }
    public void PostRemarks()
    {
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
namespace __Blazor.SOS.FMS.Client.Components.Accident.BillPosting
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateSfGrid_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TValue> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Syncfusion.Blazor.Grids.SfGrid<TValue>>(seq);
        __builder.AddAttribute(__seq0, "DataSource", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateSfNumericTextBox_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
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
