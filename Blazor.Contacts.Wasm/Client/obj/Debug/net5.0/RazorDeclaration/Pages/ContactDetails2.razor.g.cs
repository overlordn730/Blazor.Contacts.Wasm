// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Blazor.Contacts.Wasm.Client.Pages
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\ProjectCerberus\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ProjectCerberus\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\ProjectCerberus\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\ProjectCerberus\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\ProjectCerberus\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\ProjectCerberus\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\ProjectCerberus\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\ProjectCerberus\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\ProjectCerberus\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using Blazor.Contacts.Wasm.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\ProjectCerberus\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\_Imports.razor"
using Blazor.Contacts.Wasm.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\ProjectCerberus\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\Pages\ContactDetails2.razor"
using Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\ProjectCerberus\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\Pages\ContactDetails2.razor"
using Blazor.Contacts.Wasm.Shared;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/contactdetail")]
    public partial class ContactDetails2 : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\ProjectCerberus\Blazor.Contacts.Wasm\Blazor.Contacts.Wasm\Client\Pages\ContactDetails2.razor"
       
    public Contact contact;
    protected async override Task OnInitializedasync(){
        contact = new Contact();
    }
    protected async Task Save(){
        await ContactService.SaveContact(contact);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IContactService ContactService { get; set; }
    }
}
#pragma warning restore 1591
