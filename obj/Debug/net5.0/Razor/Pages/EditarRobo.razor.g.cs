#pragma checksum "C:\Users\admin\Desktop\ITLA\Programacion 3\2do parcial\robos\Pages\EditarRobo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "193ce58c031f4744266af2a9cfaa37a393a53a24"
// <auto-generated/>
#pragma warning disable 1591
namespace robos.Pages
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
#line 2 "C:\Users\admin\Desktop\ITLA\Programacion 3\2do parcial\robos\Pages\EditarRobo.razor"
using robos.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\admin\Desktop\ITLA\Programacion 3\2do parcial\robos\Pages\EditarRobo.razor"
using robos.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\admin\Desktop\ITLA\Programacion 3\2do parcial\robos\Pages\EditarRobo.razor"
using BlazorLeaflet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\admin\Desktop\ITLA\Programacion 3\2do parcial\robos\Pages\EditarRobo.razor"
using BlazorLeaflet.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\admin\Desktop\ITLA\Programacion 3\2do parcial\robos\Pages\EditarRobo.razor"
using BlazorLeaflet.Models.Events;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editar-robo/{RoboId:int}")]
    public partial class EditarRobo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Editar Robo</h3>\r\n<br>\r\n");
            __builder.OpenElement(1, "div");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 14 "C:\Users\admin\Desktop\ITLA\Programacion 3\2do parcial\robos\Pages\EditarRobo.razor"
                     robo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 14 "C:\Users\admin\Desktop\ITLA\Programacion 3\2do parcial\robos\Pages\EditarRobo.razor"
                                          ValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "form-group mb-3");
                __builder2.AddMarkupContent(8, "<label>Cedula del Querellante</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(9);
                __builder2.AddAttribute(10, "class", "form-control");
                __builder2.AddAttribute(11, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 17 "C:\Users\admin\Desktop\ITLA\Programacion 3\2do parcial\robos\Pages\EditarRobo.razor"
                                    robo.Cedula

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => robo.Cedula = __value, robo.Cedula))));
                __builder2.AddAttribute(13, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => robo.Cedula));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(14, "\r\n        ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "form-group mb-3");
                __builder2.AddMarkupContent(17, "<label>Nombre del Querellante</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(18);
                __builder2.AddAttribute(19, "class", "form-control");
                __builder2.AddAttribute(20, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Users\admin\Desktop\ITLA\Programacion 3\2do parcial\robos\Pages\EditarRobo.razor"
                                    robo.Nombre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(21, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => robo.Nombre = __value, robo.Nombre))));
                __builder2.AddAttribute(22, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => robo.Nombre));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n        ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "form-group mb-3");
                __builder2.AddMarkupContent(26, "<label>Apellido del Querellante</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(27);
                __builder2.AddAttribute(28, "class", "form-control");
                __builder2.AddAttribute(29, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Users\admin\Desktop\ITLA\Programacion 3\2do parcial\robos\Pages\EditarRobo.razor"
                                    robo.Apellido

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(30, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => robo.Apellido = __value, robo.Apellido))));
                __builder2.AddAttribute(31, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => robo.Apellido));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n        ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "form-group mb-3");
                __builder2.AddMarkupContent(35, "<label>Que se Robaron?</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(36);
                __builder2.AddAttribute(37, "class", "form-control");
                __builder2.AddAttribute(38, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 29 "C:\Users\admin\Desktop\ITLA\Programacion 3\2do parcial\robos\Pages\EditarRobo.razor"
                                        robo.Descripcion

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => robo.Descripcion = __value, robo.Descripcion))));
                __builder2.AddAttribute(40, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => robo.Descripcion));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n        ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "form-group mb-3");
                __builder2.AddMarkupContent(44, "<label>Valor de lo Robado (en $)</label>\r\n            ");
                __Blazor.robos.Pages.EditarRobo.TypeInference.CreateInputNumber_0(__builder2, 45, 46, "form-control", 47, "0", 48, 
#nullable restore
#line 33 "C:\Users\admin\Desktop\ITLA\Programacion 3\2do parcial\robos\Pages\EditarRobo.razor"
                                       robo.Valor

#line default
#line hidden
#nullable disable
                , 49, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => robo.Valor = __value, robo.Valor)), 50, () => robo.Valor);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n        ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "form-group mb-3");
                __builder2.AddMarkupContent(54, "<label>Fecha del Robo</label>\r\n            ");
                __Blazor.robos.Pages.EditarRobo.TypeInference.CreateInputDate_1(__builder2, 55, 56, "form-control", 57, 
#nullable restore
#line 37 "C:\Users\admin\Desktop\ITLA\Programacion 3\2do parcial\robos\Pages\EditarRobo.razor"
                                     robo.Fecha

#line default
#line hidden
#nullable disable
                , 58, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => robo.Fecha = __value, robo.Fecha)), 59, () => robo.Fecha);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(60, "\r\n        ");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "form-group mb-3");
                __builder2.AddMarkupContent(63, "<label>Dirección del Robo</label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(64);
                __builder2.AddAttribute(65, "class", "form-control");
                __builder2.AddAttribute(66, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 41 "C:\Users\admin\Desktop\ITLA\Programacion 3\2do parcial\robos\Pages\EditarRobo.razor"
                                    robo.Direccion

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(67, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => robo.Direccion = __value, robo.Direccion))));
                __builder2.AddAttribute(68, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => robo.Direccion));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n        ");
                __builder2.OpenElement(70, "div");
                __builder2.AddAttribute(71, "class", "form-group mb-3");
                __builder2.AddMarkupContent(72, "<label>Ubicacion del Robo</label>\r\n            ");
                __builder2.OpenElement(73, "div");
                __builder2.AddAttribute(74, "id", "mapContainer");
                __builder2.AddAttribute(75, "style", "width: 100%; height: 360px;");
                __builder2.OpenComponent<robos.Shared.LeafletMap>(76);
                __builder2.AddAttribute(77, "Map", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorLeaflet.Map>(
#nullable restore
#line 46 "C:\Users\admin\Desktop\ITLA\Programacion 3\2do parcial\robos\Pages\EditarRobo.razor"
                                 mapa

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n        ");
                __builder2.OpenElement(79, "div");
                __builder2.AddAttribute(80, "class", "mb-3 text-center");
                __builder2.OpenElement(81, "h4");
                __builder2.AddAttribute(82, "class", "text-danger mt-2 mb-3");
                __builder2.AddContent(83, 
#nullable restore
#line 50 "C:\Users\admin\Desktop\ITLA\Programacion 3\2do parcial\robos\Pages\EditarRobo.razor"
                                               error

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\r\n            ");
                __builder2.AddMarkupContent(85, "<button type=\"submit\" class=\"btn btn-success w-25\">Guardar</button>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 56 "C:\Users\admin\Desktop\ITLA\Programacion 3\2do parcial\robos\Pages\EditarRobo.razor"
       
    [Parameter]
    public int RoboId { get; set; }

    private Robo robo = null;
    private string error = "";

    private Map mapa = null;
    private Marker ubicacionRobo = null;

    private void ValidSubmit() {
        if (!Functions.ValidaCedula(robo.Cedula)) {
            error = "La cedula no es valida, verifique";
            return;
        }

        error = "";
        rc.SaveChanges();
        nm.NavigateTo("robos-lista");
    }

    protected override void OnInitialized() {
        robo = rc.Robos.First(x => x.Id == RoboId);

        mapa = new Map(jsr) {
            Center = new LatLng(18.9f, -70f),
            Zoom = 7.47f
        };

        ubicacionRobo = new Marker(robo.Latitud, robo.Longitud) {
            Draggable = true,
            Title = "Ubicacion del Robo"
        };

        mapa.OnInitialized += () => {
            mapa.AddLayer(new TileLayer {
                UrlTemplate = "https://tile.openstreetmap.org/{z}/{x}/{y}.png",
                Attribution = "&copy; <a href=\"https://www.openstreetmap.org/copyright\">OpenStreetMap</a> contributors"
            });
            mapa.AddLayer(ubicacionRobo);
        };

        ubicacionRobo.OnDrag += (Marker sender, DragEvent e) => {
            robo.Latitud = e.LatLng.Lat;
            robo.Longitud = e.LatLng.Lng;
        };
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nm { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsr { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RobosContext rc { get; set; }
    }
}
namespace __Blazor.robos.Pages.EditarRobo
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "min", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
