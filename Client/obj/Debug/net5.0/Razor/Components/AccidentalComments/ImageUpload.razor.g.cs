#pragma checksum "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalComments\ImageUpload.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f93b466bce10d6e0bbb32e28365a0040d7ba5713"
// <auto-generated/>
#pragma warning disable 1591
namespace SOS.FMS.Client.Components.AccidentalComments
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
    public partial class ImageUpload : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row p-1");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-xl-7");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row pl-4");
#nullable restore
#line 4 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalComments\ImageUpload.razor"
             foreach (var i in imageDataUrls)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-3 mb-2 p-2");
            __builder.OpenElement(8, "img");
            __builder.AddAttribute(9, "src", 
#nullable restore
#line 7 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalComments\ImageUpload.razor"
                               i

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(10, "style", "width:90%;height:auto;");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalComments\ImageUpload.razor"
                                                                           () => DisplayImage(i)

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 9 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalComments\ImageUpload.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "col-3 mb-2 p-2");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "d-flex");
            __builder.AddAttribute(16, "style", "display: flex; align-items: flex-start; justify-content: flex-end; width: 100%;");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "mr-3");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "container1");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "button-wrap");
            __builder.AddMarkupContent(23, "<label class=\"btn btn-fms btn-md text-uppercase font-weight-bold chat-send py-8 px-6\" for=\"upload\">Upload File</label>\r\n                                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(24);
            __builder.AddAttribute(25, "id", "upload");
            __builder.AddAttribute(26, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalComments\ImageUpload.razor"
                                                                  OnInputFileChange

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(27, "style", " display:none; position: absolute; z-index: -3; top: 15px; left: 20px; font-size: 17px; color: #b8b8b8;");
            __builder.AddAttribute(28, "multiple", true);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                    <div></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "col-xl-5");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "card");
            __builder.AddMarkupContent(35, "<div class=\"card-header\"><div class=\"card-title mb-0 font-weight-bolder\">Photo Viewer</div></div>\r\n            ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "card-body");
            __builder.OpenElement(38, "img");
            __builder.AddAttribute(39, "src", 
#nullable restore
#line 32 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalComments\ImageUpload.razor"
                           displayImage

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(40, "style", "width:99%;height:auto;");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\BA Tech\source\repos\sosfms\Client\Components\AccidentalComments\ImageUpload.razor"
       
    [Parameter]
    public EventCallback<string> OnImagePost { get; set; }

    public string displayImage;
    private IList<string> imageDataUrls = new List<string>();
    public void DisplayImage(string item)
    {
        displayImage = item;
    }


    private async Task OnInputFileChange(InputFileChangeEventArgs e)
    {
        var maxAllowedFiles = 3;
        var format = "image/png";

        foreach (var imageFile in e.GetMultipleFiles(maxAllowedFiles))
        {
            var resizedImageFile = await imageFile.RequestImageFileAsync(format,
                100, 100);
            var buffer = new byte[resizedImageFile.Size];
            await resizedImageFile.OpenReadStream().ReadAsync(buffer);
            var imageDataUrl =
                $"data:{format};base64,{Convert.ToBase64String(buffer)}";
            imageDataUrls.Add(imageDataUrl);

            await OnImagePost.InvokeAsync(imageDataUrl);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private INotificationService NotificationService { get; set; }
    }
}
#pragma warning restore 1591
