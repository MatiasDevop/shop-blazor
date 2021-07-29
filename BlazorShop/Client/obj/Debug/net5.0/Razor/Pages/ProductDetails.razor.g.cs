#pragma checksum "D:\Blazor\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7808b02ebd178e88360bf1ff7211fde5f443d58c"
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
using BlazorShop.Client.Services.CartService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Blazor\BlazorShop\BlazorShop\Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\Blazor\BlazorShop\BlazorShop\Client\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "D:\Blazor\BlazorShop\BlazorShop\Client\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/product/{id:int}")]
    public partial class ProductDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h3");
            __builder.AddContent(1, 
#nullable restore
#line 7 "D:\Blazor\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
     product.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(2, "\r\n\r\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "media");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "media-img-big-wrapper mr-2");
            __builder.OpenElement(7, "img");
            __builder.AddAttribute(8, "class", "media-img-big");
            __builder.AddAttribute(9, "src", 
#nullable restore
#line 11 "D:\Blazor\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
                                         product.Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(10, "alt", 
#nullable restore
#line 11 "D:\Blazor\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
                                                              product.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "media-body");
            __builder.OpenElement(14, "h2");
            __builder.AddAttribute(15, "class", "mb-0");
            __builder.AddContent(16, 
#nullable restore
#line 14 "D:\Blazor\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
                          product.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.OpenElement(18, "p");
            __builder.AddContent(19, 
#nullable restore
#line 15 "D:\Blazor\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
            product.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 16 "D:\Blazor\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
         if (product.Variants != null && product.Variants.Count > 0)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "form-group");
            __builder.OpenElement(22, "select");
            __builder.AddAttribute(23, "class", "form-control");
            __builder.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "D:\Blazor\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
                                                    currentEditionId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => currentEditionId = __value, currentEditionId));
            __builder.SetUpdatesAttributeName("value");
#nullable restore
#line 20 "D:\Blazor\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
                     foreach (var variant in product.Variants)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(26, "option");
            __builder.AddAttribute(27, "value", 
#nullable restore
#line 22 "D:\Blazor\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
                                        variant.EditionId

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(28, 
#nullable restore
#line 22 "D:\Blazor\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
                                                            variant.Edition.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 23 "D:\Blazor\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 26 "D:\Blazor\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "D:\Blazor\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
         if (GetSelectedVariant() != null)
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\Blazor\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
             if (GetSelectedVariant().OriginalPrice > GetSelectedVariant().Price)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(29, "h6");
            __builder.AddAttribute(30, "class", "text-muted original-price");
            __builder.AddContent(31, "$");
            __builder.AddContent(32, 
#nullable restore
#line 31 "D:\Blazor\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
                                                        GetSelectedVariant().OriginalPrice

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 32 "D:\Blazor\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(33, "h4");
            __builder.AddAttribute(34, "class", "price");
            __builder.AddMarkupContent(35, "\r\n                $");
            __builder.AddContent(36, 
#nullable restore
#line 34 "D:\Blazor\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
                  GetSelectedVariant().Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 36 "D:\Blazor\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(37, "button");
            __builder.AddAttribute(38, "class", "btn btn-primary");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "D:\Blazor\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
                                                  AddToCart

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(40, "<i class=\"oi oi-cart\"></i>&nbsp;&nbsp;&nbsp;Add to Cart");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "D:\Blazor\BlazorShop\BlazorShop\Client\Pages\ProductDetails.razor"
       

    private Product product = new Product();

    private int currentEditionId = 1;

    [Parameter]
    public int Id { get; set; }

    protected override async Task OnInitializedAsync()
    {
        product = await ProductService.GetProduct(Id);

        if (product.Variants.Count > 0)
        {
            currentEditionId = product.Variants[0].EditionId;
        }
    }

    private ProductVariant GetSelectedVariant()
    {
        var variant = product.Variants.FirstOrDefault(v => v.EditionId == currentEditionId);
        return variant;
    }

    private async Task AddToCart()
    {
        await CartService.AddToCart(GetSelectedVariant());
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService ToastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService LocalStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICartService CartService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProductService ProductService { get; set; }
    }
}
#pragma warning restore 1591
