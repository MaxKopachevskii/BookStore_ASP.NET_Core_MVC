#pragma checksum "C:\Users\Admin\source\repos\BookStore_ASP.NET_Core_MVC\ASP.NET_Core_BookStore\Views\Books\DetailsBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94b1e284db8ac87d1c6a2ae0324ebe6cfa3df375"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_DetailsBook), @"mvc.1.0.view", @"/Views/Books/DetailsBook.cshtml")]
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
#line 1 "C:\Users\Admin\source\repos\BookStore_ASP.NET_Core_MVC\ASP.NET_Core_BookStore\Views\_ViewImports.cshtml"
using ASP.NET_Core_BookStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\source\repos\BookStore_ASP.NET_Core_MVC\ASP.NET_Core_BookStore\Views\_ViewImports.cshtml"
using ASP.NET_Core_BookStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94b1e284db8ac87d1c6a2ae0324ebe6cfa3df375", @"/Views/Books/DetailsBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bfa2bb0c8dc0859635af7e951d714552f414bba", @"/Views/_ViewImports.cshtml")]
    public class Views_Books_DetailsBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ASP.NET_Core_BookStore.Models.Book>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Books", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AllFavoriteBooks", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AllBooks", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BookInBasket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Admin\source\repos\BookStore_ASP.NET_Core_MVC\ASP.NET_Core_BookStore\Views\Books\DetailsBook.cshtml"
  
    ViewData["Title"] = "DetailsBook";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Admin\source\repos\BookStore_ASP.NET_Core_MVC\ASP.NET_Core_BookStore\Views\Books\DetailsBook.cshtml"
  
    string InStock = "";
    string color = "";
    string disable = "";
    if (Model.CountInStock >= 3)
    {
        InStock = "Есть в наличии";
        color = "green";
    }
    if (Model.CountInStock < 3 && Model.CountInStock > 0)
    {
        InStock = "Товар заканчивается";
        color = "orange";
    }
    if (Model.CountInStock == 0)
    {
        InStock = "Нет в наличии";
        color = "red";
        disable = "disabled";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <nav aria-label=\"breadcrumb\">\r\n        <ol class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94b1e284db8ac87d1c6a2ae0324ebe6cfa3df3755819", async() => {
                WriteLiteral("Главная");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n            <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94b1e284db8ac87d1c6a2ae0324ebe6cfa3df3757428", async() => {
                WriteLiteral("Все товары");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n            <li class=\"breadcrumb-item active\" aria-current=\"page\">");
#nullable restore
#line 33 "C:\Users\Admin\source\repos\BookStore_ASP.NET_Core_MVC\ASP.NET_Core_BookStore\Views\Books\DetailsBook.cshtml"
                                                              Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        </ol>\r\n    </nav>\r\n\r\n<h3>");
#nullable restore
#line 37 "C:\Users\Admin\source\repos\BookStore_ASP.NET_Core_MVC\ASP.NET_Core_BookStore\Views\Books\DetailsBook.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<br />\r\n<div class=\"row row-cols-1 row-cols-md-3\">\r\n    <div class=\"col mb-4\">\r\n        <img style=\"width: 22rem;\"");
            BeginWriteAttribute("src", " src=\"", 1136, "\"", 1152, 1);
#nullable restore
#line 41 "C:\Users\Admin\source\repos\BookStore_ASP.NET_Core_MVC\ASP.NET_Core_BookStore\Views\Books\DetailsBook.cshtml"
WriteAttributeValue("", 1142, Model.Img, 1142, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n    </div>\r\n    <div class=\"col mb-4\">\r\n        <p style=\"font-size:2em;\"><strong>");
#nullable restore
#line 44 "C:\Users\Admin\source\repos\BookStore_ASP.NET_Core_MVC\ASP.NET_Core_BookStore\Views\Books\DetailsBook.cshtml"
                                     Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" грн.</strong></p>\r\n        <p");
            BeginWriteAttribute("style", " style=\"", 1311, "\"", 1348, 3);
            WriteAttributeValue("", 1319, "font-size:1.1em;", 1319, 16, true);
            WriteAttributeValue(" ", 1335, "color:", 1336, 7, true);
