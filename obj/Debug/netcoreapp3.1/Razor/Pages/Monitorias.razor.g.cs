#pragma checksum "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5b894b5bb712b488990e97fb2ebb857a451e876b"
// <auto-generated/>
#pragma warning disable 1591
namespace Frontend.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\_Imports.razor"
using Frontend;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\_Imports.razor"
using Frontend.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/monitorias")]
    public partial class Monitorias : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 8 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
     if(loadingToken){

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "\t\t");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "mainLayout");
            __builder.AddMarkupContent(3, "\r\n\t\t");
            __builder.OpenComponent<Frontend.Shared.Nav>(4);
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n\t\t\t");
            __builder.AddMarkupContent(6, @"<div class=""mainLayout__container"">
				<header class=""mainLayout__container__header"">
					<div class=""mainLayout__container__header__gradient"">
						<h1 class=""color-white"">Sistema de monitorias</h1>
						<span class=""color-white"">Universidad Santiago de Cali</span>
					</div>
				</header>
				<main>
				</main>
			</div>
		");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
#nullable restore
#line 22 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
	}else{


#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "  ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "mainLayout");
            __builder.AddMarkupContent(11, "\r\n");
#nullable restore
#line 25 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
         if (modal == true){

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(12, "\t\t\t");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "modal");
            __builder.AddMarkupContent(15, "\r\n\t\t\t\t\t");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "modal__container");
            __builder.AddMarkupContent(18, "\r\n\t\t\t\t\t\t");
            __builder.OpenElement(19, "button");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
                                          closeModal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(21, "class", "modal__container__exit");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n");
#nullable restore
#line 29 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
                         if(currentModal == "removestudent") {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(23, "\t\t\t\t\t\t");
            __builder.AddMarkupContent(24, "<p>¿Quieres eliminar esta monitoria?</p>\r\n\t\t\t\t\t\t");
            __builder.OpenElement(25, "div");
            __builder.AddMarkupContent(26, "\r\n\t\t\t\t\t\t\t");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
                                              closeModal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "class", "modal__container__button");
            __builder.AddMarkupContent(30, "\r\n\t\t\t\t\t\t\t\tCancelar\r\n\t\t\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n\t\t\t\t\t\t\t");
            __builder.OpenElement(32, "button");
            __builder.AddAttribute(33, "class", "modal__container__button modal__container__button--red");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
                                          removestudent

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(35, "\r\n\t\t\t\t\t\t\t\tEliminar\r\n\t\t\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n\t\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n");
#nullable restore
#line 42 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
						}

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
                         if(currentModal == "delete") {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(38, "\t\t\t\t\t\t");
            __builder.AddMarkupContent(39, "<p>¿Quieres eliminar esta monitoria?</p>\r\n\t\t\t\t\t\t");
            __builder.OpenElement(40, "div");
            __builder.AddMarkupContent(41, "\r\n\t\t\t\t\t\t\t");
            __builder.OpenElement(42, "button");
            __builder.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
                                              closeModal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "class", "modal__container__button");
            __builder.AddMarkupContent(45, "\r\n\t\t\t\t\t\t\t\tCancelar\r\n\t\t\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n\t\t\t\t\t\t\t");
            __builder.OpenElement(47, "button");
            __builder.AddAttribute(48, "class", "modal__container__button modal__container__button--red");
            __builder.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
                                          eliminarMonitoria

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(50, "\r\n\t\t\t\t\t\t\t\tEliminar\r\n\t\t\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n\t\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n");
#nullable restore
#line 56 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
						}

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
                         if(currentModal == "addstudent") {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(53, "\t\t\t\t\t\t");
            __builder.AddMarkupContent(54, "<p>¿Quieres asistir a esta monitoria?</p>\r\n\t\t\t\t\t\t");
            __builder.OpenElement(55, "div");
            __builder.AddMarkupContent(56, "\r\n\t\t\t\t\t\t\t");
            __builder.OpenElement(57, "button");
            __builder.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 60 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
                                              closeModal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(59, "class", "modal__container__button");
            __builder.AddMarkupContent(60, "\r\n\t\t\t\t\t\t\t\tCancelar\r\n\t\t\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n\t\t\t\t\t\t\t");
            __builder.OpenElement(62, "button");
            __builder.AddAttribute(63, "class", "modal__container__button modal__container__button--blue");
            __builder.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 65 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
                                          addStudent

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(65, "\r\n\t\t\t\t\t\t\t\tInscribir\r\n\t\t\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n\t\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n");
#nullable restore
#line 70 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
						}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(68, "\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n\t\t\t\t");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 72 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
                               closeModal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "class", "modal__overlay");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n");
