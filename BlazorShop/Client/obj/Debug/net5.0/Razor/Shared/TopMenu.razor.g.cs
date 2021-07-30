#pragma checksum "D:\Blazor\BlazorShop\BlazorShop\Client\Shared\TopMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf31b2b8ce66d15f3cab49d85bae30da86b7eb8e"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorShop.Client.Shared
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
using BlazorShop.Client.Services.CartService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Blazor\BlazorShop\BlazorShop\Client\_Imports.razor"
using BlazorShop.Client.Services.StatsService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Blazor\BlazorShop\BlazorShop\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Blazor\BlazorShop\BlazorShop\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\Blazor\BlazorShop\BlazorShop\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "D:\Blazor\BlazorShop\BlazorShop\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
    public partial class TopMenu : Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "a");
            __builder.AddAttribute(1, "href", "cart");
            __builder.AddAttribute(2, "class", "btn btn-info");
            __builder.AddMarkupContent(3, "<i class=\"oi oi-cart\"></i>\r\n        Cart\r\n        ");
            __builder.OpenElement(4, "span");
            __builder.AddAttribute(5, "class", "badge badge-pill badge-light");
            __builder.AddContent(6, 
#nullable restore
#line 8 "D:\Blazor\BlazorShop\BlazorShop\Client\Shared\TopMenu.razor"
                                                    GetProductCount()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "D:\Blazor\BlazorShop\BlazorShop\Client\Shared\TopMenu.razor"
               

    protected override void OnInitialized()
    {
        CartService.OnChange += StateHasChanged;
    }

    public void Dispose()
    {
        CartService.OnChange -= StateHasChanged;
    }

    private int GetProductCount()
    {
        var cart = LocalStorage.GetItem<List<ProductVariant>>("cart");
        return cart != null ? cart.Count : 0;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICartService CartService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISyncLocalStorageService LocalStorage { get; set; }
    }
}
#pragma warning restore 1591
