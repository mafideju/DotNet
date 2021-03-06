#pragma checksum "/home/marciomafidejurodrigues/Projects/DotNet/BlazorApp/Pages/Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c3f83e825ef5ce23a7d55dcfd900eb8c4b4021e"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/marciomafidejurodrigues/Projects/DotNet/BlazorApp/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/marciomafidejurodrigues/Projects/DotNet/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/marciomafidejurodrigues/Projects/DotNet/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/marciomafidejurodrigues/Projects/DotNet/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/marciomafidejurodrigues/Projects/DotNet/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/marciomafidejurodrigues/Projects/DotNet/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/marciomafidejurodrigues/Projects/DotNet/BlazorApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/marciomafidejurodrigues/Projects/DotNet/BlazorApp/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/marciomafidejurodrigues/Projects/DotNet/BlazorApp/_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/home/marciomafidejurodrigues/Projects/DotNet/BlazorApp/_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Contador</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Contagem Atual: ");
            __builder.AddContent(3, 
#nullable restore
#line 5 "/home/marciomafidejurodrigues/Projects/DotNet/BlazorApp/Pages/Counter.razor"
                    currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-primary");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "/home/marciomafidejurodrigues/Projects/DotNet/BlazorApp/Pages/Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Aumentar");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "class", "btn btn-primary");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "/home/marciomafidejurodrigues/Projects/DotNet/BlazorApp/Pages/Counter.razor"
                                          DecrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(13, "Diminuir");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "class", "btn btn-primary");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "/home/marciomafidejurodrigues/Projects/DotNet/BlazorApp/Pages/Counter.razor"
                                          ZeroCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(18, "Zerar");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "/home/marciomafidejurodrigues/Projects/DotNet/BlazorApp/Pages/Counter.razor"
       
    private int currentCount = 0;

    [Parameter]
    public int IncrementAmount { get; set; } = 5;

    private void IncrementCount()
    {
        currentCount += IncrementAmount;
    }
    private void DecrementCount()
    {
        currentCount -= IncrementAmount;
    }

    private void ZeroCount()
    {
        currentCount = 0;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
