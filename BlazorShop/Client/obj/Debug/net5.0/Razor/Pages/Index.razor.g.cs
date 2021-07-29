#pragma checksum "D:\Blazor\BlazorShop\BlazorShop\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d81b363003d9eaf04aa3db69114f588eb9764263"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorShop.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Blazor\BlazorShop\BlazorShop\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Blazor\BlazorShop\BlazorShop\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Blazor\BlazorShop\BlazorShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Blazor\BlazorShop\BlazorShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Blazor\BlazorShop\BlazorShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Blazor\BlazorShop\BlazorShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Blazor\BlazorShop\BlazorShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Blazor\BlazorShop\BlazorShop\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Blazor\BlazorShop\BlazorShop\Client\_Imports.razor"
using BlazorShop.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Blazor\BlazorShop\BlazorShop\Client\_Imports.razor"
using BlazorShop.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Blazor\BlazorShop\BlazorShop\Client\_Imports.razor"
using BlazorShop.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Blazor\BlazorShop\BlazorShop\Client\_Imports.razor"
using BlazorShop.Client.Services.ProductService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Blazor\BlazorShop\BlazorShop\Client\_Imports.razor"
using BlazorShop.Client.Services.CategoryService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Blazor\BlazorShop\BlazorShop\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Blazor\BlazorShop\BlazorShop\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Blazor\BlazorShop\BlazorShop\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/{categoryurl}")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 7 "D:\Blazor\BlazorShop\BlazorShop\Client\Pages\Index.razor"
 if (category != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "h1");
            __builder.AddContent(1, "welcome to the ");
            __builder.AddContent(2, 
#nullable restore
#line 9 "D:\Blazor\BlazorShop\BlazorShop\Client\Pages\Index.razor"
                        category.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(3, " section!");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenComponent<BlazorShop.Client.Shared.ProductList>(5);
            __builder.CloseComponent();
#nullable restore
#line 11 "D:\Blazor\BlazorShop\BlazorShop\Client\Pages\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "<h1>Welcome to Blazing Shop!</h1>\r\n    ");
            __builder.OpenComponent<BlazorShop.Client.Shared.ProductList>(7);
            __builder.CloseComponent();
#nullable restore
#line 16 "D:\Blazor\BlazorShop\BlazorShop\Client\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 18 "D:\Blazor\BlazorShop\BlazorShop\Client\Pages\Index.razor"
      

    [Parameter]
    public string CategoryUrl { get; set; }

    private Category category = null;

    protected override async Task OnParametersSetAsync()
    {
       await ProductService.LoadProducts(CategoryUrl);

        if (CategoryUrl != null)
        {
            category = CategoryService.Categories.FirstOrDefault(c => c.Url.ToLower().Equals(CategoryUrl.ToLower()));
        }
        else
        {
            category = null;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService ProductService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICategoryService CategoryService { get; set; }
    }
}
#pragma warning restore 1591
