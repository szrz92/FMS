#pragma checksum "C:\Users\Btech\Desktop\FMS\Client\Components\Accident\ImageUpload.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f5db471ca4d4e210b3b045fcb6e2198b19771086"
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
#line 1 "C:\Users\Btech\Desktop\FMS\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Btech\Desktop\FMS\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Btech\Desktop\FMS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Btech\Desktop\FMS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Btech\Desktop\FMS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Btech\Desktop\FMS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Btech\Desktop\FMS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Btech\Desktop\FMS\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Btech\Desktop\FMS\Client\_Imports.razor"
using SOS.FMS.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Btech\Desktop\FMS\Client\_Imports.razor"
using SOS.FMS.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Btech\Desktop\FMS\Client\_Imports.razor"
using SOS.FMS.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Btech\Desktop\FMS\Client\_Imports.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Btech\Desktop\FMS\Client\_Imports.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Btech\Desktop\FMS\Client\_Imports.razor"
using SOS.FMS.Client.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Btech\Desktop\FMS\Client\_Imports.razor"
using SOS.FMS.Shared.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Btech\Desktop\FMS\Client\_Imports.razor"
using Syncfusion.Blazor.Inputs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Btech\Desktop\FMS\Client\_Imports.razor"
using Syncfusion.Blazor.Grids;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Btech\Desktop\FMS\Client\_Imports.razor"
using Syncfusion.Blazor.Spinner;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Btech\Desktop\FMS\Client\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Btech\Desktop\FMS\Client\_Imports.razor"
using Syncfusion.Blazor.Popups;

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Btech\Desktop\FMS\Client\_Imports.razor"
using Syncfusion.Blazor.Navigations;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Btech\Desktop\FMS\Client\_Imports.razor"
using Syncfusion.Blazor.PivotView;

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\Btech\Desktop\FMS\Client\_Imports.razor"
using Append.Blazor.Notifications;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Btech\Desktop\FMS\Client\_Imports.razor"
using SOS.FMS.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\Btech\Desktop\FMS\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\Btech\Desktop\FMS\Client\_Imports.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
    public partial class ImageUpload : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "C:\Users\Btech\Desktop\FMS\Client\Components\Accident\ImageUpload.razor"
 if (fileNames != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row p-1");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-xl-7");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card");
            __builder.AddMarkupContent(6, "<div class=\"card-header\">\r\n                    Uploaded Files\r\n                </div>\r\n                ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card-body");
            __builder.OpenElement(9, "ul");
#nullable restore
#line 14 "C:\Users\Btech\Desktop\FMS\Client\Components\Accident\ImageUpload.razor"
                         foreach (var t in fileNames)
                        {
                            if (t != null)
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "li");
            __builder.OpenElement(11, "a");
            __builder.AddAttribute(12, "target", "_blank");
            __builder.AddAttribute(13, "href", "api\\download\\" + (
#nullable restore
#line 19 "C:\Users\Btech\Desktop\FMS\Client\Components\Accident\ImageUpload.razor"
                                                    AccidentalCommentModal.FMSAccidentalCheckId.ToString()

#line default
#line hidden
#nullable disable
            ) + "\\" + (
#nullable restore
#line 19 "C:\Users\Btech\Desktop\FMS\Client\Components\Accident\ImageUpload.razor"
                                                                                                             t

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(14, 
#nullable restore
#line 19 "C:\Users\Btech\Desktop\FMS\Client\Components\Accident\ImageUpload.razor"
                                                                                                                 t

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 21 "C:\Users\Btech\Desktop\FMS\Client\Components\Accident\ImageUpload.razor"
        }
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "col-xl-5");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "card");
            __builder.AddMarkupContent(20, "<div class=\"card-header\">\r\n                    Upload Files\r\n                </div>\r\n                ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "card-body");
            __builder.OpenComponent<Syncfusion.Blazor.Inputs.SfUploader>(23);
            __builder.AddAttribute(24, "ID", "UploadFiles");
            __builder.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Inputs.UploaderEvents>(26);
                __builder2.AddAttribute(27, "ValueChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Syncfusion.Blazor.Inputs.UploadChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Syncfusion.Blazor.Inputs.UploadChangeEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\Btech\Desktop\FMS\Client\Components\Accident\ImageUpload.razor"
                                                     OnChange

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 40 "C:\Users\Btech\Desktop\FMS\Client\Components\Accident\ImageUpload.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(28, "<img style=\"position:fixed;top:50%;left:70%;\" src=\"assets/media/loading.gif\">");
#nullable restore
#line 44 "C:\Users\Btech\Desktop\FMS\Client\Components\Accident\ImageUpload.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\Btech\Desktop\FMS\Client\Components\Accident\ImageUpload.razor"
       
    [Parameter]
    public FMSAccidentalCommentModalVM AccidentalCommentModal { get; set; }
    [Parameter]
    public EventCallback<string> OnImagePost { get; set; }

    public string displayImage;
    private IList<string> imageDataUrls = new List<string>();
    public void DisplayImage(string item)
    {
        displayImage = item;
    }


    protected override async Task OnInitializedAsync()
    {
        LoaderOn();
        await LoadData();
        await base.OnInitializedAsync();
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

    public List<string> fileNames { get; set; }
    public void LoaderOn()
    {
        fileNames = null;
    }
    public async Task LoadData()
    {
        fileNames = await GetFiles();
    }
    public async Task<List<string>> GetFiles()
    {
        ApiRequest request = new ApiRequest() { FMSAccidentalCheckId = AccidentalCommentModal.FMSAccidentalCheckId };
        var getBillResponse = await Http.PostAsJsonAsync<ApiRequest>("api/Files/Files", request);
        return JsonConvert.DeserializeObject<List<string>>(await getBillResponse.Content.ReadAsStringAsync());
    }

    private async void OnChange(UploadChangeEventArgs args)
    {
        LoaderOn();
        var files = new List<FileInfo>();
        foreach (var file in args.Files)
        {
            var content = new MultipartFormDataContent {
                    { new ByteArrayContent(file.Stream.GetBuffer()), AccidentalCommentModal.FMSAccidentalCheckId.ToString(), file.FileInfo.Name}
                };
            var filepath = await Http.PostAsync("api/Files/Save", content);
            if (filepath.IsSuccessStatusCode)
            {
                await LoadData();
                StateHasChanged();
            }
        }
        await LoadData();
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
#pragma warning restore 1591
