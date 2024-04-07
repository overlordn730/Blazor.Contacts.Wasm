using Blazor.Contacts.Wasm.Shared;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blazor.Contacts.Wasm.Client.Services
{
    public interface IContactService
    {
        Task SaveContact(Contact contact);
        Task DeleteContact(int id);
        Task<IEnumerable<Contact>> GetAllContacts();
        Task<Contact> GetContactById(int id);
        Task<IEnumerable<AutorDTO>> GetAutores();
    }
}
