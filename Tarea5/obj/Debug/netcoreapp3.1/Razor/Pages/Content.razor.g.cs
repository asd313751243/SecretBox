#pragma checksum "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea5\Tarea5\Pages\Content.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3533335a0b6fb955bd1acf7bf6658e91aec7ee11"
// <auto-generated/>
#pragma warning disable 1591
namespace Tarea5.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea5\Tarea5\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea5\Tarea5\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea5\Tarea5\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea5\Tarea5\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea5\Tarea5\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea5\Tarea5\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea5\Tarea5\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea5\Tarea5\_Imports.razor"
using Tarea5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea5\Tarea5\_Imports.razor"
using Tarea5.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea5\Tarea5\Pages\Content.razor"
using Tarea5.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/content/{id:int}")]
    public partial class Content : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 8 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea5\Tarea5\Pages\Content.razor"
 if (state == "on")
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "float-right");
            __builder.AddMarkupContent(3, "\r\n        ");
            __builder.OpenElement(4, "img");
            __builder.AddAttribute(5, "src", 
#nullable restore
#line 11 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea5\Tarea5\Pages\Content.razor"
                   image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(6, "class", "rounded");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.OpenElement(8, "h6");
            __builder.AddContent(9, 
#nullable restore
#line 12 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea5\Tarea5\Pages\Content.razor"
             _data.Nombres

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "container");
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "row-5");
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "col-10 bg-light m-2 justify-content-start");
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.AddMarkupContent(21, "<div class=\"p-3 mb-3 bg-info text-white text-center\">New Secret</div>\r\n                ");
            __builder.OpenElement(22, "form");
            __builder.AddAttribute(23, "onsubmit", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#nullable restore
#line 18 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea5\Tarea5\Pages\Content.razor"
                                 AddSecret

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", " form-group");
            __builder.AddMarkupContent(27, "\r\n                        ");
            __builder.AddMarkupContent(28, "<b>Titulo</b>\r\n                        ");
            __builder.OpenElement(29, "input");
            __builder.AddAttribute(30, "type", "text");
            __builder.AddAttribute(31, "class", "form-control");
            __builder.AddAttribute(32, "required", true);
            __builder.AddAttribute(33, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea5\Tarea5\Pages\Content.razor"
                                                                                _secret.Titulo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _secret.Titulo = __value, _secret.Titulo));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                    ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", " form-group");
            __builder.AddMarkupContent(39, "\r\n                        ");
            __builder.AddMarkupContent(40, "<b>Descripcion</b>\r\n                        ");
            __builder.OpenElement(41, "input");
            __builder.AddAttribute(42, "type", "text");
            __builder.AddAttribute(43, "class", "form-control");
            __builder.AddAttribute(44, "required", true);
            __builder.AddAttribute(45, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea5\Tarea5\Pages\Content.razor"
                                                                                _secret.Descripcion

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _secret.Descripcion = __value, _secret.Descripcion));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                    ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "class", " form-group");
            __builder.AddMarkupContent(51, "\r\n                        ");
            __builder.AddMarkupContent(52, "<b>Valor Monetario</b>\r\n                        ");
            __builder.OpenElement(53, "input");
            __builder.AddAttribute(54, "type", "number");
            __builder.AddAttribute(55, "step", "0.01");
            __builder.AddAttribute(56, "class", "form-control");
            __builder.AddAttribute(57, "required", true);
            __builder.AddAttribute(58, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea5\Tarea5\Pages\Content.razor"
                                                                                              _secret.Valor_monetario

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(59, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _secret.Valor_monetario = __value, _secret.Valor_monetario, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                    ");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", " form-group");
            __builder.AddMarkupContent(64, "\r\n                        ");
            __builder.AddMarkupContent(65, "<b>Fecha</b>\r\n                        ");
            __builder.OpenElement(66, "input");
            __builder.AddAttribute(67, "type", "date");
            __builder.AddAttribute(68, "class", "form-control");
            __builder.AddAttribute(69, "required", true);
            __builder.AddAttribute(70, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 33 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea5\Tarea5\Pages\Content.razor"
                                                                                _secret.Fecha

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(71, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _secret.Fecha = __value, _secret.Fecha, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                    ");
            __builder.OpenElement(74, "div");
            __builder.AddAttribute(75, "class", " form-group");
            __builder.AddMarkupContent(76, "\r\n                        ");
            __builder.AddMarkupContent(77, "<b>Lugar</b>\r\n                        ");
            __builder.OpenElement(78, "input");
            __builder.AddAttribute(79, "type", "text");
            __builder.AddAttribute(80, "class", "form-control");
            __builder.AddAttribute(81, "required", true);
            __builder.AddAttribute(82, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 37 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea5\Tarea5\Pages\Content.razor"
                                                                                _secret.Lugar

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(83, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _secret.Lugar = __value, _secret.Lugar));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n                    ");
            __builder.OpenElement(86, "div");
            __builder.AddAttribute(87, "class", " form-group");
            __builder.AddMarkupContent(88, "\r\n                        ");
            __builder.AddMarkupContent(89, "<b>Latitud</b>\r\n                        ");
            __builder.OpenElement(90, "input");
            __builder.AddAttribute(91, "type", "number");
            __builder.AddAttribute(92, "step", "0.00000000001");
            __builder.AddAttribute(93, "class", "form-control");
            __builder.AddAttribute(94, "required", true);
            __builder.AddAttribute(95, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 41 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea5\Tarea5\Pages\Content.razor"
                                                                                                       _secret.Lat

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(96, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _secret.Lat = __value, _secret.Lat, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n                    ");
            __builder.OpenElement(99, "div");
            __builder.AddAttribute(100, "class", " form-group");
            __builder.AddMarkupContent(101, "\r\n                        ");
            __builder.AddMarkupContent(102, "<b>Longitud</b>\r\n                        ");
            __builder.OpenElement(103, "input");
            __builder.AddAttribute(104, "type", "number");
            __builder.AddAttribute(105, "step", "0.00000000001");
            __builder.AddAttribute(106, "class", "form-control");
            __builder.AddAttribute(107, "required", true);
            __builder.AddAttribute(108, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 45 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea5\Tarea5\Pages\Content.razor"
                                                                                                       _secret.Lng

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(109, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _secret.Lng = __value, _secret.Lng, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n                    ");
            __builder.AddMarkupContent(112, "<div class=\"text-center p-3 mb-3\">\r\n                        <input type=\"submit\" class=\"btn btn-primary\" value=\"New Secret\">\r\n                        <br>\r\n                    </div>\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n");
            __builder.AddContent(117, "    ");
            __builder.AddMarkupContent(118, @"<style>
        .card {
            float: left;
            margin: 5px;
            width: 50px;
            height: 500px;
            background-color: #0cbaba;
            background-image: linear-gradient(315deg, #0cbaba 0%, #380036 74%);
        }
    </style>
");
#nullable restore
#line 67 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea5\Tarea5\Pages\Content.razor"
     foreach (var s in user_secrets)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(119, "        ");
            __builder.OpenElement(120, "div");
            __builder.AddAttribute(121, "class", "card");
            __builder.AddAttribute(122, "style", "width: 18rem;");
            __builder.AddMarkupContent(123, "\r\n            ");
            __builder.OpenElement(124, "div");
            __builder.AddAttribute(125, "class", "card-body text-white");
            __builder.AddMarkupContent(126, "\r\n                ");
            __builder.OpenElement(127, "h5");
            __builder.AddAttribute(128, "class", "card-title");
            __builder.AddContent(129, 
#nullable restore
#line 71 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea5\Tarea5\Pages\Content.razor"
                                        s.Titulo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "\r\n                ");
            __builder.AddMarkupContent(131, "<h6 class=\"card-subtitle mb-2 text-muted\">Descripcion</h6>\r\n                ");
            __builder.OpenElement(132, "p");
            __builder.AddAttribute(133, "class", "card-text");
            __builder.AddContent(134, 
#nullable restore
#line 73 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea5\Tarea5\Pages\Content.razor"
                                      s.Descripcion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n                ");
            __builder.AddMarkupContent(136, "<h6 class=\"card-subtitle mb-2 text-muted\">Valor Monetario</h6>\r\n                ");
            __builder.OpenElement(137, "p");
            __builder.AddAttribute(138, "class", "card-text");
            __builder.AddContent(139, 
#nullable restore
#line 75 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea5\Tarea5\Pages\Content.razor"
                                      s.Valor_monetario

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(140, "\r\n                ");
            __builder.AddMarkupContent(141, "<h6 class=\"card-subtitle mb-2 text-muted\">Fecha</h6>\r\n                ");
            __builder.OpenElement(142, "p");
            __builder.AddAttribute(143, "class", "card-text");
            __builder.AddContent(144, 
#nullable restore
#line 77 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea5\Tarea5\Pages\Content.razor"
                                      s.Fecha

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(145, "\r\n                ");
            __builder.AddMarkupContent(146, "<h6 class=\"card-subtitle mb-2 text-muted\">Lugar</h6>\r\n                ");
            __builder.OpenElement(147, "p");
            __builder.AddAttribute(148, "class", "card-text");
            __builder.AddContent(149, 
#nullable restore
#line 79 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea5\Tarea5\Pages\Content.razor"
                                      s.Lugar

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(150, "\r\n                ");
            __builder.AddMarkupContent(151, "<h6 class=\"card-subtitle mb-2 text-muted\">Latitud</h6>\r\n                ");
            __builder.OpenElement(152, "p");
            __builder.AddAttribute(153, "class", "card-text");
            __builder.AddContent(154, 
#nullable restore
#line 81 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea5\Tarea5\Pages\Content.razor"
                                      s.Lat

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(155, "\r\n                ");
            __builder.AddMarkupContent(156, "<h6 class=\"card-subtitle mb-2 text-muted\">Longitud</h6>\r\n                ");
            __builder.OpenElement(157, "p");
            __builder.AddAttribute(158, "class", "card-text");
            __builder.AddContent(159, 
#nullable restore
#line 83 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea5\Tarea5\Pages\Content.razor"
                                      s.Lng

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(160, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(161, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(162, "\r\n");
#nullable restore
#line 86 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea5\Tarea5\Pages\Content.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea5\Tarea5\Pages\Content.razor"
     
}
else if (state == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(163, "    ");
            __builder.AddMarkupContent(164, "<center><h1>Loading...</h1></center>\r\n");
#nullable restore
#line 91 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea5\Tarea5\Pages\Content.razor"
}
else if (state == "off")
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(165, "    ");
            __builder.OpenElement(166, "center");
            __builder.AddMarkupContent(167, "\r\n        ");
            __builder.AddMarkupContent(168, "<h3>Debes hacer el login antes de entrar a esta pagina</h3>\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(169);
            __builder.AddAttribute(170, "class", "nav-link");
            __builder.AddAttribute(171, "href", "/");
            __builder.AddAttribute(172, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(173, "\r\n            ");
                __builder2.AddMarkupContent(174, "<a>Back to Log In</a>\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(175, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(176, "\r\n");
#nullable restore
#line 100 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea5\Tarea5\Pages\Content.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 103 "E:\ITLA\ITLA\6to cuatri\Programacion III\Tarea5\Tarea5\Pages\Content.razor"
       
    [Parameter]
    public int id { get; set; }

    private List<User> _users = new List<User>();
    private List<Secret> _secrets = new List<Secret>();
    private List<Secret> user_secrets = new List<Secret>();
    private User _user = new User();
    private Secret _secret = new Secret();
    private ApiData _data = new ApiData();
    private string image, state;

    protected override async Task OnInitializedAsync()
    {
        _users = await userServices.GetUsersAsync();
        _user = _users.FirstOrDefault(p => p.UserId == id);
        if(_user != null)
        {
            _data = await Http.GetJsonAsync<ApiData>("https://api.adamix.net/apec/cedula/" + _user.Cedula);
            image = _data.foto;
            await RefreshSecrets();
            state = _user.State;
            _user.State = "off";
            await userServices.UpdateUserAsync(_user);
        }
        else
        {
            state = "off";
        }
    }

    private async Task RefreshSecrets()
    {
        _secrets = await secretServices.GetSecretsAsync();
        user_secrets = _secrets.Where(p => p.UserId == id).ToList();
        _secret = new Secret();
    }

    private async Task AddSecret()
    {
        _user._Secrets.Add(_secret);
        await userServices.UpdateUserAsync(_user);
        await RefreshSecrets();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SecretServices secretServices { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserServices userServices { get; set; }
    }
}
#pragma warning restore 1591
