#pragma checksum "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09ec9436fc96ee38d61f984f09874820b0fb54eb"
// <auto-generated/>
#pragma warning disable 1591
namespace CockTailBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\_Imports.razor"
using CockTailBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\_Imports.razor"
using CockTailBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\Index.razor"
using CockTailBlazor.CustomAPI;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Welcome to My CockTail Party</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, @"<p style=""text-align:justify"">
    The Oxford Dictionaries define cocktail as ""An alcoholic
    drink consisting of a spirit or spirits mixed with other
    ingredients, such as fruit juice or cream"". A cocktail
    can contain alcohol, a sugar, and a bitter/citrus. When
    a mixed drink contains only a distilled spirit and a mixer,
    such as soda or fruit juice, it is a highball. Many of
    the International Bartenders Association Official Cocktails
    are highballs. When a mixed drink contains only a distilled
    spirit and a liqueur, it is a duo, and when it adds a mixer,
    it is a trio. Additional ingredients may be sugar, honey, milk,
    cream, and various herbs.
</p>

");
            __builder.OpenElement(2, "div");
            __builder.AddMarkupContent(3, "\r\n");
#nullable restore
#line 21 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\Index.razor"
     if (Program.singleDrink != null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "        ");
            __builder.AddMarkupContent(5, "<p><b><u> Today\'s Chosen Drink Is:</u></b></p>\r\n");
#nullable restore
#line 24 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\Index.razor"
         foreach (Drinks drink in Program.singleDrink.drinks)
        {
            drinkIDClicked = drink.idDrink;

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "            ");
            __builder.OpenElement(7, "a");
            __builder.AddAttribute(8, "href", "/Details/" + (
#nullable restore
#line 27 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\Index.razor"
                               drinkIDClicked

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.OpenComponent<MatBlazor.MatCard>(10);
            __builder.AddAttribute(11, "class", "demo-mat-card");
            __builder.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(13, "\r\n                    ");
                __builder2.OpenComponent<MatBlazor.MatCardContent>(14);
                __builder2.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(16, "\r\n                        ");
                    __builder3.OpenComponent<MatBlazor.MatCardMedia>(17);
                    __builder3.AddAttribute(18, "Wide", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 30 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\Index.razor"
                                            true

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(19, "ImageUrl", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\Index.razor"
                                                            drink.strDrinkThumb

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(21, "\r\n                            ");
                        __builder4.OpenElement(22, "div");
                        __builder4.AddAttribute(23, "class", "demo-mat-card-content");
                        __builder4.AddAttribute(24, "style", "color: white;");
                        __builder4.AddMarkupContent(25, "\r\n                                ");
                        __builder4.OpenComponent<MatBlazor.MatHeadline6>(26);
                        __builder4.AddAttribute(27, "class", "demo-mat-card-clean-margin");
                        __builder4.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(29, "\r\n                                    ");
                            __builder5.AddContent(30, 
#nullable restore
#line 33 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\Index.razor"
                                     drink.strDrink

#line default
#line hidden
#nullable disable
                            );
                            __builder5.AddMarkupContent(31, "\r\n                                ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(32, "\r\n                                ");
                        __builder4.OpenComponent<MatBlazor.MatSubtitle2>(33);
                        __builder4.AddAttribute(34, "class", "demo-mat-card-clean-margin");
                        __builder4.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(36, "\r\n                                    Drink Type: ");
                            __builder5.AddContent(37, 
#nullable restore
#line 36 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\Index.razor"
                                                 drink.strCategory

#line default
#line hidden
#nullable disable
                            );
                            __builder5.AddMarkupContent(38, "\r\n                                ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(39, "\r\n                            ");
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(40, "\r\n                        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(41, "\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(42, "\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(43, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
#nullable restore
#line 43 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\Index.razor"
         
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "D:\OneDrive_Trios\C# Blazor\CockTailBlazor\Pages\Index.razor"
     
        string drinkIDClicked;
        protected override async Task OnInitializedAsync()
        {
            Program.MakeAllNull();
            await Program.fetch.RandomDrinkAsync();
        }
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591