using System.Collections.Generic;
using System.Threading.Tasks;
using Transacao.API.Entities;

namespace Transacao.API.Repositories.Interfaces
{
    public interface ITransactionRepository
    {
        Task<IEnumerable<Transaction>> GetTransactions();
        Task<Transaction> GetTransaction(string id);
        Task CreateTransaction(Transaction product);
        Task<bool> DeleteTransaction(string id);
    }
}
