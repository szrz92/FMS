// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#pragma warning restore 1591