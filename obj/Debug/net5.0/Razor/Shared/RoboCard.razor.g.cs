#pragma checksum "C:\Users\admin\Desktop\ITLA\Programacion 3\2do parcial\robos\Shared\RoboCard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "720581d0e4eba674e859bcb15ffe5b7f6b172323"
// <auto-generated/>
#pragma warning disable 1591
namespace robos.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\admin\Desktop\ITLA\Programacion 3\2do parcial\robos\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\Desktop\ITLA\Programacion 3\2do parcial\robos\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\admin\Desktop\ITLA\Programacion 3\2do parcial\robos\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\admin\Desktop\ITLA\Programacion 3\2do parcial\robos\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\admin\Desktop\ITLA\Programacion 3\2do parcial\robos\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\admin\Desktop\ITLA\Programacion 3\2do parcial\robos\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\admin\Desktop\ITLA\Programacion 3\2do parcial\robos\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\admin\Desktop\ITLA\Programacion 3\2do parcial\robos\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\admin\Desktop\ITLA\Programacion 3\2do parcial\robos\_Imports.razor"
using robos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\admin\Desktop\ITLA\Programacion 3\2do parcial\robos\_Imports.razor"
using robos.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\admin\Desktop\ITLA\Programacion 3\2do parcial\robos\Shared\RoboCard.razor"
using robos.Data.Models;

#line default
#line hidden
#nullable disable
    public partial class RoboCard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "alert" + " alert-" + (
#nullable restore
#line 3 "C:\Users\admin\Desktop\ITLA\Programacion 3\2do parcial\robos\Shared\RoboCard.razor"
                          Robo.Id % 2 == 0 ? "info" : "success"

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-sm-2");
            __builder.AddMarkupContent(6, "<b>Cedula</b>\r\n            ");
            __builder.OpenElement(7, "p");
            __builder.AddContent(8, 
#nullable restore
#line 7 "C:\Users\admin\Desktop\ITLA\Programacion 3\2do parcial\robos\Shared\RoboCard.razor"
                Robo.Cedula

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-sm-3");
            __builder.AddMarkupContent(12, "<b>Nombre Apellido</b>\r\n            ");
            __builder.OpenElement(13, "p");
            __builder.AddContent(14, 
#nullable restore
#line 11 "C:\Users\admin\Desktop\ITLA\Programacion 3\2do parcial\robos\Shared\RoboCard.razor"
                Robo.Nombre

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(15, " ");
            __builder.AddContent(16, 
#nullable restore
#line 11 "C:\Users\admin\Desktop\ITLA\Programacion 3\2do parcial\robos\Shared\RoboCard.razor"
                             Robo.Apellido

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "col-sm-2");
            __builder.AddMarkupContent(20, "<b>Fecha del robo</b>\r\n            ");
            __builder.OpenElement(21, "p");
            __builder.AddContent(22, 
#nullable restore
#line 15 "C:\Users\admin\Desktop\ITLA\Programacion 3\2do parcial\robos\Shared\RoboCard.razor"
                Robo.Fecha.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "col-sm-5");
            __builder.AddMarkupContent(26, "<b>Dirección del Robo</b>\r\n            ");
            __builder.OpenElement(27, "p");
            __builder.AddContent(28, 
#nullable restore
#line 19 "C:\Users\admin\Desktop\ITLA\Programacion 3\2do parcial\robos\Shared\RoboCard.razor"
                Robo.Direccion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n    ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "row");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "col-sm-2");
            __builder.AddMarkupContent(34, "<b>Valor de lo robado</b>\r\n            ");
            __builder.OpenElement(35, "p");
            __builder.AddContent(36, 
#nullable restore
#line 25 "C:\Users\admin\Desktop\ITLA\Programacion 3\2do parcial\robos\Shared\RoboCard.razor"
                Robo.Valor.ToString("C0")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "col-sm-6");
            __builder.AddMarkupContent(40, "<b>Descripcion (Que se robaron?)</b>\r\n            ");
            __builder.OpenElement(41, "p");
            __builder.AddContent(42, 
#nullable restore
#line 29 "C:\Users\admin\Desktop\ITLA\Programacion 3\2do parcial\robos\Shared\RoboCard.razor"
                Robo.Descripcion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n        ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "col-sm-4 text-center");
            __builder.OpenElement(46, "a");
            __builder.AddAttribute(47, "href", "editar-robo/" + (
#nullable restore
#line 32 "C:\Users\admin\Desktop\ITLA\Programacion 3\2do parcial\robos\Shared\RoboCard.razor"
                                  Robo.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "class", "btn btn-warning");
            __builder.AddContent(49, "Editar");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n            ");
            __builder.OpenElement(51, "a");
            __builder.AddAttribute(52, "href", "exportar-robo/" + (
#nullable restore
#line 33 "C:\Users\admin\Desktop\ITLA\Programacion 3\2do parcial\robos\Shared\RoboCard.razor"
                                    Robo.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(53, "class", "btn btn-info");
            __builder.AddContent(54, "Exportar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\admin\Desktop\ITLA\Programacion 3\2do parcial\robos\Shared\RoboCard.razor"
       
    [Parameter]
    public Robo Robo { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