#nullable restore
#line 45 "C:\Users\Admin\source\repos\BookStore_ASP.NET_Core_MVC\ASP.NET_Core_BookStore\Views\Books\DetailsBook.cshtml"
WriteAttributeValue("", 1342, color, 1342, 6, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i><strong>");
#nullable restore
#line 45 "C:\Users\Admin\source\repos\BookStore_ASP.NET_Core_MVC\ASP.NET_Core_BookStore\Views\Books\DetailsBook.cshtml"
                                                       Write(InStock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></i></p>\r\n        <p style=\"font-size:1.1em;\">Артикул:&nbsp;<i><strong>");
#nullable restore
#line 46 "C:\Users\Admin\source\repos\BookStore_ASP.NET_Core_MVC\ASP.NET_Core_BookStore\Views\Books\DetailsBook.cshtml"
                                                        Write(Model.CodeBook);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></i></p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94b1e284db8ac87d1c6a2ae0324ebe6cfa3df37511881", async() => {
                WriteLiteral(@"
            <svg class=""bi bi-bucket"" width=""1.3em"" height=""1.3em"" viewBox=""0 0 16 16"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
                <path fill-rule=""evenodd"" d=""M8 1.5A4.5 4.5 0 003.5 6h-1a5.5 5.5 0 1111 0h-1A4.5 4.5 0 008 1.5z"" clip-rule=""evenodd"" />
                <path fill-rule=""evenodd"" d=""M1.61 5.687A.5.5 0 012 5.5h12a.5.5 0 01.488.608l-1.826 8.217a1.5 1.5 0 01-1.464 1.175H4.802a1.5 1.5 0 01-1.464-1.175L1.512 6.108a.5.5 0 01.098-.42zm1.013.813l1.691 7.608a.5.5 0 00.488.392h6.396a.5.5 0 00.488-.392l1.69-7.608H2.624z"" clip-rule=""evenodd"" />
            </svg>
            В корзину
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1501, "btn", 1501, 3, true);
            AddHtmlAttributeValue(" ", 1504, "btn-lg", 1505, 7, true);
            AddHtmlAttributeValue(" ", 1511, "btn-danger", 1512, 11, true);
#nullable restore
#line 47 "C:\Users\Admin\source\repos\BookStore_ASP.NET_Core_MVC\ASP.NET_Core_BookStore\Views\Books\DetailsBook.cshtml"
AddHtmlAttributeValue(" ", 1522, disable, 1523, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "C:\Users\Admin\source\repos\BookStore_ASP.NET_Core_MVC\ASP.NET_Core_BookStore\Views\Books\DetailsBook.cshtml"
                                                                                                     WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <br /><br />\r\n        <p style=\"font-size:1.1em;\">ISBN:&nbsp;<i>");
#nullable restore
#line 55 "C:\Users\Admin\source\repos\BookStore_ASP.NET_Core_MVC\ASP.NET_Core_BookStore\Views\Books\DetailsBook.cshtml"
                                             Write(Model.ISBN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></p>\r\n        <p style=\"font-size:1.1em;\">Автор:&nbsp;<i>");
#nullable restore
#line 56 "C:\Users\Admin\source\repos\BookStore_ASP.NET_Core_MVC\ASP.NET_Core_BookStore\Views\Books\DetailsBook.cshtml"
                                              Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></p>\r\n        <p style=\"font-size:1.1em;\">Издательство:&nbsp;<i>");
#nullable restore
#line 57 "C:\Users\Admin\source\repos\BookStore_ASP.NET_Core_MVC\ASP.NET_Core_BookStore\Views\Books\DetailsBook.cshtml"
                                                     Write(Model.PublishHouse);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></p>\r\n        <p style=\"font-size:1.1em;\">Год:&nbsp;<i>");
#nullable restore
#line 58 "C:\Users\Admin\source\repos\BookStore_ASP.NET_Core_MVC\ASP.NET_Core_BookStore\Views\Books\DetailsBook.cshtml"
                                            Write(Model.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></p>\r\n        <p style=\"font-size:1.1em;\">Страниц:&nbsp;<i>");
#nullable restore
#line 59 "C:\Users\Admin\source\repos\BookStore_ASP.NET_Core_MVC\ASP.NET_Core_BookStore\Views\Books\DetailsBook.cshtml"
                                                Write(Model.Pages);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i></p>\r\n        <p style=\"font-size:1.1em;\">Категория:&nbsp;<i>");
