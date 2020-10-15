#pragma checksum "C:\Users\kkz\source\repos\CentralizedInstallationServer\LeicaInstallationServer.App\Pages\EnvironmentDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc3e9f70fa67b2d7cee071254a640ced69b8ad4e"
// <auto-generated/>
#pragma warning disable 1591
namespace LeicaInstallationServer.App.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\kkz\source\repos\CentralizedInstallationServer\LeicaInstallationServer.App\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\kkz\source\repos\CentralizedInstallationServer\LeicaInstallationServer.App\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#line 3 "C:\Users\kkz\source\repos\CentralizedInstallationServer\LeicaInstallationServer.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 4 "C:\Users\kkz\source\repos\CentralizedInstallationServer\LeicaInstallationServer.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "C:\Users\kkz\source\repos\CentralizedInstallationServer\LeicaInstallationServer.App\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 6 "C:\Users\kkz\source\repos\CentralizedInstallationServer\LeicaInstallationServer.App\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 7 "C:\Users\kkz\source\repos\CentralizedInstallationServer\LeicaInstallationServer.App\_Imports.razor"
using LeicaInstallationServer.App;

#line default
#line hidden
#line 8 "C:\Users\kkz\source\repos\CentralizedInstallationServer\LeicaInstallationServer.App\_Imports.razor"
using LeicaInstallationServer.App.Shared;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.RouteAttribute("/environmentdetail/{EmployeeId}")]
    public partial class EnvironmentDetail : Microsoft.AspNetCore.Components.ComponentBase
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
#line 5 "C:\Users\kkz\source\repos\CentralizedInstallationServer\LeicaInstallationServer.App\Pages\EnvironmentDetail.razor"
                                            Environments.FirstName

#line default
#line hidden
            );
            __builder.AddContent(7, " ");
            __builder.AddContent(8, 
#line 5 "C:\Users\kkz\source\repos\CentralizedInstallationServer\LeicaInstallationServer.App\Pages\EnvironmentDetail.razor"
                                                                    Environments.LastName

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
#line 10 "C:\Users\kkz\source\repos\CentralizedInstallationServer\LeicaInstallationServer.App\Pages\EnvironmentDetail.razor"
                            $"https://gillcleerenpluralsight.blob.core.windows.net/person/{Environments.EmployeeId}.jpg"

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
            __builder.AddMarkupContent(30, "<label class=\"col-sm-4 col-form-label\">Environment Index</label>\r\n                        ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "col-sm-8");
            __builder.AddMarkupContent(33, "\r\n                            ");
            __builder.OpenElement(34, "label");
            __builder.AddAttribute(35, "type", "text");
            __builder.AddAttribute(36, "class", "form-control-plaintext");
            __builder.AddContent(37, 
#line 17 "C:\Users\kkz\source\repos\CentralizedInstallationServer\LeicaInstallationServer.App\Pages\EnvironmentDetail.razor"
                                                                               Environments.EmployeeId

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
            __builder.AddMarkupContent(44, "<label class=\"col-sm-4 col-form-label\">Environment Name</label>\r\n                        ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "col-sm-8");
            __builder.AddMarkupContent(47, "\r\n                            ");
            __builder.OpenElement(48, "label");
            __builder.AddAttribute(49, "type", "text");
            __builder.AddAttribute(50, "readonly", true);
            __builder.AddAttribute(51, "class", "form-control-plaintext");
            __builder.AddContent(52, 
#line 23 "C:\Users\kkz\source\repos\CentralizedInstallationServer\LeicaInstallationServer.App\Pages\EnvironmentDetail.razor"
                                                                                        Environments.FirstName

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
            __builder.AddMarkupContent(59, "<label class=\"col-sm-4 col-form-label\">Environment IP</label>\r\n                        ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "col-sm-8");
            __builder.AddMarkupContent(62, "\r\n                            ");
            __builder.OpenElement(63, "label");
            __builder.AddAttribute(64, "type", "text");
            __builder.AddAttribute(65, "readonly", true);
            __builder.AddAttribute(66, "class", "form-control-plaintext");
            __builder.AddContent(67, 
#line 30 "C:\Users\kkz\source\repos\CentralizedInstallationServer\LeicaInstallationServer.App\Pages\EnvironmentDetail.razor"
                                                                                        Environments.LastName

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
            __builder.AddMarkupContent(74, "<label class=\"col-sm-4 col-form-label\">Added Date</label>\r\n                        ");
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "class", "col-sm-8");
            __builder.AddMarkupContent(77, "\r\n                            ");
            __builder.OpenElement(78, "label");
            __builder.AddAttribute(79, "type", "text");
            __builder.AddAttribute(80, "readonly", true);
            __builder.AddAttribute(81, "class", "form-control-plaintext");
            __builder.AddContent(82, 
#line 37 "C:\Users\kkz\source\repos\CentralizedInstallationServer\LeicaInstallationServer.App\Pages\EnvironmentDetail.razor"
                                                                                        Environments.BirthDate.ToShortDateString()

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n\r\n\r\n                    ");
            __builder.OpenElement(86, "div");
            __builder.AddAttribute(87, "class", "form-group row");
            __builder.AddMarkupContent(88, "\r\n                        ");
            __builder.AddMarkupContent(89, "<label class=\"col-sm-4 col-form-label\">Added By</label>\r\n                        ");
            __builder.OpenElement(90, "div");
            __builder.AddAttribute(91, "class", "col-sm-8");
            __builder.AddMarkupContent(92, "\r\n                            ");
            __builder.OpenElement(93, "label");
            __builder.AddAttribute(94, "type", "text");
            __builder.AddAttribute(95, "readonly", true);
            __builder.AddAttribute(96, "class", "form-control-plaintext");
            __builder.AddContent(97, 
#line 51 "C:\Users\kkz\source\repos\CentralizedInstallationServer\LeicaInstallationServer.App\Pages\EnvironmentDetail.razor"
                                                                                        Environments.Street

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
            __builder.AddMarkupContent(104, "<label class=\"col-sm-4 col-form-label\">Contact Person</label>\r\n                        ");
            __builder.OpenElement(105, "div");
            __builder.AddAttribute(106, "class", "col-sm-8");
            __builder.AddMarkupContent(107, "\r\n                            ");
            __builder.OpenElement(108, "label");
            __builder.AddAttribute(109, "type", "text");
            __builder.AddAttribute(110, "readonly", true);
            __builder.AddAttribute(111, "class", "form-control-plaintext");
            __builder.AddContent(112, 
#line 58 "C:\Users\kkz\source\repos\CentralizedInstallationServer\LeicaInstallationServer.App\Pages\EnvironmentDetail.razor"
                                                                                        Environments.City

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
