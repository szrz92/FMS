#pragma checksum "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Users.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76fd4dc6d189bfe16d8a72b50073725249c0967b"
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
#line 4 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Users.razor"
using SOS.FMS.Client.Components.Users;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Users")]
    public partial class Users : Microsoft.AspNetCore.Components.ComponentBase
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
            
            
            <ul class=""breadcrumb breadcrumb-transparent breadcrumb-dot font-weight-bold p-0 my-2 font-size-sm""><li class=""breadcrumb-item""><a href=""/"" class=""text-muted"">Application User Management</a></li></ul></div>
        
        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "d-flex align-items-center");
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "class", "btn btn-bg-danger text-white mr-2");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Users.razor"
                                                                        ShowAddUserSideBar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(11, "ADD USER");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n\r\n\r\n");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "d-flex flex-column-fluid");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "container-fluid");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "card card-custom card-stretch");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "card-body");
#nullable restore
#line 49 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Users.razor"
                 if (UsersList != null)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "col-lg-12 control-section");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "content-wrapper");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "row");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "id", "container");
            __Blazor.SOS.FMS.Client.Pages.Users.TypeInference.CreateSfGrid_0(__builder, 29, 30, "UsersGrid", 31, 
#nullable restore
#line 55 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Users.razor"
                                                                                         UsersList

#line default
#line hidden
#nullable disable
            , 32, 
#nullable restore
#line 56 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Users.razor"
                                                         true

#line default
#line hidden
#nullable disable
            , 33, 
#nullable restore
#line 56 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Users.razor"
                                                                             true

#line default
#line hidden
#nullable disable
            , 34, 
#nullable restore
#line 56 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Users.razor"
                                                                                                   true

#line default
#line hidden
#nullable disable
            , 35, "600", 36, 
#nullable restore
#line 57 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Users.razor"
                                                                    38

#line default
#line hidden
#nullable disable
            , 37, 
#nullable restore
#line 58 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Users.razor"
                                                       new List<string>() { "ExcelExport", "CsvExport", "PdfExport", "Search"}

#line default
#line hidden
#nullable disable
            , 38, 
#nullable restore
#line 59 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Users.razor"
                                                              true

#line default
#line hidden
#nullable disable
            , 39, 
#nullable restore
#line 59 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Users.razor"
                                                                                    true

#line default
#line hidden
#nullable disable
            , 40, (__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridPageSettings>(41);
                __builder2.AddAttribute(42, "PageCount", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 60 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Users.razor"
                                                                     5

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "PageSize", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 60 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Users.razor"
                                                                                  20

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "PageSizes", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 60 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Users.razor"
                                                                                                 new int[]{ 5, 10, 20, 50, 100 }

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(45, "\r\n                                        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridFilterSettings>(46);
                __builder2.AddAttribute(47, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.FilterType>(
#nullable restore
#line 61 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Users.razor"
                                                                  Syncfusion.Blazor.Grids.FilterType.Menu

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(48, "\r\n                                        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridSelectionSettings>(49);
                __builder2.AddAttribute(50, "CheckboxOnly", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 62 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Users.razor"
                                                                             true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "PersistSelection", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 62 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Users.razor"
                                                                                                     true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "Type", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Grids.SelectionType>(
#nullable restore
#line 62 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Users.razor"
                                                                                                                 SelectionType.Multiple

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(53, "\r\n                                        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridEvents<FMSApplicationUserVM>>(54);
                __builder2.AddAttribute(55, "OnToolbarClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Navigations.ClickEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Navigations.ClickEventArgs>(this, 
#nullable restore
#line 63 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Users.razor"
                                                                    UsersToolbarClick

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(56, "\r\n                                        ");
                __builder2.OpenComponent<Syncfusion.Blazor.Grids.GridColumns>(57);
                __builder2.AddAttribute(58, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(59);
                    __builder3.AddAttribute(60, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 65 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Users.razor"
                                                               nameof(FMSApplicationUserVM.UserName)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(61, "HeaderText", "User Name");
                    __builder3.AddAttribute(62, "Width", "130");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(63, "\r\n                                            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(64);
                    __builder3.AddAttribute(65, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 66 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Users.razor"
                                                               nameof(FMSApplicationUserVM.Email)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(66, "HeaderText", "Email");
                    __builder3.AddAttribute(67, "Width", "130");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(68, "\r\n                                            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(69);
                    __builder3.AddAttribute(70, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 67 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Users.razor"
                                                               nameof(FMSApplicationUserVM.FullName)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(71, "HeaderText", "Full Name");
                    __builder3.AddAttribute(72, "Width", "130");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(73, "\r\n                                            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(74);
                    __builder3.AddAttribute(75, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 68 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Users.razor"
                                                               nameof(FMSApplicationUserVM.Department)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(76, "HeaderText", "Department");
                    __builder3.AddAttribute(77, "Width", "130");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(78, "\r\n                                            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(79);
                    __builder3.AddAttribute(80, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 69 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Users.razor"
                                                               nameof(FMSApplicationUserVM.Region)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(81, "HeaderText", "Region");
                    __builder3.AddAttribute(82, "Width", "130");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(83, "\r\n                                            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(84);
                    __builder3.AddAttribute(85, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 70 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Users.razor"
                                                               nameof(FMSApplicationUserVM.SubRegion)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(86, "HeaderText", "Sub Region");
                    __builder3.AddAttribute(87, "Width", "130");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(88, "\r\n                                            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(89);
                    __builder3.AddAttribute(90, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 71 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Users.razor"
                                                               nameof(FMSApplicationUserVM.UserRoleNames)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(91, "HeaderText", "Roles");
                    __builder3.AddAttribute(92, "Width", "130");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(93, "\r\n                                            ");
                    __builder3.OpenComponent<Syncfusion.Blazor.Grids.GridColumn>(94);
                    __builder3.AddAttribute(95, "HeaderText", "Action");
                    __builder3.AddAttribute(96, "AllowFiltering", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 72 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Users.razor"
                                                                                            false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(97, "AllowSorting", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 72 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Users.razor"
                                                                                                                 false

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(98, "Width", "180");
                    __builder3.AddAttribute(99, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((context) => (__builder4) => {
#nullable restore
#line 74 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Users.razor"
                                                      
                                                        var UserInfo = (context as FMSApplicationUserVM);

#line default
#line hidden
#nullable disable
                        __builder4.OpenElement(100, "button");
                        __builder4.AddAttribute(101, "class", "btn btn-sm btn-success");
                        __builder4.AddAttribute(102, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 76 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Users.razor"
                                                                                                         ()=>EditUser(UserInfo.UserName)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddContent(103, "EDIT");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(104, "\r\n                                                        ");
                        __builder4.OpenElement(105, "button");
                        __builder4.AddAttribute(106, "class", "btn btn-sm btn-danger");
                        __builder4.AddAttribute(107, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 77 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Users.razor"
                                                                                                        ()=>DeleteUser(UserInfo.UserName)

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddContent(108, "DELETE");
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            , 109, (__value) => {
#nullable restore
#line 55 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Users.razor"
                                                                 UsersGrid = __value;

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
#line 87 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Users.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(110, "<h5>Loading.....</h5>");
#nullable restore
#line 91 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Users.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n\r\n");
            __builder.OpenComponent<SOS.FMS.Client.Components.Users.AddUser>(112);
            __builder.AddAttribute(113, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 100 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Users.razor"
                  AddUserSideBarVisibility

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(114, "OnVisibilityChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 100 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Users.razor"
                                                                 OnAddUserVisibilityChanged

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(115, "OnAddSuccess", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 100 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Users.razor"
                                                                                                           OnAddSuccess

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(116, "\r\n");
            __builder.OpenComponent<SOS.FMS.Client.Components.Users.EditUser>(117);
            __builder.AddAttribute(118, "Visible", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 101 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Users.razor"
                   EditUserSideBarVisibility

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(119, "ApplicationUser", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<SOS.FMS.Shared.ViewModels.FMSApplicationUserVM>(
#nullable restore
#line 101 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Users.razor"
                                                               UserToBeEdited

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(120, "RolesList", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<SOS.FMS.Shared.ViewModels.FMSRoleVM>>(
#nullable restore
#line 101 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Users.razor"
                                                                                          RolesList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(121, "OnVisibilityChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 101 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Users.razor"
                                                                                                                          OnEditUserVisibilityChanged

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(122, "OnEditSuccess", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 101 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Users.razor"
                                                                                                                                                                      OnEditSuccess

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 102 "C:\Users\BA Tech\source\repos\sosfms\Client\Pages\Users.razor"
       
    public List<FMSApplicationUserVM> UsersList { get; set; }
    public List<FMSRoleVM> RolesList { get; set; }

    protected override async Task OnInitializedAsync()
    {
        UsersList = (await Http.GetFromJsonAsync<List<FMSApplicationUserVM>>("api/Auth/RegisteredUsers"))
                            .ToList();
        RolesList = (await Http.GetFromJsonAsync<List<FMSRoleVM>>("api/Auth/FMSRoles"))
                            .ToList();
        await base.OnInitializedAsync();
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        await base.OnAfterRenderAsync(firstRender);
    }

    #region Syncfusion

    SfGrid<FMSApplicationUserVM> UsersGrid;

    public void UsersToolbarClick(Syncfusion.Blazor.Navigations.ClickEventArgs args)
    {
        if (args.Item.Id == "UsersGrid_pdfexport")
        {
            PdfExportProperties Props = new PdfExportProperties();
            Props.PageOrientation = PageOrientation.Landscape;
            Props.PageSize = PdfPageSize.A4;
            this.UsersGrid.PdfExport(Props);
        }
        if (args.Item.Id == "UsersGrid_excelexport")
        {
            this.UsersGrid.ExcelExport();
        }
        if (args.Item.Id == "UsersGrid_csvexport")
        {
            this.UsersGrid.CsvExport();
        }
    }
    #endregion

    #region Add User

    public bool AddUserSideBarVisibility { get; set; } = false;

    public void ShowAddUserSideBar()
    {
        OnAddUserVisibilityChanged(true);
    }

    public void OnAddUserVisibilityChanged(bool visibilityStatus)
    {
        AddUserSideBarVisibility = visibilityStatus;
    }
    public async void OnAddSuccess(bool isAdded)
    {
        if (isAdded)
        {
            UsersList = (await Http.GetFromJsonAsync<List<FMSApplicationUserVM>>("api/Auth/RegisteredUsers"))
                                .ToList();
        }
    }

    #endregion

    #region Delete User
    public async void DeleteUser(string userName)
    {
        var deleteResponse = await Http.PostAsJsonAsync("api/Auth/DeleteUser", new ApiRequest() { UserName = userName });
        if (deleteResponse.IsSuccessStatusCode)
        {
            UsersList = (await Http.GetFromJsonAsync<List<FMSApplicationUserVM>>("api/Auth/RegisteredUsers"))
                                .ToList();
        }
        StateHasChanged();
    }
    #endregion

    #region Edit User

    public bool EditUserSideBarVisibility { get; set; } = false;
    public FMSApplicationUserVM UserToBeEdited { get; set; }
    public string UserName { get; set; }

    public void ShowEditUserSideBar()
    {
        OnEditUserVisibilityChanged(true);
    }

    public void OnEditUserVisibilityChanged(bool visibilityStatus)
    {
        EditUserSideBarVisibility = visibilityStatus;
    }

    public async void OnEditSuccess(bool isUpdated)
    {
        if (isUpdated)
        {
            UsersList = (await Http.GetFromJsonAsync<List<FMSApplicationUserVM>>("api/Auth/RegisteredUsers"))
                                .ToList();
        }
    }

    public async void EditUser(string userName)
    {
        if (!string.IsNullOrEmpty(userName))
        {
            UserToBeEdited = JsonConvert.DeserializeObject<FMSApplicationUserVM>((
                await Http.PostAsJsonAsync("api/Auth/RegisteredUser",
                new ApiRequest() { UserName = userName }))
                .Content.ReadAsStringAsync().Result);

            ShowEditUserSideBar();
            StateHasChanged();
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
namespace __Blazor.SOS.FMS.Client.Pages.Users
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