#nullable restore
#line 60 "C:\Users\Admin\source\repos\BookStore_ASP.NET_Core_MVC\ASP.NET_Core_BookStore\Views\Books\DetailsBook.cshtml"
                                                  Write(Model.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</i></p>
    </div>
    <div class=""col mb-4"">
    </div>
    <div class=""col mb-4"">
    </div>
</div>

<ul class=""nav nav-tabs"" id=""myTab"" role=""tablist"">
    <li class=""nav-item"">
        <a style=""font-size:1.1em; color:black;"" class=""nav-link active"" id=""home-tab"" data-toggle=""tab"" href=""#home"" role=""tab"" aria-controls=""home"" aria-selected=""true"">О книге</a>
    </li>
    <li class=""nav-item"">
        <a style=""font-size:1.1em; color:black;"" class=""nav-link"" id=""profile-tab"" data-toggle=""tab"" href=""#profile"" role=""tab"" aria-controls=""profile"" aria-selected=""false"">О нас</a>
    </li>
    <li class=""nav-item"">
        <a style=""font-size:1.1em; color:black;"" class=""nav-link"" id=""contact-tab"" data-toggle=""tab"" href=""#contact"" role=""tab"" aria-controls=""contact"" aria-selected=""false"">Контакты</a>
    </li>
</ul>
<div class=""tab-content"" id=""myTabContent"">
    <div style=""font-size:1.1em;"" class=""tab-pane fade show active"" id=""home"" role=""tabpanel"" aria-labelledby=""home-tab""><br />&nbsp;&nb");
            WriteLiteral("sp;&nbsp;&nbsp;&nbsp;&nbsp;");
#nullable restore
#line 80 "C:\Users\Admin\source\repos\BookStore_ASP.NET_Core_MVC\ASP.NET_Core_BookStore\Views\Books\DetailsBook.cshtml"
                                                                                                                                                              Write(Model.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
    <div style=""font-size:1.1em;"" class=""tab-pane fade"" id=""profile"" role=""tabpanel"" aria-labelledby=""profile-tab""><br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Интернет – магазин книг – это очень удобный сервис для тех, кто не мыслит своей жизни без чтения. На нашем сайте «BookStore», Вы можете купить книги по низким ценам, которые принадлежат самым разным жанрам – мир программирования, психология, художественая литература и так далее, - и совершенно не важно, живете Вы в Киеве, или же в любом другом уголке Украины, покупки может совершать любой человек! Нельзя не отметить, что еще совсем недавно, большинство людей сталкивались с проблемой – где приобрести необходимую книгу. Особенно, это вопрос был актуален для людей, которые проживали в небольших городах, где выбор книг был невелик. Но, сегодня, данная проблема ушла в прошлое, благодаря интернет – магазинам книг, у жителей любого населенного пункта, есть возможность покупать самые редкие экземпляры книг, по самым приемлемым ценам. Для того, что бы купи");
            WriteLiteral(@"ть книгу онлайн, нужно выделить всего несколько минут. Для этого, Вам нужно просто остановить свой выбор на необходимой книге, и составить заказ, и через минимальное количество времени, курьер Вам ее доставит. Как видите, преимущества таких покупок очевидны – экономия Ваших сил и времени на поиски необходимой литературы. Купить книгу в нашем интернет магазине - это сделать разумный выбор! «BookStore» дарит возможность купить самые разные виды литературы. Кроме этого, у Вас есть возможность заказывать доставку книг под заказ. Мы можем доставить Вам книги, не только те, что есть в нашем ассортименте, а еще и очень редкие издания. К тому же, все книги, которые Вы можете у нас приобрести, отличаются вполне приемлемыми ценами. Как видите, покупать книги онлайн – это очень быстро и очень удобно. С нашим интернет – магазином Вы станете обладателем самых разных изданий!</div>
    <div style=""font-size:1.1em;"" class=""tab-pane fade"" id=""contact"" role=""tabpanel"" aria-labelledby=""contact-tab""><br />
       <pre style=""");
            WriteLiteral("font-size:1.1em;\">\r\nВремя работы:\r\nПонедельник - Пятница : с 9-00 до 18-00\r\nСуббота : 10-00 - 16-00\r\nВоскресенье - Выходной\r\n\r\n- (066) 500-30-10\r\n- (096) 001-23-23\r\n- e-mail:bookstore@gmail.com\r\n       </pre>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ASP.NET_Core_BookStore.Models.Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
