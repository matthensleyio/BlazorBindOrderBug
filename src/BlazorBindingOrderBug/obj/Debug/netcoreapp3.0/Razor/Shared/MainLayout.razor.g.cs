#pragma checksum "C:\Users\matt\source\repos\BlazorBindOrderBug\src\BlazorBindingOrderBug\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4d4ef6a2acd02575f1bffd426c77bcb182965e3"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorBindingOrderBug.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\matt\source\repos\BlazorBindOrderBug\src\BlazorBindingOrderBug\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\matt\source\repos\BlazorBindOrderBug\src\BlazorBindingOrderBug\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\matt\source\repos\BlazorBindOrderBug\src\BlazorBindingOrderBug\_Imports.razor"
using Microsoft.AspNetCore.Components.Layouts;

#line default
#line hidden
#line 4 "C:\Users\matt\source\repos\BlazorBindOrderBug\src\BlazorBindingOrderBug\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "C:\Users\matt\source\repos\BlazorBindOrderBug\src\BlazorBindingOrderBug\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Users\matt\source\repos\BlazorBindOrderBug\src\BlazorBindingOrderBug\_Imports.razor"
using BlazorBindingOrderBug.Shared;

#line default
#line hidden
    public class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.OpenElement(0, "div");
            builder.AddAttribute(1, "class", "main");
            builder.AddMarkupContent(2, "\r\n    ");
            builder.OpenElement(3, "div");
            builder.AddAttribute(4, "class", "content px-4");
            builder.AddMarkupContent(5, "\r\n        ");
            builder.AddContent(6, 
#line 5 "C:\Users\matt\source\repos\BlazorBindOrderBug\src\BlazorBindingOrderBug\Shared\MainLayout.razor"
         Body

#line default
#line hidden
            );
            builder.AddMarkupContent(7, "\r\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(8, "\r\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
