#pragma checksum "C:\Users\Dolglas\Desktop\Visual Studio 2019\BlzMakeup\BlzMakeup\Views\Produtos\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd810519b8c84626d13e6454cc57a5052e9e7bae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produtos_List), @"mvc.1.0.view", @"/Views/Produtos/List.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Dolglas\Desktop\Visual Studio 2019\BlzMakeup\BlzMakeup\Views\_ViewImports.cshtml"
using BlzMakeup.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dolglas\Desktop\Visual Studio 2019\BlzMakeup\BlzMakeup\Views\_ViewImports.cshtml"
using BlzMakeup;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Dolglas\Desktop\Visual Studio 2019\BlzMakeup\BlzMakeup\Views\_ViewImports.cshtml"
using BlzMakeup.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd810519b8c84626d13e6454cc57a5052e9e7bae", @"/Views/Produtos/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"933284ff67278b4c5a9b182a9f7c995cdfdbfed6", @"/Views/_ViewImports.cshtml")]
    public class Views_Produtos_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProdutosListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ProdutosResumo", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Dolglas\Desktop\Visual Studio 2019\BlzMakeup\BlzMakeup\Views\Produtos\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"nome-login pb-5 pt-3\"> ");
#nullable restore
#line 7 "C:\Users\Dolglas\Desktop\Visual Studio 2019\BlzMakeup\BlzMakeup\Views\Produtos\List.cshtml"
                             Write(Model.CategoriaAtual);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\r\n\r\n<div class=\"row\">\r\n");
#nullable restore
#line 10 "C:\Users\Dolglas\Desktop\Visual Studio 2019\BlzMakeup\BlzMakeup\Views\Produtos\List.cshtml"
     foreach (var produto in Model.Produtos)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "cd810519b8c84626d13e6454cc57a5052e9e7bae4464", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 12 "C:\Users\Dolglas\Desktop\Visual Studio 2019\BlzMakeup\BlzMakeup\Views\Produtos\List.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => produto);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("for", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\Users\Dolglas\Desktop\Visual Studio 2019\BlzMakeup\BlzMakeup\Views\Produtos\List.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
#nullable restore
#line 16 "C:\Users\Dolglas\Desktop\Visual Studio 2019\BlzMakeup\BlzMakeup\Views\Produtos\List.cshtml"
 if (Model.Produtos.Count() == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-warning text-center\" role=\"alert\">\r\n        Nenhum item corresponde a pesquisa\r\n    </div>\r\n");
#nullable restore
#line 21 "C:\Users\Dolglas\Desktop\Visual Studio 2019\BlzMakeup\BlzMakeup\Views\Produtos\List.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProdutosListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
