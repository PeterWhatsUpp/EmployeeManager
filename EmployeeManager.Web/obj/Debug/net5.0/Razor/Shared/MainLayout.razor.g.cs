#pragma checksum "E:\C#_20210418\!!!!_zbiorczy_C#\BLAZOR\EmployeeManager\EmployeeManager.Web\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "172a1321a1445336d3392205347ddd51c718fdb8"
// <auto-generated/>
#pragma warning disable 1591
namespace EmployeeManager.Web.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\C#_20210418\!!!!_zbiorczy_C#\BLAZOR\EmployeeManager\EmployeeManager.Web\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\C#_20210418\!!!!_zbiorczy_C#\BLAZOR\EmployeeManager\EmployeeManager.Web\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\C#_20210418\!!!!_zbiorczy_C#\BLAZOR\EmployeeManager\EmployeeManager.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\C#_20210418\!!!!_zbiorczy_C#\BLAZOR\EmployeeManager\EmployeeManager.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\C#_20210418\!!!!_zbiorczy_C#\BLAZOR\EmployeeManager\EmployeeManager.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\C#_20210418\!!!!_zbiorczy_C#\BLAZOR\EmployeeManager\EmployeeManager.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\C#_20210418\!!!!_zbiorczy_C#\BLAZOR\EmployeeManager\EmployeeManager.Web\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\C#_20210418\!!!!_zbiorczy_C#\BLAZOR\EmployeeManager\EmployeeManager.Web\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\C#_20210418\!!!!_zbiorczy_C#\BLAZOR\EmployeeManager\EmployeeManager.Web\_Imports.razor"
using EmployeeManager.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\C#_20210418\!!!!_zbiorczy_C#\BLAZOR\EmployeeManager\EmployeeManager.Web\_Imports.razor"
using EmployeeManager.Web.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-q8fpuzj5p5");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-q8fpuzj5p5");
            __builder.OpenComponent<EmployeeManager.Web.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-q8fpuzj5p5");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "content px-4");
            __builder.AddAttribute(13, "b-q8fpuzj5p5");
            __builder.AddContent(14, 
#nullable restore
#line 11 "E:\C#_20210418\!!!!_zbiorczy_C#\BLAZOR\EmployeeManager\EmployeeManager.Web\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
