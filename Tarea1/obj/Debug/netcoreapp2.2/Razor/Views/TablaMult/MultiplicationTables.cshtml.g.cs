#pragma checksum "C:\Users\eljos\source\repos\Tarea1\Tarea1\Views\TablaMult\MultiplicationTables.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59a54febef6eeec99c68cc3fa264a1f0b66037f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TablaMult_MultiplicationTables), @"mvc.1.0.view", @"/Views/TablaMult/MultiplicationTables.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TablaMult/MultiplicationTables.cshtml", typeof(AspNetCore.Views_TablaMult_MultiplicationTables))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\eljos\source\repos\Tarea1\Tarea1\Views\_ViewImports.cshtml"
using Tarea1;

#line default
#line hidden
#line 2 "C:\Users\eljos\source\repos\Tarea1\Tarea1\Views\_ViewImports.cshtml"
using Tarea1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59a54febef6eeec99c68cc3fa264a1f0b66037f9", @"/Views/TablaMult/MultiplicationTables.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c83f63846b9ac0634998a743c48be748dac8e52", @"/Views/_ViewImports.cshtml")]
    public class Views_TablaMult_MultiplicationTables : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\eljos\source\repos\Tarea1\Tarea1\Views\TablaMult\MultiplicationTables.cshtml"
  
    ViewData["Title"] = "Tablas de Multiplicar";

#line default
#line hidden
            BeginContext(57, 152, true);
            WriteLiteral("\r\n<h1 style=\"text-align:center\">Tablas de Multiplicar</h1>\r\n\r\n<div class=\"col-12\" style=\"margin-left:auto; margin-right:auto\">\r\n    <table border=\"1\">\r\n");
            EndContext();
#line 9 "C:\Users\eljos\source\repos\Tarea1\Tarea1\Views\TablaMult\MultiplicationTables.cshtml"
         for (int i = 1; i <= 12; i++)
        {

#line default
#line hidden
            BeginContext(260, 18, true);
            WriteLiteral("            <tr>\r\n");
            EndContext();
#line 12 "C:\Users\eljos\source\repos\Tarea1\Tarea1\Views\TablaMult\MultiplicationTables.cshtml"
                 for (int j = 1; j <= 12; j++)
                {

#line default
#line hidden
            BeginContext(345, 24, true);
            WriteLiteral("                    <td>");
            EndContext();
            BeginContext(370, 1, false);
#line 14 "C:\Users\eljos\source\repos\Tarea1\Tarea1\Views\TablaMult\MultiplicationTables.cshtml"
                   Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(371, 3, true);
            WriteLiteral(" * ");
            EndContext();
            BeginContext(375, 1, false);
#line 14 "C:\Users\eljos\source\repos\Tarea1\Tarea1\Views\TablaMult\MultiplicationTables.cshtml"
                        Write(j);

#line default
#line hidden
            EndContext();
            BeginContext(376, 3, true);
            WriteLiteral(" = ");
            EndContext();
            BeginContext(381, 5, false);
#line 14 "C:\Users\eljos\source\repos\Tarea1\Tarea1\Views\TablaMult\MultiplicationTables.cshtml"
                              Write(i * j);

#line default
#line hidden
            EndContext();
            BeginContext(387, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 15 "C:\Users\eljos\source\repos\Tarea1\Tarea1\Views\TablaMult\MultiplicationTables.cshtml"
                }

#line default
#line hidden
            BeginContext(413, 19, true);
            WriteLiteral("            </tr>\r\n");
            EndContext();
#line 17 "C:\Users\eljos\source\repos\Tarea1\Tarea1\Views\TablaMult\MultiplicationTables.cshtml"
        }

#line default
#line hidden
            BeginContext(443, 24, true);
            WriteLiteral("    </table>\r\n</div>\r\n\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
