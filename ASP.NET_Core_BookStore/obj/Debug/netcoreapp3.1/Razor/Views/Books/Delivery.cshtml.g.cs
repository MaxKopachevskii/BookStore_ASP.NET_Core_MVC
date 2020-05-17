#pragma checksum "C:\Users\Admin\source\repos\BookStore_ASP.NET_Core_MVC\ASP.NET_Core_BookStore\Views\Books\Delivery.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe40e374d710032dfc87fd52cedef6900efb31c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Delivery), @"mvc.1.0.view", @"/Views/Books/Delivery.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe40e374d710032dfc87fd52cedef6900efb31c6", @"/Views/Books/Delivery.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bfa2bb0c8dc0859635af7e951d714552f414bba", @"/Views/_ViewImports.cshtml")]
    public class Views_Books_Delivery : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Books", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AllFavoriteBooks", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Admin\source\repos\BookStore_ASP.NET_Core_MVC\ASP.NET_Core_BookStore\Views\Books\Delivery.cshtml"
  
    ViewData["Title"] = "Delivery";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<nav aria-label=\"breadcrumb\">\r\n    <ol class=\"breadcrumb\">\r\n        <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe40e374d710032dfc87fd52cedef6900efb31c64453", async() => {
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
            WriteLiteral(@"</li>
        <li class=""breadcrumb-item active"" aria-current=""page"">Доставка</li>
    </ol>
</nav>
<h2>Доставка</h2>
<hr />
<pre style=""font-size:1.1em;"">
Работаем без праздников и выходных! Жители Киева могут получить заказ уже в день его оформления. 
Клиенты из других городов Украины могут получить заказ в течение 1-5 дней в зависимости от местонахождения населенного пункта и выбранного способа доставки. 
Заказы на сумму свыше 1000 грн доставляются бесплатно*. Доступные способы, точные сроки и стоимость доставки Вы можете увидеть во время оформления заказа в 
корзине заказа, после выбора города доставки. 

     *Доставка осуществляется за счет предприятия.


<h4>Доставка ""Укрпошта Экспресс"" бесплатно от 100 грн Заказы от 100 грн</h4>
   – бесплатно во все отделения ""Укрпошта"". Заказы до 100 грн 
   – стоимость доставки составляет 30 грн. 

Дополнительно оплачивается комиссия за наложенный платеж в размере 1% от суммы наложенного платежа, но не менее 5 грн. 
Например, сумма до 500 грн – ");
            WriteLiteral(@"комиссия составляет 5 грн. Если сумма больше 500 грн – то 1% от суммы. Заказ будет доставлен в отделение 
""Укрпошта"" в течение 2-5 дней. Для получения отправления необходим паспорт или удостоверение личности. Обратите внимание: заказы отправляются
 на следующий рабочий день после оформления. 

<h4>Курьерская доставка ""Укрпошта"" (склад - двери)</h4>

Стоимость доставки составляет 35 грн. Дополнительно
 оплачивается комиссия за наложенный платеж в размере 1% от суммы наложенного платежа, но не менее 5 грн. Например, сумма до 500 грн – комиссия 
составляет 5 грн. Если сумма больше 500 грн – то 1% от суммы. Заказ будет доставлен в течение 2-3 дней. Обратите внимание: заказы отправляются 
на следующий рабочий день после оформления. 

<h4>Доставка на склад ""Нова пошта""</h4>

Стоимость доставки фиксированная и составляет 40 грн, поэтому дополнительных затрат за пересылку средств не взимается. 
Заказ будет доставлен в пункт самовывоза в течение 1-2 рабочих дней. «Нова пошта» проинформирует SMS-сообщение");
            WriteLiteral(@"м о том, что заказ ожидает в 
отделении «Нова пошта». Обратите внимание: заказы, оформленные до 16:00, доставляются в отделение «Нова пошта» на следующий рабочий день 
(в отдаленные населенные пункты на 2-3 день). Заказ может бесплатно храниться на складе «Нова пошта» 4 рабочих дня. На 5 день заказ автоматически 
отправляется обратно Отправителю. Для получения отправления необходим паспорт, удостоверение личности или приложение «Нова пошта».


</pre>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