#nullable restore
#line 74 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
		}

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
             if (loading == false){
			

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
             if(usuario.roll==1){

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(75, "\t\t\t");
            __builder.OpenComponent<Frontend.Shared.NavMenu>(76);
            __builder.CloseComponent();
            __builder.AddMarkupContent(77, "\r\n");
#nullable restore
#line 78 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
			}

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
             if (usuario.roll==2)
			{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(78, "\t\t\t");
            __builder.OpenComponent<Frontend.Shared.NavMenuMonitor>(79);
            __builder.CloseComponent();
            __builder.AddMarkupContent(80, "\t\r\n");
#nullable restore
#line 82 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
			}

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
             if (usuario.roll==3)
			{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(81, "\t\t\t");
            __builder.OpenComponent<Frontend.Shared.NavMenuUser>(82);
            __builder.CloseComponent();
            __builder.AddMarkupContent(83, "\t\t\r\n");
#nullable restore
#line 86 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
			}

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
             
			}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(84, "\t\t\t");
            __builder.OpenElement(85, "div");
            __builder.AddAttribute(86, "class", "mainLayout__container");
            __builder.AddMarkupContent(87, "\r\n\t\t\t\t");
            __builder.AddMarkupContent(88, @"<header class=""mainLayout__container__header"">
					<div class=""mainLayout__container__header__gradient"">
						<h1 class=""color-white"">Sistema de monitorias</h1>
						<span class=""color-white"">Universidad Santiago de Cali</span>
					</div>
				</header>
				");
            __builder.OpenElement(89, "main");
            __builder.AddMarkupContent(90, "\r\n\t\t\t\t\t");
            __builder.OpenElement(91, "div");
            __builder.AddAttribute(92, "class", "monitorias");
            __builder.AddMarkupContent(93, "\r\n");
#nullable restore
#line 97 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
                         if(usuario.roll == 1){

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(94, "\t\t\t\t\t\t");
            __builder.AddMarkupContent(95, "<a class=\"form-monitoria__button monitorias\" href=\"/nueva-monitoria\">Crear una monitoria</a>\r\n");
#nullable restore
#line 99 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
						}

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
           if (loading == false){
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 101 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
             foreach (var item in monitorias)
            {
				if(usuario.roll == 1){

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(96, "\t\t\t\t\t");
            __builder.OpenElement(97, "div");
            __builder.AddAttribute(98, "class", "monitorias__item");
            __builder.AddMarkupContent(99, "\r\n\t\t\t\t\t\t\t\t");
            __builder.OpenElement(100, "div");
            __builder.AddAttribute(101, "class", "monitorias__item__header");
            __builder.AddMarkupContent(102, "\r\n\t\t\t\t\t\t\t\t\t");
            __builder.OpenElement(103, "h2");
            __builder.AddContent(104, 
#nullable restore
#line 106 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
                                         item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n\t\t\t\t\t\t\t\t\t");
            __builder.OpenElement(106, "div");
            __builder.AddMarkupContent(107, "\r\n\t\t\t\t\t\t\t\t\t\t");
            __builder.OpenElement(108, "a");
            __builder.AddAttribute(109, "href", "/monitorias/" + (
#nullable restore
#line 108 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
                                                              item.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(110, "class", "monitorias__item__button edit");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n\t\t\t\t\t\t\t\t\t\t");
            __builder.OpenElement(112, "button");
            __builder.AddAttribute(113, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 109 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
                                                            () => openModal(item.Id, "delete")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(114, "class", "monitorias__item__button trash");
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n\t\t\t\t\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n\t\t\t\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n\t\t\t\t\t\t\t\t<hr>\r\n\t\t\t\t\t\t\t\t<br>\r\n\t\t\t\t\t\t\t\t");
            __builder.OpenElement(118, "p");
            __builder.AddMarkupContent(119, "\r\n              \t\t");
            __builder.AddContent(120, 
#nullable restore
#line 115 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
                       item.faculty

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(121, "\r\n\t\t\t\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(122, "\r\n\t\t\t\t\t\t\t\t<br>\r\n\t\t\t\t\t\t\t\t");
            __builder.OpenElement(123, "p");
            __builder.AddMarkupContent(124, "<strong>Día: </strong>");
            __builder.AddContent(125, 
#nullable restore
#line 118 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
                                                          item.day

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n\t\t\t\t\t\t\t\t<br>\r\n\t\t\t\t\t\t\t\t");
            __builder.OpenElement(127, "p");
            __builder.AddMarkupContent(128, "<strong>Hora de inicio: </strong>");
            __builder.AddContent(129, 
#nullable restore
#line 120 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
                                                                     DateTime.Parse(item.init).ToShortTimeString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "\r\n\t\t\t\t\t\t\t\t<br>\r\n\t\t\t\t\t\t\t\t");
            __builder.OpenElement(131, "p");
            __builder.AddMarkupContent(132, "<strong>Hora de Fin: </strong>");
            __builder.AddContent(133, 
#nullable restore
#line 122 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
                                                                  DateTime.Parse(item.end).ToShortTimeString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\r\n\t\t\t\t\t\t\t\t<br>\r\n\t\t\t\t\t\t\t\t");
            __builder.OpenElement(135, "p");
            __builder.AddMarkupContent(136, "<strong>Sala: </strong>");
            __builder.AddContent(137, 
#nullable restore
#line 124 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
                                                           item.livingRoom

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(138, "\r\n\t\t\t\t\t\t\t\t<br>\r\n\t\t\t\t\t\t\t\t");
            __builder.OpenElement(139, "p");
            __builder.AddMarkupContent(140, "<strong>Cupos: </strong>");
            __builder.AddContent(141, 
#nullable restore
#line 126 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
                                                            item.initialQuotas

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(142, "\r\n\t\t\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(143, "\r\n");
#nullable restore
#line 128 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
				}else{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(144, "\t\t\t\t\t");
            __builder.OpenElement(145, "div");
            __builder.AddAttribute(146, "class", "add-monitoria__item");
            __builder.AddMarkupContent(147, "\r\n\t\t\t\t\t");
            __builder.OpenElement(148, "div");
            __builder.AddMarkupContent(149, "\r\n\t\t\t\t\t");
            __builder.OpenElement(150, "h3");
            __builder.AddAttribute(151, "class", "add-monitoria__item__title");
            __builder.AddMarkupContent(152, "\r\n\t\t\t\t\t");
            __builder.AddContent(153, 
#nullable restore
#line 132 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
                     item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(154, "\r\n\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(155, "\r\n\t\t\t\t\t<br>\r\n\t\t\t\t\t");
            __builder.OpenElement(156, "p");
            __builder.AddMarkupContent(157, "\r\n\t\t\t\t\t\t");
            __builder.AddContent(158, 
#nullable restore
#line 136 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
                         item.faculty

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(159, "\r\n\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(160, "\r\n\t\t\t\t\t");
            __builder.OpenElement(161, "p");
            __builder.AddMarkupContent(162, "<strong>Día: </strong>");
            __builder.AddContent(163, 
#nullable restore
#line 138 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
                                              item.day

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(164, "\r\n\t\t\t\t\t");
            __builder.OpenElement(165, "p");
            __builder.AddMarkupContent(166, "<strong>Hora de inicio: </strong>");
            __builder.AddContent(167, 
#nullable restore
#line 139 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
                                                         DateTime.Parse(item.init).ToShortTimeString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(168, "\r\n\t\t\t\t\t");
            __builder.OpenElement(169, "p");
            __builder.AddMarkupContent(170, "<strong>Hora de Fin: </strong>");
            __builder.AddContent(171, 
#nullable restore
#line 140 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
                                                      DateTime.Parse(item.end).ToShortTimeString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(172, "\r\n\t\t\t\t\t");
            __builder.OpenElement(173, "p");
            __builder.AddMarkupContent(174, "<strong>Sala: </strong>");
            __builder.AddContent(175, 
#nullable restore
#line 141 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
                                               item.livingRoom

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(176, "\r\n\t\t\t\t\t");
            __builder.OpenElement(177, "p");
            __builder.AddMarkupContent(178, "<strong>Cupos: </strong>");
            __builder.AddContent(179, 
#nullable restore
#line 142 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
                                                item.initialQuotas

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(180, "\r\n\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(181, "\r\n\t\t\t\t\t");
            __builder.OpenElement(182, "div");
            __builder.AddAttribute(183, "class", "flex-center");
            __builder.AddMarkupContent(184, "\r\n");
#nullable restore
#line 145 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
                          bool isStudent = false;
					
						foreach (var idUser in item.students)
						{
							if (idUser == usuario.Id)
							{
									isStudent = true;
							}
						}
						if (!isStudent)
						{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(185, "\t\t\t\t\t\t\t");
            __builder.OpenElement(186, "button");
            __builder.AddAttribute(187, "class", "form-monitoria__button modalMonitor");
            __builder.AddAttribute(188, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 156 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
                                                                                            () => openModal(item.Id, "addstudent")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(189, "Apuntarse");
            __builder.CloseElement();
            __builder.AddMarkupContent(190, "\r\n");
#nullable restore
#line 157 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
						}else{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(191, "\t\t\t\t\t\t\t");
            __builder.OpenElement(192, "button");
            __builder.AddAttribute(193, "class", "form-monitoria__button modalMonitor red");
            __builder.AddAttribute(194, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 158 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
                                                                                                () => openModal(item.Id, "removestudent")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(195, "Salir de esta monitoria");
            __builder.CloseElement();
            __builder.AddMarkupContent(196, "\r\n");
#nullable restore
#line 159 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
						}
						

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(197, "\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(198, "\r\n\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(199, "\r\n");
#nullable restore
#line 163 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
				}
							
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 165 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
             
          }else{

#line default
#line hidden
#nullable disable
            __builder.AddContent(200, "            ");
            __builder.AddMarkupContent(201, "<div>loading...</div>\r\n");
#nullable restore
#line 168 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
          }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(202, "\t\t\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(203, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(204, "\r\n\t\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(205, "\r\n\t\t");
            __builder.CloseElement();
            __builder.AddMarkupContent(206, "\r\n");
#nullable restore
#line 173 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
	}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 175 "C:\Users\Juan Jose Castro\Desktop\frontend-monitorias\Pages\Monitorias.razor"
       
  public bool loading = true;
  bool loadingToken = true;
  public bool modal = false;
  public string currentModal = "";
  public string currentId = "";
  public string[] token;
  Usuario usuario { get; set; }
	
  Monitoria[] monitorias { get; set; }

  private static readonly System.Text.Json.JsonSerializerOptions s_options = 
    new System.Text.Json.JsonSerializerOptions() 
  {
    PropertyNamingPolicy = System.Text.Json.JsonNamingPolicy.CamelCase,
    PropertyNameCaseInsensitive = true,
  };

	protected async override Task OnAfterRenderAsync(bool firstRender)    
	{
		if (firstRender)
    {
  			var aux = await localStorage.GetItemAsync<string>("token");
				if(aux == null){
					loadingToken = false;
					NavigationManager.NavigateTo("/");
				}else{
					loadingToken = false;
					var httpResponseUser = await Http.GetFromJsonAsync<Usuario>("http://localhost:8080/api/usuarios/" + aux, s_options );
					usuario = httpResponseUser; 
        	var httpResponse = await Http.GetFromJsonAsync<Monitoria[]>("http://localhost:8080/api/monitorias", s_options);
        	monitorias = httpResponse;
        	loading = false;
				}
    }
		StateHasChanged();
	}

	private void openModal(string id, string typeModal)
    {
				currentModal = typeModal;
				currentId = id;
        modal = true;
    }
 	private void closeModal()
    {
				currentId = "";
        modal = false;
    }

	private async Task addStudent() {
		var httpResponse = await Http.PostAsJsonAsync("http://localhost:8080/api/monitorias/"+currentId+"/"+usuario.Id, s_options);
		monitorias = await httpResponse.Content.ReadFromJsonAsync<Monitoria[]>();
		closeModal();
	}

	private async Task removestudent(){
		var httpResponse = await Http.GetFromJsonAsync<Monitoria[]>("http://localhost:8080/api/monitorias/removestudent/"+currentId+"/"+usuario.Id, s_options);
		monitorias = httpResponse;
		closeModal();
	}
	private async Task eliminarMonitoria(){
		var httpResponse = await Http.DeleteAsync("http://localhost:8080/api/monitorias/"+currentId);
		monitorias = await httpResponse.Content.ReadFromJsonAsync<Monitoria[]>();
		closeModal();
	}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService localStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
