#pragma checksum "C:\Users\diego\Documents\Ulises\trabajos\BreakingBad\Components\AlertMessage.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "755d9cb30d80b35bc5b2615c9d40bf354787ce9a"
// <auto-generated/>
#pragma warning disable 1591
namespace BreakingBad.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\diego\Documents\Ulises\trabajos\BreakingBad\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\diego\Documents\Ulises\trabajos\BreakingBad\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\diego\Documents\Ulises\trabajos\BreakingBad\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\diego\Documents\Ulises\trabajos\BreakingBad\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\diego\Documents\Ulises\trabajos\BreakingBad\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\diego\Documents\Ulises\trabajos\BreakingBad\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\diego\Documents\Ulises\trabajos\BreakingBad\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\diego\Documents\Ulises\trabajos\BreakingBad\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\diego\Documents\Ulises\trabajos\BreakingBad\_Imports.razor"
using BreakingBad;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\diego\Documents\Ulises\trabajos\BreakingBad\_Imports.razor"
using BreakingBad.Shared;

#line default
#line hidden
#nullable disable
    public partial class AlertMessage : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "alert" + " alert-" + (
#nullable restore
#line 1 "C:\Users\diego\Documents\Ulises\trabajos\BreakingBad\Components\AlertMessage.razor"
                         Color

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "role", "alert");
            __builder.AddContent(3, 
#nullable restore
#line 2 "C:\Users\diego\Documents\Ulises\trabajos\BreakingBad\Components\AlertMessage.razor"
     Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 4 "C:\Users\diego\Documents\Ulises\trabajos\BreakingBad\Components\AlertMessage.razor"
      
    [Parameter] public string Title { get; set; }
    [Parameter] public string Color { get; set; } = "primary";

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
