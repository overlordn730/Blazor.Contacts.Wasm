using Blazor.Contacts.Wasm.Shared;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor.Contacts.Wasm.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly IDbConnection _dbConnection;

        public ContactRepository(IDbConnection dbConnection)
        {
            this._dbConnection = dbConnection;
        }

        public async Task DeleteContact(int id)
        {
            var sql = @"DELETE FROM CONTACTS WHERE ID = @ID";

            var result = await _dbConnection.ExecuteAsync(sql, new { Id = id });
        }

        public async Task<IEnumerable<Contact>> GetAll()
        {
            var sql = @"SELECT Id,
                               FIRSTNAME,
                               LASTNAME,
                               PHONE,
                               ADDRESS
                        FROM CONTACTS";
            return await _dbConnection.QueryAsync<Contact>(sql, new { });
        }

        public async Task<Contact> GetContactDetails(int id)
        {
            var sql = @"SELECT Id,
                               FIRSTNAME,
                               LASTNAME,
                               PHONE,
                               ADDRESS
                        FROM CONTACTS
                        WHERE ID = @ID";
            return await _dbConnection.QueryFirstOrDefaultAsync<Contact>(sql, new { Id = id });
        }

        public async Task<bool> InsertContact(Contact contact)
        {
            try
            {
                var sql = @"INSERT INTO CONTACTS (FirstName, LastName, Phone, Address)
                            VALUES (@FirstName, @LastName, @Phone, @Address)";
                var result = await _dbConnection.ExecuteAsync(
                    sql, new
                    {
                        contact.FirstName,
                        contact.LastName,
                        contact.Phone,
                        contact.Address
                    });
                return result > 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<bool> UpdateContact(Contact contact)
        {
            try
            {
                var sql = @"UPDATE CONTACTS 
                            SET FirstName = @FirstName, LastName = @LastName, Phone = @Phone, Address = @Address
                            WHERE Id = @Id";
                var result = await _dbConnection.ExecuteAsync(
                    sql, new
                    {
                        contact.Id,
                        contact.FirstName,
                        contact.LastName,
                        contact.Phone,
                        contact.Address
                    });
                return result > 0;
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
