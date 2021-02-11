#pragma checksum "C:\Users\diego\Documents\Ulises\trabajos\BreakingBad\Components\CharacterCard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1399cb1e3d9ae47d1dc762e469de42b45acc04af"
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
#nullable restore
#line 1 "C:\Users\diego\Documents\Ulises\trabajos\BreakingBad\Components\CharacterCard.razor"
using BreakingBad.Data;

#line default
#line hidden
#nullable disable
    public partial class CharacterCard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card my-4");
            __builder.AddAttribute(2, "style", "width: 100%;");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col col-4 pl-5 py-2");
            __builder.OpenElement(7, "img");
            __builder.AddAttribute(8, "src", 
#nullable restore
#line 5 "C:\Users\diego\Documents\Ulises\trabajos\BreakingBad\Components\CharacterCard.razor"
                       Character.img

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(9, "alt", "character picture");
            __builder.AddAttribute(10, "style", "width: 100%;");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "col col-7");
            __builder.OpenElement(14, "h3");
            __builder.AddAttribute(15, "class", "card-title");
            __builder.AddContent(16, 
#nullable restore
#line 8 "C:\Users\diego\Documents\Ulises\trabajos\BreakingBad\Components\CharacterCard.razor"
                                    Character.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "ul");
            __builder.AddAttribute(19, "class", "list-group list-group-flush");
            __builder.OpenElement(20, "li");
            __builder.AddAttribute(21, "class", "list-group-item");
            __builder.AddContent(22, "Birthday: ");
            __builder.OpenElement(23, "strong");
            __builder.AddContent(24, 
#nullable restore
#line 10 "C:\Users\diego\Documents\Ulises\trabajos\BreakingBad\Components\CharacterCard.razor"
                                                               Character.birthday

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.OpenElement(26, "li");
            __builder.AddAttribute(27, "class", "list-group-item");
            __builder.AddContent(28, "Nickname: ");
            __builder.OpenElement(29, "strong");
            __builder.AddContent(30, 
#nullable restore
#line 11 "C:\Users\diego\Documents\Ulises\trabajos\BreakingBad\Components\CharacterCard.razor"
                                                               Character.nickname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.OpenElement(32, "li");
            __builder.AddAttribute(33, "class", "list-group-item");
            __builder.AddContent(34, "Actor/Actress: ");
            __builder.OpenElement(35, "strong");
            __builder.AddContent(36, 
#nullable restore
#line 12 "C:\Users\diego\Documents\Ulises\trabajos\BreakingBad\Components\CharacterCard.razor"
                                                                    Character.portrayed

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.OpenElement(38, "li");
            __builder.AddAttribute(39, "class", "list-group-item");
            __builder.AddContent(40, "Status: ");
            __builder.OpenElement(41, "strong");
            __builder.AddContent(42, 
#nullable restore
#line 13 "C:\Users\diego\Documents\Ulises\trabajos\BreakingBad\Components\CharacterCard.razor"
                                                             Character.status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.OpenElement(44, "li");
            __builder.AddAttribute(45, "class", "list-group-item");
            __builder.AddMarkupContent(46, "<h4 class=\"card-subtitle mb-2\">Occupation</h4>");
#nullable restore
#line 16 "C:\Users\diego\Documents\Ulises\trabajos\BreakingBad\Components\CharacterCard.razor"
                     foreach (var o in @Character.occupation)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(47, "span");
            __builder.AddAttribute(48, "class", "badge badge-pill badge-primary");
            __builder.AddContent(49, 
#nullable restore
#line 18 "C:\Users\diego\Documents\Ulises\trabajos\BreakingBad\Components\CharacterCard.razor"
                                                                      o

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 19 "C:\Users\diego\Documents\Ulises\trabajos\BreakingBad\Components\CharacterCard.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\Users\diego\Documents\Ulises\trabajos\BreakingBad\Components\CharacterCard.razor"
      
    [Parameter] public BBCharacter Character { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
