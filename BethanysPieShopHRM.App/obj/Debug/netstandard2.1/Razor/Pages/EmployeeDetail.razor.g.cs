#pragma checksum "C:\Users\kkz\source\repos\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5982ddae37882b6c259251c47ae67e08d1374e5"
// <auto-generated/>
#pragma warning disable 1591
namespace BethanysPieShopHRM.App.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\kkz\source\repos\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\kkz\source\repos\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#line 3 "C:\Users\kkz\source\repos\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 4 "C:\Users\kkz\source\repos\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "C:\Users\kkz\source\repos\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 6 "C:\Users\kkz\source\repos\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 7 "C:\Users\kkz\source\repos\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using BethanysPieShopHRM.App;

#line default
#line hidden
#line 8 "C:\Users\kkz\source\repos\BethanysPieShopHRM.App\BethanysPieShopHRM.App\_Imports.razor"
using BethanysPieShopHRM.App.Shared;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/employeedetail/{EmployeeId}")]
    public partial class EmployeeDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "section");
            __builder.AddAttribute(1, "class", "employee-detail");
            __builder.AddMarkupContent(2, "\r\n\r\n        ");
            __builder.OpenElement(3, "h1");
            __builder.AddAttribute(4, "class", "page-title");
            __builder.AddContent(5, "Details for ");
            __builder.AddContent(6, 
#line 5 "C:\Users\kkz\source\repos\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"
                                            Employee.FirstName

#line default
#line hidden
            );
            __builder.AddContent(7, " ");
            __builder.AddContent(8, 
#line 5 "C:\Users\kkz\source\repos\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"
                                                                Employee.LastName

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n\r\n        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-12 row");
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "col-2");
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "img");
            __builder.AddAttribute(17, "src", 
#line 10 "C:\Users\kkz\source\repos\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"
                            $"https://gillcleerenpluralsight.blob.core.windows.net/person/{Employee.EmployeeId}.jpg"

#line default
#line hidden
            );
            __builder.AddAttribute(18, "class", "img-responsive rounded-circle employee-detail-img");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "col-10 row");
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "col-xs-12 col-sm-8");
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "form-group row");
            __builder.AddMarkupContent(29, "\r\n                        ");
            __builder.AddMarkupContent(30, "<label class=\"col-sm-4 col-form-label\">Employee ID</label>\r\n                        ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "col-sm-8");
            __builder.AddMarkupContent(33, "\r\n                            ");
            __builder.OpenElement(34, "label");
            __builder.AddAttribute(35, "type", "text");
            __builder.AddAttribute(36, "class", "form-control-plaintext");
            __builder.AddContent(37, 
#line 17 "C:\Users\kkz\source\repos\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"
                                                                               Employee.EmployeeId

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                    ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "form-group row");
            __builder.AddMarkupContent(43, "\r\n                        ");
            __builder.AddMarkupContent(44, "<label class=\"col-sm-4 col-form-label\">First name</label>\r\n                        ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "col-sm-8");
            __builder.AddMarkupContent(47, "\r\n                            ");
            __builder.OpenElement(48, "label");
            __builder.AddAttribute(49, "type", "text");
            __builder.AddAttribute(50, "readonly", true);
            __builder.AddAttribute(51, "class", "form-control-plaintext");
            __builder.AddContent(52, 
#line 23 "C:\Users\kkz\source\repos\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"
                                                                                        Employee.FirstName

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n\r\n                    ");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "form-group row");
            __builder.AddMarkupContent(58, "\r\n                        ");
            __builder.AddMarkupContent(59, "<label class=\"col-sm-4 col-form-label\">Last name</label>\r\n                        ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "col-sm-8");
            __builder.AddMarkupContent(62, "\r\n                            ");
            __builder.OpenElement(63, "label");
            __builder.AddAttribute(64, "type", "text");
            __builder.AddAttribute(65, "readonly", true);
            __builder.AddAttribute(66, "class", "form-control-plaintext");
            __builder.AddContent(67, 
#line 30 "C:\Users\kkz\source\repos\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"
                                                                                        Employee.LastName

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n\r\n                    ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "form-group row");
            __builder.AddMarkupContent(73, "\r\n                        ");
            __builder.AddMarkupContent(74, "<label class=\"col-sm-4 col-form-label\">Birthdate</label>\r\n                        ");
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "class", "col-sm-8");
            __builder.AddMarkupContent(77, "\r\n                            ");
            __builder.OpenElement(78, "label");
            __builder.AddAttribute(79, "type", "text");
            __builder.AddAttribute(80, "readonly", true);
            __builder.AddAttribute(81, "class", "form-control-plaintext");
            __builder.AddContent(82, 
#line 37 "C:\Users\kkz\source\repos\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"
                                                                                        Employee.BirthDate.ToShortDateString()

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n\r\n                    ");
            __builder.OpenElement(86, "div");
            __builder.AddAttribute(87, "class", "form-group row");
            __builder.AddMarkupContent(88, "\r\n                        ");
            __builder.AddMarkupContent(89, "<label class=\"col-sm-4 col-form-label\">Email</label>\r\n                        ");
            __builder.OpenElement(90, "div");
            __builder.AddAttribute(91, "class", "col-sm-8");
            __builder.AddMarkupContent(92, "\r\n                            ");
            __builder.OpenElement(93, "label");
            __builder.AddAttribute(94, "type", "text");
            __builder.AddAttribute(95, "readonly", true);
            __builder.AddAttribute(96, "class", "form-control-plaintext");
            __builder.AddContent(97, 
#line 44 "C:\Users\kkz\source\repos\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"
                                                                                        Employee.Email

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n\r\n                    ");
            __builder.OpenElement(101, "div");
            __builder.AddAttribute(102, "class", "form-group row");
            __builder.AddMarkupContent(103, "\r\n                        ");
            __builder.AddMarkupContent(104, "<label class=\"col-sm-4 col-form-label\">Street</label>\r\n                        ");
            __builder.OpenElement(105, "div");
            __builder.AddAttribute(106, "class", "col-sm-8");
            __builder.AddMarkupContent(107, "\r\n                            ");
            __builder.OpenElement(108, "label");
            __builder.AddAttribute(109, "type", "text");
            __builder.AddAttribute(110, "readonly", true);
            __builder.AddAttribute(111, "class", "form-control-plaintext");
            __builder.AddContent(112, 
#line 51 "C:\Users\kkz\source\repos\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"
                                                                                        Employee.Street

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n\r\n                    ");
            __builder.OpenElement(116, "div");
            __builder.AddAttribute(117, "class", "form-group row");
            __builder.AddMarkupContent(118, "\r\n                        ");
            __builder.AddMarkupContent(119, "<label class=\"col-sm-4 col-form-label\">Zip</label>\r\n                        ");
            __builder.OpenElement(120, "div");
            __builder.AddAttribute(121, "class", "col-sm-8");
            __builder.AddMarkupContent(122, "\r\n                            ");
            __builder.OpenElement(123, "label");
            __builder.AddAttribute(124, "type", "text");
            __builder.AddAttribute(125, "readonly", true);
            __builder.AddAttribute(126, "class", "form-control-plaintext");
            __builder.AddContent(127, 
#line 58 "C:\Users\kkz\source\repos\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"
                                                                                        Employee.Zip

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(128, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "\r\n\r\n                    ");
            __builder.OpenElement(131, "div");
            __builder.AddAttribute(132, "class", "form-group row");
            __builder.AddMarkupContent(133, "\r\n                        ");
            __builder.AddMarkupContent(134, "<label class=\"col-sm-4 col-form-label\">City</label>\r\n                        ");
            __builder.OpenElement(135, "div");
            __builder.AddAttribute(136, "class", "col-sm-8");
            __builder.AddMarkupContent(137, "\r\n                            ");
            __builder.OpenElement(138, "label");
            __builder.AddAttribute(139, "type", "text");
            __builder.AddAttribute(140, "readonly", true);
            __builder.AddAttribute(141, "class", "form-control-plaintext");
            __builder.AddContent(142, 
#line 65 "C:\Users\kkz\source\repos\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"
                                                                                        Employee.City

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(143, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(144, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(145, "\r\n\r\n                    ");
            __builder.OpenElement(146, "div");
            __builder.AddAttribute(147, "class", "form-group row");
            __builder.AddMarkupContent(148, "\r\n                        ");
            __builder.AddMarkupContent(149, "<label class=\"col-sm-4 col-form-label\">Phone number</label>\r\n                        ");
            __builder.OpenElement(150, "div");
            __builder.AddAttribute(151, "class", "col-sm-8");
            __builder.AddMarkupContent(152, "\r\n                            ");
            __builder.OpenElement(153, "label");
            __builder.AddAttribute(154, "type", "text");
            __builder.AddAttribute(155, "readonly", true);
            __builder.AddAttribute(156, "class", "form-control-plaintext");
            __builder.AddContent(157, 
#line 72 "C:\Users\kkz\source\repos\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"
                                                                                        Employee.PhoneNumber

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(158, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(159, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(160, "\r\n\r\n                    ");
            __builder.OpenElement(161, "div");
            __builder.AddAttribute(162, "class", "form-group row");
            __builder.AddMarkupContent(163, "\r\n                        ");
            __builder.AddMarkupContent(164, "<label class=\"col-sm-4 col-form-label\">Gender</label>\r\n                        ");
            __builder.OpenElement(165, "div");
            __builder.AddAttribute(166, "class", "col-sm-8");
            __builder.AddMarkupContent(167, "\r\n                            ");
            __builder.OpenElement(168, "label");
            __builder.AddAttribute(169, "type", "text");
            __builder.AddAttribute(170, "readonly", true);
            __builder.AddAttribute(171, "class", "form-control-plaintext");
            __builder.AddContent(172, 
#line 79 "C:\Users\kkz\source\repos\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"
                                                                                        Employee.Gender

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(173, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(174, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(175, "\r\n\r\n                    ");
            __builder.OpenElement(176, "div");
            __builder.AddAttribute(177, "class", "form-group row");
            __builder.AddMarkupContent(178, "\r\n                        ");
            __builder.AddMarkupContent(179, "<label class=\"col-sm-4 col-form-label\">Smoker</label>\r\n                        ");
            __builder.OpenElement(180, "div");
            __builder.AddAttribute(181, "class", "col-sm-8");
            __builder.AddMarkupContent(182, "\r\n\r\n");
#line 87 "C:\Users\kkz\source\repos\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"
                             if (Employee.Smoker)
                            {

#line default
#line hidden
            __builder.AddContent(183, "                                ");
            __builder.AddMarkupContent(184, "<label type=\"text\" readonly class=\"form-control-plaintext\">Yes</label>\r\n");
#line 90 "C:\Users\kkz\source\repos\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"
                            }
                            else
                            {

#line default
#line hidden
            __builder.AddContent(185, "                                ");
            __builder.AddMarkupContent(186, "<label type=\"text\" readonly class=\"form-control-plaintext\">No</label>\r\n");
#line 94 "C:\Users\kkz\source\repos\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"

                            }

#line default
#line hidden
            __builder.AddContent(187, "                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(188, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(189, "\r\n\r\n                    ");
            __builder.OpenElement(190, "div");
            __builder.AddAttribute(191, "class", "form-group row");
            __builder.AddMarkupContent(192, "\r\n                        ");
            __builder.AddMarkupContent(193, "<label class=\"col-sm-4 col-form-label\">Joined us</label>\r\n                        ");
            __builder.OpenElement(194, "div");
            __builder.AddAttribute(195, "class", "col-sm-8");
            __builder.AddMarkupContent(196, "\r\n                            ");
            __builder.OpenElement(197, "label");
            __builder.AddAttribute(198, "type", "text");
            __builder.AddAttribute(199, "readonly", true);
            __builder.AddAttribute(200, "class", "form-control-plaintext");
            __builder.AddContent(201, 
#line 102 "C:\Users\kkz\source\repos\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"
                                                                                        Employee.JoinedDate?.ToShortDateString()

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(202, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(203, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(204, "\r\n\r\n                    ");
            __builder.OpenElement(205, "div");
            __builder.AddAttribute(206, "class", "form-group row");
            __builder.AddMarkupContent(207, "\r\n                        ");
            __builder.AddMarkupContent(208, "<label class=\"col-sm-4 col-form-label\">Left us</label>\r\n                        ");
            __builder.OpenElement(209, "div");
            __builder.AddAttribute(210, "class", "col-sm-8");
            __builder.AddMarkupContent(211, "\r\n                            ");
            __builder.OpenElement(212, "label");
            __builder.AddAttribute(213, "type", "text");
            __builder.AddAttribute(214, "readonly", true);
            __builder.AddAttribute(215, "class", "form-control-plaintext");
            __builder.AddContent(216, 
#line 109 "C:\Users\kkz\source\repos\BethanysPieShopHRM.App\BethanysPieShopHRM.App\Pages\EmployeeDetail.razor"
                                                                                        Employee.ExitDate?.ToShortDateString()

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(217, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(218, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(219, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(220, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(221, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(222, "\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
