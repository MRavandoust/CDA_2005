#pragma checksum "D:\GitHub\CDA_2005\TP_Freelancer\TP_asp\FreeLance\FreeLance\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce648a8dd93dec27f9787caf0b62601ec6e1c47c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\GitHub\CDA_2005\TP_Freelancer\TP_asp\FreeLance\FreeLance\Views\_ViewImports.cshtml"
using FreeLance;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GitHub\CDA_2005\TP_Freelancer\TP_asp\FreeLance\FreeLance\Views\_ViewImports.cshtml"
using FreeLance.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce648a8dd93dec27f9787caf0b62601ec6e1c47c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cccba7a2904a34e31b82202c563f4ed0e0c68939", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FreeLance.Models.Customer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\GitHub\CDA_2005\TP_Freelancer\TP_asp\FreeLance\FreeLance\Views\Home\Index.cshtml"
   ViewData["Title"] = "Home Page"; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\GitHub\CDA_2005\TP_Freelancer\TP_asp\FreeLance\FreeLance\Views\Home\Index.cshtml"
   ViewBag.LastClient = Model.Last().Name; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<section>\n    <div class=\"box1\">\n        <h2>Gestion des clients</h2>\n        <p>Dernier client ajouté/modifié: ");
#nullable restore
#line 7 "D:\GitHub\CDA_2005\TP_Freelancer\TP_asp\FreeLance\FreeLance\Views\Home\Index.cshtml"
                                     Write(ViewBag.LastClient);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n        <a class=\"button\"");
            BeginWriteAttribute("href", " href=\"", 290, "\"", 329, 1);
#nullable restore
#line 8 "D:\GitHub\CDA_2005\TP_Freelancer\TP_asp\FreeLance\FreeLance\Views\Home\Index.cshtml"
WriteAttributeValue("", 297, Url.Action("Create", "Clients"), 297, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> + Ajouter un nouveau client</a>\n    </div>\n</section>\n\n\n<h3>Gestion des clients</h3>\n\n    <table>\n        <tr>\n            <th>");
#nullable restore
#line 17 "D:\GitHub\CDA_2005\TP_Freelancer\TP_asp\FreeLance\FreeLance\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n            <th>");
#nullable restore
#line 18 "D:\GitHub\CDA_2005\TP_Freelancer\TP_asp\FreeLance\FreeLance\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n            <th>");
#nullable restore
#line 19 "D:\GitHub\CDA_2005\TP_Freelancer\TP_asp\FreeLance\FreeLance\Views\Home\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n            <th>Actions</th>\n        </tr>\n");
#nullable restore
#line 22 "D:\GitHub\CDA_2005\TP_Freelancer\TP_asp\FreeLance\FreeLance\Views\Home\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n    <td>");
#nullable restore
#line 25 "D:\GitHub\CDA_2005\TP_Freelancer\TP_asp\FreeLance\FreeLance\Views\Home\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 26 "D:\GitHub\CDA_2005\TP_Freelancer\TP_asp\FreeLance\FreeLance\Views\Home\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>");
#nullable restore
#line 27 "D:\GitHub\CDA_2005\TP_Freelancer\TP_asp\FreeLance\FreeLance\Views\Home\Index.cshtml"
   Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n    <td>\n        <a");
            BeginWriteAttribute("href", " href =\"", 906, "\"", 967, 1);
#nullable restore
#line 29 "D:\GitHub\CDA_2005\TP_Freelancer\TP_asp\FreeLance\FreeLance\Views\Home\Index.cshtml"
WriteAttributeValue("", 914, Url.Action("Edit", "Clients", new { id = @item.Id }), 914, 53, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-edit\"></i></a>\n        <a");
            BeginWriteAttribute("href", " href =\"", 1011, "\"", 1074, 1);
#nullable restore
#line 30 "D:\GitHub\CDA_2005\TP_Freelancer\TP_asp\FreeLance\FreeLance\Views\Home\Index.cshtml"
WriteAttributeValue("", 1019, Url.Action("Delete", "Clients", new { id = @item.Id }), 1019, 55, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fas fa-times\"></i></a>\n    </td>\n</tr>\n");
#nullable restore
#line 33 "D:\GitHub\CDA_2005\TP_Freelancer\TP_asp\FreeLance\FreeLance\Views\Home\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    </table>




<h3>Informations</h3>
<p>Largeur max du conteneur: 960px;</p>
<p>Police de caracteres (font): Verdana, Geneva, Tahoma, sans-serif</p>

<h3>Couleurs</h3>
<section class=""color"">
    <div class=""couleurs noir"">Noir : #111</div>
    <div class=""couleurs gris1"">Gris (1) : #FAF7F5</div>
    <div class=""couleurs gris2"">Gris (2) : #45505E</div>
</section>

<section class=""color"">
    <div class=""couleurs vert"">Vert : #38DD09</div>
    <div class=""couleurs violet"">Violet (survol des boutons) : #3809DD</div>
</section>


<section class=""liens"">
    <a href=""#"">Ajouter</a>
    <span class=""point"">.</span>
    <a href=""#"">Quelques</a>
    <span class=""point"">.</span>
    <a href=""#"">Liens</a>
    <span class=""point"">.</span>
    <a href=""#"">De votre choix</a>
    <span class=""point"">.</span>
    <a href=""#"">Un autre lien</a>
</section>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FreeLance.Models.Customer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
